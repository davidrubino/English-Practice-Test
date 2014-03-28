namespace MainForm
{
    partial class ListeningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeningForm));
            this.button_Play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_OK = new System.Windows.Forms.Button();
            this.radioButton_Answer3 = new System.Windows.Forms.RadioButton();
            this.radioButton_Answer2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Answer1 = new System.Windows.Forms.RadioButton();
            this.label_Question = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_score = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Play
            // 
            this.button_Play.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Play.Location = new System.Drawing.Point(138, 244);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(78, 30);
            this.button_Play.TabIndex = 0;
            this.button_Play.Text = "Play!";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(112, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listening Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 126);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button_OK);
            this.panel1.Controls.Add(this.radioButton_Answer3);
            this.panel1.Controls.Add(this.radioButton_Answer2);
            this.panel1.Controls.Add(this.radioButton_Answer1);
            this.panel1.Controls.Add(this.label_Question);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(398, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 365);
            this.panel1.TabIndex = 5;
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(146, 244);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(78, 30);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // radioButton_Answer3
            // 
            this.radioButton_Answer3.AutoSize = true;
            this.radioButton_Answer3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Answer3.Location = new System.Drawing.Point(24, 186);
            this.radioButton_Answer3.Name = "radioButton_Answer3";
            this.radioButton_Answer3.Size = new System.Drawing.Size(80, 18);
            this.radioButton_Answer3.TabIndex = 9;
            this.radioButton_Answer3.Text = "Answer3";
            this.radioButton_Answer3.UseVisualStyleBackColor = true;
            // 
            // radioButton_Answer2
            // 
            this.radioButton_Answer2.AutoSize = true;
            this.radioButton_Answer2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Answer2.Location = new System.Drawing.Point(24, 163);
            this.radioButton_Answer2.Name = "radioButton_Answer2";
            this.radioButton_Answer2.Size = new System.Drawing.Size(80, 18);
            this.radioButton_Answer2.TabIndex = 8;
            this.radioButton_Answer2.Text = "Answer2";
            this.radioButton_Answer2.UseVisualStyleBackColor = true;
            // 
            // radioButton_Answer1
            // 
            this.radioButton_Answer1.AutoSize = true;
            this.radioButton_Answer1.Checked = true;
            this.radioButton_Answer1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Answer1.Location = new System.Drawing.Point(24, 140);
            this.radioButton_Answer1.Name = "radioButton_Answer1";
            this.radioButton_Answer1.Size = new System.Drawing.Size(80, 18);
            this.radioButton_Answer1.TabIndex = 7;
            this.radioButton_Answer1.TabStop = true;
            this.radioButton_Answer1.Text = "Answer1";
            this.radioButton_Answer1.UseVisualStyleBackColor = true;
            // 
            // label_Question
            // 
            this.label_Question.AutoSize = true;
            this.label_Question.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Question.Location = new System.Drawing.Point(21, 84);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(82, 18);
            this.label_Question.TabIndex = 6;
            this.label_Question.Text = "Question";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_Play);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 365);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label_score);
            this.panel3.Location = new System.Drawing.Point(0, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 50);
            this.panel3.TabIndex = 4;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.Color.Red;
            this.label_score.Location = new System.Drawing.Point(52, 13);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(97, 19);
            this.label_score.TabIndex = 7;
            this.label_score.Text = "label_score";
            // 
            // ListeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 365);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ListeningForm";
            this.Text = "Listening Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListeningForm_FormClosing);
            this.Load += new System.EventHandler(this.ListeningForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_Answer3;
        private System.Windows.Forms.RadioButton radioButton_Answer2;
        private System.Windows.Forms.RadioButton radioButton_Answer1;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_score;
    }
}