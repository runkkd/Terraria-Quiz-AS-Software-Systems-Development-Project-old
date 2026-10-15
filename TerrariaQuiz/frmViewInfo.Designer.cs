
namespace TerrariaQuiz
{
    partial class frmViewInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewInfo));
            this.tmParralax = new System.Windows.Forms.Timer(this.components);
            this.dgvPlayerReport = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnQuizResults = new System.Windows.Forms.Button();
            this.btnAchievements = new System.Windows.Forms.Button();
            this.dgvAchievements = new System.Windows.Forms.DataGridView();
            this.btnSortNameAch = new System.Windows.Forms.Button();
            this.btnSortAchievements = new System.Windows.Forms.Button();
            this.btnSortCompleted = new System.Windows.Forms.Button();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnSortByTopic = new System.Windows.Forms.Button();
            this.btnSortScore = new System.Windows.Forms.Button();
            this.btnSortNameInfo = new System.Windows.Forms.Button();
            this.lbSortingTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAchievements)).BeginInit();
            this.panelBack.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmParralax
            // 
            this.tmParralax.Interval = 10;
            this.tmParralax.Tick += new System.EventHandler(this.tmParralax_Tick);
            // 
            // dgvPlayerReport
            // 
            this.dgvPlayerReport.AllowUserToAddRows = false;
            this.dgvPlayerReport.AllowUserToDeleteRows = false;
            this.dgvPlayerReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerReport.Location = new System.Drawing.Point(12, 72);
            this.dgvPlayerReport.Name = "dgvPlayerReport";
            this.dgvPlayerReport.ReadOnly = true;
            this.dgvPlayerReport.Size = new System.Drawing.Size(485, 292);
            this.dgvPlayerReport.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitle.Location = new System.Drawing.Point(136, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(215, 38);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Data Grid Info";
            // 
            // btnQuizResults
            // 
            this.btnQuizResults.BackColor = System.Drawing.Color.Black;
            this.btnQuizResults.Enabled = false;
            this.btnQuizResults.FlatAppearance.BorderSize = 0;
            this.btnQuizResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuizResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuizResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuizResults.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizResults.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuizResults.Location = new System.Drawing.Point(38, 381);
            this.btnQuizResults.Name = "btnQuizResults";
            this.btnQuizResults.Size = new System.Drawing.Size(170, 48);
            this.btnQuizResults.TabIndex = 14;
            this.btnQuizResults.Text = "Quiz Results";
            this.btnQuizResults.UseVisualStyleBackColor = false;
            this.btnQuizResults.Click += new System.EventHandler(this.btnQuizResults_Click);
            this.btnQuizResults.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnQuizResults.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnAchievements
            // 
            this.btnAchievements.BackColor = System.Drawing.Color.Black;
            this.btnAchievements.FlatAppearance.BorderSize = 0;
            this.btnAchievements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAchievements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAchievements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAchievements.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchievements.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAchievements.Location = new System.Drawing.Point(299, 381);
            this.btnAchievements.Name = "btnAchievements";
            this.btnAchievements.Size = new System.Drawing.Size(170, 48);
            this.btnAchievements.TabIndex = 15;
            this.btnAchievements.Text = "Achievements";
            this.btnAchievements.UseVisualStyleBackColor = false;
            this.btnAchievements.Click += new System.EventHandler(this.btnAchievements_Click);
            this.btnAchievements.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnAchievements.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // dgvAchievements
            // 
            this.dgvAchievements.AllowUserToAddRows = false;
            this.dgvAchievements.AllowUserToDeleteRows = false;
            this.dgvAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAchievements.Location = new System.Drawing.Point(12, 72);
            this.dgvAchievements.Name = "dgvAchievements";
            this.dgvAchievements.ReadOnly = true;
            this.dgvAchievements.Size = new System.Drawing.Size(485, 292);
            this.dgvAchievements.TabIndex = 16;
            // 
            // btnSortNameAch
            // 
            this.btnSortNameAch.BackColor = System.Drawing.Color.Black;
            this.btnSortNameAch.FlatAppearance.BorderSize = 0;
            this.btnSortNameAch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortNameAch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortNameAch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortNameAch.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNameAch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSortNameAch.Location = new System.Drawing.Point(3, 13);
            this.btnSortNameAch.Name = "btnSortNameAch";
            this.btnSortNameAch.Size = new System.Drawing.Size(222, 48);
            this.btnSortNameAch.TabIndex = 17;
            this.btnSortNameAch.Text = "Sort by name";
            this.btnSortNameAch.UseVisualStyleBackColor = false;
            this.btnSortNameAch.Click += new System.EventHandler(this.btnSortName_Click);
            this.btnSortNameAch.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnSortNameAch.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnSortAchievements
            // 
            this.btnSortAchievements.BackColor = System.Drawing.Color.Black;
            this.btnSortAchievements.FlatAppearance.BorderSize = 0;
            this.btnSortAchievements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortAchievements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortAchievements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAchievements.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAchievements.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSortAchievements.Location = new System.Drawing.Point(3, 83);
            this.btnSortAchievements.Name = "btnSortAchievements";
            this.btnSortAchievements.Size = new System.Drawing.Size(222, 75);
            this.btnSortAchievements.TabIndex = 18;
            this.btnSortAchievements.Text = "Sort by Achievement";
            this.btnSortAchievements.UseVisualStyleBackColor = false;
            this.btnSortAchievements.Click += new System.EventHandler(this.btnSortAchievements_Click);
            this.btnSortAchievements.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnSortAchievements.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnSortCompleted
            // 
            this.btnSortCompleted.BackColor = System.Drawing.Color.Black;
            this.btnSortCompleted.FlatAppearance.BorderSize = 0;
            this.btnSortCompleted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortCompleted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortCompleted.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortCompleted.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSortCompleted.Location = new System.Drawing.Point(3, 184);
            this.btnSortCompleted.Name = "btnSortCompleted";
            this.btnSortCompleted.Size = new System.Drawing.Size(222, 73);
            this.btnSortCompleted.TabIndex = 19;
            this.btnSortCompleted.Text = "Sort by completed";
            this.btnSortCompleted.UseVisualStyleBackColor = false;
            this.btnSortCompleted.Click += new System.EventHandler(this.btnSortCompleted_Click);
            this.btnSortCompleted.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnSortCompleted.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBack.Controls.Add(this.btnSortCompleted);
            this.panelBack.Controls.Add(this.btnSortAchievements);
            this.panelBack.Controls.Add(this.btnSortNameAch);
            this.panelBack.Location = new System.Drawing.Point(535, 84);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(228, 280);
            this.panelBack.TabIndex = 23;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInfo.Controls.Add(this.btnSortByTopic);
            this.panelInfo.Controls.Add(this.btnSortScore);
            this.panelInfo.Controls.Add(this.btnSortNameInfo);
            this.panelInfo.Location = new System.Drawing.Point(535, 84);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(228, 280);
            this.panelInfo.TabIndex = 24;
            // 
            // btnSortByTopic
            // 
            this.btnSortByTopic.BackColor = System.Drawing.Color.Black;
            this.btnSortByTopic.FlatAppearance.BorderSize = 0;
            this.btnSortByTopic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortByTopic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortByTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortByTopic.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByTopic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSortByTopic.Location = new System.Drawing.Point(2, 151);
            this.btnSortByTopic.Name = "btnSortByTopic";
            this.btnSortByTopic.Size = new System.Drawing.Size(222, 48);
            this.btnSortByTopic.TabIndex = 25;
            this.btnSortByTopic.Text = "Sort by topic";
            this.btnSortByTopic.UseVisualStyleBackColor = false;
            this.btnSortByTopic.Click += new System.EventHandler(this.btnSortByTopic_Click);
            this.btnSortByTopic.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnSortByTopic.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnSortScore
            // 
            this.btnSortScore.BackColor = System.Drawing.Color.Black;
            this.btnSortScore.FlatAppearance.BorderSize = 0;
            this.btnSortScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortScore.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSortScore.Location = new System.Drawing.Point(2, 83);
            this.btnSortScore.Name = "btnSortScore";
            this.btnSortScore.Size = new System.Drawing.Size(222, 48);
            this.btnSortScore.TabIndex = 24;
            this.btnSortScore.Text = "Sort by score";
            this.btnSortScore.UseVisualStyleBackColor = false;
            this.btnSortScore.Click += new System.EventHandler(this.btnSortScore_Click);
            this.btnSortScore.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnSortScore.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnSortNameInfo
            // 
            this.btnSortNameInfo.BackColor = System.Drawing.Color.Black;
            this.btnSortNameInfo.FlatAppearance.BorderSize = 0;
            this.btnSortNameInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortNameInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortNameInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortNameInfo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNameInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSortNameInfo.Location = new System.Drawing.Point(2, 13);
            this.btnSortNameInfo.Name = "btnSortNameInfo";
            this.btnSortNameInfo.Size = new System.Drawing.Size(222, 48);
            this.btnSortNameInfo.TabIndex = 23;
            this.btnSortNameInfo.Text = "Sort by name";
            this.btnSortNameInfo.UseVisualStyleBackColor = false;
            this.btnSortNameInfo.Click += new System.EventHandler(this.btnSortNameInfo_Click);
            this.btnSortNameInfo.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnSortNameInfo.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbSortingTitle
            // 
            this.lbSortingTitle.AutoSize = true;
            this.lbSortingTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSortingTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbSortingTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSortingTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSortingTitle.Location = new System.Drawing.Point(555, 43);
            this.lbSortingTitle.Name = "lbSortingTitle";
            this.lbSortingTitle.Size = new System.Drawing.Size(222, 38);
            this.lbSortingTitle.TabIndex = 25;
            this.lbSortingTitle.Text = "Sorting Options";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(673, 395);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 43);
            this.btnLogout.TabIndex = 34;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnLogout.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // frmViewInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(97)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbSortingTitle);
            this.Controls.Add(this.btnAchievements);
            this.Controls.Add(this.btnQuizResults);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dgvPlayerReport);
            this.Controls.Add(this.dgvAchievements);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewInfo";
            this.Load += new System.EventHandler(this.frmPlaceholder_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPlaceholder_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAchievements)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmParralax;
        private System.Windows.Forms.DataGridView dgvPlayerReport;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnQuizResults;
        private System.Windows.Forms.Button btnAchievements;
        private System.Windows.Forms.DataGridView dgvAchievements;
        private System.Windows.Forms.Button btnSortNameAch;
        private System.Windows.Forms.Button btnSortAchievements;
        private System.Windows.Forms.Button btnSortCompleted;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button btnSortByTopic;
        private System.Windows.Forms.Button btnSortScore;
        private System.Windows.Forms.Button btnSortNameInfo;
        private System.Windows.Forms.Label lbSortingTitle;
        private System.Windows.Forms.Button btnLogout;
    }
}