namespace TerrariaQuiz
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnProceed = new System.Windows.Forms.Button();
            this.trbMusicVolume = new System.Windows.Forms.TrackBar();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMusicVolume = new System.Windows.Forms.Label();
            this.chbParallax = new System.Windows.Forms.CheckBox();
            this.lbParallax = new System.Windows.Forms.Label();
            this.tmParralax = new System.Windows.Forms.Timer(this.components);
            this.lbMusicVolumePercent = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.btnCCEANote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbMusicVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Black;
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProceed.Location = new System.Drawing.Point(379, 234);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(132, 48);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            this.btnProceed.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnProceed.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // trbMusicVolume
            // 
            this.trbMusicVolume.Location = new System.Drawing.Point(12, 67);
            this.trbMusicVolume.Maximum = 100;
            this.trbMusicVolume.Name = "trbMusicVolume";
            this.trbMusicVolume.Size = new System.Drawing.Size(282, 45);
            this.trbMusicVolume.TabIndex = 4;
            this.trbMusicVolume.Value = 50;
            this.trbMusicVolume.Scroll += new System.EventHandler(this.trbMusicVolume_Scroll);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Black;
            this.lbTitle.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(83, 25);
            this.lbTitle.TabIndex = 11;
            this.lbTitle.Text = "Settings";
            // 
            // lbMusicVolume
            // 
            this.lbMusicVolume.AutoSize = true;
            this.lbMusicVolume.BackColor = System.Drawing.Color.Black;
            this.lbMusicVolume.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMusicVolume.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbMusicVolume.Location = new System.Drawing.Point(12, 45);
            this.lbMusicVolume.Name = "lbMusicVolume";
            this.lbMusicVolume.Size = new System.Drawing.Size(94, 19);
            this.lbMusicVolume.TabIndex = 12;
            this.lbMusicVolume.Text = "Music Volume";
            // 
            // chbParallax
            // 
            this.chbParallax.AutoSize = true;
            this.chbParallax.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chbParallax.Checked = true;
            this.chbParallax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbParallax.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParallax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbParallax.Location = new System.Drawing.Point(12, 186);
            this.chbParallax.Name = "chbParallax";
            this.chbParallax.Size = new System.Drawing.Size(44, 22);
            this.chbParallax.TabIndex = 15;
            this.chbParallax.Text = "On";
            this.chbParallax.UseVisualStyleBackColor = false;
            this.chbParallax.CheckedChanged += new System.EventHandler(this.chbParallax_CheckedChanged);
            // 
            // lbParallax
            // 
            this.lbParallax.AutoSize = true;
            this.lbParallax.BackColor = System.Drawing.Color.Black;
            this.lbParallax.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParallax.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbParallax.Location = new System.Drawing.Point(12, 164);
            this.lbParallax.Name = "lbParallax";
            this.lbParallax.Size = new System.Drawing.Size(59, 19);
            this.lbParallax.TabIndex = 16;
            this.lbParallax.Text = "Parallax";
            // 
            // tmParralax
            // 
            this.tmParralax.Interval = 10;
            this.tmParralax.Tick += new System.EventHandler(this.tmParralax_Tick);
            // 
            // lbMusicVolumePercent
            // 
            this.lbMusicVolumePercent.AutoSize = true;
            this.lbMusicVolumePercent.BackColor = System.Drawing.Color.Black;
            this.lbMusicVolumePercent.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMusicVolumePercent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbMusicVolumePercent.Location = new System.Drawing.Point(300, 67);
            this.lbMusicVolumePercent.Name = "lbMusicVolumePercent";
            this.lbMusicVolumePercent.Size = new System.Drawing.Size(36, 19);
            this.lbMusicVolumePercent.TabIndex = 17;
            this.lbMusicVolumePercent.Text = "50%";
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "French",
            "German"});
            this.cbLanguage.Location = new System.Drawing.Point(12, 137);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(121, 24);
            this.cbLanguage.TabIndex = 18;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.BackColor = System.Drawing.Color.Black;
            this.lbLanguage.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbLanguage.Location = new System.Drawing.Point(12, 115);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(65, 19);
            this.lbLanguage.TabIndex = 19;
            this.lbLanguage.Text = "Language";
            // 
            // btnCCEANote
            // 
            this.btnCCEANote.BackColor = System.Drawing.Color.Black;
            this.btnCCEANote.FlatAppearance.BorderSize = 0;
            this.btnCCEANote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCCEANote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCCEANote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCEANote.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCEANote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCCEANote.Location = new System.Drawing.Point(379, 164);
            this.btnCCEANote.Name = "btnCCEANote";
            this.btnCCEANote.Size = new System.Drawing.Size(132, 64);
            this.btnCCEANote.TabIndex = 20;
            this.btnCCEANote.Text = "Note to CCEA";
            this.btnCCEANote.UseVisualStyleBackColor = false;
            this.btnCCEANote.Click += new System.EventHandler(this.btnCCEANote_Click);
            this.btnCCEANote.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnCCEANote.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TerrariaQuiz.Resources.Sky;
            this.ClientSize = new System.Drawing.Size(523, 294);
            this.Controls.Add(this.btnCCEANote);
            this.Controls.Add(this.lbLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.lbMusicVolumePercent);
            this.Controls.Add(this.lbParallax);
            this.Controls.Add(this.chbParallax);
            this.Controls.Add(this.lbMusicVolume);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.trbMusicVolume);
            this.Controls.Add(this.btnProceed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(539, 333);
            this.MinimumSize = new System.Drawing.Size(539, 333);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.VisibleChanged += new System.EventHandler(this.frmSettings_VisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmSettings_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trbMusicVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TrackBar trbMusicVolume;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMusicVolume;
        private System.Windows.Forms.CheckBox chbParallax;
        private System.Windows.Forms.Label lbParallax;
        private System.Windows.Forms.Timer tmParralax;
        private System.Windows.Forms.Label lbMusicVolumePercent;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.Button btnCCEANote;
    }
}