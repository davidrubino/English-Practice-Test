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
        
        private UserInputAnswersForm answersForm;
        private ListChecker listChecker;

        public Form3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.TransparencyKey = Color.Empty;
            this.answersForm = new UserInputAnswersForm();
            this.listChecker = new ListChecker(answersForm);
            button_gotIt.Font = new Font("Times New Roman", 10);
            LoadImage("C:/Users/DavidPC/documents/visual studio 2013/Projects/EnglishProject/MainForm/TextInstruction.html");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button_gotIt_Click(object sender, EventArgs e)
        {
            LoadImage("C:/Users/DavidPC/documents/visual studio 2013/Projects/EnglishProject/MainForm/WebArticle_UserVersion.html");
            toolStrip1.Visible = true;
            panel_bottom.Visible = false;
        }

        private void toolStripButton_submitAnswers_Click(object sender, EventArgs e)
        {
            this.listChecker.FillUserAnswersList();
            MessageBox.Show(this.listChecker.ShowScore());
        }

        private void toolStripButton_displayCompletedText_Click(object sender, EventArgs e)
        {
            LoadImage("C:/Users/DavidPC/documents/visual studio 2013/Projects/EnglishProject/MainForm/WebArticle.html");
        }

        private void toolStripButton_showAnswerTable_Click(object sender, EventArgs e)
        {
            this.answersForm.Show();
        }

        private void toolStripButton_viewMyAnswers_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.listChecker.UserAnswersListToString());
        }

        private void LoadImage(string path)
        {
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format(path, curDir));
        }

    }
}
