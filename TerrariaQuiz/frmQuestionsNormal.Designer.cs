
namespace TerrariaQuiz
{
    partial class frmBossQuestionsNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBossQuestionsNormal));
            this.lbQuestionNum = new System.Windows.Forms.Label();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.lbDrag1 = new System.Windows.Forms.Label();
            this.lbDrag2 = new System.Windows.Forms.Label();
            this.lbDrag3 = new System.Windows.Forms.Label();
            this.lbDrag4 = new System.Windows.Forms.Label();
            this.lbDrag5 = new System.Windows.Forms.Label();
            this.lbDrag6 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.pgbTime = new System.Windows.Forms.ProgressBar();
            this.lbScore = new System.Windows.Forms.Label();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.pImage6 = new System.Windows.Forms.PictureBox();
            this.pImage5 = new System.Windows.Forms.PictureBox();
            this.pImage4 = new System.Windows.Forms.PictureBox();
            this.pImage3 = new System.Windows.Forms.PictureBox();
            this.pImage2 = new System.Windows.Forms.PictureBox();
            this.pImage1 = new System.Windows.Forms.PictureBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmParralax = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pImage6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuestionNum
            // 
            this.lbQuestionNum.AutoSize = true;
            this.lbQuestionNum.BackColor = System.Drawing.Color.Black;
            this.lbQuestionNum.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestionNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbQuestionNum.Location = new System.Drawing.Point(12, 32);
            this.lbQuestionNum.Name = "lbQuestionNum";
            this.lbQuestionNum.Size = new System.Drawing.Size(85, 19);
            this.lbQuestionNum.TabIndex = 9;
            this.lbQuestionNum.Text = "Question 4a";
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.BackColor = System.Drawing.Color.Black;
            this.lbQuestion.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbQuestion.Location = new System.Drawing.Point(11, 5);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(470, 25);
            this.lbQuestion.TabIndex = 10;
            this.lbQuestion.Text = "Drag and Drop the boss name with the correct boss";
            // 
            // lbDrag1
            // 
            this.lbDrag1.AutoSize = true;
            this.lbDrag1.BackColor = System.Drawing.Color.Black;
            this.lbDrag1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrag1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDrag1.Location = new System.Drawing.Point(240, 308);
            this.lbDrag1.Name = "lbDrag1";
            this.lbDrag1.Size = new System.Drawing.Size(55, 23);
            this.lbDrag1.TabIndex = 11;
            this.lbDrag1.Text = "drag1";
            this.lbDrag1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // lbDrag2
            // 
            this.lbDrag2.AutoSize = true;
            this.lbDrag2.BackColor = System.Drawing.Color.Black;
            this.lbDrag2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrag2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDrag2.Location = new System.Drawing.Point(9, 308);
            this.lbDrag2.Name = "lbDrag2";
            this.lbDrag2.Size = new System.Drawing.Size(55, 23);
            this.lbDrag2.TabIndex = 13;
            this.lbDrag2.Text = "drag2";
            this.lbDrag2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // lbDrag3
            // 
            this.lbDrag3.AutoSize = true;
            this.lbDrag3.BackColor = System.Drawing.Color.Black;
            this.lbDrag3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrag3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDrag3.Location = new System.Drawing.Point(240, 204);
            this.lbDrag3.Name = "lbDrag3";
            this.lbDrag3.Size = new System.Drawing.Size(55, 23);
            this.lbDrag3.TabIndex = 15;
            this.lbDrag3.Text = "drag3";
            this.lbDrag3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // lbDrag4
            // 
            this.lbDrag4.AutoSize = true;
            this.lbDrag4.BackColor = System.Drawing.Color.Black;
            this.lbDrag4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrag4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDrag4.Location = new System.Drawing.Point(9, 204);
            this.lbDrag4.Name = "lbDrag4";
            this.lbDrag4.Size = new System.Drawing.Size(55, 23);
            this.lbDrag4.TabIndex = 17;
            this.lbDrag4.Text = "drag4";
            this.lbDrag4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // lbDrag5
            // 
            this.lbDrag5.AutoSize = true;
            this.lbDrag5.BackColor = System.Drawing.Color.Black;
            this.lbDrag5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrag5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDrag5.Location = new System.Drawing.Point(9, 107);
            this.lbDrag5.Name = "lbDrag5";
            this.lbDrag5.Size = new System.Drawing.Size(55, 23);
            this.lbDrag5.TabIndex = 18;
            this.lbDrag5.Text = "drag5";
            this.lbDrag5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // lbDrag6
            // 
            this.lbDrag6.AutoSize = true;
            this.lbDrag6.BackColor = System.Drawing.Color.Black;
            this.lbDrag6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrag6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDrag6.Location = new System.Drawing.Point(240, 107);
            this.lbDrag6.Name = "lbDrag6";
            this.lbDrag6.Size = new System.Drawing.Size(55, 23);
            this.lbDrag6.TabIndex = 19;
            this.lbDrag6.Text = "drag6";
            this.lbDrag6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelGrabbed);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Black;
            this.lbTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTime.Location = new System.Drawing.Point(130, 382);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(118, 19);
            this.lbTime.TabIndex = 24;
            this.lbTime.Text = "Time Remaining: ";
            // 
            // pgbTime
            // 
            this.pgbTime.Location = new System.Drawing.Point(32, 404);
            this.pgbTime.Maximum = 60;
            this.pgbTime.Name = "pgbTime";
            this.pgbTime.Size = new System.Drawing.Size(342, 23);
            this.pgbTime.TabIndex = 23;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Black;
            this.lbScore.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbScore.Location = new System.Drawing.Point(633, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(65, 21);
            this.lbScore.TabIndex = 25;
            this.lbScore.Text = "Score: ";
            // 
            // tmTime
            // 
            this.tmTime.Interval = 1000;
            this.tmTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pImage6
            // 
            this.pImage6.BackColor = System.Drawing.Color.Transparent;
            this.pImage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pImage6.Location = new System.Drawing.Point(596, 72);
            this.pImage6.Name = "pImage6";
            this.pImage6.Size = new System.Drawing.Size(90, 90);
            this.pImage6.TabIndex = 22;
            this.pImage6.TabStop = false;
            this.pImage6.DragDrop += new System.Windows.Forms.DragEventHandler(this.EaterDragDrop);
            this.pImage6.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // pImage5
            // 
            this.pImage5.BackColor = System.Drawing.Color.Transparent;
            this.pImage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pImage5.Location = new System.Drawing.Point(596, 337);
            this.pImage5.Name = "pImage5";
            this.pImage5.Size = new System.Drawing.Size(90, 90);
            this.pImage5.TabIndex = 21;
            this.pImage5.TabStop = false;
            this.pImage5.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlanteraDragDrop);
            this.pImage5.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // pImage4
            // 
            this.pImage4.BackColor = System.Drawing.Color.Transparent;
            this.pImage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pImage4.Location = new System.Drawing.Point(489, 72);
            this.pImage4.Name = "pImage4";
            this.pImage4.Size = new System.Drawing.Size(90, 90);
            this.pImage4.TabIndex = 20;
            this.pImage4.TabStop = false;
            this.pImage4.DragDrop += new System.Windows.Forms.DragEventHandler(this.SlimeDragDrop);
            this.pImage4.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // pImage3
            // 
            this.pImage3.BackColor = System.Drawing.Color.Transparent;
            this.pImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pImage3.Location = new System.Drawing.Point(489, 204);
            this.pImage3.Name = "pImage3";
            this.pImage3.Size = new System.Drawing.Size(90, 90);
            this.pImage3.TabIndex = 16;
            this.pImage3.TabStop = false;
            this.pImage3.DragDrop += new System.Windows.Forms.DragEventHandler(this.MoonDragDrop);
            this.pImage3.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // pImage2
            // 
            this.pImage2.BackColor = System.Drawing.Color.Transparent;
            this.pImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pImage2.Location = new System.Drawing.Point(596, 204);
            this.pImage2.Name = "pImage2";
            this.pImage2.Size = new System.Drawing.Size(90, 90);
            this.pImage2.TabIndex = 14;
            this.pImage2.TabStop = false;
            this.pImage2.DragDrop += new System.Windows.Forms.DragEventHandler(this.QueenDragDrop);
            this.pImage2.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // pImage1
            // 
            this.pImage1.BackColor = System.Drawing.Color.Transparent;
            this.pImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pImage1.Location = new System.Drawing.Point(489, 337);
            this.pImage1.Name = "pImage1";
            this.pImage1.Size = new System.Drawing.Size(90, 90);
            this.pImage1.TabIndex = 12;
            this.pImage1.TabStop = false;
            this.pImage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.WallDragDrop);
            this.pImage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllowDragDropCopy);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVersion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVersion.Location = new System.Drawing.Point(9, 430);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(62, 21);
            this.lbVersion.TabIndex = 26;
            this.lbVersion.Text = "Version";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(190)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Controls.Add(this.lbQuestionNum);
            this.panel1.Controls.Add(this.lbQuestion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 57);
            this.panel1.TabIndex = 27;
            this.panel1.TabStop = true;
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
            this.btnHelp.Location = new System.Drawing.Point(389, 405);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(86, 43);
            this.btnHelp.TabIndex = 28;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // frmBossQuestionsNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 460);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pgbTime);
            this.Controls.Add(this.pImage6);
            this.Controls.Add(this.pImage5);
            this.Controls.Add(this.pImage4);
            this.Controls.Add(this.lbDrag6);
            this.Controls.Add(this.lbDrag5);
            this.Controls.Add(this.lbDrag4);
            this.Controls.Add(this.pImage3);
            this.Controls.Add(this.lbDrag3);
            this.Controls.Add(this.pImage2);
            this.Controls.Add(this.lbDrag2);
            this.Controls.Add(this.pImage1);
            this.Controls.Add(this.lbDrag1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(726, 499);
            this.MinimumSize = new System.Drawing.Size(726, 499);
            this.Name = "frmBossQuestionsNormal";
            this.Text = "frmBossQuestionsNormal";
            this.Load += new System.EventHandler(this.frmBossQuestionsNormal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmBossQuestionsNormal_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pImage6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbQuestionNum;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Label lbDrag1;
        private System.Windows.Forms.PictureBox pImage1;
        private System.Windows.Forms.Label lbDrag2;
        private System.Windows.Forms.PictureBox pImage2;
        private System.Windows.Forms.Label lbDrag3;
        private System.Windows.Forms.PictureBox pImage3;
        private System.Windows.Forms.Label lbDrag4;
        private System.Windows.Forms.Label lbDrag5;
        private System.Windows.Forms.Label lbDrag6;
        private System.Windows.Forms.PictureBox pImage4;
        private System.Windows.Forms.PictureBox pImage5;
        private System.Windows.Forms.PictureBox pImage6;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ProgressBar pgbTime;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmParralax;
        private System.Windows.Forms.Button btnHelp;
    }
}