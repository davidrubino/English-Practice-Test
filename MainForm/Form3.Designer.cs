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
            this.button_gotIt = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_showAnswerTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_viewMyAnswers = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_submitAnswers = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_displayCompletedText = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel_bottom.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_gotIt
            // 
            this.button_gotIt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_gotIt.AutoSize = true;
            this.button_gotIt.Location = new System.Drawing.Point(242, 11);
            this.button_gotIt.Name = "button_gotIt";
            this.button_gotIt.Size = new System.Drawing.Size(66, 23);
            this.button_gotIt.TabIndex = 1;
            this.button_gotIt.Text = "Got it!";
            this.button_gotIt.UseVisualStyleBackColor = true;
            this.button_gotIt.Click += new System.EventHandler(this.button_gotIt_Click);
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.button_gotIt);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 228);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(590, 44);
            this.panel_bottom.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(590, 228);
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
            this.toolStrip1.Size = new System.Drawing.Size(590, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 272);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel_bottom);
            this.Name = "Form3";
            this.Text = "Vocabulary and Grammar Test";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_gotIt;
        private System.Windows.Forms.Panel panel_bottom;
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

    }
}