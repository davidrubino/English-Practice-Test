using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MainForm
{
    public partial class ListeningForm : Form
    {

        private List<string> userAnswers, rightAnswers;
        private int index;
        private List<Question> questionsList;
        private QuestionsGenerator questionsGenerator;
        private SoundPlayer sndplayr;
        
        public ListeningForm()
        {
            this.index = 0;
            this.questionsGenerator = new QuestionsGenerator();
            this.questionsList = this.questionsGenerator.ListeningTestQuestions();
            this.userAnswers = new List<string>();
            this.rightAnswers = new List<string>();
            this.sndplayr = new SoundPlayer();
            InitializeComponent();
            rightAnswers = this.GetRightAnswers(this.questionsList);
            this.SetParameters(questionsList.ElementAt(0));
            this.label_score.Visible = false;
        }

        private void ListeningForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            try
            {
                this.sndplayr = new SoundPlayer(MainForm.Properties.Resources.Blown_Away);
                this.sndplayr.Play();
                button_Play.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.SubmitAnswers();
        }

        private void ListeningForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.sndplayr.Stop();
        }

        private List<string> GetRightAnswers(List<Question> questionsList)
        {
            List<string> answers = new List<string>();
            for (int i = 0; i < questionsList.Count; i++)
            {
                answers.Add(questionsList.ElementAt(i).GetRightAnswer(questionsList.ElementAt(i)).GetTitle());
            }
            return answers;
        }

        private void SetIndex(int i)
        {
            this.index = i;
        }

        private void SetParameters(Question q)
        {
            label_Question.Text = q.GetTitle();
            radioButton_Answer1.Text = q.GetFirstAnswer().GetTitle();
            radioButton_Answer2.Text = q.GetSecondAnswer().GetTitle();
            radioButton_Answer3.Text = q.GetThirdAnswer().GetTitle();
        }
        
        private void NextQuestion(int i)
        {
            this.SetParameters(this.questionsList.ElementAt(i));
        }

        private string CheckResults()
        {
            string message = "";
            int score = 0;
            int totalAnswers = this.rightAnswers.Count;
            for (int i = 0; i < this.userAnswers.Count; i++)
            {
                if (this.rightAnswers.Contains(this.userAnswers.ElementAt(i)))
                    score++;
            }
            if (score == 10)
            {
                message = "Congratulations! You got the 10 correct answers!";
            }
            else if (score < 10 && score >= 6)
            {
                message = "Well done! You have a score of " + score + ".";
            }
            else if (score < 6 && score >= 1)
            {
                message = "Sorry, but you only got " + score + " out of 10.";
            }
            else
            {
                message = "Shame on you! You even haven't got one correct answer!!";
            }
            return message;
        }
        
        private void SubmitAnswers()
        {
            RadioButton rb = null;
            if (radioButton_Answer1.Checked == true)
            {
                rb = radioButton_Answer1;
            }
            else if (radioButton_Answer2.Checked == true)
            {
                rb = radioButton_Answer2;
            }
            else if (radioButton_Answer3.Checked == true)
            {
                rb = radioButton_Answer3;
            }
            this.userAnswers.Add(rb.Text);
            this.SetIndex(this.index + 1);
            if (this.index < this.questionsList.Count)
            {
                this.NextQuestion(this.index);
            }
            else
            {
                button_OK.Enabled = false;
                this.sndplayr.Stop();
                this.label_score.Text = this.CheckResults();
                this.label_score.Visible = true;
            }
        }
    }
}
