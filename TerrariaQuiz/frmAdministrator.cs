using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmAdministrator : Form
    {
        // Importing method from gdi32.dll to add font from memory
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        private FontFamily ff;
        private Font font;
        Image layer_1 = Resources.BackgroundDesertHills;
        Image layer_2 = Resources.MiddlegroundDesertLand;
        Image layer_3 = Resources.ForegroundDesertCliff;
        Image layer_Sun = Resources.Sun;
        public string chosen = "";
        private double angle;
        public bool imagesLoaded = false;
        public frmAdministrator()
        {
            // Settung up program
            InitializeComponent();
            CenterToScreen();

            // Setting specific controls to be transparent
            btnLogout.BackColor = Color.Transparent; btnChange.BackColor = Color.Transparent; lbVersion.BackColor = Color.Transparent; btnAchievements.BackColor = Color.Transparent; btnQuizResults.BackColor = Color.Transparent; btnChangeAge.BackColor = Color.Transparent; btnChangeUsername.BackColor = Color.Transparent; btnChangePassword.BackColor = Color.Transparent; btnChangeAchievement.BackColor = Color.Transparent; lbAchievementId.BackColor = Color.Transparent; lbAchievementObtained.BackColor = Color.Transparent; lbAdminTitle.BackColor = Color.Transparent; lbNewAge.BackColor = Color.Transparent; lbNewPassword.BackColor = Color.Transparent; lbNewUsername.BackColor = Color.Transparent; lbTitle.BackColor = Color.Transparent; lbUsername.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
        }
        // Method to load a custom font from resources
        private void LoadFont()
        {
            // Load font byte array from resources
            byte[] fontArray = Resources.ANDYB;

            // Get the length of the font data
            int dataLength = Resources.ANDYB.Length;

            // Allocate memory for the font data
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);

            // Copy the font data to the allocated memory
            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            // Variable to store the number of fonts
            uint cFonts = 0;

            // Add the font memory resource
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            // Create a PrivateFontCollection to hold the loaded font
            PrivateFontCollection pfc = new PrivateFontCollection();

            // Add the font to the PrivateFontCollection from the memory
            pfc.AddMemoryFont(ptrData, dataLength);

            // Free the allocated memory to prevent memory leaks
            Marshal.FreeCoTaskMem(ptrData);

            // Get the FontFamily from the PrivateFontCollection
            ff = pfc.Families[0];

            // Create a Font using the loaded FontFamily
            font = new System.Drawing.Font(ff, 15f, FontStyle.Bold);
        }

        // Method to allocate font to a control
        public void ApplyFont(System.Drawing.Font f, Control c, float size)
        {
            // Set the default font style
            FontStyle fontStyle = FontStyle.Regular;

            // Set the font of the control using the specified size and style
            c.Font = new System.Drawing.Font(ff, size, fontStyle);
        }
        
        // Event handler for audio played when buttons are hovered over
        private void playAudioHover()
        {
            SoundPlayer click = new SoundPlayer(Resources.MenuClick);
            click.Play();
        }
        // Event handler for button hover
        private void ControlHovered(object sender, EventArgs e)
        {
            // Changes colour and font size of button when hovered over
            ((Control)sender).ForeColor = Color.Yellow;
            ApplyFont(font, ((Control)sender), ((Control)sender).Font.Size + 1);
            // Plays click sound when hovered
            playAudioHover();
        }

        // Event handler for mouse leaving button
        private void ControlLeft(object sender, EventArgs e)
        {
            // Changes colour and font size of button when mouse leaves
            ((Control)sender).ForeColor = SystemColors.ButtonFace;
            ApplyFont(font, (Control)sender, ((Control)sender).Font.Size - 1);
        }

        // Method to add data into the achievments data grid view
        private void InitializeDataGridViewAchievements()
        {
            // Clearing the data grid so data isnt added multiple times when refreshing
            dgvAchievements.Rows.Clear();
            dgvAchievements.Columns.Clear();

            // Checking whether translation is needed or not
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                dgvPlayerReport.Columns.Add("PlayerIdColumn", frmSplashScreen.Translator.TranslateText("Username", "en", frmSplashScreen.CPlayer.Language));
                dgvPlayerReport.Columns.Add("ScoreColumn", frmSplashScreen.Translator.TranslateText("Score", "en", frmSplashScreen.CPlayer.Language));
                dgvPlayerReport.Columns.Add("TopicColumn", frmSplashScreen.Translator.TranslateText("Topic", "en", frmSplashScreen.CPlayer.Language));

                dgvAchievements.Columns.Add("PlayerIdColumn", frmSplashScreen.Translator.TranslateText("Username", "en", frmSplashScreen.CPlayer.Language));
                dgvAchievements.Columns.Add("AchievementNameColumn", frmSplashScreen.Translator.TranslateText("Achievement", "en", frmSplashScreen.CPlayer.Language));
                dgvAchievements.Columns.Add("AchievementIdColumn", frmSplashScreen.Translator.TranslateText("AchievementId", "en", frmSplashScreen.CPlayer.Language));
                dgvAchievements.Columns.Add("CompletedColumn", frmSplashScreen.Translator.TranslateText("Achieved", "en", frmSplashScreen.CPlayer.Language));
            }
            else
            {
                dgvAchievements.Columns.Add("PlayerIdColumn", "Username");
                dgvAchievements.Columns.Add("AchievementNameColumn", "Achievement");
                dgvAchievements.Columns.Add("AchievementIdColumn", "AchievementId");
                dgvAchievements.Columns.Add("CompletedColumn", "Achieved");
            }

            // Populate DataTable with data
            foreach (var achievement in frmSplashScreen.AchievementManager.playerAchievements)
            {
                dgvAchievements.Rows.Add(achievement.PlayerId, (frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText(frmSplashScreen.AchievementManager.GetAchievementName(achievement.AchievementId), "en", frmSplashScreen.CPlayer.Language) : frmSplashScreen.AchievementManager.GetAchievementName(achievement.AchievementId), achievement.AchievementId, achievement.Completed);
            }

            // Set up DataGridView
            dgvAchievements.AutoGenerateColumns = false;

            // Configure columns
            dgvAchievements.Columns["PlayerIdColumn"].DataPropertyName = "PlayerIdColumn";
            dgvAchievements.Columns["AchievementNameColumn"].DataPropertyName = "AchievementId";
            dgvAchievements.Columns["AchievementIdColumn"].DataPropertyName = "AchievementId";
            dgvAchievements.Columns["CompletedColumn"].DataPropertyName = "Completed";

            // Handle the CellFormatting event to display achievement names
            dgvAchievements.Columns["AchievementNameColumn"].Width = 115;
            dgvAchievements.CellFormatting += dgvAchievements_CellFormatting;
        }

        // Method to Convert achievement ID to achievement name
        private void dgvAchievements_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column is the "AchievementNameColumn"
            if (e.ColumnIndex == dgvAchievements.Columns["AchievementNameColumn"].Index)
            {
                // Get the achievement name from the cell value
                string achievementName = e.Value.ToString();

                // Set the cell value to the achievement name
                e.Value = achievementName;
            }
        }

        // Method to convert topic ID to topic name
        private void dgvPlayerInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column is the "ScoreColumn"
            if (e.ColumnIndex == dgvPlayerReport.Columns["TopicColumn"].Index)
            {
                // Get the achievement name from the cell value
                string topicName = e.Value.ToString();

                // Set the cell value to the achievement name
                e.Value = topicName;
            }
        }

        // Method to add data into the achievments data grid view
        private void InitializeDataGridViewQuizInfo()
        {
            // Clearing the data grid so data isnt added multiple times when refreshing
            dgvPlayerReport.Rows.Clear();
            dgvPlayerReport.Columns.Clear();

            // Checking whether translation is needed or not
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                dgvPlayerReport.Columns.Add("PlayerIdColumn", frmSplashScreen.Translator.TranslateText("Username", "en", frmSplashScreen.CPlayer.Language));
                dgvPlayerReport.Columns.Add("ScoreColumn", frmSplashScreen.Translator.TranslateText("Score", "en", frmSplashScreen.CPlayer.Language));
                dgvPlayerReport.Columns.Add("AgeColumn", frmSplashScreen.Translator.TranslateText("Age", "en", frmSplashScreen.CPlayer.Language));
                dgvPlayerReport.Columns.Add("TopicColumn", frmSplashScreen.Translator.TranslateText("Topic", "en", frmSplashScreen.CPlayer.Language));
            }
            else
            {
                dgvPlayerReport.Columns.Add("PlayerIdColumn", "Username");
                dgvPlayerReport.Columns.Add("ScoreColumn", "Score");
                dgvPlayerReport.Columns.Add("AgeColumn", "Age");
                dgvPlayerReport.Columns.Add("TopicColumn", "Topic");
            }
            

            // Populate DataTable with data
            foreach (var account in frmSplashScreen.AccountManager.players)
            {
                dgvPlayerReport.Rows.Add(account.PlayerId, account.Score, account.Age, (frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText(frmSplashScreen.AccountManager.GetTopicName(account.Type) , "en", frmSplashScreen.CPlayer.Language) : frmSplashScreen.AccountManager.GetTopicName(account.Type));
            }

            // Set up DataGridView
            dgvPlayerReport.AutoGenerateColumns = false;

            // Configure columns
            dgvPlayerReport.Columns["PlayerIdColumn"].DataPropertyName = "PlayerIdColumn";
            dgvPlayerReport.Columns["ScoreColumn"].DataPropertyName = "Score";
            dgvPlayerReport.Columns["AgeColumn"].DataPropertyName = "Age";
            dgvPlayerReport.Columns["TopicColumn"].DataPropertyName = "Type";

            // Handle the CellFormatting event to display achievement names
            dgvPlayerReport.CellFormatting += dgvPlayerInfo_CellFormatting;
        }

        // Method to round the corners of a panel
        private void ApplyRoundedCornersToPanel(Panel panel, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            panel.Region = new Region(path);
        }

        // Method to loop through all panels and apply rounded corners
        private void ApplyRoundedCornersToAllPanels(Control container)
        {
            int cornerRadius = 20;

            foreach (Control control in container.Controls)
            {
                if (control is Panel)
                {
                    ApplyRoundedCornersToPanel((Panel)control, cornerRadius);
                }
                if (control.HasChildren)
                {
                    ApplyRoundedCornersToAllPanels(control);
                }
            }
        }
        private void frmAdministrator_Load(object sender, EventArgs e)
        {
            // Startig parallax time to create moving background effect and setting images loaded to be true
            tmParralax.Start();
            imagesLoaded = true;

            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;

            // Loading custom font and applying it to all text containing controls then displaying current version in version label
            LoadFont();
            lbVersion.Text = Version.version;
            ApplyRoundedCornersToAllPanels(this);
            ApplyFont(font, this.btnQuizResults, 18);
            ApplyFont(font, this.btnAchievements, 18);
            ApplyFont(font, this.btnChangeAchievement, 18);
            ApplyFont(font, this.btnChangeAge, 18);
            ApplyFont(font, this.btnChangePassword, 18);
            ApplyFont(font, this.btnChangeUsername, 18);
            ApplyFont(font, this.btnChange, 18);
            ApplyFont(font, this.btnLogout, 18);
            ApplyFont(font, this.lbUsername, 14);
            ApplyFont(font, this.lbNewUsername, 14);
            ApplyFont(font, this.lbNewPassword, 14);
            ApplyFont(font, this.lbAchievementId, 14);
            ApplyFont(font, this.lbAchievementId, 14);
            ApplyFont(font, this.lbNewAge, 14);
            ApplyFont(font, this.lbTitle, 22);
            ApplyFont(font, this.lbAdminTitle, 22);
            ApplyFont(font, this.tbUsername, 13);
            ApplyFont(font, this.tbNewAge, 13);
            ApplyFont(font, this.tbNewUsername, 13);
            ApplyFont(font, this.tbNewPassword, 13);
            ApplyFont(font, this.tbAchievementId, 13);
            ApplyFont(font, this.tbAchievementObtained, 13);
            ApplyFont(font, this.lbVersion, 13);

            // Calling methods to add data to the data grids then translating text
            InitializeDataGridViewAchievements();
            InitializeDataGridViewQuizInfo();
            translate();
        }
        // Method to translate text
        private void translate()
        {
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                // Checking if the user has selected a language other than english to see if translation is needed then translating based on chosen language if so
                lbTitle.Text = frmSplashScreen.Translator.TranslateText(lbTitle.Text, "en", frmSplashScreen.CPlayer.Language);
                btnChangeAchievement.Text = frmSplashScreen.Translator.TranslateText(btnChangeAchievement.Text, "en", frmSplashScreen.CPlayer.Language);
                btnQuizResults.Text = frmSplashScreen.Translator.TranslateText(btnQuizResults.Text, "en", frmSplashScreen.CPlayer.Language);
                btnAchievements.Text = frmSplashScreen.Translator.TranslateText(btnAchievements.Text, "en", frmSplashScreen.CPlayer.Language);
                btnChangeAge.Text = frmSplashScreen.Translator.TranslateText(btnChangeAge.Text, "en", frmSplashScreen.CPlayer.Language);
                btnChangePassword.Text = frmSplashScreen.Translator.TranslateText(btnChangePassword.Text, "en", frmSplashScreen.CPlayer.Language);
                btnChangeUsername.Text = frmSplashScreen.Translator.TranslateText(btnChangeUsername.Text, "en", frmSplashScreen.CPlayer.Language);
                btnChange.Text = frmSplashScreen.Translator.TranslateText(btnChange.Text, "en", frmSplashScreen.CPlayer.Language);
                lbUsername.Text = frmSplashScreen.Translator.TranslateText(lbUsername.Text, "en", frmSplashScreen.CPlayer.Language);
                lbNewUsername.Text = frmSplashScreen.Translator.TranslateText(lbNewUsername.Text, "en", frmSplashScreen.CPlayer.Language);
                lbAchievementId.Text = frmSplashScreen.Translator.TranslateText(lbAchievementId.Text, "en", frmSplashScreen.CPlayer.Language);
                lbAchievementObtained.Text = frmSplashScreen.Translator.TranslateText(lbAchievementObtained.Text, "en", frmSplashScreen.CPlayer.Language);
                lbNewPassword.Text = frmSplashScreen.Translator.TranslateText(lbNewPassword.Text, "en", frmSplashScreen.CPlayer.Language);
                lbNewAge.Text = frmSplashScreen.Translator.TranslateText(lbNewAge.Text, "en", frmSplashScreen.CPlayer.Language);
                lbTitle.Text = frmSplashScreen.Translator.TranslateText(lbTitle.Text, "en", frmSplashScreen.CPlayer.Language);
                lbAdminTitle.Text = frmSplashScreen.Translator.TranslateText(lbAdminTitle.Text, "en", frmSplashScreen.CPlayer.Language);
            }
        }

        private void frmAdministrator_Paint(object sender, PaintEventArgs e)
        {
            // Creating moving parallax effect or just painting on background image instead depending on if parallax is enabled or not
            if (imagesLoaded == true && frmSplashScreen.CPlayer.Parallax == true)
            {
                // Draws background layers, sun, airship, and logo
                e.Graphics.DrawImage(layer_Sun, s1, s2);
                e.Graphics.DrawImage(layer_1, b1, 0);
                e.Graphics.DrawImage(layer_1, b2, 0);
                e.Graphics.DrawImage(layer_2, x1, 0);
                e.Graphics.DrawImage(layer_2, x2, 0);
                e.Graphics.DrawImage(layer_3, g1, 0);
                e.Graphics.DrawImage(layer_3, g2, 0);
            }
            else if (imagesLoaded == true && frmSplashScreen.CPlayer.Parallax == false)
            {
                // Draws background layers, sun, airship, and logo
                e.Graphics.DrawImage(layer_Sun, s1, s2);
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_3, 0, 0);
                e.Graphics.DrawImage(layer_3, 0, 0);
            }
        }

        // Variables for animation handling
        int b1 = 0, b2 = 816, x1 = 0, x2 = 816, g1 = 0, g2 = 816, s1 = 0, s2 = 0;

        // Event handler for achievements button being clicked
        private void btnAchievements_Click(object sender, EventArgs e)
        {
            btnAchievements.Enabled = false;
            btnQuizResults.Enabled = true;
            dgvAchievements.BringToFront();
        }

        // Event handler for quiz results button being clicked
        private void btnQuizResults_Click(object sender, EventArgs e)
        {
            btnAchievements.Enabled = true;
            btnQuizResults.Enabled = false;
            dgvPlayerReport.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmSplashScreen.formLogin.Show();
            this.Hide();
            frmSplashScreen.CPlayer = new PlayerJson();
        }

        // Event handler for change age button being clicked
        private void btnChangeAge_Click(object sender, EventArgs e)
        {
            chosen = "ChangeAge";
            panelUsername.Visible = true;
            panelAchievement.Visible = false;
            panelAge.Visible = true;
            panelNewPassword.Visible = false;
            panelNewUsername.Visible = false;
        }

        // Event handler for change acheviement button being clicked
        private void btnChangeAchievement_Click(object sender, EventArgs e)
        {
            chosen = "ChangeAchievement";
            panelUsername.Visible = true;
            panelAchievement.Visible = true;
            panelAge.Visible = false;
            panelNewPassword.Visible = false;
            panelNewUsername.Visible = false;
        }

        // Event handler for change password button being clicked
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            chosen = "ChangePassword";
            panelUsername.Visible = true;
            panelAchievement.Visible = false;
            panelAge.Visible = false;
            panelNewPassword.Visible = true;
            panelNewUsername.Visible = false;
        }

        // Event handler for change username button being clicked
        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            chosen = "ChangeUsername";
            tbUsername.Text = tbNewUsername.Text;
            panelUsername.Visible = true;
            panelAchievement.Visible = false;
            panelAge.Visible = false;
            panelNewPassword.Visible = false;
            panelNewUsername.Visible = true;
        }

        // Event handler for change confirmation button being clicked
        private void btnChange_Click(object sender, EventArgs e)
        {
            // Making sure the user has input a username
            if (!string.IsNullOrEmpty(tbUsername.Text))
            {
                string result = "";
                
                // Switch to check what change option the admin has chosen
                switch (chosen)
                {
                    case "ChangeUsername":
                        // Validating the new username input by the user and if all validation is passed then the username is changed
                        result = frmSplashScreen.AccountManager.ValidateUsername(tbNewUsername.Text);
                        if (result == "Username successfully changed!")
                        {
                            frmSplashScreen.AccountManager.ChangeUsername(tbUsername.Text, tbNewUsername.Text);
                            frmSplashScreen.AchievementManager.ChangePlayerUsername(tbUsername.Text, tbNewUsername.Text);
                        }
                        MessageBox.Show((frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText(result, "en", frmSplashScreen.CPlayer.Language) : result, (frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText("New Username Feedback", "en", frmSplashScreen.CPlayer.Language) : "New Username Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbUsername.Text = tbNewUsername.Text;
                        break;
                    case "ChangePassword":
                        // Validating the new password input by the user and if all validation is passed then the password is changed
                        result = frmSplashScreen.AccountManager.ValidatePassword(tbNewPassword.Text, tbUsername.Text);
                        if (result == "Password successfully changed!")
                        {
                            frmSplashScreen.AccountManager.ChangePassword(tbUsername.Text, tbNewPassword.Text);
                        }
                        MessageBox.Show((frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText(result, "en", frmSplashScreen.CPlayer.Language) : result, (frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText("New Password Feedback", "en", frmSplashScreen.CPlayer.Language) : "New Password Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "ChangeAchievement":
                        // Validating that a valid achievmeent id, achievementObtained and username have been input and if so the correct achievment is updated
                        result = frmSplashScreen.AccountManager.ValidateAchievement(tbAchievementId.Text, tbAchievementObtained.Text, tbUsername.Text);
                        int achievementId = 0;
                        if (result == "Successfully changed achievement status!")
                        {
                            // Switch to get the given achievement and update is as requested
                            switch (tbAchievementId.Text)
                            {
                                case "1":
                                    achievementId = 1;
                                    break;
                                case "2":
                                    achievementId = 2;
                                    break;
                                case "3":
                                    achievementId = 3;
                                    break;
                                case "4":
                                    achievementId = 4;
                                    break;
                                case "5":
                                    achievementId = 5;
                                    break;
                            }
                            // Checking whether the achievement is to be given or removed and updating accordingly
                            if (tbAchievementObtained.Text == "false" || tbAchievementObtained.Text == "False")
                            {
                                frmSplashScreen.AchievementManager.MarkAchievementUncompleted(tbUsername.Text, achievementId);
                                frmSplashScreen.AchievementManager.SaveAchievements();
                            }
                            else if (tbAchievementObtained.Text == "true" || tbAchievementObtained.Text == "True")
                            {
                                frmSplashScreen.AchievementManager.MarkAchievementCompleted(tbUsername.Text, achievementId);
                                frmSplashScreen.AchievementManager.SaveAchievements();
                            }
                        }
                        MessageBox.Show((frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText(result, "en", frmSplashScreen.CPlayer.Language) : result, (frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText("Achievement Feedback", "en", frmSplashScreen.CPlayer.Language) : "Achievement Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "ChangeAge":
                        int age = 0;
                        // Validating the new age input by the user and if all validation is passed then the age is changed
                        result = frmSplashScreen.AccountManager.ValidateAge(tbUsername.Text, tbNewAge.Text);
                        if (result == "Age successfully changed!")
                        {
                            age = Convert.ToInt32(tbNewAge.Text);
                            frmSplashScreen.AccountManager.ChangeAge(tbUsername.Text, age);
                        }
                        MessageBox.Show((frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText(result, "en", frmSplashScreen.CPlayer.Language) : "result", (frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText("New Age Feedback", "en", frmSplashScreen.CPlayer.Language) : "New Age Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                // Loading in the updated data for the players and calling methods to add the updated data to the data grid views to update them so they display the new data
                frmSplashScreen.AchievementManager.LoadAchievements();
                frmSplashScreen.AccountManager.LoadPlayersFromJson();
                InitializeDataGridViewAchievements();
                InitializeDataGridViewQuizInfo();
                tbAchievementId.Text = "";
                tbAchievementObtained.Text = "";
                tbNewAge.Text = "";
                tbNewPassword.Text = "";
                tbNewUsername.Text = "";
                tbUsername.Text = "";
            }
        }

        // Event handler for parallax time ticking
        private void tmParralax_Tick(object sender, EventArgs e)
        {
            // Calling method to move background to create parallax moving background effect
            background_move();
        }

        void background_move()
        {
            /*
            * Moving each background layer horizontally
            * Resetting positions when they go off - screen
            * Invalidating the form to trigger repaint
            * This creates a parallax effect
            * Note: The specific values and logic may need adjustment based on your design 
            */
            if (b1 < -816)
            {
                b1 = 809;
            }
            b1 -= 1;
            b2 -= 1;
            if (b2 < -816)
            {
                b2 = 809;
            }
            if (x1 < -816)
            {
                x1 = 809;
            }
            x2 -= 2;
            x1 -= 2;
            if (x2 < -816)
            {
                x2 = 809;
            }
            if (g1 < -816)
            {
                g1 = 809;
            }
            g2 -= 4;
            g1 -= 4;
            if (g2 < -816)
            {
                g2 = 809;
            }
            // Calculate the position of the sun in an orbit
            int orbitRadius = 500;
            int centerX = Width / 2;
            int centerY = Height;

            // Calculate new position
            int newX = centerX + (int)(orbitRadius * Math.Cos(angle));
            int newY = centerY + (int)(orbitRadius * Math.Sin(angle));

            // Set the sun's location
            s1 = (newX - 40 / 2);
            s2 = (newY - 40 / 2);

            // Increment the angle for the next position
            angle += 0.002; // Adjust the increment for the speed of orbit

            // Keep the angle within a reasonable range
            if (angle >= 2 * Math.PI)
            {
                angle = 0;
            }

            // Trigger a repaint of the form
            Invalidate();
        }
    }
}
