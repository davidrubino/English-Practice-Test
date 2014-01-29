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

        public Form1()
        {
            this.index = 0;
            this.timeLeft = 0;
            this.questionsList = new List<Question>();
            this.userAnswers = new List<string>();
            this.rightAnswers = new List<string>();
            InitializeComponent();
            questionsList = this.InitializeQuestions();
            rightAnswers = this.GetRightAnswers(this.questionsList);
            this.SetParameters(questionsList.ElementAt(0));
            this.StartTimer();
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

            //Question 4
            Answer q4_a1 = new Answer("Alaska", false);
            Answer q4_a2 = new Answer("Hawaii", true);
            Answer q4_a3 = new Answer("New Mexico", false);
            Question q4 = new Question("What was the last state to enter the Union?", q4_a1, q4_a2, q4_a3);

            //Question 5
            Answer q5_a1 = new Answer("John F. Kennedy", false);
            Answer q5_a2 = new Answer("Martin Luther King Jr.", true);
            Answer q5_a3 = new Answer("Bob Kennedy", false);
            Question q5 = new Question("What man acted a lot for the progress of the Civil Rights in the 60s?", q5_a1, q5_a2, q5_a3);

            //Question 6
            Answer q6_a1 = new Answer("7 Red Stripes for the 7 Confederate States", false);
            Answer q6_a2 = new Answer("Red and Blue for the 2 main political parties", false);
            Answer q6_a3 = new Answer("13 Red and White Stripes for the 13 Colonies", true);
            Question q6 = new Question("Which sentence reflects the correct meaning of the US Flag?", q6_a1, q6_a2, q6_a3);

            //Question 7
            Answer q7_a1 = new Answer("Gold City", false);
            Answer q7_a2 = new Answer("Cash City", false);
            Answer q7_a3 = new Answer("Sin City", true);
            Question q7 = new Question("What is the nickname of Las Vegas?", q7_a1, q7_a2, q7_a3);

            //Question 8
            Answer q8_a1 = new Answer("Missouri", false);
            Answer q8_a2 = new Answer("Alabama", false);
            Answer q8_a3 = new Answer("New York", true);
            Question q8 = new Question("Civil War – Find the intruder:", q8_a1, q8_a2, q8_a3);

            //Question 9
            Answer q9_a1 = new Answer("North Dakota", false);
            Answer q9_a2 = new Answer("South Dakota", true);
            Answer q9_a3 = new Answer("Colorado", false);
            Question q9 = new Question("Where is Mount Rushmore located?", q9_a1, q9_a2, q9_a3);

            //Question 10
            Answer q10_a1 = new Answer("The Star Spangled Banner", true);
            Answer q10_a2 = new Answer("The Stars and Stripes Forever", false);
            Answer q10_a3 = new Answer("God Bless America", false);
            Question q10 = new Question("What is the National Anthem’s name?", q10_a1, q10_a2, q10_a3);

            //Question 11
            Answer q11_a1 = new Answer("In God We Trust", true);
            Answer q11_a2 = new Answer("God Bless America", false);
            Answer q11_a3 = new Answer("E Pluribus Unum", false);
            Question q11 = new Question("What sentence is written on every American bill?", q11_a1, q11_a2, q11_a3);

            //Question 12
            Answer q12_a1 = new Answer("George Washington, John Adams, Thomas Jefferson", false);
            Answer q12_a2 = new Answer("Jimmy Carter, Ronald Reagan, George H.W. Bush", false);
            Answer q12_a3 = new Answer("Dwight D. Eisenhower, Harry S. Truman, John F. Kennedy", true);
            Question q12 = new Question("The following presidents succeeded one to each other in office, except for:", q12_a1, q12_a2, q12_a3);

            //Question 13
            Answer q13_a1 = new Answer("Los Angeles", true);
            Answer q13_a2 = new Answer("San Francisco", false);
            Answer q13_a3 = new Answer("Seattle", false);
            Question q13 = new Question("What city is famous for being home to many movies companies?", q13_a1, q13_a2, q13_a3);

            //Question 14
            Answer q14_a1 = new Answer("The Mormon Church", false);
            Answer q14_a2 = new Answer("The Southern Baptist Convention", false);
            Answer q14_a3 = new Answer("The Methodist Church", true);
            Question q14 = new Question("Which church was NOT founded in America?", q14_a1, q14_a2, q14_a3);

            //Question 15
            Answer q15_a1 = new Answer("Monument Valley", true);
            Answer q15_a2 = new Answer("The Grand Canyon", false);
            Answer q15_a3 = new Answer("Death Valley", false);
            Question q15 = new Question("What was John Ford’s favorite place to shot movies?", q15_a1, q15_a2, q15_a3);

            //Question 16
            Answer q16_a1 = new Answer("Tories and Democrats", false);
            Answer q16_a2 = new Answer("Republicans and Democrats", true);
            Answer q16_a3 = new Answer("Libertarians and Tories", false);
            Question q16 = new Question("What are the main political parties in the United States?", q16_a1, q16_a2, q16_a3);

            //Question 17
            Answer q17_a1 = new Answer("July 4 1776", true);
            Answer q17_a2 = new Answer("July 4 1789", false);
            Answer q17_a3 = new Answer("July 14 1776", false);
            Question q17 = new Question("When was the Declaration of Independence signed?", q17_a1, q17_a2, q17_a3);

            //Question 18
            Answer q18_a1 = new Answer("The Declaration of Independence", false);
            Answer q18_a2 = new Answer("The Bill of Rights", false);
            Answer q18_a3 = new Answer("The Constitution", true);
            Question q18 = new Question("What is the Supreme Law of the Land?", q18_a1, q18_a2, q18_a3);

            //Question 19
            Answer q19_a1 = new Answer("A famous American opera singer", false);
            Answer q19_a2 = new Answer("The author of God Bless America and White Christmas", true);
            Answer q19_a3 = new Answer("The co-writer of the Broadway show The Sound of Music", false);
            Question q19 = new Question("Who was Irving Berlin?", q19_a1, q19_a2, q19_a3);

            //Question 20
            Answer q20_a1 = new Answer("Labor Day", false);
            Answer q20_a2 = new Answer("Halloween", true);
            Answer q20_a3 = new Answer("Memorial Day", false);
            Question q20 = new Question("Which of the following is NOT a federal holiday in the US:", q20_a1, q20_a2, q20_a3);

            //Question 21
            Answer q21_a1 = new Answer("George A. Custer", true);
            Answer q21_a2 = new Answer("Ulysses S. Grant", false);
            Answer q21_a3 = new Answer("Robert E. Lee", false);
            Question q21 = new Question("What famous officer was killed during the battle of Little Big Horn?", q21_a1, q21_a2, q21_a3);

            //Question 22
            Answer q22_a1 = new Answer("The Oval Office", true);
            Answer q22_a2 = new Answer("The Circle Office", false);
            Answer q22_a3 = new Answer("The Square Office", false);
            Question q22 = new Question("What is the name of the president’s office?", q22_a1, q22_a2, q22_a3);

            //Question 23
            Answer q23_a1 = new Answer("Mel Gibson", false);
            Answer q23_a2 = new Answer("Al Pacino", false);
            Answer q23_a3 = new Answer("Arnold Schwarzenegger", true);
            Question q23 = new Question("What famous American actor was NOT born in the US?", q23_a1, q23_a2, q23_a3);

            //Question 24
            Answer q24_a1 = new Answer("Klondike", false);
            Answer q24_a2 = new Answer("Utah", false);
            Answer q24_a3 = new Answer("California", true);
            Question q24 = new Question("What was the main state involved in the Gold Rush?", q24_a1, q24_a2, q24_a3);

            //Question 25
            Answer q25_a1 = new Answer("New Hampshire", false);
            Answer q25_a2 = new Answer("New England", true);
            Answer q25_a3 = new Answer("New York", false);
            Question q25 = new Question("Which one of the following is NOT a US state?", q25_a1, q25_a2, q25_a3);

            //Question 26
            Answer q26_a1 = new Answer("The Lone Star State", true);
            Answer q26_a2 = new Answer("The Alamo State", false);
            Answer q26_a3 = new Answer("The Cow-Boy State", false);
            Question q26 = new Question("What is the nickname of Texas?", q26_a1, q26_a2, q26_a3);

            //Question 27
            Answer q27_a1 = new Answer("Spanish", true);
            Answer q27_a2 = new Answer("French", false);
            Answer q27_a3 = new Answer("Dutch", false);
            Question q27 = new Question("What is the second most spoken language in the US?", q27_a1, q27_a2, q27_a3);

            //Question 28
            Answer q28_a1 = new Answer("Minnesota", true);
            Answer q28_a2 = new Answer("Florida", false);
            Answer q28_a3 = new Answer("Montana", false);
            Question q28 = new Question("What state is famous for its many lakes?", q28_a1, q28_a2, q28_a3);

            //Question 29
            Answer q29_a1 = new Answer("Kenny Rogers", false);
            Answer q29_a2 = new Answer("Tim McGraw", false);
            Answer q29_a3 = new Answer("Johnny Cash", true);
            Question q29 = new Question("What famous country singer was performing in prisons?", q29_a1, q29_a2, q29_a3);

            //Question 30
            Answer q30_a1 = new Answer("Dallas", true);
            Answer q30_a2 = new Answer("Sacramento", false);
            Answer q30_a3 = new Answer("Salt Lake City", false);
            Question q30 = new Question("State capitals – Find the intruder:", q30_a1, q30_a2, q30_a3);

            //Add questions to the list
            this.questionsList.Add(q1);
            this.questionsList.Add(q2);
            this.questionsList.Add(q3);
            this.questionsList.Add(q4);
            this.questionsList.Add(q5);
            this.questionsList.Add(q6);
            this.questionsList.Add(q7);
            this.questionsList.Add(q8);
            this.questionsList.Add(q9);
            this.questionsList.Add(q10);
            this.questionsList.Add(q11);
            this.questionsList.Add(q12);
            this.questionsList.Add(q13);
            this.questionsList.Add(q14);
            this.questionsList.Add(q15);
            this.questionsList.Add(q16);
            this.questionsList.Add(q17);
            this.questionsList.Add(q18);
            this.questionsList.Add(q19);
            this.questionsList.Add(q20);
            this.questionsList.Add(q21);
            this.questionsList.Add(q22);
            this.questionsList.Add(q23);
            this.questionsList.Add(q24);
            this.questionsList.Add(q25);
            this.questionsList.Add(q26);
            this.questionsList.Add(q27);
            this.questionsList.Add(q28);
            this.questionsList.Add(q29);
            this.questionsList.Add(q30);
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

        private string CheckResults()
        {
            int score = 0;
            int totalAnswers = this.rightAnswers.Count;
            for(int i=0; i<this.userAnswers.Count; i++)
            {
                if (this.rightAnswers.Contains(this.userAnswers.ElementAt(i)))
                    score++;
            }
            return "Correct answers: " + score + " out of " + totalAnswers;
        }

        private void StartTimer()
        {
            this.timeLeft = 10;
            this.RemainingTimeLabel.Text = "10 seconds";
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
            if (this.index < this.questionsList.Count) {
                this.NextQuestion(this.index);
            }
            else
            {
                Button_Next.Enabled = false;
                this.StopTimer();
            }
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
            this.SubmitAnswers();
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

        private void checkResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.CheckResults(), "My Results", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
    }
}
