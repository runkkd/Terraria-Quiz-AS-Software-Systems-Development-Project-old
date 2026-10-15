using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Media;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;
using System.Runtime.InteropServices.ComTypes;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmRegister : Form
    {
        // Importing external method from gdi32.dll to add font from memory
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        // Fields for custom font, background images and error handling
        FontFamily ff;
        Font font;
        Image layer_1 = Resources.BackgroundCrimsonHills;
        Image layer_2 = Resources.MiddlegroundCrimsonHillsAndBones;
        Image layer_3 = Resources.ForegroundCrimsonTrees;
        Image layer_4 = Resources.ForegroundCrimsonTreesFront;
        public frmRegister()
        {
            // Setting up program
            InitializeComponent();
            CenterToScreen();

            // Setting specific controls to be transparent
            lbAge.BackColor = Color.Transparent; lbVersion.BackColor = Color.Transparent; chbShow.BackColor = Color.Transparent; lbTitle.BackColor = Color.Transparent; lbPassword.BackColor = Color.Transparent; lbVerifyPassword.BackColor = Color.Transparent; lbUsername.BackColor = Color.Transparent; btnCreate.BackColor = Color.Transparent;

            // Changing form text to display Terraria Quiz and the splash text
            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;
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

        // Method to handle background movement
        int b1 = 0, b2 = 397, x1 = 0, x2 = 397, g1 = 0, g2 = 397, h1 = 0, h2 = 397;
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

            // Trigger a repaint of the form
            Invalidate();
        }

        // Method to reset text in TextBox controls
        private void resetFields()
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbVerifyPassed.Text = "";
            tbAge.Text = "";
        }

        // Method to disable all input controls
        private void DisableAll()
        {
            tbPassword.Enabled = false;
            tbVerifyPassed.Enabled = false;
            tbUsername.Enabled = false;
            btnCreate.Enabled = false;
            chbShow.Enabled = false;
        }

        // Method to enable all input controls
        private void EnableAll()
        {
            tbPassword.Enabled = true;
            tbVerifyPassed.Enabled = true;
            tbUsername.Enabled = true;
            btnCreate.Enabled = true;
            chbShow.Enabled = true;
        }

        // Event handler for the "Create" button click
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Disabling input controls during processing
            DisableAll();

            string[] info = frmSplashScreen.AccountManager.ValidateRegistration(tbUsername.Text, tbPassword.Text, tbVerifyPassed.Text, tbAge.Text);

            // Displaying error message if verification fails
            if (info[0] == "True")
            {
                MessageBox.Show(info[1], info[2], MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetFields();
                EnableAll();
            }
            else if (info[0] == "False")
            {
                try
                {
                    // Load existing achievements from JSON
                    List<PlayerAchievement> playerAchievementsList = LoadPlayerAchievementsFromJson("player_achievements.json");


                    // Loop to create and add achievements
                    for (int i = 1; i < 6; i++)
                    {
                        PlayerAchievement playerAchievement = new PlayerAchievement("",0,false)
                        {
                            PlayerId = tbUsername.Text,
                            AchievementId = i,
                            Completed = false
                        };

                        playerAchievementsList.Add(playerAchievement);
                    }

                    frmSplashScreen.AccountManager.AddAccount(tbUsername.Text, tbPassword.Text, Convert.ToInt32(tbAge.Text));
                    SavePlayersToJson("player_achievements.json", playerAchievementsList);

                    // Displaying success message and transitioning to the login form
                    MessageBox.Show(info[1], info[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tmParralax.Stop();
                    new frmLogin().Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.OK)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
        }
        private void playAudioHover()
        { // set up to play the click sound played when buttons are hovered over like actual Terraria buttons do
            SoundPlayer click = new SoundPlayer(Resources.MenuClick);
            click.Play();
        }
        // Event handler for control hover
        private void ControlHovered(object sender, EventArgs e)
        {
            // Changes colour and font size of button when hovered over
            ((Control)sender).ForeColor = Color.Yellow;
            ApplyFont(font, ((Control)sender), ((Control)sender).Font.Size + 1);
            // Plays click sound when hovered
            playAudioHover();
        }
        // Event handler for control leaving hover
        private void ControlLeft(object sender, EventArgs e)
        {
            // Changes colour and font size of button when mouse leaves
            ((Control)sender).ForeColor = SystemColors.ButtonFace;
            ApplyFont(font, (Control)sender, ((Control)sender).Font.Size - 1);
        }
        // Event handler for "Show" checkbox state change
        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            // Showing/hiding password based on checkbox state
            tbPassword.UseSystemPasswordChar = !chbShow.Checked;
            tbVerifyPassed.UseSystemPasswordChar = !chbShow.Checked;
        }

        // Event handler for form paint, handles drawing background images
        private void frmRegister_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(layer_1, b1, 0);
            e.Graphics.DrawImage(layer_1, b2, 0);
            e.Graphics.DrawImage(layer_2, x1, 0);
            e.Graphics.DrawImage(layer_2, x2, 0);
            e.Graphics.DrawImage(layer_3, g1, 0);
            e.Graphics.DrawImage(layer_3, g2, 0);
            e.Graphics.DrawImage(layer_4, h1, 0);
            e.Graphics.DrawImage(layer_4, h2, 0);
        }

        // Event handler for background movement timer tick
        private void tmParralax_Tick(object sender, EventArgs e)
        {
            background_move();
        }

        // Event handler for form load, starts the background movement timer
        private void frmRegister_Load(object sender, EventArgs e)
        {
            // Starting timer for parallax animation
            tmParralax.Start();

            // Changing the version text when form is loaded
            lbVersion.Text = Version.version;

            // Loading the custom font and applying it to controls with text
            LoadFont();
            ApplyFont(font, this.btnCreate, 13);
            ApplyFont(font, this.lbTitle, 14);
            ApplyFont(font, this.lbUsername, 12);
            ApplyFont(font, this.lbVersion, 13);
            ApplyFont(font, this.lbPassword, 12);
            ApplyFont(font, this.lbVerifyPassword, 12);
            ApplyFont(font, this.chbShow, 10);
            ApplyFont(font, this.lbAge, 12);
            ApplyFont(font, this.tbUserInfo, 10);
            ApplyFont(font, this.tbPassInfo, 10);
            ApplyFont(font, this.tbAgeInfo, 10);
        }

        // Method to load player achievements from the player_achievements json file
        private List<PlayerAchievement> LoadPlayerAchievementsFromJson(string fileName)
        {
            try
            {
                // Read the JSON from the file
                string json = System.IO.File.ReadAllText(fileName);

                // Deserialize the JSON to a list of PlayerAchievement
                List<PlayerAchievement> playerAchievementsList = JsonConvert.DeserializeObject<List<PlayerAchievement>>(json);

                // Return the loaded list
                return playerAchievementsList ?? new List<PlayerAchievement>();
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., log the error
                Console.WriteLine($"Error loading player achievements from JSON: {ex.Message}");
                return new List<PlayerAchievement>();
            }
        }

        // Method to save the updated version of the player_accounts json file
        private void SavePlayersToJson(string fileName, List<PlayerAchievement> players)
        {
            try
            {
                // Serialize the list of players to JSON
                string json = JsonConvert.SerializeObject(players, Formatting.Indented);

                // Write the JSON to the file
                System.IO.File.WriteAllText(fileName, json);
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., log the error
                Console.WriteLine($"Error saving players to JSON: {ex.Message}");
            }
        }

        // Event handlesr for TextBox controls entering focus
        private void tbUsername_Enter(object sender, EventArgs e)
        {
            tbUserInfo.Visible = true;
        }
        private void tbPassword_Enter(object sender, EventArgs e)
        {
            tbPassInfo.Visible = true;
        }
        private void tbVerifyPassed_Enter(object sender, EventArgs e)
        {
            tbPassInfo.Visible = true;
        }

        // Event handler for TextBox control leaving focus
        private void tbAge_Leave(object sender, EventArgs e)
        {
            tbAgeInfo.Visible = false;
        }

        // Event handler for TextBox control entering focus
        private void tbAge_Enter(object sender, EventArgs e)
        {
            tbAgeInfo.Visible = true;
        }

        // Event handlers for TextBox controls leaving focus
        private void tbVerifyPassed_Leave(object sender, EventArgs e)
        {
            tbPassInfo.Visible = false;
        }
        private void tbPassword_Leave(object sender, EventArgs e)
        {
            tbPassInfo.Visible = false;
        }
        private void tbUsername_Leave(object sender, EventArgs e)
        {
            tbUserInfo.Visible = false;
        }
    }
}
