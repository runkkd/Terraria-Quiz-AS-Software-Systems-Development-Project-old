using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;
using Newtonsoft.Json;
using static TerrariaQuiz.frmSplashScreen;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmLogin : Form
    {
        // Importing method from gdi32.dll to add a font from memory
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        // Variables for handling custom font
        FontFamily ff;
        Font font;

        // Event for changing volume when account is logged in
        public EventHandler changeMusicVolume;

        // Background images for parallax effect
        Image layer_1 = Resources.BackgroundCourruptedHills;
        Image layer_2 = Resources.MiddlegroundCorruptedHills;
        Image layer_3 = Resources.ForegroundCorruptedTreesBack;
        Image layer_4 = Resources.ForegroundCorruptedTreesMiddle;
        Image layer_5 = Resources.ForegroundCorruptedTreesFront;

        // Variable for first load
        public bool firstLoad = false;
        public frmLogin()
        {
            // Setting up program
            InitializeComponent();
            CenterToScreen();

            // Making certain controls transparent
            btnDetails.BackColor = Color.Transparent; btnRegister.BackColor = Color.Transparent; lbVersion.BackColor = Color.Transparent; chbShow.BackColor = Color.Transparent; lbTitle.BackColor = Color.Transparent; lbPassword.BackColor = Color.Transparent; lbUsername.BackColor = Color.Transparent; btnLogin.BackColor = Color.Transparent;

            // Enabling double buffering for animation smoothing
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

        // Variables for background movement in parallax effect
        int b1 = 0, b2 = 397, x1 = 0, x2 = 397, g1 = 0, g2 = 397, h1 = 0, h2 = 397, t1 = 0, t2 = 397;

        // Method to move background layers for parallax effect
        void background_move()
        {
            /*
            * Moving each background layer horizontally
            * Resetting positions when they go off - screen
            * Invalidating the form to trigger repaint
            * This creates a parallax effect
            * Note: The specific values and logic may need adjustment based on your design 
            */
            if (b1 < -397)
            {
                b1 = 390;
            }
            b1 -= 1;
            b2 -= 1;
            if (b2 < -397)
            {
                b2 = 390;
            }
            if (x1 < -397)
            {
                x1 = 390;
            }
            x2 -= 2;
            x1 -= 2;
            if (x2 < -397)
            {
                x2 = 390;
            }
            if (g1 < -397)
            {
                g1 = 390;
            }
            g2 -= 3;
            g1 -= 3;
            if (g2 < -397)
            {
                g2 = 390;
            }
            if (h1 < -397)
            {
                h1 = 390;
            }
            h2 -= 4;
            h1 -= 4;
            if (h2 < -397)
            {
                h2 = 390;
            }

            if (t1 < -397)
            {
                t1 = 390;
            }
            t2 -= 5;
            t1 -= 5;
            if (t2 < -397)
            {
                t2 = 390;
            }

            // Trigger a repaint of the form
            Invalidate();
        }

        // Method to reset text fields
        private void resetFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }
        }

        // Method to disable all input controls
        private void DisableAll()
        {
            tbPassword.Enabled = false;
            tbUsername.Enabled = false;
            btnLogin.Enabled = false;
            chbShow.Enabled = false;
        }

        // Method to enable all input controls
        private void EnableAll()
        {
            tbPassword.Enabled = true;
            tbUsername.Enabled = true;
            btnLogin.Enabled = true;
            chbShow.Enabled = true;
        }

        // Event handler when the form is loaded
        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Setting form text to display Terraria Quiz and the splash text
            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;

            // Starting the parallax timer
            tmParralax.Start();

            // Setting version text when form is loaded
            lbVersion.Text = Version.version;

            // Loading custom font and applying it to controls
            LoadFont();
            ApplyFont(font, this.btnLogin, 22);
            ApplyFont(font, this.lbTitle, 14);
            ApplyFont(font, this.lbUsername, 14);
            ApplyFont(font, this.tbUsername, 12);
            ApplyFont(font, this.tbPassword, 12);
            ApplyFont(font, this.lbVersion, 13);
            ApplyFont(font, this.lbPassword, 14);
            ApplyFont(font, this.btnRegister, 22);
            ApplyFont(font, this.btnDetails, 12);
            ApplyFont(font, this.chbShow, 14);
            firstLoad = true;
        }
        private void playAudioHover() // set up to play the click sound played when buttons are hovered over like actual Terraria buttons do
        {
            SoundPlayer click = new SoundPlayer(Resources.MenuClick);
            click.Play();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        { // Provide login details for a normal account and an admin account
            MessageBox.Show("Account details for a normal account are, Username \"CCEA\", Password: \"password\". Account details for an admin account are, Username: \"Admin\", Password: \"Password123\".", "Account Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmLogin_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true && firstLoad == true)
            {
                tmParralax.Start();
                resetFields();
            }
        }

        private void tmParralax_Tick(object sender, EventArgs e) // Adjusts background every time the timer ticks tyo create parallax affect
        {
            background_move();
        }

        // Event handler for playing hover sound and adjusting appearance on control hover
        private void ControlHovered(object sender, EventArgs e)
        {
            // Changes colour and font size of button when hovered over
            ((Control)sender).ForeColor = Color.Yellow;
            ApplyFont(font, ((Control)sender), ((Control)sender).Font.Size + 1);
            // Plays click sound when hovered
            playAudioHover();
        }

        // Event handler for adjusting appearance on control leave
        private void ControlLeft(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = SystemColors.ButtonFace;
            ApplyFont(font, (Control)sender, ((Control)sender).Font.Size - 1);
        }

        // Event handler for checking/unchecking show password checkbox
        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            // Showing/hiding password based on checkbox state
            tbPassword.UseSystemPasswordChar = !chbShow.Checked;
        }
    
        // Event handler for login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verifying the username and password
            bool validLogin = frmSplashScreen.AccountManager.ValidateLogin(tbUsername.Text, tbPassword.Text);
            bool isAdmin = frmSplashScreen.AccountManager.ValidateAdmin(tbUsername.Text);
            if (validLogin == false)
            {
                // Displaying error message and resetting fields
                MessageBox.Show("invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetFields();
                EnableAll();
            }
            else if (validLogin == true)
            {
                // Successful login
                frmSplashScreen.CPlayer.PlayerId = tbUsername.Text;
                MessageBox.Show("Correct details entered.","Account Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Stopping the parallax affect to prevent lag from it running the background
                tmParralax.Stop();

                // Load player achievements
                List<PlayerAchievement> playerAchievementsList = LoadPlayerAchievementsFromJson("player_achievements.json", tbUsername.Text);

                frmSplashScreen.AccountManager.LoadMusicVolume();
                frmSplashScreen.AccountManager.LoadParallax();
                frmSplashScreen.AccountManager.LoadLanguage();
                // Checking if the account that has been logged into is an admin account or not
                if (isAdmin == false)
                { // If it is not an admin account the start screen is shown
                    new frmStart().Show();
                    Hide();
                }
                else
                { // If it is an admin account the admin form is shown
                    new frmAdministrator().Show();
                    Hide();
                }
                changeMusicVolume?.Invoke(CPlayer.MusicVolume, EventArgs.Empty);
            }
        }

        // Method to get all players from the player_accounts json file
        public static List<PlayerJson> LoadPlayersFromJson(string fileName)
        {
            List<PlayerJson> playerList = new List<PlayerJson>();

            if (File.Exists(fileName))
            {
                // Read the JSON file
                string jsonData = File.ReadAllText(fileName);

                // Deserialize JSON to a list of Player objects
                playerList = JsonConvert.DeserializeObject<List<PlayerJson>>(jsonData);
            }

            return playerList;
        }

        // Method to get all player achievements from the player_achievements json file
        public static List<PlayerAchievement> LoadPlayerAchievementsFromJson(string fileName, string playerId)
        {
            List<PlayerAchievement> playerAchievementsList = new List<PlayerAchievement>();

            // Load existing achievements from JSON
            List<PlayerJson> playerList = LoadPlayersFromJson("player_achievments.json");

            // Find the player with the specified ID
            PlayerJson player = playerList.FirstOrDefault(p => p.PlayerId == playerId);

            if (player != null)
            {
                // Filter achievements based on player ID
                playerAchievementsList = player.Achievements;
            }

            return playerAchievementsList;
        }

        // Event handler for register button click
        private void btnRegister_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            Hide();
        }

        // Event handler for painting the form (drawing background layers)
        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(layer_1, b1, 0);
            e.Graphics.DrawImage(layer_1, b2, 0);
            e.Graphics.DrawImage(layer_2, x1, 0);
            e.Graphics.DrawImage(layer_2, x2, 0);
            e.Graphics.DrawImage(layer_3, g1, 0);
            e.Graphics.DrawImage(layer_3, g2, 0);
            e.Graphics.DrawImage(layer_4, h1, 0);
            e.Graphics.DrawImage(layer_4, h2, 0);
            e.Graphics.DrawImage(layer_5, t1, 0);
            e.Graphics.DrawImage(layer_5, t2, 0);
        }
    }
}
