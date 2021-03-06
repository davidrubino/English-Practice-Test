﻿using System;
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
    public partial class Form2 : Form
    {
        
        private Form1 QuizForm;
        private Form3 GrammarTest;
        private ListeningForm ListeningTest;
        
        public Form2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_Quizz_Click(object sender, EventArgs e)
        {
            this.QuizForm = new Form1();
            this.QuizForm.Show();
            this.QuizForm.StartTimer();
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            this.GrammarTest = new Form3();
            this.GrammarTest.Show();
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by David RUBINO and Thibaut LESAGE", "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button_Listening_Click(object sender, EventArgs e)
        {
            this.ListeningTest = new ListeningForm();
            this.ListeningTest.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
