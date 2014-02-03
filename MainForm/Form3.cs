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
using Code7248.word_reader;

namespace MainForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string curDir = Directory.GetCurrentDirectory();
                this.webBrowser1.Url = new Uri(String.Format("C:/Users/DavidPC/Documents/Projet ENGLISH/html/englishProjectEx2.html", curDir));

                /*using (StreamReader sr = new StreamReader("C:/Users/DavidPC/Documents/Projet ENGLISH/html/englishProjectEx2.html"))
                {
                    String line = await sr.ReadToEndAsync();
                    label1.Text = line;

                    
                }*/

            }
            catch (Exception ex)
            {
                label1.Text = "Could not read the file";
            }
        }
    }
}
