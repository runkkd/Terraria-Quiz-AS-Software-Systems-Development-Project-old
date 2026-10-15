
namespace TerrariaQuiz
{
    partial class frmQuestionsVeryHard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestionsVeryHard));
            this.lbScore = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.ltbOne = new System.Windows.Forms.ListBox();
            this.lbType1 = new System.Windows.Forms.Label();
            this.lbType2 = new System.Windows.Forms.Label();
            this.ltbTwo = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbQuestionNum = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.pgbTime = new System.Windows.Forms.ProgressBar();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.tmParralax = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Black;
            this.lbScore.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbScore.Location = new System.Drawing.Point(637, 6);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(65, 21);
            this.lbScore.TabIndex = 5;
            this.lbScore.Text = "Score: ";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVersion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVersion.Location = new System.Drawing.Point(11, 477);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(62, 21);
            this.lbVersion.TabIndex = 20;
            this.lbVersion.Text = "Version";
            // 
            // ltbOne
            // 
            this.ltbOne.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ltbOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltbOne.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbOne.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ltbOne.FormattingEnabled = true;
            this.ltbOne.ItemHeight = 16;
            this.ltbOne.Location = new System.Drawing.Point(161, 103);
            this.ltbOne.Name = "ltbOne";
            this.ltbOne.Size = new System.Drawing.Size(189, 192);
            this.ltbOne.TabIndex = 21;
            // 
            // lbType1
            // 
            this.lbType1.AutoSize = true;
            this.lbType1.BackColor = System.Drawing.Color.Black;
            this.lbType1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbType1.Location = new System.Drawing.Point(166, 79);
            this.lbType1.Name = "lbType1";
            this.lbType1.Size = new System.Drawing.Size(44, 21);
            this.lbType1.TabIndex = 22;
            this.lbType1.Text = "Type";
            // 
            // lbType2
            // 
            this.lbType2.AutoSize = true;
            this.lbType2.BackColor = System.Drawing.Color.Black;
            this.lbType2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbType2.Location = new System.Drawing.Point(472, 79);
            this.lbType2.Name = "lbType2";
            this.lbType2.Size = new System.Drawing.Size(44, 21);
            this.lbType2.TabIndex = 24;
            this.lbType2.Text = "Type";
            // 
            // ltbTwo
            // 
            this.ltbTwo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ltbTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltbTwo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbTwo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ltbTwo.FormattingEnabled = true;
            this.ltbTwo.ItemHeight = 16;
            this.ltbTwo.Location = new System.Drawing.Point(467, 103);
            this.ltbTwo.Name = "ltbTwo";
            this.ltbTwo.Size = new System.Drawing.Size(189, 192);
            this.ltbTwo.TabIndex = 23;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Black;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRight.Location = new System.Drawing.Point(380, 120);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(56, 47);
            this.btnRight.TabIndex = 25;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            this.btnRight.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnRight.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Black;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLeft.Location = new System.Drawing.Point(380, 217);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(56, 47);
            this.btnLeft.TabIndex = 26;
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            this.btnLeft.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnLeft.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Black;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheck.Location = new System.Drawing.Point(522, 454);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(165, 41);
            this.btnCheck.TabIndex = 27;
            this.btnCheck.Text = "Click to Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnCheck.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbCorrect
            // 
            this.lbCorrect.AutoSize = true;
            this.lbCorrect.BackColor = System.Drawing.Color.Black;
            this.lbCorrect.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCorrect.Location = new System.Drawing.Point(232, 353);
            this.lbCorrect.Name = "lbCorrect";
            this.lbCorrect.Size = new System.Drawing.Size(367, 30);
            this.lbCorrect.TabIndex = 28;
            this.lbCorrect.Text = "You got 0 correct and 0 incorrect!";
            this.lbCorrect.Visible = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Black;
            this.lbTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitle.Location = new System.Drawing.Point(12, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(437, 30);
            this.lbTitle.TabIndex = 29;
            this.lbTitle.Text = "Sort the items into the correct category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(190)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.lbQuestionNum);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 34;
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
            this.lbQuestionNum.Text = "Question 6";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTime.Location = new System.Drawing.Point(222, 450);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(112, 19);
            this.lbTime.TabIndex = 36;
            this.lbTime.Text = "Time Remaining:";
            // 
            // pgbTime
            // 
            this.pgbTime.Location = new System.Drawing.Point(81, 472);
            this.pgbTime.Maximum = 75;
            this.pgbTime.Name = "pgbTime";
            this.pgbTime.Size = new System.Drawing.Size(435, 23);
            this.pgbTime.TabIndex = 35;
            // 
            // tmTime
            // 
            this.tmTime.Interval = 1000;
            this.tmTime.Tick += new System.EventHandler(this.tmTime_Tick);
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
            this.btnHelp.Location = new System.Drawing.Point(701, 454);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(86, 41);
            this.btnHelp.TabIndex = 37;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // frmQuestionsVeryHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pgbTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCorrect);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lbType2);
            this.Controls.Add(this.ltbTwo);
            this.Controls.Add(this.lbType1);
            this.Controls.Add(this.ltbOne);
            this.Controls.Add(this.lbVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 546);
            this.MinimumSize = new System.Drawing.Size(816, 546);
            this.Name = "frmQuestionsVeryHard";
            this.Text = "frmQuestionsVeryHard";
            this.Load += new System.EventHandler(this.frmQuestionsVeryHard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmQuestionsVeryHard_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.ListBox ltbOne;
        private System.Windows.Forms.Label lbType1;
        private System.Windows.Forms.Label lbType2;
        private System.Windows.Forms.ListBox ltbTwo;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbCorrect;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbQuestionNum;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ProgressBar pgbTime;
        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.Timer tmParralax;
        private System.Windows.Forms.Button btnHelp;
    }
}