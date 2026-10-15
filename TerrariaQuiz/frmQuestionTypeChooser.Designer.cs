
namespace TerrariaQuiz
{
    partial class frmQuestionTypeChooser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestionTypeChooser));
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnNpcs = new System.Windows.Forms.Button();
            this.btnWeapons = new System.Windows.Forms.Button();
            this.btnBosses = new System.Windows.Forms.Button();
            this.tmParralax = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.lbVersion.TabIndex = 7;
            this.lbVersion.Text = "Version";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(12, 61);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(407, 38);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Please choose a question type";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.Black;
            this.btnRandom.BackgroundImage = global::TerrariaQuiz.Resources.Teleportation_Potion;
            this.btnRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRandom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRandom.Location = new System.Drawing.Point(443, 285);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(125, 125);
            this.btnRandom.TabIndex = 12;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            this.btnRandom.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnRandom.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnNpcs
            // 
            this.btnNpcs.BackColor = System.Drawing.Color.Black;
            this.btnNpcs.BackgroundImage = global::TerrariaQuiz.Resources.Guide;
            this.btnNpcs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNpcs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNpcs.FlatAppearance.BorderSize = 0;
            this.btnNpcs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNpcs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNpcs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNpcs.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNpcs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNpcs.Location = new System.Drawing.Point(251, 285);
            this.btnNpcs.Name = "btnNpcs";
            this.btnNpcs.Size = new System.Drawing.Size(125, 125);
            this.btnNpcs.TabIndex = 11;
            this.btnNpcs.Text = "Npcs";
            this.btnNpcs.UseVisualStyleBackColor = false;
            this.btnNpcs.Click += new System.EventHandler(this.btnNpcs_Click);
            this.btnNpcs.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnNpcs.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnWeapons
            // 
            this.btnWeapons.BackColor = System.Drawing.Color.Black;
            this.btnWeapons.BackgroundImage = global::TerrariaQuiz.Resources.Zenith;
            this.btnWeapons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWeapons.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWeapons.FlatAppearance.BorderSize = 0;
            this.btnWeapons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWeapons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWeapons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeapons.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeapons.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWeapons.Location = new System.Drawing.Point(443, 112);
            this.btnWeapons.Name = "btnWeapons";
            this.btnWeapons.Size = new System.Drawing.Size(125, 125);
            this.btnWeapons.TabIndex = 10;
            this.btnWeapons.Text = "Weapons";
            this.btnWeapons.UseVisualStyleBackColor = false;
            this.btnWeapons.Click += new System.EventHandler(this.btnWeapons_Click);
            this.btnWeapons.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnWeapons.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnBosses
            // 
            this.btnBosses.BackColor = System.Drawing.Color.Black;
            this.btnBosses.BackgroundImage = global::TerrariaQuiz.Resources.King_Slime;
            this.btnBosses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBosses.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBosses.FlatAppearance.BorderSize = 0;
            this.btnBosses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBosses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBosses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBosses.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBosses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBosses.Location = new System.Drawing.Point(251, 112);
            this.btnBosses.Name = "btnBosses";
            this.btnBosses.Size = new System.Drawing.Size(125, 125);
            this.btnBosses.TabIndex = 9;
            this.btnBosses.Text = "Bosses";
            this.btnBosses.UseVisualStyleBackColor = false;
            this.btnBosses.Click += new System.EventHandler(this.btnBosses_Click);
            this.btnBosses.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnBosses.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // tmParralax
            // 
            this.tmParralax.Enabled = true;
            this.tmParralax.Interval = 10;
            this.tmParralax.Tick += new System.EventHandler(this.tmParralax_Tick);
            // 
            // frmQuestionTypeChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TerrariaQuiz.Resources.Sky;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnNpcs);
            this.Controls.Add(this.btnWeapons);
            this.Controls.Add(this.btnBosses);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmQuestionTypeChooser";
            this.Text = "frmQuestionTypeChooser";
            this.Load += new System.EventHandler(this.frmQuestionTypeChooser_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmQuestionTypeChooser_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnBosses;
        private System.Windows.Forms.Button btnWeapons;
        private System.Windows.Forms.Button btnNpcs;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Timer tmParralax;
    }
}