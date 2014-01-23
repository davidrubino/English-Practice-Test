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

        private int index;
        private List<Question> questionsList;
        private List<string> userAnswers;
        private List<string> rightAnswers;

        public Form1()
        {
            this.index = 0;
            this.questionsList = new List<Question>();
            this.userAnswers = new List<string>();
            this.rightAnswers = new List<string>();
            InitializeComponent();
            questionsList = this.InitializeQuestions();
            rightAnswers = this.GetRightAnswers(this.questionsList);
            this.SetParameters(questionsList.ElementAt(0));
        }

        private void SetIndex(int i)
        {
            this.index = i;
        }

        private void NextQuestion(int i)
        {
            this.SetParameters(this.questionsList.ElementAt(i));
        }
        
        private List<string> GetRightAnswers(List<Question> questionsList)
        {
            List<string> answers = new List<string>();
            for(int i=0; i<questionsList.Count; i++)
            {
                answers.Add(questionsList.ElementAt(i).GetRightAnswer(questionsList.ElementAt(i)).GetTitle());
            }
            return answers;
        }

        private List<Question> InitializeQuestions()
        {
            //Question 1
            Answer q1_a1 = new Answer("Abraham Lincoln", false);
            Answer q1_a2 = new Answer("George Washington", true);
            Answer q1_a3 = new Answer("Thomas Jefferson", false);
            Question q1 = new Question("Who was the first president of the United States?", q1_a1, q1_a2, q1_a3);

            //Question 2
            Answer q2_a1 = new Answer("Washington D.C.", true);
            Answer q2_a2 = new Answer("Seattle", false);
            Answer q2_a3 = new Answer("New York", false);
            Question q2 = new Question("What is the capital of the United States?",q2_a1,q2_a2,q2_a3);

            //Question 3
            Answer q3_a1 = new Answer("48", false);
            Answer q3_a2 = new Answer("50", true);
            Answer q3_a3 = new Answer("51", false);
            Question q3 = new Question("How many states are in the United States?", q3_a1, q3_a2, q3_a3);

            //Add questions to the list
            this.questionsList.Add(q1);
            this.questionsList.Add(q2);
            this.questionsList.Add(q3);
            return questionsList;
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
            if(this.userAnswers.Any())
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
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application created by David RUBINO and Thibaut LESAGE", "About",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {

        }

        private void Button_Next_Click(object sender, EventArgs e)
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
                this.NextQuestion(this.index);
            else
                Button_Next.Enabled = false;
        }

        private void Button_Validate_Click(object sender, EventArgs e)
        {

        }

        private void showRightAnswersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.ShowRightAnswers(), "Right Answers", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void showMyAnswersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.ShowUserAnswers(), "My Answers", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
