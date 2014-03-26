namespace MainForm
{
    partial class Form3
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_showAnswerTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_submitAnswers = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_viewMyAnswers = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_displayCompletedText = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Answer_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Answers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(535, 300);
            this.webBrowser1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_showAnswerTable,
            this.toolStripLabel3,
            this.toolStripButton_submitAnswers,
            this.toolStripLabel1,
            this.toolStripButton_viewMyAnswers,
            this.toolStripLabel4,
            this.toolStripButton_displayCompletedText,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(735, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_showAnswerTable
            // 
            this.toolStripButton_showAnswerTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_showAnswerTable.Image = global::MainForm.Properties.Resources.show_answer_table;
            this.toolStripButton_showAnswerTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_showAnswerTable.Name = "toolStripButton_showAnswerTable";
            this.toolStripButton_showAnswerTable.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_showAnswerTable.Text = "toolStripButton1";
            this.toolStripButton_showAnswerTable.Click += new System.EventHandler(this.toolStripButton_showAnswerTable_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(110, 22);
            this.toolStripLabel3.Text = "Show Answer Table";
            // 
            // toolStripButton_submitAnswers
            // 
            this.toolStripButton_submitAnswers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_submitAnswers.Image = global::MainForm.Properties.Resources.submit_answers;
            this.toolStripButton_submitAnswers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_submitAnswers.Name = "toolStripButton_submitAnswers";
            this.toolStripButton_submitAnswers.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_submitAnswers.Text = "Submit My Answers";
            this.toolStripButton_submitAnswers.Click += new System.EventHandler(this.toolStripButton_submitAnswers_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel1.Text = "Submit My Answers";
            // 
            // toolStripButton_viewMyAnswers
            // 
            this.toolStripButton_viewMyAnswers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_viewMyAnswers.Image = global::MainForm.Properties.Resources.view_my_answers;
            this.toolStripButton_viewMyAnswers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_viewMyAnswers.Name = "toolStripButton_viewMyAnswers";
            this.toolStripButton_viewMyAnswers.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_viewMyAnswers.Text = "toolStripButton1";
            this.toolStripButton_viewMyAnswers.Click += new System.EventHandler(this.toolStripButton_viewMyAnswers_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel4.Text = "View My Answers";
            // 
            // toolStripButton_displayCompletedText
            // 
            this.toolStripButton_displayCompletedText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_displayCompletedText.Image = global::MainForm.Properties.Resources.show_completed_text;
            this.toolStripButton_displayCompletedText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_displayCompletedText.Name = "toolStripButton_displayCompletedText";
            this.toolStripButton_displayCompletedText.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_displayCompletedText.Text = "Show Completed Text";
            this.toolStripButton_displayCompletedText.Click += new System.EventHandler(this.toolStripButton_displayCompletedText_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(123, 22);
            this.toolStripLabel2.Text = "Show Completed Text";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(535, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 300);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 300);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Answer_Number,
            this.User_Answers});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(200, 300);
            this.dataGridView1.TabIndex = 7;
            // 
            // Answer_Number
            // 
            this.Answer_Number.HeaderText = "#";
            this.Answer_Number.Name = "Answer_Number";
            this.Answer_Number.ReadOnly = true;
            this.Answer_Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Answer_Number.Width = 30;
            // 
            // User_Answers
            // 
            this.User_Answers.HeaderText = "Answer";
            this.User_Answers.Name = "User_Answers";
            this.User_Answers.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 325);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form3";
            this.Text = "Vocabulary and Grammar Test";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_submitAnswers;
        private System.Windows.Forms.ToolStripButton toolStripButton_displayCompletedText;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton_showAnswerTable;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton_viewMyAnswers;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Answers;

    }
}