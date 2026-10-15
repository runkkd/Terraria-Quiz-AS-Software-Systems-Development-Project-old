
namespace TerrariaQuiz
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.lbLoadingLabel = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.pLoad = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pBackground = new System.Windows.Forms.PictureBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelFade = new System.Windows.Forms.Panel();
            this.mBackgroundMusic = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBackgroundMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // tmTime
            // 
            this.tmTime.Enabled = true;
            this.tmTime.Interval = 1;
            this.tmTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbLoadingLabel
            // 
            this.lbLoadingLabel.AutoSize = true;
            this.lbLoadingLabel.BackColor = System.Drawing.Color.Black;
            this.lbLoadingLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoadingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbLoadingLabel.Location = new System.Drawing.Point(274, 268);
            this.lbLoadingLabel.Name = "lbLoadingLabel";
            this.lbLoadingLabel.Size = new System.Drawing.Size(106, 30);
            this.lbLoadingLabel.TabIndex = 3;
            this.lbLoadingLabel.Text = "Loading..";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVersion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVersion.Location = new System.Drawing.Point(12, 420);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(62, 21);
            this.lbVersion.TabIndex = 6;
            this.lbVersion.Text = "Version";
            // 
            // pLoad
            // 
            this.pLoad.BackColor = System.Drawing.Color.Lime;
            this.pLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pLoad.Location = new System.Drawing.Point(124, -64);
            this.pLoad.Name = "pLoad";
            this.pLoad.Size = new System.Drawing.Size(535, 27);
            this.pLoad.TabIndex = 40;
            this.pLoad.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Location = new System.Drawing.Point(120, 349);
            this.panel.MaximumSize = new System.Drawing.Size(570, 20);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(570, 20);
            this.panel.TabIndex = 44;
            // 
            // pBackground
            // 
            this.pBackground.BackColor = System.Drawing.Color.White;
            this.pBackground.BackgroundImage = global::TerrariaQuiz.Resources.mushroom;
            this.pBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBackground.Location = new System.Drawing.Point(0, -4);
            this.pBackground.Name = "pBackground";
            this.pBackground.Size = new System.Drawing.Size(803, 457);
            this.pBackground.TabIndex = 1;
            this.pBackground.TabStop = false;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.Control;
            this.panelBack.Location = new System.Drawing.Point(118, 347);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(574, 24);
            this.panelBack.TabIndex = 45;
            // 
            // panelFade
            // 
            this.panelFade.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelFade.Location = new System.Drawing.Point(0, -4);
            this.panelFade.Name = "panelFade";
            this.panelFade.Size = new System.Drawing.Size(803, 457);
            this.panelFade.TabIndex = 46;
            // 
            // mBackgroundMusic
            // 
            this.mBackgroundMusic.Enabled = true;
            this.mBackgroundMusic.Location = new System.Drawing.Point(669, 157);
            this.mBackgroundMusic.Name = "mBackgroundMusic";
            this.mBackgroundMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mBackgroundMusic.OcxState")));
            this.mBackgroundMusic.Size = new System.Drawing.Size(78, 65);
            this.mBackgroundMusic.TabIndex = 38;
            this.mBackgroundMusic.Visible = false;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pLoad);
            this.Controls.Add(this.mBackgroundMusic);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbLoadingLabel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.pBackground);
            this.Controls.Add(this.panelFade);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmSplashScreen";
            this.Text = "frmSplashScreen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mBackgroundMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.Label lbLoadingLabel;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.PictureBox pLoad;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pBackground;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelFade;
        private AxWMPLib.AxWindowsMediaPlayer mBackgroundMusic;
    }
}