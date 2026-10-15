
namespace TerrariaQuiz
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.pTitle = new System.Windows.Forms.PictureBox();
            this.btnStartHelp = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnQuestionPickerHelp = new System.Windows.Forms.Button();
            this.btnFirstQuesHelp = new System.Windows.Forms.Button();
            this.btnSecondQuesHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btn3rdQuesHelp = new System.Windows.Forms.Button();
            this.tmParralax = new System.Windows.Forms.Timer(this.components);
            this.btn4thQuesHelp = new System.Windows.Forms.Button();
            this.btn5thQuesHelp = new System.Windows.Forms.Button();
            this.btnViewInfoHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.BackgroundImage = global::TerrariaQuiz.Resources.custom_terraria_logo;
            this.pTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTitle.Location = new System.Drawing.Point(291, -1);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(135, 86);
            this.pTitle.TabIndex = 6;
            this.pTitle.TabStop = false;
            // 
            // btnStartHelp
            // 
            this.btnStartHelp.BackColor = System.Drawing.Color.Black;
            this.btnStartHelp.FlatAppearance.BorderSize = 0;
            this.btnStartHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStartHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStartHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartHelp.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStartHelp.Location = new System.Drawing.Point(12, 124);
            this.btnStartHelp.Name = "btnStartHelp";
            this.btnStartHelp.Size = new System.Drawing.Size(101, 36);
            this.btnStartHelp.TabIndex = 7;
            this.btnStartHelp.Tag = "Start";
            this.btnStartHelp.Text = "Start";
            this.btnStartHelp.UseVisualStyleBackColor = false;
            this.btnStartHelp.Click += new System.EventHandler(this.HelpButton_Click);
            this.btnStartHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnStartHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Black;
            this.lbTitle.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitle.Location = new System.Drawing.Point(7, 96);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(454, 25);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Click the buttons to get help for the related form";
            // 
            // btnQuestionPickerHelp
            // 
            this.btnQuestionPickerHelp.BackColor = System.Drawing.Color.Black;
            this.btnQuestionPickerHelp.FlatAppearance.BorderSize = 0;
            this.btnQuestionPickerHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuestionPickerHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuestionPickerHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionPickerHelp.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionPickerHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuestionPickerHelp.Location = new System.Drawing.Point(12, 166);
            this.btnQuestionPickerHelp.Name = "btnQuestionPickerHelp";
            this.btnQuestionPickerHelp.Size = new System.Drawing.Size(164, 36);
            this.btnQuestionPickerHelp.TabIndex = 11;
            this.btnQuestionPickerHelp.Tag = "QuestionPicker";
            this.btnQuestionPickerHelp.Text = "Question Picker";
            this.btnQuestionPickerHelp.UseVisualStyleBackColor = false;
            this.btnQuestionPickerHelp.Click += new System.EventHandler(this.HelpButton_Click);
            this.btnQuestionPickerHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnQuestionPickerHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnFirstQuesHelp
            // 
            this.btnFirstQuesHelp.BackColor = System.Drawing.Color.Black;
            this.btnFirstQuesHelp.FlatAppearance.BorderSize = 0;
            this.btnFirstQuesHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFirstQuesHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFirstQuesHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstQuesHelp.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstQuesHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFirstQuesHelp.Location = new System.Drawing.Point(12, 208);
            this.btnFirstQuesHelp.Name = "btnFirstQuesHelp";
            this.btnFirstQuesHelp.Size = new System.Drawing.Size(164, 36);
            this.btnFirstQuesHelp.TabIndex = 12;
            this.btnFirstQuesHelp.Tag = "1stQuestion";
            this.btnFirstQuesHelp.Text = "1st Question";
            this.btnFirstQuesHelp.UseVisualStyleBackColor = false;
            this.btnFirstQuesHelp.Click += new System.EventHandler(this.HelpButton_Click);
            this.btnFirstQuesHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnFirstQuesHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnSecondQuesHelp
            // 
            this.btnSecondQuesHelp.BackColor = System.Drawing.Color.Black;
            this.btnSecondQuesHelp.FlatAppearance.BorderSize = 0;
            this.btnSecondQuesHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSecondQuesHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSecondQuesHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondQuesHelp.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondQuesHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSecondQuesHelp.Location = new System.Drawing.Point(12, 250);
            this.btnSecondQuesHelp.Name = "btnSecondQuesHelp";
            this.btnSecondQuesHelp.Size = new System.Drawing.Size(164, 36);
            this.btnSecondQuesHelp.TabIndex = 13;
            this.btnSecondQuesHelp.Tag = "2ndQuestion";
            this.btnSecondQuesHelp.Text = "2nd Question";
            this.btnSecondQuesHelp.UseVisualStyleBackColor = false;
            this.btnSecondQuesHelp.Click += new System.EventHandler(this.HelpButton_Click);
            this.btnSecondQuesHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnSecondQuesHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(517, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 36);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit Help";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnExit.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVersion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVersion.Location = new System.Drawing.Point(8, 420);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(62, 21);
            this.lbVersion.TabIndex = 27;
            this.lbVersion.Text = "Version";
            // 
            // btn3rdQuesHelp
            // 
            this.btn3rdQuesHelp.BackColor = System.Drawing.Color.Black;
            this.btn3rdQuesHelp.FlatAppearance.BorderSize = 0;
            this.btn3rdQuesHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn3rdQuesHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn3rdQuesHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3rdQuesHelp.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3rdQuesHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3rdQuesHelp.Location = new System.Drawing.Point(12, 292);
            this.btn3rdQuesHelp.Name = "btn3rdQuesHelp";
            this.btn3rdQuesHelp.Size = new System.Drawing.Size(164, 36);
            this.btn3rdQuesHelp.TabIndex = 28;
            this.btn3rdQuesHelp.Tag = "3rdQuestion";
            this.btn3rdQuesHelp.Text = "3rd Question";
            this.btn3rdQuesHelp.UseVisualStyleBackColor = false;
            this.btn3rdQuesHelp.Click += new System.EventHandler(this.HelpButton_Click);
            this.btn3rdQuesHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btn3rdQuesHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // tmParralax
            // 
            this.tmParralax.Enabled = true;
            this.tmParralax.Interval = 10;
            this.tmParralax.Tick += new System.EventHandler(this.tmParralax_Tick);
            // 
            // btn4thQuesHelp
            // 
            this.btn4thQuesHelp.BackColor = System.Drawing.Color.Black;
            this.btn4thQuesHelp.FlatAppearance.BorderSize = 0;
            this.btn4thQuesHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn4thQuesHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn4thQuesHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4thQuesHelp.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4thQuesHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4thQuesHelp.Location = new System.Drawing.Point(12, 334);
            this.btn4thQuesHelp.Name = "btn4thQuesHelp";
            this.btn4thQuesHelp.Size = new System.Drawing.Size(164, 36);
            this.btn4thQuesHelp.TabIndex = 29;
            this.btn4thQuesHelp.Tag = "4thQuestion";
            this.btn4thQuesHelp.Text = "4th Question";
            this.btn4thQuesHelp.UseVisualStyleBackColor = false;
            this.btn4thQuesHelp.Click += new System.EventHandler(this.HelpButton_Click);
            this.btn4thQuesHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btn4thQuesHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btn5thQuesHelp
            // 
            this.btn5thQuesHelp.BackColor = System.Drawing.Color.Black;
            this.btn5thQuesHelp.FlatAppearance.BorderSize = 0;
            this.btn5thQuesHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn5thQuesHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn5thQuesHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5thQuesHelp.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5thQuesHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5thQuesHelp.Location = new System.Drawing.Point(12, 376);
            this.btn5thQuesHelp.Name = "btn5thQuesHelp";
            this.btn5thQuesHelp.Size = new System.Drawing.Size(164, 36);
            this.btn5thQuesHelp.TabIndex = 30;
            this.btn5thQuesHelp.Tag = "5thQuestion";
            this.btn5thQuesHelp.Text = "5th Question";
            this.btn5thQuesHelp.UseVisualStyleBackColor = false;
            this.btn5thQuesHelp.Click += new System.EventHandler(this.HelpButton_Click);
            this.btn5thQuesHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btn5thQuesHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnViewInfoHelp
            // 
            this.btnViewInfoHelp.BackColor = System.Drawing.Color.Black;
            this.btnViewInfoHelp.FlatAppearance.BorderSize = 0;
            this.btnViewInfoHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewInfoHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnViewInfoHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInfoHelp.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInfoHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewInfoHelp.Location = new System.Drawing.Point(181, 124);
            this.btnViewInfoHelp.Name = "btnViewInfoHelp";
            this.btnViewInfoHelp.Size = new System.Drawing.Size(167, 36);
            this.btnViewInfoHelp.TabIndex = 31;
            this.btnViewInfoHelp.Tag = "Leaderboard";
            this.btnViewInfoHelp.Text = "Leaderboard";
            this.btnViewInfoHelp.UseVisualStyleBackColor = false;
            this.btnViewInfoHelp.Click += new System.EventHandler(this.HelpButton_Click);
            this.btnViewInfoHelp.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnViewInfoHelp.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TerrariaQuiz.Resources.BackgroundHell3;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.btnViewInfoHelp);
            this.Controls.Add(this.btn5thQuesHelp);
            this.Controls.Add(this.btn4thQuesHelp);
            this.Controls.Add(this.btn3rdQuesHelp);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSecondQuesHelp);
            this.Controls.Add(this.btnFirstQuesHelp);
            this.Controls.Add(this.btnQuestionPickerHelp);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnStartHelp);
            this.Controls.Add(this.pTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(681, 489);
            this.MinimumSize = new System.Drawing.Size(681, 489);
            this.Name = "frmHelp";
            this.Text = "frmHelp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHelp_FormClosed);
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.Shown += new System.EventHandler(this.frmHelp_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmHelp_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pTitle;
        private System.Windows.Forms.Button btnStartHelp;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnQuestionPickerHelp;
        private System.Windows.Forms.Button btnFirstQuesHelp;
        private System.Windows.Forms.Button btnSecondQuesHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btn3rdQuesHelp;
        private System.Windows.Forms.Timer tmParralax;
        private System.Windows.Forms.Button btn4thQuesHelp;
        private System.Windows.Forms.Button btn5thQuesHelp;
        private System.Windows.Forms.Button btnViewInfoHelp;
    }
}