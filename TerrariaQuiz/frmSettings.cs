using stdole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class frmSettings : Form
    {
        // Importing the AddFontMemResourceEx method from gdi32.dll
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        private FontFamily ff;
        private System.Drawing.Font font;

        // Events for changing volume of music
        public EventHandler changeMusicVolume;

        // Variables for parallax animation
        Image layer_1 = Resources.BackgroundMountainVerySmall;
        Image layer_2 = Resources.MiddlegroundMountainVerySmall;
        Image layer_3 = Resources.ForegroundHillVerySmall;
        Image layer_4 = Resources.ForegroundTreesVerySmall;
        public bool imagesLoaded = false;
        public frmSettings()
        {
            // Setting up program
            InitializeComponent();
            CenterToScreen();

            // Setting background color to be transparent
            btnCCEANote.BackColor = Color.Transparent; lbLanguage.BackColor = Color.Transparent; btnProceed.BackColor = Color.Transparent; chbParallax.BackColor = Color.Transparent; lbTitle.BackColor = Color.Transparent; lbMusicVolume.BackColor = Color.Transparent; lbParallax.BackColor = Color.Transparent; lbMusicVolumePercent.BackColor = Color.Transparent;

            // Enabling property of the form to help with animation smoothing
            this.DoubleBuffered = true;
        }

        // Event Handler for form loading
        private void frmSettings_Load(object sender, EventArgs e)
        {
            // Changing form text to display Terraria Quiz and the splash text
            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;

            // Loading custom Andy Bold font and applying it to all text containing controls then starting animations
            LoadCustomFont();
            ApplyFont(font, this.lbTitle, 15);
            ApplyFont(font, this.lbMusicVolume, 12);
            ApplyFont(font, this.chbParallax, 12);
            ApplyFont(font, this.lbParallax, 12);
            ApplyFont(font, this.lbMusicVolumePercent, 12);
            ApplyFont(font, this.cbLanguage, 12);
            ApplyFont(font, this.lbLanguage, 12);
            ApplyFont(font, this.btnProceed, 18);
            ApplyFont(font, this.btnCCEANote, 12);
            imagesLoaded = true;
            tmParralax.Start();
            Invalidate();
        }
        // Method to load a custom font from resources
        private void LoadCustomFont()
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
        private void playAudioHover() // set up to play the click sound played when buttons are hovered over like actual Terraria buttons do
        {
            SoundPlayer click = new SoundPlayer(Resources.MenuClick);
            click.Play();
        }
        private void ControlHovered(object sender, EventArgs e)
        {
            // Changes colour and font size of button when hovered over
            ((Control)sender).ForeColor = Color.Yellow;
            ApplyFont(font, ((Control)sender), ((Control)sender).Font.Size + 1);
            // Plays click sound when hovered
            playAudioHover();
        }
        private void ControlLeft(object sender, EventArgs e)
        {
            // Changes colour and font size of button when mouse leaves
            ((Control)sender).ForeColor = SystemColors.ButtonFace;
            ApplyFont(font, (Control)sender, ((Control)sender).Font.Size - 1);
        }

        // Event Handler for Music Scroll Bar being scrolled
        private void trbMusicVolume_Scroll(object sender, EventArgs e)
        {
            // Setting the MusicVolume variable in the player class and invoking an event to update the volume of the axwindowsmediaplayer
            frmSplashScreen.CPlayer.MusicVolume = trbMusicVolume.Value;
            lbMusicVolumePercent.Text = frmSplashScreen.CPlayer.MusicVolume.ToString() + "%";
            changeMusicVolume?.Invoke(trbMusicVolume.Value, EventArgs.Empty);
        }

        // Setting up variables for animation
        int b1 = 0, b2 = 539, x1 = 0, x2 = 539, g1 = 0, g2 = 539, h1 = 0, h2 = 539;

        // Event Handler for user selecting an item in the language combo box
        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checking what language the user selected and setting accordingly
            updateLanguage(cbLanguage.SelectedItem.ToString());
        }

        // Event Handler for button clicking
        private void btnCCEANote_Click(object sender, EventArgs e)
        {
            // Message box to inform CCEA about aws services
            MessageBox.Show("The translation service uses amazon web services and there is a chance that access to the web services could be blocked by a proxy on your computer (unlikely but still a fair possibility) so if the text is blank after translation and the debug shows an exception for amazon web services that is the case.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method to update the language in text controls
        private void updateLanguage(string toUpdate)
        {
            // Checking which language is chosen and translating accordingly
            switch (toUpdate)
            {
                case "English":
                    frmSplashScreen.CPlayer.Language = "en";
                    lbTitle.Text = "Settings";
                    lbMusicVolume.Text = "Music Volume";
                    lbLanguage.Text = "Language";
                    lbParallax.Text = "Parallax";
                    btnProceed.Text = "Proceed";
                    break;
                case "Spanish":
                    frmSplashScreen.CPlayer.Language = "es";
                    lbTitle.Text = frmSplashScreen.Translator.TranslateText("Settings", "en", "es");
                    lbMusicVolume.Text = frmSplashScreen.Translator.TranslateText("Music Volume", "en", "es");
                    lbLanguage.Text = frmSplashScreen.Translator.TranslateText("Language", "en", "es");
                    lbParallax.Text = frmSplashScreen.Translator.TranslateText("Parallax", "en", "es");
                    btnProceed.Text = frmSplashScreen.Translator.TranslateText("Proceed", "en", "es");
                    break;
                case "French":
                    frmSplashScreen.CPlayer.Language = "fr";
                    lbTitle.Text = frmSplashScreen.Translator.TranslateText("Settings", "en", "fr");
                    lbMusicVolume.Text = frmSplashScreen.Translator.TranslateText("Music Volume", "en", "fr");
                    lbLanguage.Text = frmSplashScreen.Translator.TranslateText("Language", "en", "fr");
                    lbParallax.Text = frmSplashScreen.Translator.TranslateText("Parallax", "en", "fr");
                    btnProceed.Text = frmSplashScreen.Translator.TranslateText("Proceed", "en", "fr");
                    break;
                case "German":
                    frmSplashScreen.CPlayer.Language = "de";
                    lbTitle.Text = frmSplashScreen.Translator.TranslateText("Settings", "en", "de");
                    lbMusicVolume.Text = frmSplashScreen.Translator.TranslateText("Music Volume", "en", "de");
                    lbLanguage.Text = frmSplashScreen.Translator.TranslateText("Language", "en", "de");
                    lbParallax.Text = frmSplashScreen.Translator.TranslateText("Parallax", "en", "de");
                    btnProceed.Text = frmSplashScreen.Translator.TranslateText("Proceed", "en", "de");
                    break;
            }
        }
        // Event Handler for settings form being shown
        private void frmSettings_VisibleChanged(object sender, EventArgs e)
        {
            // If form is being shown then the values of the settings options are updated
            if (this.Visible == true)
            {
                chbParallax.Checked = frmSplashScreen.CPlayer.Parallax;
                trbMusicVolume.Value = frmSplashScreen.CPlayer.MusicVolume;
                lbMusicVolumePercent.Text = frmSplashScreen.CPlayer.MusicVolume.ToString() + "%";
                string fullLanguageName = "";
                switch (frmSplashScreen.CPlayer.Language)
                {
                    case "en":
                        fullLanguageName = "English";
                        break;
                    case "es":
                        fullLanguageName = "Spanish";
                        break;
                    case "fr":
                        fullLanguageName = "French";
                        break;
                    case "de":
                        fullLanguageName = "German";
                        break;
                }
                updateLanguage(fullLanguageName);
            }
        }

        // Event handler for the user pressing the button to proceed with the quiz
        private void btnProceed_Click(object sender, EventArgs e)
        {
            // Verifying that the user wants to exit the settings menu
            if (MessageBox.Show("Are you sure you want to save these settings?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                frmSplashScreen.formStart.Show();
                frmSplashScreen.AccountManager.SaveSettings(frmSplashScreen.CPlayer.PlayerId, chbParallax.Checked, trbMusicVolume.Value, frmSplashScreen.CPlayer.Language);
            }
        }

        private void tmParralax_Tick(object sender, EventArgs e)
        { // Creating parallax moving background effect
            background_move();
        }

        // Event handler for parallax option being changed
        private void chbParallax_CheckedChanged(object sender, EventArgs e)
        {
            // Sets parallax value in the the player class accordingly to what the player has chosen in settings
            if (chbParallax.Checked == true)
            {
                frmSplashScreen.CPlayer.Parallax = true;
                tmParralax.Start();
            }
            else if (chbParallax.Checked == false)
            {
                frmSplashScreen.CPlayer.Parallax = false;
                tmParralax.Stop();
            }
        }

        private void frmSettings_Paint(object sender, PaintEventArgs e)
        {
            // Creating moving parallax effect or just painting on background image instead depending on if parallax is enabled or not
            if (imagesLoaded == true && frmSplashScreen.CPlayer.Parallax == true)
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
            else if (frmSplashScreen.CPlayer.Parallax == false)
            {
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_3, 0, 0);
                e.Graphics.DrawImage(layer_3, 0, 0);
                e.Graphics.DrawImage(layer_4, 0, 0);
                e.Graphics.DrawImage(layer_4, 0, 0);
            }
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
            if (b1 < -539)
            {
                b1 = 530;
            }
            b1 -= 1;
            b2 -= 1;
            if (b2 < -539)
            {
                b2 = 530;
            }
            if (x1 < -539)
            {
                x1 = 530;
            }
            x2 -= 2;
            x1 -= 2;
            if (x2 < -539)
            {
                x2 = 530;
            }
            if (g1 < -539)
            {
                g1 = 530;
            }
            g2 -= 3;
            g1 -= 3;
            if (g2 < -539)
            {
                g2 = 530;
            }
            if (h1 < -539)
            {
                h1 = 530;
            }
            h2 -= 4;
            h1 -= 4;
            if (h2 < -539)
            {
                h2 = 530;
            }
            // Trigger a repaint of the form
            Invalidate();
        }
    }
}
