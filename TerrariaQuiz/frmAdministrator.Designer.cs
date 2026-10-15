
namespace TerrariaQuiz
{
    partial class frmAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrator));
            this.tmParralax = new System.Windows.Forms.Timer(this.components);
            this.btnAchievements = new System.Windows.Forms.Button();
            this.btnQuizResults = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgvPlayerReport = new System.Windows.Forms.DataGridView();
            this.dgvAchievements = new System.Windows.Forms.DataGridView();
            this.panelChangeOptions = new System.Windows.Forms.Panel();
            this.btnChangeAge = new System.Windows.Forms.Button();
            this.btnChangeAchievement = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.lbAdminTitle = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.MaskedTextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbNewUsername = new System.Windows.Forms.Label();
            this.tbNewUsername = new System.Windows.Forms.MaskedTextBox();
            this.panelNewUsername = new System.Windows.Forms.Panel();
            this.panelNewPassword = new System.Windows.Forms.Panel();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.MaskedTextBox();
            this.panelAchievement = new System.Windows.Forms.Panel();
            this.lbAchievementObtained = new System.Windows.Forms.Label();
            this.tbAchievementObtained = new System.Windows.Forms.MaskedTextBox();
            this.lbAchievementId = new System.Windows.Forms.Label();
            this.tbAchievementId = new System.Windows.Forms.MaskedTextBox();
            this.panelAge = new System.Windows.Forms.Panel();
            this.lbNewAge = new System.Windows.Forms.Label();
            this.tbNewAge = new System.Windows.Forms.MaskedTextBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAchievements)).BeginInit();
            this.panelChangeOptions.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.panelNewUsername.SuspendLayout();
            this.panelNewPassword.SuspendLayout();
            this.panelAchievement.SuspendLayout();
            this.panelAge.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmParralax
            // 
            this.tmParralax.Interval = 10;
            this.tmParralax.Tick += new System.EventHandler(this.tmParralax_Tick);
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
            this.btnAchievements.Location = new System.Drawing.Point(213, 208);
            this.btnAchievements.Name = "btnAchievements";
            this.btnAchievements.Size = new System.Drawing.Size(170, 48);
            this.btnAchievements.TabIndex = 19;
            this.btnAchievements.Text = "Achievements";
            this.btnAchievements.UseVisualStyleBackColor = false;
            this.btnAchievements.Click += new System.EventHandler(this.btnAchievements_Click);
            this.btnAchievements.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnAchievements.MouseLeave += new System.EventHandler(this.ControlLeft);
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
            this.btnQuizResults.Location = new System.Drawing.Point(37, 208);
            this.btnQuizResults.Name = "btnQuizResults";
            this.btnQuizResults.Size = new System.Drawing.Size(170, 48);
            this.btnQuizResults.TabIndex = 18;
            this.btnQuizResults.Text = "Quiz Results";
            this.btnQuizResults.UseVisualStyleBackColor = false;
            this.btnQuizResults.Click += new System.EventHandler(this.btnQuizResults_Click);
            this.btnQuizResults.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnQuizResults.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitle.Location = new System.Drawing.Point(158, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(215, 38);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "Data Grid Info";
            // 
            // dgvPlayerReport
            // 
            this.dgvPlayerReport.AllowUserToAddRows = false;
            this.dgvPlayerReport.AllowUserToDeleteRows = false;
            this.dgvPlayerReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerReport.Location = new System.Drawing.Point(22, 50);
            this.dgvPlayerReport.Name = "dgvPlayerReport";
            this.dgvPlayerReport.ReadOnly = true;
            this.dgvPlayerReport.Size = new System.Drawing.Size(499, 152);
            this.dgvPlayerReport.TabIndex = 16;
            // 
            // dgvAchievements
            // 
            this.dgvAchievements.AllowUserToAddRows = false;
            this.dgvAchievements.AllowUserToDeleteRows = false;
            this.dgvAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAchievements.Location = new System.Drawing.Point(22, 50);
            this.dgvAchievements.Name = "dgvAchievements";
            this.dgvAchievements.ReadOnly = true;
            this.dgvAchievements.Size = new System.Drawing.Size(499, 152);
            this.dgvAchievements.TabIndex = 20;
            // 
            // panelChangeOptions
            // 
            this.panelChangeOptions.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelChangeOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChangeOptions.Controls.Add(this.btnChangeAge);
            this.panelChangeOptions.Controls.Add(this.btnChangeAchievement);
            this.panelChangeOptions.Controls.Add(this.btnChangePassword);
            this.panelChangeOptions.Controls.Add(this.btnChangeUsername);
            this.panelChangeOptions.Location = new System.Drawing.Point(541, 50);
            this.panelChangeOptions.Name = "panelChangeOptions";
            this.panelChangeOptions.Size = new System.Drawing.Size(228, 375);
            this.panelChangeOptions.TabIndex = 24;
            // 
            // btnChangeAge
            // 
            this.btnChangeAge.BackColor = System.Drawing.Color.Black;
            this.btnChangeAge.FlatAppearance.BorderSize = 0;
            this.btnChangeAge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChangeAge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChangeAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAge.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeAge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeAge.Location = new System.Drawing.Point(29, 313);
            this.btnChangeAge.Name = "btnChangeAge";
            this.btnChangeAge.Size = new System.Drawing.Size(170, 43);
            this.btnChangeAge.TabIndex = 20;
            this.btnChangeAge.Text = "Change Age";
            this.btnChangeAge.UseVisualStyleBackColor = false;
            this.btnChangeAge.Click += new System.EventHandler(this.btnChangeAge_Click);
            this.btnChangeAge.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnChangeAge.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnChangeAchievement
            // 
            this.btnChangeAchievement.BackColor = System.Drawing.Color.Black;
            this.btnChangeAchievement.FlatAppearance.BorderSize = 0;
            this.btnChangeAchievement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChangeAchievement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChangeAchievement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAchievement.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeAchievement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeAchievement.Location = new System.Drawing.Point(29, 214);
            this.btnChangeAchievement.Name = "btnChangeAchievement";
            this.btnChangeAchievement.Size = new System.Drawing.Size(170, 73);
            this.btnChangeAchievement.TabIndex = 19;
            this.btnChangeAchievement.Text = "Change Achievement";
            this.btnChangeAchievement.UseVisualStyleBackColor = false;
            this.btnChangeAchievement.Click += new System.EventHandler(this.btnChangeAchievement_Click);
            this.btnChangeAchievement.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnChangeAchievement.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Black;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangePassword.Location = new System.Drawing.Point(29, 113);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(170, 75);
            this.btnChangePassword.TabIndex = 18;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            this.btnChangePassword.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnChangePassword.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.Color.Black;
            this.btnChangeUsername.FlatAppearance.BorderSize = 0;
            this.btnChangeUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChangeUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChangeUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUsername.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeUsername.Location = new System.Drawing.Point(29, 13);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Size = new System.Drawing.Size(170, 75);
            this.btnChangeUsername.TabIndex = 17;
            this.btnChangeUsername.Text = "Change Username";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
            this.btnChangeUsername.Click += new System.EventHandler(this.btnChangeUsername_Click);
            this.btnChangeUsername.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnChangeUsername.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbAdminTitle
            // 
            this.lbAdminTitle.AutoSize = true;
            this.lbAdminTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAdminTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbAdminTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdminTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAdminTitle.Location = new System.Drawing.Point(572, 9);
            this.lbAdminTitle.Name = "lbAdminTitle";
            this.lbAdminTitle.Size = new System.Drawing.Size(206, 38);
            this.lbAdminTitle.TabIndex = 26;
            this.lbAdminTitle.Text = "Admin Options";
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUsername.Controls.Add(this.lbUsername);
            this.panelUsername.Controls.Add(this.tbUsername);
            this.panelUsername.Location = new System.Drawing.Point(22, 264);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(180, 73);
            this.panelUsername.TabIndex = 25;
            this.panelUsername.Visible = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbUsername.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUsername.Location = new System.Drawing.Point(11, 12);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(86, 21);
            this.lbUsername.TabIndex = 27;
            this.lbUsername.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(15, 36);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(150, 26);
            this.tbUsername.TabIndex = 22;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Black;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChange.Location = new System.Drawing.Point(413, 381);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(115, 43);
            this.btnChange.TabIndex = 21;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            this.btnChange.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnChange.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbNewUsername
            // 
            this.lbNewUsername.AutoSize = true;
            this.lbNewUsername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNewUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbNewUsername.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNewUsername.Location = new System.Drawing.Point(11, 9);
            this.lbNewUsername.Name = "lbNewUsername";
            this.lbNewUsername.Size = new System.Drawing.Size(123, 21);
            this.lbNewUsername.TabIndex = 29;
            this.lbNewUsername.Text = "New Username:";
            // 
            // tbNewUsername
            // 
            this.tbNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewUsername.Location = new System.Drawing.Point(15, 33);
            this.tbNewUsername.Name = "tbNewUsername";
            this.tbNewUsername.Size = new System.Drawing.Size(150, 26);
            this.tbNewUsername.TabIndex = 28;
            // 
            // panelNewUsername
            // 
            this.panelNewUsername.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelNewUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNewUsername.Controls.Add(this.lbNewUsername);
            this.panelNewUsername.Controls.Add(this.tbNewUsername);
            this.panelNewUsername.Location = new System.Drawing.Point(22, 343);
            this.panelNewUsername.Name = "panelNewUsername";
            this.panelNewUsername.Size = new System.Drawing.Size(180, 73);
            this.panelNewUsername.TabIndex = 28;
            this.panelNewUsername.Visible = false;
            // 
            // panelNewPassword
            // 
            this.panelNewPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNewPassword.Controls.Add(this.lbNewPassword);
            this.panelNewPassword.Controls.Add(this.tbNewPassword);
            this.panelNewPassword.Location = new System.Drawing.Point(22, 343);
            this.panelNewPassword.Name = "panelNewPassword";
            this.panelNewPassword.Size = new System.Drawing.Size(180, 73);
            this.panelNewPassword.TabIndex = 30;
            this.panelNewPassword.Visible = false;
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNewPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbNewPassword.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNewPassword.Location = new System.Drawing.Point(11, 9);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(118, 21);
            this.lbNewPassword.TabIndex = 29;
            this.lbNewPassword.Text = "New Password:";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.Location = new System.Drawing.Point(15, 33);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(150, 26);
            this.tbNewPassword.TabIndex = 28;
            // 
            // panelAchievement
            // 
            this.panelAchievement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAchievement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAchievement.Controls.Add(this.lbAchievementObtained);
            this.panelAchievement.Controls.Add(this.tbAchievementObtained);
            this.panelAchievement.Controls.Add(this.lbAchievementId);
            this.panelAchievement.Controls.Add(this.tbAchievementId);
            this.panelAchievement.Location = new System.Drawing.Point(208, 264);
            this.panelAchievement.Name = "panelAchievement";
            this.panelAchievement.Size = new System.Drawing.Size(192, 152);
            this.panelAchievement.TabIndex = 28;
            this.panelAchievement.Visible = false;
            // 
            // lbAchievementObtained
            // 
            this.lbAchievementObtained.AutoSize = true;
            this.lbAchievementObtained.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAchievementObtained.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbAchievementObtained.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAchievementObtained.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAchievementObtained.Location = new System.Drawing.Point(11, 87);
            this.lbAchievementObtained.Name = "lbAchievementObtained";
            this.lbAchievementObtained.Size = new System.Drawing.Size(167, 21);
            this.lbAchievementObtained.TabIndex = 29;
            this.lbAchievementObtained.Text = "Obtained (true/false)";
            // 
            // tbAchievementObtained
            // 
            this.tbAchievementObtained.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAchievementObtained.Location = new System.Drawing.Point(15, 111);
            this.tbAchievementObtained.Name = "tbAchievementObtained";
            this.tbAchievementObtained.Size = new System.Drawing.Size(150, 26);
            this.tbAchievementObtained.TabIndex = 28;
            // 
            // lbAchievementId
            // 
            this.lbAchievementId.AutoSize = true;
            this.lbAchievementId.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAchievementId.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbAchievementId.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAchievementId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAchievementId.Location = new System.Drawing.Point(11, 12);
            this.lbAchievementId.Name = "lbAchievementId";
            this.lbAchievementId.Size = new System.Drawing.Size(117, 21);
            this.lbAchievementId.TabIndex = 27;
            this.lbAchievementId.Text = "AchievementId";
            // 
            // tbAchievementId
            // 
            this.tbAchievementId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAchievementId.Location = new System.Drawing.Point(15, 36);
            this.tbAchievementId.Name = "tbAchievementId";
            this.tbAchievementId.Size = new System.Drawing.Size(150, 26);
            this.tbAchievementId.TabIndex = 22;
            // 
            // panelAge
            // 
            this.panelAge.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAge.Controls.Add(this.lbNewAge);
            this.panelAge.Controls.Add(this.tbNewAge);
            this.panelAge.Location = new System.Drawing.Point(22, 343);
            this.panelAge.Name = "panelAge";
            this.panelAge.Size = new System.Drawing.Size(180, 73);
            this.panelAge.TabIndex = 31;
            this.panelAge.Visible = false;
            // 
            // lbNewAge
            // 
            this.lbNewAge.AutoSize = true;
            this.lbNewAge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNewAge.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbNewAge.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewAge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNewAge.Location = new System.Drawing.Point(11, 9);
            this.lbNewAge.Name = "lbNewAge";
            this.lbNewAge.Size = new System.Drawing.Size(138, 21);
            this.lbNewAge.TabIndex = 29;
            this.lbNewAge.Text = "New Age (14-99)";
            // 
            // tbNewAge
            // 
            this.tbNewAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewAge.Location = new System.Drawing.Point(15, 33);
            this.tbNewAge.Name = "tbNewAge";
            this.tbNewAge.Size = new System.Drawing.Size(150, 26);
            this.tbNewAge.TabIndex = 28;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVersion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVersion.Location = new System.Drawing.Point(10, 423);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(62, 21);
            this.lbVersion.TabIndex = 32;
            this.lbVersion.Text = "Version";
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
            this.btnLogout.Location = new System.Drawing.Point(413, 332);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 43);
            this.btnLogout.TabIndex = 33;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnLogout.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // frmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(97)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.panelAchievement);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lbAdminTitle);
            this.Controls.Add(this.btnAchievements);
            this.Controls.Add(this.btnQuizResults);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panelChangeOptions);
            this.Controls.Add(this.dgvPlayerReport);
            this.Controls.Add(this.dgvAchievements);
            this.Controls.Add(this.panelNewPassword);
            this.Controls.Add(this.panelNewUsername);
            this.Controls.Add(this.panelAge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministrator";
            this.Text = "frmAdministrator";
            this.Load += new System.EventHandler(this.frmAdministrator_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAdministrator_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAchievements)).EndInit();
            this.panelChangeOptions.ResumeLayout(false);
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panelNewUsername.ResumeLayout(false);
            this.panelNewUsername.PerformLayout();
            this.panelNewPassword.ResumeLayout(false);
            this.panelNewPassword.PerformLayout();
            this.panelAchievement.ResumeLayout(false);
            this.panelAchievement.PerformLayout();
            this.panelAge.ResumeLayout(false);
            this.panelAge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmParralax;
        private System.Windows.Forms.Button btnAchievements;
        private System.Windows.Forms.Button btnQuizResults;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvPlayerReport;
        private System.Windows.Forms.DataGridView dgvAchievements;
        private System.Windows.Forms.Panel panelChangeOptions;
        private System.Windows.Forms.Button btnChangeAchievement;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeUsername;
        private System.Windows.Forms.Button btnChangeAge;
        private System.Windows.Forms.Label lbAdminTitle;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.MaskedTextBox tbUsername;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbNewUsername;
        private System.Windows.Forms.MaskedTextBox tbNewUsername;
        private System.Windows.Forms.Panel panelNewUsername;
        private System.Windows.Forms.Panel panelNewPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.MaskedTextBox tbNewPassword;
        private System.Windows.Forms.Panel panelAchievement;
        private System.Windows.Forms.Label lbAchievementObtained;
        private System.Windows.Forms.MaskedTextBox tbAchievementObtained;
        private System.Windows.Forms.Label lbAchievementId;
        private System.Windows.Forms.MaskedTextBox tbAchievementId;
        private System.Windows.Forms.Panel panelAge;
        private System.Windows.Forms.Label lbNewAge;
        private System.Windows.Forms.MaskedTextBox tbNewAge;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btnLogout;
    }
}