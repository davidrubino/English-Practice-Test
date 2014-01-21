using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace PlayWavFiles
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDemo1_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sndplayr = new SoundPlayer(PlayWavFiles.Properties.Resources.Blown_Away);
                sndplayr.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }

        private void btnDemo2_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sndplayr = new SoundPlayer(PlayWavFiles.Properties.Resources.LoopyMusic);

                if (btnDemo2.Text == "Demo WAV 2")
                {
                    sndplayr.PlayLooping();
                    btnDemo2.Text = "STOP";
                }
                else
                {
                    sndplayr.Stop();
                    btnDemo2.Text = "Demo WAV 2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }
    }
}