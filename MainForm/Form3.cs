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
        
        public Form3()
        {
            InitializeComponent();
            button1.Text = "Got it!";
            button1.Font = new Font("Times New Roman", 10);
            button1.Size = new Size(100, 25);
            LoadImage("C:/Users/DavidPC/documents/visual studio 2013/Projects/EnglishProject/MainForm/TextInstruction.html");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Submit My Answers";
            button1.Size = new Size(150, 25);
            LoadImage("C:/Users/DavidPC/documents/visual studio 2013/Projects/EnglishProject/MainForm/WebArticle.html");
        }

        private void LoadImage(string path)
        {
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format(path, curDir));
        }
    }
}
