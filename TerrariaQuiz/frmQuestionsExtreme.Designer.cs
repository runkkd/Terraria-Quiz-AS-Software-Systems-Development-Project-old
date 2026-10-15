
namespace TerrariaQuiz
{
    partial class frmQuestionsExtreme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestionsExtreme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbQuestionNum = new System.Windows.Forms.Label();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.pgbTime = new System.Windows.Forms.ProgressBar();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.tmParralax = new System.Windows.Forms.Timer(this.components);
            this.btnPlayVideo = new System.Windows.Forms.Button();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.btnSkip = new System.Windows.Forms.Button();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.mVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mVideo)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 35;
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
            this.lbQuestionNum.Text = "Question 7";
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.BackColor = System.Drawing.Color.Black;
            this.lbQuestion.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbQuestion.Location = new System.Drawing.Point(12, 5);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(378, 25);
            this.lbQuestion.TabIndex = 29;
            this.lbQuestion.Text = "The final boss of Terraria is the Moon Lord";
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
            this.lbVersion.Location = new System.Drawing.Point(12, 474);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(62, 21);
            this.lbVersion.TabIndex = 36;
            this.lbVersion.Text = "Version";
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
            this.btnCheck.Location = new System.Drawing.Point(523, 452);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(168, 43);
            this.btnCheck.TabIndex = 40;
            this.btnCheck.Text = "Click to Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnCheck.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTime.Location = new System.Drawing.Point(216, 447);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(112, 19);
            this.lbTime.TabIndex = 43;
            this.lbTime.Text = "Time Remaining:";
            // 
            // pgbTime
            // 
            this.pgbTime.Location = new System.Drawing.Point(80, 469);
            this.pgbTime.Maximum = 30;
            this.pgbTime.Name = "pgbTime";
            this.pgbTime.Size = new System.Drawing.Size(438, 23);
            this.pgbTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbTime.TabIndex = 42;
            // 
            // tmTime
            // 
            this.tmTime.Interval = 1000;
            this.tmTime.Tick += new System.EventHandler(this.tmTIme_Tick);
            // 
            // tmParralax
            // 
            this.tmParralax.Interval = 10;
            this.tmParralax.Tick += new System.EventHandler(this.tmParralax_Tick);
            // 
            // btnPlayVideo
            // 
            this.btnPlayVideo.BackColor = System.Drawing.Color.Black;
            this.btnPlayVideo.FlatAppearance.BorderSize = 0;
            this.btnPlayVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlayVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlayVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayVideo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayVideo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlayVideo.Location = new System.Drawing.Point(607, 306);
            this.btnPlayVideo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPlayVideo.Name = "btnPlayVideo";
            this.btnPlayVideo.Size = new System.Drawing.Size(157, 43);
            this.btnPlayVideo.TabIndex = 45;
            this.btnPlayVideo.Text = "Start Video";
            this.btnPlayVideo.UseVisualStyleBackColor = false;
            this.btnPlayVideo.Click += new System.EventHandler(this.btnPlayVideo_Click);
            this.btnPlayVideo.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnPlayVideo.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.Black;
            this.rb3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb3.Location = new System.Drawing.Point(607, 228);
            this.rb3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(38, 27);
            this.rb3.TabIndex = 48;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = false;
            this.rb3.Visible = false;
            this.rb3.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.rb3.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.Black;
            this.rb2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb2.Location = new System.Drawing.Point(608, 168);
            this.rb2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(38, 27);
            this.rb2.TabIndex = 47;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = false;
            this.rb2.Visible = false;
            this.rb2.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.rb2.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.Black;
            this.rb1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb1.Location = new System.Drawing.Point(607, 107);
            this.rb1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(38, 27);
            this.rb1.TabIndex = 46;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = false;
            this.rb1.Visible = false;
            this.rb1.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.rb1.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.Black;
            this.btnSkip.Enabled = false;
            this.btnSkip.FlatAppearance.BorderSize = 0;
            this.btnSkip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSkip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSkip.Location = new System.Drawing.Point(31, 393);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(157, 43);
            this.btnSkip.TabIndex = 49;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            this.btnSkip.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnSkip.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.BackColor = System.Drawing.Color.Black;
            this.lbAnswer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnswer.Location = new System.Drawing.Point(204, 404);
            this.lbAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(80, 23);
            this.lbAnswer.TabIndex = 30;
            this.lbAnswer.Text = "lbAnswer";
            this.lbAnswer.Visible = false;
            // 
            // mVideo
            // 
            this.mVideo.Enabled = true;
            this.mVideo.Location = new System.Drawing.Point(12, 63);
            this.mVideo.Name = "mVideo";
            this.mVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mVideo.OcxState")));
            this.mVideo.Size = new System.Drawing.Size(552, 298);
            this.mVideo.TabIndex = 44;
            this.mVideo.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mVideo_PlayStateChange);
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
            this.btnHelp.Location = new System.Drawing.Point(703, 452);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(86, 43);
            this.btnHelp.TabIndex = 50;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // frmQuestionsExtreme
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.btnPlayVideo);
            this.Controls.Add(this.mVideo);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pgbTime);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 546);
            this.MinimumSize = new System.Drawing.Size(816, 546);
            this.Name = "frmQuestionsExtreme";
            this.Text = "frmQuestionsExtreme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuestionsExtreme_FormClosing);
            this.Load += new System.EventHandler(this.frmQuestionsTrueFalse_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmQuestionsExtreme_Paint);
            this.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.MouseLeave += new System.EventHandler(this.ControlLeft);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbQuestionNum;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ProgressBar pgbTime;
        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.Timer tmParralax;
        private AxWMPLib.AxWindowsMediaPlayer mVideo;
        private System.Windows.Forms.Button btnPlayVideo;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Button btnHelp;
    }
}