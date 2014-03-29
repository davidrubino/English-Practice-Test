using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {

        private int index, timeLeft;
        private List<Question> questionsList;
        private List<string> userAnswers, rightAnswers;
        private QuestionsGenerator questionsGenerator;
        private WebBrowserForm webBrowserForm;

        public Form1()
        {
            this.index = 0;
            this.timeLeft = 0;
            this.questionsGenerator = new QuestionsGenerator();
            this.questionsList = this.questionsGenerator.CultureQuizzQuestions();
            this.userAnswers = new List<string>();
            this.rightAnswers = new List<string>();
            InitializeComponent();
            rightAnswers = this.GetRightAnswers(this.questionsList);
            this.SetParameters(questionsList.ElementAt(0));
            this.button_Display_Right_Answers.Enabled = false;
            this.label_score.Visible = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void SetIndex(int i)
        {
            this.index = i;
        }

        private void NextQuestion(int i)
        {
            this.SetParameters(this.questionsList.ElementAt(i));
            this.StopTimer();
            this.StartTimer();
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

        private void SetParameters(Question q)
        {
            label1.Text = q.GetTitle();
            radioButton1.Text = q.GetFirstAnswer().GetTitle();
            radioButton2.Text = q.GetSecondAnswer().GetTitle();
            radioButton3.Text = q.GetThirdAnswer().GetTitle();
        }

        private string ShowRightAnswers()
        {
            string content = "";
            for (int i = 0; i < this.rightAnswers.Count; i++)
            {
                content += "\n" + this.rightAnswers.ElementAt(i);
            }
            return content;
        }

        private string ShowUserAnswers()
        {
            string content = "";
            if (this.userAnswers.Any())
            {
                for (int i = 0; i < this.userAnswers.Count; i++)
                {
                    content += "\n" + this.userAnswers.ElementAt(i);
                }
            }
            else
            {
                content = "There are no answers yet.";
            }
            return content;
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
            if(score==30)
            {
                message = "Congratulations! You got the 30 correct answers!";
            }
            else if(score<30 && score>=20)
            {
                message = "Well done! You have a score of " + score + ".";
            }
            else if(score<20 && score>=10)
            {
                message = "Sorry, but you only got " + score + " out of 30.";
            }
            else if(score<10 && score>0)
            {
                message = "This is really bad. Your score is " + score + ".";
            }
            else
            {
                message = "Shame on you! You even haven't got one correct answer!!";
            }
            return message;
        }

        public void StartTimer()
        {
            this.timeLeft = 15;
            this.RemainingTimeLabel.Text = "15 seconds";
            timer1.Start();
        }

        private void StopTimer()
        {
            timer1.Stop();
        }

        private void SubmitAnswers()
        {
            RadioButton rb = null;
            if (radioButton1.Checked == true)
            {
                rb = radioButton1;
            }
            else if (radioButton2.Checked == true)
            {
                rb = radioButton2;
            }
            else if (radioButton3.Checked == true)
            {
                rb = radioButton3;
            }
            this.userAnswers.Add(rb.Text);
            this.SetIndex(this.index + 1);
            if (this.index < this.questionsList.Count)
            {
                this.NextQuestion(this.index);
            }
            else
            {
                Button_OK.Enabled = false;
                button_Display_Right_Answers.Enabled = true;
                this.StopTimer();
                this.label_score.Text = this.CheckResults();
                this.label_score.Visible = true;
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            this.SubmitAnswers();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timeLeft > 0)
            {
                this.timeLeft = this.timeLeft - 1;
                RemainingTimeLabel.Text = this.timeLeft + " seconds";
            }
            else
            {
                this.SubmitAnswers();
            }
        }

        private void button_Display_Right_Answers_Click(object sender, EventArgs e)
        {
            this.webBrowserForm = new WebBrowserForm();
            this.webBrowserForm.Show();
        }
    }
}
