namespace PlayWavFiles
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDemo1 = new System.Windows.Forms.Button();
            this.btnDemo2 = new System.Windows.Forms.Button();
            this.gbxDemos = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxDemos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDemo1
            // 
            this.btnDemo1.Location = new System.Drawing.Point(107, 31);
            this.btnDemo1.Name = "btnDemo1";
            this.btnDemo1.Size = new System.Drawing.Size(114, 23);
            this.btnDemo1.TabIndex = 0;
            this.btnDemo1.Text = "Demo WAV 1";
            this.btnDemo1.UseVisualStyleBackColor = true;
            this.btnDemo1.Click += new System.EventHandler(this.btnDemo1_Click);
            // 
            // btnDemo2
            // 
            this.btnDemo2.Location = new System.Drawing.Point(107, 60);
            this.btnDemo2.Name = "btnDemo2";
            this.btnDemo2.Size = new System.Drawing.Size(114, 23);
            this.btnDemo2.TabIndex = 1;
            this.btnDemo2.Text = "Demo WAV 2";
            this.btnDemo2.UseVisualStyleBackColor = true;
            this.btnDemo2.Click += new System.EventHandler(this.btnDemo2_Click);
            // 
            // gbxDemos
            // 
            this.gbxDemos.Controls.Add(this.label2);
            this.gbxDemos.Controls.Add(this.label1);
            this.gbxDemos.Controls.Add(this.btnDemo1);
            this.gbxDemos.Controls.Add(this.btnDemo2);
            this.gbxDemos.Location = new System.Drawing.Point(12, 12);
            this.gbxDemos.Name = "gbxDemos";
            this.gbxDemos.Size = new System.Drawing.Size(260, 100);
            this.gbxDemos.TabIndex = 2;
            this.gbxDemos.TabStop = false;
            this.gbxDemos.Text = "Play a WAV Audio File";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 118);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Play Once:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loop Play:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbxDemos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Playing Embedded WAV Files";
            this.gbxDemos.ResumeLayout(false);
            this.gbxDemos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemo1;
        private System.Windows.Forms.Button btnDemo2;
        private System.Windows.Forms.GroupBox gbxDemos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

