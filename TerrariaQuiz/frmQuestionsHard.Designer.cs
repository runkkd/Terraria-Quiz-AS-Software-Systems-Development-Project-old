
namespace TerrariaQuiz
{
    partial class frmQuestionsHard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestionsHard));
            this.lbQuestion = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.pgbTime = new System.Windows.Forms.ProgressBar();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.cb5 = new System.Windows.Forms.ComboBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbAnswer1 = new System.Windows.Forms.Label();
            this.lbAnswer2 = new System.Windows.Forms.Label();
            this.lbAnswer3 = new System.Windows.Forms.Label();
            this.lbAnswer4 = new System.Windows.Forms.Label();
            this.lbAnswer5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbQuestionNum = new System.Windows.Forms.Label();
            this.tbParagraph = new System.Windows.Forms.TextBox();
            this.tmParralax = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbQuestion.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbQuestion.Location = new System.Drawing.Point(12, 3);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(311, 27);
            this.lbQuestion.TabIndex = 14;
            this.lbQuestion.Text = "Fill in the gaps in the paragraph";
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
            this.btnCheck.Location = new System.Drawing.Point(523, 351);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(178, 44);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Click to Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnCheck.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // cb1
            // 
            this.cb1.DropDownWidth = 150;
            this.cb1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(98, 160);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(150, 27);
            this.cb1.TabIndex = 16;
            // 
            // cb3
            // 
            this.cb3.DropDownWidth = 150;
            this.cb3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(98, 258);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(150, 27);
            this.cb3.TabIndex = 17;
            // 
            // cb2
            // 
            this.cb2.DropDownWidth = 150;
            this.cb2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(98, 210);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(150, 27);
            this.cb2.TabIndex = 18;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTime.Location = new System.Drawing.Point(287, 379);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(112, 19);
            this.lbTime.TabIndex = 20;
            this.lbTime.Text = "Time Remaining:";
            // 
            // pgbTime
            // 
            this.pgbTime.Location = new System.Drawing.Point(12, 401);
            this.pgbTime.Name = "pgbTime";
            this.pgbTime.Size = new System.Drawing.Size(596, 23);
            this.pgbTime.TabIndex = 19;
            // 
            // cb4
            // 
            this.cb4.DropDownWidth = 150;
            this.cb4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb4.FormattingEnabled = true;
            this.cb4.Location = new System.Drawing.Point(98, 308);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(150, 27);
            this.cb4.TabIndex = 21;
            // 
            // cb5
            // 
            this.cb5.DropDownWidth = 150;
            this.cb5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb5.FormattingEnabled = true;
            this.cb5.Location = new System.Drawing.Point(98, 358);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(150, 27);
            this.cb5.TabIndex = 22;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbScore.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbScore.Location = new System.Drawing.Point(633, 3);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(65, 21);
            this.lbScore.TabIndex = 23;
            this.lbScore.Text = "Score: ";
            // 
            // tmTime
            // 
            this.tmTime.Interval = 1000;
            this.tmTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVersion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVersion.Location = new System.Drawing.Point(12, 427);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(62, 21);
            this.lbVersion.TabIndex = 27;
            this.lbVersion.Text = "Version";
            // 
            // lbAnswer1
            // 
            this.lbAnswer1.AutoSize = true;
            this.lbAnswer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAnswer1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnswer1.Location = new System.Drawing.Point(12, 168);
            this.lbAnswer1.Name = "lbAnswer1";
            this.lbAnswer1.Size = new System.Drawing.Size(68, 19);
            this.lbAnswer1.TabIndex = 28;
            this.lbAnswer1.Text = "Answer 1";
            // 
            // lbAnswer2
            // 
            this.lbAnswer2.AutoSize = true;
            this.lbAnswer2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAnswer2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnswer2.Location = new System.Drawing.Point(13, 218);
            this.lbAnswer2.Name = "lbAnswer2";
            this.lbAnswer2.Size = new System.Drawing.Size(68, 19);
            this.lbAnswer2.TabIndex = 29;
            this.lbAnswer2.Text = "Answer 2";
            // 
            // lbAnswer3
            // 
            this.lbAnswer3.AutoSize = true;
            this.lbAnswer3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAnswer3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnswer3.Location = new System.Drawing.Point(13, 266);
            this.lbAnswer3.Name = "lbAnswer3";
            this.lbAnswer3.Size = new System.Drawing.Size(68, 19);
            this.lbAnswer3.TabIndex = 30;
            this.lbAnswer3.Text = "Answer 3";
            // 
            // lbAnswer4
            // 
            this.lbAnswer4.AutoSize = true;
            this.lbAnswer4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAnswer4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnswer4.Location = new System.Drawing.Point(12, 316);
            this.lbAnswer4.Name = "lbAnswer4";
            this.lbAnswer4.Size = new System.Drawing.Size(68, 19);
            this.lbAnswer4.TabIndex = 31;
            this.lbAnswer4.Text = "Answer 4";
            // 
            // lbAnswer5
            // 
            this.lbAnswer5.AutoSize = true;
            this.lbAnswer5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAnswer5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnswer5.Location = new System.Drawing.Point(13, 366);
            this.lbAnswer5.Name = "lbAnswer5";
            this.lbAnswer5.Size = new System.Drawing.Size(68, 19);
            this.lbAnswer5.TabIndex = 32;
            this.lbAnswer5.Text = "Answer 5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(190)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.lbQuestionNum);
            this.panel1.Controls.Add(this.lbQuestion);
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 57);
            this.panel1.TabIndex = 33;
            this.panel1.TabStop = true;
            // 
            // lbQuestionNum
            // 
            this.lbQuestionNum.AutoSize = true;
            this.lbQuestionNum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbQuestionNum.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestionNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbQuestionNum.Location = new System.Drawing.Point(12, 35);
            this.lbQuestionNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuestionNum.Name = "lbQuestionNum";
            this.lbQuestionNum.Size = new System.Drawing.Size(78, 19);
            this.lbQuestionNum.TabIndex = 24;
            this.lbQuestionNum.Text = "Question 5";
            // 
            // tbParagraph
            // 
            this.tbParagraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(190)))), ((int)(((byte)(249)))));
            this.tbParagraph.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbParagraph.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbParagraph.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParagraph.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbParagraph.Location = new System.Drawing.Point(8, 63);
            this.tbParagraph.Multiline = true;
            this.tbParagraph.Name = "tbParagraph";
            this.tbParagraph.ReadOnly = true;
            this.tbParagraph.Size = new System.Drawing.Size(690, 91);
            this.tbParagraph.TabIndex = 34;
            this.tbParagraph.Text = "Paragraph goes here.";
            // 
            // tmParralax
            // 
            this.tmParralax.Interval = 10;
            this.tmParralax.Tick += new System.EventHandler(this.tmParralax_Tick);
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
            this.btnHelp.Location = new System.Drawing.Point(615, 401);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(86, 43);
            this.btnHelp.TabIndex = 35;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // frmQuestionsHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 460);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tbParagraph);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAnswer5);
            this.Controls.Add(this.lbAnswer4);
            this.Controls.Add(this.lbAnswer3);
            this.Controls.Add(this.lbAnswer2);
            this.Controls.Add(this.lbAnswer1);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pgbTime);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.btnCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(726, 499);
            this.MinimumSize = new System.Drawing.Size(726, 499);
            this.Name = "frmQuestionsHard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "frmQuestionsHard";
            this.Load += new System.EventHandler(this.frmQuestionsHard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmQuestionsHard_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ProgressBar pgbTime;
        private System.Windows.Forms.ComboBox cb4;
        private System.Windows.Forms.ComboBox cb5;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbAnswer1;
        private System.Windows.Forms.Label lbAnswer2;
        private System.Windows.Forms.Label lbAnswer3;
        private System.Windows.Forms.Label lbAnswer4;
        private System.Windows.Forms.Label lbAnswer5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbQuestionNum;
        private System.Windows.Forms.TextBox tbParagraph;
        private System.Windows.Forms.Timer tmParralax;
        private System.Windows.Forms.Button btnHelp;
    }
}