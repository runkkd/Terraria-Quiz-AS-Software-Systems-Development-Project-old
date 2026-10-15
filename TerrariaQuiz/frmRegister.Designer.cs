
namespace TerrariaQuiz
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbVerifyPassword = new System.Windows.Forms.Label();
            this.tbVerifyPassed = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.chbShow = new System.Windows.Forms.CheckBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbUserInfo = new System.Windows.Forms.TextBox();
            this.tbPassInfo = new System.Windows.Forms.TextBox();
            this.tbAgeInfo = new System.Windows.Forms.TextBox();
            this.tmParralax = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(12, 67);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(83, 20);
            this.tbUsername.TabIndex = 7;
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Black;
            this.lbTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitle.Location = new System.Drawing.Point(11, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(274, 23);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Please create the Account details";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Black;
            this.lbUsername.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUsername.Location = new System.Drawing.Point(11, 42);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(75, 19);
            this.lbUsername.TabIndex = 11;
            this.lbUsername.Text = "Username:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Black;
            this.lbPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPassword.Location = new System.Drawing.Point(12, 92);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(71, 19);
            this.lbPassword.TabIndex = 13;
            this.lbPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(12, 117);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(83, 20);
            this.tbPassword.TabIndex = 12;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // lbVerifyPassword
            // 
            this.lbVerifyPassword.AutoSize = true;
            this.lbVerifyPassword.BackColor = System.Drawing.Color.Black;
            this.lbVerifyPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVerifyPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVerifyPassword.Location = new System.Drawing.Point(12, 143);
            this.lbVerifyPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVerifyPassword.Name = "lbVerifyPassword";
            this.lbVerifyPassword.Size = new System.Drawing.Size(117, 19);
            this.lbVerifyPassword.TabIndex = 15;
            this.lbVerifyPassword.Text = "Verify Password:";
            // 
            // tbVerifyPassed
            // 
            this.tbVerifyPassed.Location = new System.Drawing.Point(12, 170);
            this.tbVerifyPassed.Name = "tbVerifyPassed";
            this.tbVerifyPassed.Size = new System.Drawing.Size(83, 20);
            this.tbVerifyPassed.TabIndex = 14;
            this.tbVerifyPassed.UseSystemPasswordChar = true;
            this.tbVerifyPassed.Enter += new System.EventHandler(this.tbVerifyPassed_Enter);
            this.tbVerifyPassed.Leave += new System.EventHandler(this.tbVerifyPassed_Leave);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Black;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreate.Location = new System.Drawing.Point(208, 284);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(162, 29);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            this.btnCreate.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.btnCreate.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // chbShow
            // 
            this.chbShow.AutoSize = true;
            this.chbShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chbShow.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbShow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chbShow.Location = new System.Drawing.Point(11, 246);
            this.chbShow.Name = "chbShow";
            this.chbShow.Size = new System.Drawing.Size(106, 20);
            this.chbShow.TabIndex = 17;
            this.chbShow.Text = "Show Password";
            this.chbShow.UseVisualStyleBackColor = false;
            this.chbShow.CheckedChanged += new System.EventHandler(this.chbShow_CheckedChanged);
            this.chbShow.MouseEnter += new System.EventHandler(this.ControlHovered);
            this.chbShow.MouseLeave += new System.EventHandler(this.ControlLeft);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVersion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVersion.Location = new System.Drawing.Point(8, 292);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(62, 21);
            this.lbVersion.TabIndex = 27;
            this.lbVersion.Text = "Version";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.BackColor = System.Drawing.Color.Black;
            this.lbAge.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAge.Location = new System.Drawing.Point(11, 195);
            this.lbAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(39, 19);
            this.lbAge.TabIndex = 29;
            this.lbAge.Text = "Age:";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(11, 220);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(83, 20);
            this.tbAge.TabIndex = 28;
            this.tbAge.Enter += new System.EventHandler(this.tbAge_Enter);
            this.tbAge.Leave += new System.EventHandler(this.tbAge_Leave);
            // 
            // tbUserInfo
            // 
            this.tbUserInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserInfo.Location = new System.Drawing.Point(155, 52);
            this.tbUserInfo.Multiline = true;
            this.tbUserInfo.Name = "tbUserInfo";
            this.tbUserInfo.ReadOnly = true;
            this.tbUserInfo.Size = new System.Drawing.Size(161, 35);
            this.tbUserInfo.TabIndex = 30;
            this.tbUserInfo.Text = "Usernames must be unique and atleast 3 characters";
            this.tbUserInfo.Visible = false;
            // 
            // tbPassInfo
            // 
            this.tbPassInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassInfo.Location = new System.Drawing.Point(155, 102);
            this.tbPassInfo.Multiline = true;
            this.tbPassInfo.Name = "tbPassInfo";
            this.tbPassInfo.ReadOnly = true;
            this.tbPassInfo.Size = new System.Drawing.Size(161, 35);
            this.tbPassInfo.TabIndex = 31;
            this.tbPassInfo.Text = "Password must be atleast 8 characters.";
            this.tbPassInfo.Visible = false;
            // 
            // tbAgeInfo
            // 
            this.tbAgeInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAgeInfo.Location = new System.Drawing.Point(155, 219);
            this.tbAgeInfo.Multiline = true;
            this.tbAgeInfo.Name = "tbAgeInfo";
            this.tbAgeInfo.ReadOnly = true;
            this.tbAgeInfo.Size = new System.Drawing.Size(161, 24);
            this.tbAgeInfo.TabIndex = 32;
            this.tbAgeInfo.Text = "Age must be between 14-99.\r\n";
            this.tbAgeInfo.Visible = false;
            // 
            // tmParralax
            // 
            this.tmParralax.Interval = 10;
            this.tmParralax.Tick += new System.EventHandler(this.tmParralax_Tick);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TerrariaQuiz.Resources.Sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(381, 322);
            this.Controls.Add(this.tbAgeInfo);
            this.Controls.Add(this.tbPassInfo);
            this.Controls.Add(this.tbUserInfo);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.chbShow);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbVerifyPassword);
            this.Controls.Add(this.tbVerifyPassed);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbUsername);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(397, 361);
            this.MinimumSize = new System.Drawing.Size(397, 361);
            this.Name = "frmRegister";
            this.Text = "o";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmRegister_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbVerifyPassword;
        private System.Windows.Forms.TextBox tbVerifyPassed;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox chbShow;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbUserInfo;
        private System.Windows.Forms.TextBox tbPassInfo;
        private System.Windows.Forms.TextBox tbAgeInfo;
        private System.Windows.Forms.Timer tmParralax;
    }
}