using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MainForm
{
    public partial class Form3 : Form
    {
        
        private DataTable dt;
        private int score;
        private List<string> correctAnswersList;

        public Form3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.TransparencyKey = Color.Empty;
            this.dt = new DataTable();
            this.InitializeTable();
            this.score = 0;
            this.correctAnswersList = new List<string>();
            this.FillCorrectAnswersList();
            this.toolStripLabel_score.Visible = false;

            String appdir = Path.GetDirectoryName(Application.ExecutablePath);
            String myfile = Path.Combine(appdir, "WebArticle_UserVersion.html");
            webBrowser1.Url = new Uri("file:///" + myfile);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton_submitAnswers_Click(object sender, EventArgs e)
        {
            this.toolStripButton_submitAnswers.Enabled = false;
            this.toolStripButton_displayCompletedText.Enabled = true;
            this.toolStripLabel_score.Visible = true;
            this.toolStripLabel_score.Text = "Correct answers: " + this.CheckResults()+"/30";
        }

        private void toolStripButton_displayCompletedText_Click(object sender, EventArgs e)
        {
            String appdir = Path.GetDirectoryName(Application.ExecutablePath);
            String myfile = Path.Combine(appdir, "WebArticle.html");
            webBrowser1.Url = new Uri("file:///" + myfile);
        }

        private void LoadImage(string path)
        {
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format(path, curDir));
        }

        private void InitializeTable()
        {
            this.dt.Clear();
            this.dt.Columns.Add("#");
            this.dt.Columns.Add("Answer");
            this.dt.Columns[0].ReadOnly = true;

            for (int i = 1; i <= 30; i++)
            {
                DataRow _answerNo = dt.NewRow();
                _answerNo["#"] = i;
                dt.Rows.Add(_answerNo);
            }

            dataGridView_User.DataSource = dt;
            dataGridView_User.AutoResizeColumns();
        }

        public void FillCorrectAnswersList()
        {
            this.correctAnswersList.Add("have");
            this.correctAnswersList.Add("has");
            this.correctAnswersList.Add("about");
            this.correctAnswersList.Add("accessible");
            this.correctAnswersList.Add("at");
            this.correctAnswersList.Add("to");
            this.correctAnswersList.Add("to");
            this.correctAnswersList.Add("operating systems");
            this.correctAnswersList.Add("in");
            this.correctAnswersList.Add("more");
            this.correctAnswersList.Add("scale");
            this.correctAnswersList.Add("any");
            this.correctAnswersList.Add("from");
            this.correctAnswersList.Add("to");
            this.correctAnswersList.Add("through");
            this.correctAnswersList.Add("called");
            this.correctAnswersList.Add("aside");
            this.correctAnswersList.Add("sensors");
            this.correctAnswersList.Add("as");
            this.correctAnswersList.Add("privacy");
            this.correctAnswersList.Add("into");
            this.correctAnswersList.Add("stores");
            this.correctAnswersList.Add("at");
            this.correctAnswersList.Add("able");
            this.correctAnswersList.Add("down");
            this.correctAnswersList.Add("into");
            this.correctAnswersList.Add("much");
            this.correctAnswersList.Add("what");
            this.correctAnswersList.Add("much");
            this.correctAnswersList.Add("valuable");
        }

        private int CheckResults()
        {
            for(int i=0; i<30; i++)
            {
                string yATmax = dt.Rows[i]["Answer"].ToString();
                if (yATmax == this.correctAnswersList.ElementAt(i))
                {
                    score++;
                }
            }
            return score;
        }
    }
}
