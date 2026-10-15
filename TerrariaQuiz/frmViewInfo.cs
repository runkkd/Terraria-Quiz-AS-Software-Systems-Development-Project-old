using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Logging;
using static TerrariaQuiz.frmSplashScreen;
using stdole;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using WMPLib;
using System.Media;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Cryptography;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmViewInfo : Form
    {
        // Importing method from gdi32.dll to add font from memory
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        private FontFamily ff;
        private System.Drawing.Font font;

        // Variables for animation handling
        Image layer_1 = Resources.BackgroundDesertHills;
        Image layer_2 = Resources.MiddlegroundDesertLand;
        Image layer_3 = Resources.ForegroundDesertCliff;
        Image layer_Sun = Resources.Sun;
        public bool imagesLoaded = false;
        private double angle;
        public frmViewInfo()
        {
            // Setting up program
            InitializeComponent();
            CenterToScreen();

            // Setting back colour to be transparent on specific controls and enabling properties used for animation smoothing
            btnLogout.BackColor = Color.Transparent; lbTitle.BackColor = Color.Transparent; btnQuizResults.BackColor = Color.Transparent; btnAchievements.BackColor = Color.Transparent; btnSortNameAch.BackColor = Color.Transparent; btnSortAchievements.BackColor= Color.Transparent; btnSortCompleted.BackColor = Color.Transparent; btnSortNameInfo.BackColor = Color.Transparent; btnSortScore.BackColor = Color.Transparent; btnSortByTopic.BackColor = Color.Transparent; lbSortingTitle.BackColor = Color.Transparent;
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

        // Method to initialize the DataGridView for displaying player achievements
        private void InitializeDataGridViewAchievements()
        {
            // Add columns to the DataGridView
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                dgvAchievements.Columns.Add("PlayerIdColumn", frmSplashScreen.Translator.TranslateText("Username", "en", frmSplashScreen.CPlayer.Language));
                dgvAchievements.Columns.Add("AchievementNameColumn", frmSplashScreen.Translator.TranslateText("Achievement", "en", frmSplashScreen.CPlayer.Language));
                dgvAchievements.Columns.Add("CompletedColumn", frmSplashScreen.Translator.TranslateText("Achieved", "en", frmSplashScreen.CPlayer.Language));
            }
            else
            {
                dgvAchievements.Columns.Add("PlayerIdColumn", "Username");
                dgvAchievements.Columns.Add("AchievementNameColumn", "Achievement");
                dgvAchievements.Columns.Add("CompletedColumn", "Achieved");
            }

            // Populate DataTable with data
            foreach (var achievement in frmSplashScreen.AchievementManager.playerAchievements)
            {
                // Add a row for each achievement in the DataTable
                dgvAchievements.Rows.Add(achievement.PlayerId, frmSplashScreen.AchievementManager.GetAchievementName(achievement.AchievementId), achievement.Completed);
            }

            // Set up DataGridView
            dgvAchievements.AutoGenerateColumns = false;

            // Configure columns' data properties
            dgvAchievements.Columns["PlayerIdColumn"].DataPropertyName = "PlayerIdColumn";
            dgvAchievements.Columns["AchievementNameColumn"].DataPropertyName = "AchievementId";
            dgvAchievements.Columns["CompletedColumn"].DataPropertyName = "Completed";

            // Set width for the AchievementNameColumn
            dgvAchievements.Columns["AchievementNameColumn"].Width = 115;

            // Handle the CellFormatting event to display achievement names
            dgvAchievements.CellFormatting += dgvAchievements_CellFormatting;
        }

        // Event handler for formatting DataGridView cells
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

        // Event handler for formatting DataGridView cells
        private void dgvPlayerInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column is the "TopicColumn"
            if (e.ColumnIndex == dgvPlayerReport.Columns["TopicColumn"].Index)
            {
                // Get the topic name from the cell value
                string topicName = e.Value.ToString();

                // Set the cell value to the topic name
                e.Value = topicName;
            }
        }

        // Method for initializing the DataGridView for quiz information
        private void InitializeDataGridViewQuizInfo()
        {
            // Add columns to the DataGridView
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                dgvPlayerReport.Columns.Add("PlayerIdColumn", frmSplashScreen.Translator.TranslateText("Username", "en", frmSplashScreen.CPlayer.Language));
                dgvPlayerReport.Columns.Add("ScoreColumn", frmSplashScreen.Translator.TranslateText("Score", "en", frmSplashScreen.CPlayer.Language));
                dgvPlayerReport.Columns.Add("TopicColumn", frmSplashScreen.Translator.TranslateText("Topic", "en", frmSplashScreen.CPlayer.Language));
            }
            else
            {
                dgvPlayerReport.Columns.Add("PlayerIdColumn", "Username");
                dgvPlayerReport.Columns.Add("ScoreColumn", "Score");
                dgvPlayerReport.Columns.Add("TopicColumn", "Topic");
            }

            // Populate DataTable with data
            foreach (var account in frmSplashScreen.AccountManager.players)
            {
                // Add rows to the DataGridView with player information
                if (frmSplashScreen.CPlayer.Language != "en")
                {
                    dgvPlayerReport.Rows.Add(account.PlayerId, account.Score, frmSplashScreen.Translator.TranslateText(frmSplashScreen.AccountManager.GetTopicName(account.Type), "en", frmSplashScreen.CPlayer.Language));
                }
                else
                {
                    dgvPlayerReport.Rows.Add(account.PlayerId, account.Score, frmSplashScreen.AccountManager.GetTopicName(account.Type), "en", frmSplashScreen.CPlayer.Language);
                }
            }

            // Set up DataGridView
            dgvPlayerReport.AutoGenerateColumns = false;

            // Configure columns
            dgvPlayerReport.Columns["PlayerIdColumn"].DataPropertyName = "PlayerIdColumn";
            dgvPlayerReport.Columns["ScoreColumn"].DataPropertyName = "Score";
            dgvPlayerReport.Columns["TopicColumn"].DataPropertyName = "Type";

            // Handle the CellFormatting event to display topic names
            dgvPlayerReport.CellFormatting += dgvPlayerInfo_CellFormatting;
        }

        // Event handler for the Placeholder form when it is loaded
        private void frmPlaceholder_Load(object sender, EventArgs e)
        {
            // Set the form title using the splash text from the SplashScreen form
            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;

            // Set parent controls for various UI elements
            panelBack.Parent = this;
            panelInfo.Parent = this;
            btnSortAchievements.Parent = panelBack;
            btnSortNameAch.Parent = panelBack;

            // Apply rounded corners to all panels in the form
            ApplyRoundedCornersToAllPanels(this);

            // Load custom Andy Bold font and apply it to specific labels and buttons
            LoadFont();
            ApplyFont(font, this.lbTitle, 22);
            ApplyFont(font, this.lbSortingTitle, 22);
            ApplyFont(font, this.btnQuizResults, 18);
            ApplyFont(font, this.btnAchievements, 18);
            ApplyFont(font, this.btnSortAchievements, 18);
            ApplyFont(font, this.btnSortCompleted, 18);
            ApplyFont(font, this.btnSortNameAch, 18);
            ApplyFont(font, this.btnSortNameInfo, 18);
            ApplyFont(font, this.btnSortScore, 18);
            ApplyFont(font, this.btnSortByTopic, 18);
            ApplyFont(font, this.btnLogout, 18);

            // Load achievements, start parallax timer, indicate that images are loaded, and initialize DataGridViews
            frmSplashScreen.AchievementManager.LoadAchievements();
            tmParralax.Start();
            imagesLoaded = true;
            InitializeDataGridViewAchievements();
            InitializeDataGridViewQuizInfo();
            translate();
        }
        // Method to translate text
        private void translate()
        {
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                // Checking what language the user has selected and applying accordingly
                lbTitle.Text = frmSplashScreen.Translator.TranslateText(lbTitle.Text, "en", frmSplashScreen.CPlayer.Language);
                lbSortingTitle.Text = frmSplashScreen.Translator.TranslateText(lbSortingTitle.Text, "en", frmSplashScreen.CPlayer.Language);
                btnQuizResults.Text = frmSplashScreen.Translator.TranslateText(btnQuizResults.Text, "en", frmSplashScreen.CPlayer.Language);
                btnAchievements.Text = frmSplashScreen.Translator.TranslateText(btnAchievements.Text, "en", frmSplashScreen.CPlayer.Language);
                btnSortAchievements.Text = frmSplashScreen.Translator.TranslateText(btnSortAchievements.Text, "en", frmSplashScreen.CPlayer.Language);
                btnSortCompleted.Text = frmSplashScreen.Translator.TranslateText(btnSortCompleted.Text, "en", frmSplashScreen.CPlayer.Language);
                btnSortNameAch.Text = frmSplashScreen.Translator.TranslateText(btnSortNameAch.Text, "en", frmSplashScreen.CPlayer.Language);
                btnSortNameInfo.Text = frmSplashScreen.Translator.TranslateText(btnSortNameInfo.Text, "en", frmSplashScreen.CPlayer.Language);
                btnSortScore.Text = frmSplashScreen.Translator.TranslateText(btnSortScore.Text, "en", frmSplashScreen.CPlayer.Language);
                btnSortByTopic.Text = frmSplashScreen.Translator.TranslateText(btnSortByTopic.Text, "en", frmSplashScreen.CPlayer.Language);
            }
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
        // Paint event handler for the Placeholder form
        private void frmPlaceholder_Paint(object sender, PaintEventArgs e)
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
                e.Graphics.DrawImage(layer_Sun, 0, 0);
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_3, 0, 0);
                e.Graphics.DrawImage(layer_3, 0, 0);
            }
        }

        // Tick event handler for the parallax timer
        private void tmParralax_Tick(object sender, EventArgs e)
        {
            // Move background layers
            background_move();
        }

        // Variables for background layer positions
        int b1 = 0, b2 = 816, x1 = 0, x2 = 816, g1 = 0, g2 = 816, s1 = 0, s2 = 0;

        // Click event handler for sorting achievements by completion status in descending order
        private void btnSortCompleted_Click(object sender, EventArgs e)
        {
            dgvAchievements.Sort(dgvAchievements.Columns["CompletedColumn"], ListSortDirection.Descending);
        }

        // Click event handler for sorting player report by username in ascending order
        private void btnSortNameInfo_Click(object sender, EventArgs e)
        {
            dgvPlayerReport.Sort(dgvPlayerReport.Columns["PlayerIdColumn"], ListSortDirection.Ascending);
        }

        // Click event handler for sorting player report by score in descending order
        private void btnSortScore_Click(object sender, EventArgs e)
        {
            dgvPlayerReport.Sort(dgvPlayerReport.Columns["ScoreColumn"], ListSortDirection.Descending);
        }

        // Click event handler for sorting player report by topic in ascending order
        private void btnSortByTopic_Click(object sender, EventArgs e)
        {
            dgvPlayerReport.Sort(dgvPlayerReport.Columns["TopicColumn"], ListSortDirection.Ascending);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmSplashScreen.formLogin.Show();
            this.Hide();
            frmSplashScreen.CPlayer = new PlayerJson();
        }

        // Click event handler for sorting achievements by name in ascending order
        private void btnSortAchievements_Click(object sender, EventArgs e)
        {
            dgvAchievements.Sort(dgvAchievements.Columns["AchievementNameColumn"], ListSortDirection.Ascending);
        }

        // Method to apply rounded corners to a Panel control
        private void ApplyRoundedCornersToPanel(Panel panel, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            panel.Region = new Region(path);
        }

        // Method to apply rounded corners to all Panel controls within a container
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

        // Click event handler for sorting achievements by username in ascending order
        private void btnSortName_Click(object sender, EventArgs e)
        {
            dgvAchievements.Sort(dgvAchievements.Columns["PlayerIdColumn"], ListSortDirection.Ascending);
        }

        // Click event handler for displaying quiz results and enabling/disabling buttons and panels
        private void btnQuizResults_Click(object sender, EventArgs e)
        {
            btnAchievements.Enabled = true;
            btnQuizResults.Enabled = false;
            panelInfo.Visible = true;
            panelBack.Visible = false;
            dgvPlayerReport.BringToFront();
        }

        // Click event handler for displaying achievements and enabling/disabling buttons and panels
        private void btnAchievements_Click(object sender, EventArgs e)
        {
            btnAchievements.Enabled = false;
            btnQuizResults.Enabled = true;
            panelInfo.Visible = false;
            panelBack.Visible = true;
            dgvAchievements.BringToFront();
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
