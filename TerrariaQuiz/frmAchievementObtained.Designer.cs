
namespace TerrariaQuiz
{
    partial class frmAchievementObtained
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAchievementObtained));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAchievementInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAchievementTitle = new System.Windows.Forms.Label();
            this.pTreeOne = new System.Windows.Forms.PictureBox();
            this.pAchievementOne = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pTreeOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAchievementOne)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbAchievementInfo);
            this.panel2.Location = new System.Drawing.Point(96, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 49);
            this.panel2.TabIndex = 11;
            // 
            // lbAchievementInfo
            // 
            this.lbAchievementInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAchievementInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbAchievementInfo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAchievementInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAchievementInfo.Location = new System.Drawing.Point(3, 4);
            this.lbAchievementInfo.Name = "lbAchievementInfo";
            this.lbAchievementInfo.Size = new System.Drawing.Size(253, 45);
            this.lbAchievementInfo.TabIndex = 6;
            this.lbAchievementInfo.Text = "You beat the Terraria Quiz!";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbAchievementTitle);
            this.panel1.Location = new System.Drawing.Point(127, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 25);
            this.panel1.TabIndex = 10;
            // 
            // lbAchievementTitle
            // 
            this.lbAchievementTitle.AutoSize = true;
            this.lbAchievementTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAchievementTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbAchievementTitle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAchievementTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAchievementTitle.Location = new System.Drawing.Point(3, 4);
            this.lbAchievementTitle.Name = "lbAchievementTitle";
            this.lbAchievementTitle.Size = new System.Drawing.Size(99, 19);
            this.lbAchievementTitle.TabIndex = 6;
            this.lbAchievementTitle.Text = "Quiz Achiever";
            // 
            // pTreeOne
            // 
            this.pTreeOne.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pTreeOne.BackgroundImage = global::TerrariaQuiz.Resources.TreeTrue;
            this.pTreeOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTreeOne.Image = global::TerrariaQuiz.Resources.AchieveBorder;
            this.pTreeOne.Location = new System.Drawing.Point(96, 12);
            this.pTreeOne.Name = "pTreeOne";
            this.pTreeOne.Size = new System.Drawing.Size(25, 25);
            this.pTreeOne.TabIndex = 9;
            this.pTreeOne.TabStop = false;
            // 
            // pAchievementOne
            // 
            this.pAchievementOne.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pAchievementOne.BackgroundImage = global::TerrariaQuiz.Resources.Achieve1False;
            this.pAchievementOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pAchievementOne.Image = global::TerrariaQuiz.Resources.AchieveBorder;
            this.pAchievementOne.Location = new System.Drawing.Point(11, 12);
            this.pAchievementOne.Name = "pAchievementOne";
            this.pAchievementOne.Size = new System.Drawing.Size(80, 80);
            this.pAchievementOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAchievementOne.TabIndex = 8;
            this.pAchievementOne.TabStop = false;
            // 
            // frmAchievementObtained
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TerrariaQuiz.Resources.panelBackground;
            this.ClientSize = new System.Drawing.Size(366, 107);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pTreeOne);
            this.Controls.Add(this.pAchievementOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1600, -700);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 146);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 146);
            this.Name = "frmAchievementObtained";
            this.ShowInTaskbar = false;
            this.Text = "Achievement Obtained!";
            this.Load += new System.EventHandler(this.frmAchievementObtained_Load);
            this.Shown += new System.EventHandler(this.frmAchievementObtained_Shown);
            this.VisibleChanged += new System.EventHandler(this.frmAchievementObtained_VisibleChanged);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pTreeOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAchievementOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbAchievementInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAchievementTitle;
        private System.Windows.Forms.PictureBox pTreeOne;
        private System.Windows.Forms.PictureBox pAchievementOne;
    }
}