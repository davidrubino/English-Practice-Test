﻿using System;
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
    public partial class WebBrowserForm : Form
    {
        public WebBrowserForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            String appdir = Path.GetDirectoryName(Application.ExecutablePath);
            String myfile = Path.Combine(appdir, "CultureQuiz.html");
            webBrowser1.Url = new Uri("file:///" + myfile);
        }
    }
}
