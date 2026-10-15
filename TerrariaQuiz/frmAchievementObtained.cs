using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Media;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmAchievementObtained : Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        private FontFamily ff;
        private System.Drawing.Font font;
        private const int WS_SYSMENU = 0x80000;
        private static SoundPlayer achievementObtained = new SoundPlayer(Resources.Achieved);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU; // Removes the close button
                return cp;
            }
        }
        public frmAchievementObtained()
        {
            InitializeComponent();
            // Setting transparent backgrounds and moving form
            lbAchievementInfo.BackColor = Color.Transparent; lbAchievementTitle.BackColor = Color.Transparent;
            if (frmSplashScreen.AchievementManager != null)
            {
                frmSplashScreen.AchievementManager.AchievementUnlocked += ShowAchievement;
            }
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

        public void ShowAchievement(object sender, PlayerAchievement e)
        {
            // Showing this form and playing the achievmeent obtained sound
            frmSplashScreen.formAchieve.Show();
            achievementObtained.Play();
            // Switch to get what achievment was obtained then change specific controls accordingly
            switch (e.AchievementId)
            {
                case 1:
                        lbAchievementTitle.Text = "Quiz Achiever";
                        pAchievementOne.BackgroundImage = Resources.Achieve1;
                        lbAchievementInfo.Text = "You beat the Terraria Quiz!";
                    break;
                case 2:
                        lbAchievementTitle.Text = "Quizmaster Conqueror";
                        pAchievementOne.BackgroundImage = Resources.Achieve2;
                        lbAchievementInfo.Text = "You didn't make a single mistake in the Terraria Quiz!";
                    break;
                case 3:
                        lbAchievementTitle.Text = "Boss Conqueror";
                        pAchievementOne.BackgroundImage = Resources.Achieve3;
                        lbAchievementInfo.Text = "You played the Bosses topic in the Terraria Quiz!";
                    break;
                case 4:
                        lbAchievementTitle.Text = "Arms Maestro";
                        pAchievementOne.BackgroundImage = Resources.Achieve4;
                        lbAchievementInfo.Text = "You played the Weapons topic in the Terraria Quiz!";
                    break;
                case 5:
                        lbAchievementTitle.Text = "Citizen Scholar";
                        pAchievementOne.BackgroundImage = Resources.Achieve5;
                        lbAchievementInfo.Text = "You played the NPCs topic in the Terraria Quiz!";
                    break;
            }
        }
        private void frmAchievementObtained_Load(object sender, EventArgs e)
        {
            // Calling method to load custom font and applying font to certain controls
            LoadCustomFont();
            ApplyFont(font, lbAchievementInfo, 12);
            ApplyFont(font, lbAchievementTitle, 12);
            // Calculating where to place the achievement notification based on screen size
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
        // Method to translate text
        private void translate()
        {
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                // Checking what language the user has selected and applying accordingly
                lbAchievementInfo.Text = frmSplashScreen.Translator.TranslateText(lbAchievementInfo.Text, "en", frmSplashScreen.CPlayer.Language);
                lbAchievementTitle.Text = frmSplashScreen.Translator.TranslateText(lbAchievementTitle.Text, "en", frmSplashScreen.CPlayer.Language);
            }
        }
        private async Task FadeOutForm()
        {
            // Creating fade out effect
            const int animationDuration = 5000; // in milliseconds
            const int steps = 100; // Number of steps in the loop
            double opacityDecrement = 1.0 / steps;

            for (int i = 0; i < steps; i++)
            {
                Opacity -= opacityDecrement;
                await Task.Delay(animationDuration / steps);
            }
            // Hiding form at end of animation
            Hide();
        }
        private async void frmAchievementObtained_VisibleChanged(object sender, EventArgs e)
        {
            // Playing achievement obtained sound
            SoundPlayer achievementObtained = new SoundPlayer();
            achievementObtained.Play();
            if (this.Visible)
            {
                await DelayAsync(3000);
                await FadeOutForm();
            }
        }
        private Task DelayAsync(int milliseconds)
        {
            // Task.Delay creates a non-blocking delay
            return Task.Delay(milliseconds);
        }

        private void frmAchievementObtained_Shown(object sender, EventArgs e)
        {
            // Calling method to translate form
            translate();
        }
    }
}
