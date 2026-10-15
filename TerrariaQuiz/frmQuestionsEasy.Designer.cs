
namespace TerrariaQuiz
{
    partial class frmQuestionsEasy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestionsEasy));
            this.lbScore = new System.Windows.Forms.Label();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.lbQuestionNum = new System.Windows.Forms.Label();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.pgbTime = new System.Windows.Forms.ProgressBar();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lbVersion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pFeedback = new System.Windows.Forms.PictureBox();
            this.tmParralax = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Black;
            this.lbScore.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbScore.Location = new System.Drawing.Point(610, 9);
            this.lbScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(74, 21);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "Score: 0";
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.BackColor = System.Drawing.Color.Black;
            this.rb4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb4.Location = new System.Drawing.Point(13, 267);
            this.rb4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(38, 27);
            this.rb4.TabIndex = 15;
            this.rb4.TabStop = true;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = false;
            this.rb4.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.rb4.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.Black;
            this.rb3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb3.Location = new System.Drawing.Point(12, 238);
            this.rb3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(38, 27);
            this.rb3.TabIndex = 14;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = false;
            this.rb3.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.rb3.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.Black;
            this.rb2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb2.Location = new System.Drawing.Point(13, 209);
            this.rb2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(38, 27);
            this.rb2.TabIndex = 13;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = false;
            this.rb2.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.rb2.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.Black;
            this.rb1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb1.Location = new System.Drawing.Point(13, 180);
            this.rb1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(38, 27);
            this.rb1.TabIndex = 12;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = false;
            this.rb1.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.rb1.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheck.Location = new System.Drawing.Point(485, 390);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(197, 55);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Click to Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnCheck.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.BackColor = System.Drawing.Color.Black;
            this.lbAnswer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnswer.Location = new System.Drawing.Point(17, 330);
            this.lbAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(80, 23);
            this.lbAnswer.TabIndex = 10;
            this.lbAnswer.Text = "lbAnswer";
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.BackColor = System.Drawing.Color.Black;
            this.lbQuestion.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbQuestion.Location = new System.Drawing.Point(11, 5);
            this.lbQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(85, 25);
            this.lbQuestion.TabIndex = 9;
            this.lbQuestion.Text = "Question";
            // 
            // lbQuestionNum
            // 
            this.lbQuestionNum.AutoSize = true;
            this.lbQuestionNum.BackColor = System.Drawing.Color.Black;
            this.lbQuestionNum.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestionNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbQuestionNum.Location = new System.Drawing.Point(11, 32);
            this.lbQuestionNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuestionNum.Name = "lbQuestionNum";
            this.lbQuestionNum.Size = new System.Drawing.Size(78, 19);
            this.lbQuestionNum.TabIndex = 8;
            this.lbQuestionNum.Text = "Question 1";
            // 
            // tmTime
            // 
            this.tmTime.Interval = 1000;
            this.tmTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pgbTime
            // 
            this.pgbTime.Location = new System.Drawing.Point(9, 451);
            this.pgbTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pgbTime.Maximum = 60;
            this.pgbTime.Name = "pgbTime";
            this.pgbTime.Size = new System.Drawing.Size(778, 23);
            this.pgbTime.TabIndex = 16;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Black;
            this.lbTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTime.Location = new System.Drawing.Point(243, 426);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(118, 19);
            this.lbTime.TabIndex = 17;
            this.lbTime.Text = "Time Remaining: ";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Black;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHelp.Location = new System.Drawing.Point(701, 402);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(86, 43);
            this.btnHelp.TabIndex = 18;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVersion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVersion.Location = new System.Drawing.Point(9, 478);
            this.lbVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(62, 21);
            this.lbVersion.TabIndex = 19;
            this.lbVersion.Text = "Version";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(190)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.lbQuestion);
            this.panel1.Controls.Add(this.lbQuestionNum);
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // pFeedback
            // 
            this.pFeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pFeedback.Location = new System.Drawing.Point(541, 180);
            this.pFeedback.Name = "pFeedback";
            this.pFeedback.Size = new System.Drawing.Size(114, 114);
            this.pFeedback.TabIndex = 20;
            this.pFeedback.TabStop = false;
            this.pFeedback.Visible = false;
            // 
            // tmParralax
            // 
            this.tmParralax.Interval = 10;
            this.tmParralax.Tick += new System.EventHandler(this.tmParralax_Tick);
            // 
            // frmQuestionsEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.pFeedback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pgbTime);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbAnswer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 546);
            this.MinimumSize = new System.Drawing.Size(816, 546);
            this.Name = "frmQuestionsEasy";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "A";
            this.Load += new System.EventHandler(this.frmQuestionsEasy_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmQuestionsEasy_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Label lbQuestionNum;
        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.ProgressBar pgbTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pFeedback;
        private System.Windows.Forms.Timer tmParralax;
    }
}