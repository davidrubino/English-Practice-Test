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

        private Form1 quizzForm;
        
        public ListeningForm()
        {
            InitializeComponent();
        }

        private void ListeningForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sndplayr = new SoundPlayer(MainForm.Properties.Resources.Blown_Away);
                sndplayr.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.quizzForm = new Form1("Listening Test");
            this.quizzForm.Show();
            this.quizzForm.StartTimer();
        }
    }
}
