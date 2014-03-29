namespace MainForm
{
    partial class Form2
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
            this.button_Quizz = new System.Windows.Forms.Button();
            this.button_Test = new System.Windows.Forms.Button();
            this.button_Listening = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Quizz
            // 
            this.button_Quizz.BackColor = System.Drawing.Color.Transparent;
            this.button_Quizz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Quizz.Location = new System.Drawing.Point(42, 34);
            this.button_Quizz.Name = "button_Quizz";
            this.button_Quizz.Size = new System.Drawing.Size(151, 28);
            this.button_Quizz.TabIndex = 4;
            this.button_Quizz.Text = "Culture Quiz";
            this.button_Quizz.UseVisualStyleBackColor = false;
            this.button_Quizz.Click += new System.EventHandler(this.button_Quizz_Click);
            // 
            // button_Test
            // 
            this.button_Test.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Test.Location = new System.Drawing.Point(42, 97);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(151, 28);
            this.button_Test.TabIndex = 5;
            this.button_Test.Text = "Grammar Test";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // button_Listening
            // 
            this.button_Listening.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Listening.Location = new System.Drawing.Point(42, 155);
            this.button_Listening.Name = "button_Listening";
            this.button_Listening.Size = new System.Drawing.Size(151, 28);
            this.button_Listening.TabIndex = 6;
            this.button_Listening.Text = "Listening Test";
            this.button_Listening.UseVisualStyleBackColor = true;
            this.button_Listening.Click += new System.EventHandler(this.button_Listening_Click);
            // 
            // button_About
            // 
            this.button_About.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_About.Location = new System.Drawing.Point(42, 33);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(151, 28);
            this.button_About.TabIndex = 7;
            this.button_About.Text = "About";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(42, 83);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(151, 28);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_Quizz);
            this.groupBox1.Controls.Add(this.button_Test);
            this.groupBox1.Controls.Add(this.button_Listening);
            this.groupBox1.Location = new System.Drawing.Point(611, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 209);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button_About);
            this.groupBox2.Controls.Add(this.button_Exit);
            this.groupBox2.Location = new System.Drawing.Point(611, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 136);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainForm.Properties.Resources.main_background;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Test Your English!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Quizz;
        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.Button button_Listening;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}