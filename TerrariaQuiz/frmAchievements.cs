using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Logging;
using System.Drawing.Drawing2D;
using System.IO;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmAchievements : Form
    {
        // Importing method from gdi32.dll to add font from memory
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        private FontFamily ff;
        private Font font;
        public event EventHandler FormAchieveShown;
        public event EventHandler FormAchieveClosed;
        Image layer_1 = Resources.BackgroundHell2;
        Image layer_2 = Resources.BackgroundHell;
        Image layer_3 = Resources.MiddlegroundHell;
        Image layer_4 = Resources.ForegroundHell;
        bool imagesLoaded = false;
        public frmAchievements()
        {
            // Setting up program
            InitializeComponent();
            CenterToScreen();
            // Setting text controls to transparent background
            lbQuizAchiever.BackColor = Color.Transparent; lbQuizAchieverTitle.BackColor = Color.Transparent; lbQuizmasterConqueror.BackColor = Color.Transparent; lbQuizmasterConquerorTitle.BackColor = Color.Transparent; lbAchievements.BackColor = Color.Transparent; lbBossVanquisherTitle.BackColor = Color.Transparent; lbBossVanquisher.BackColor = Color.Transparent; lbArmsMaestroTitle.BackColor = Color.Transparent; lbArmsMaestro.BackColor = Color.Transparent; lbCitizenScholar.BackColor = Color.Transparent; lbCitizenScholarTitle.BackColor = Color.Transparent;
            // Changing form text to display Terraria Quiz and the splash text
            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;
            // Animation smoothing
            this.DoubleBuffered = true;
            // Round all panels
            ApplyRoundedCornersToAllPanels(this);
        }
        private void ApplyRoundedCornersToPanel(Panel panel, int cornerRadius)
        {
            // Using graphics path to create rounded corners on paths
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            panel.Region = new Region(path);
        }
        private void ApplyRoundedCornersToAllPanels(Control container)
        {
            // Looping through all panels and adding the rounded corners
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

        // Event to tell frmStart to disable the achievement button as a achievement screen is already open
        private void frmAchievements_Shown(object sender, EventArgs e)
        {
            // Starting parallax timer and invoking the FormAchieveShown event then calling method to translate text
            tmParralax.Start();
            FormAchieveShown?.Invoke(this, EventArgs.Empty);
            translate();
        }

        // Event to tell frmStart to enable the achievement button as the achievement screen has been closed
        private void frmAchievements_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Calling method to stop parallax timer and invoking mne
            tmParralax.Stop();
            FormAchieveClosed?.Invoke(this, EventArgs.Empty);
        }
        // Variables for parallax affect
        int b1 = 0, b2 = 681, x1 = 0, x2 = 681, g1 = 0, g2 = 681, h1 = 0, h2 = 681;

        private void frmAchievements_VisibleChanged(object sender, EventArgs e)
        { // Reloads achievements every time form is opened for live updating
            if (this.Visible == true)
            {
                ApplyAchievements();
            }
        }

        // Method to create the parallax affect
        void background_move()
        {
            /*
           * Moving each background layer horizontally
           * Resetting positions when they go off - screen
           * Invalidating the form to trigger repaint
           * This creates a parallax effect
           * Note: The specific values and logic may need adjustment based on your design 
           */
            if (b1 < -681)
            {
                b1 = 674;
            }
            b1 -= 1;
            b2 -= 1;
            if (b2 < -681)
            {
                b2 = 674;
            }
            if (x1 < -681)
            {
                x1 = 674;
            }
            x2 -= 2;
            x1 -= 2;
            if (x2 < -681)
            {
                x2 = 674;
            }
            if (g1 < -681)
            {
                g1 = 674;
            }
            g2 -= 3;
            g1 -= 3;
            if (g2 < -681)
            {
                g2 = 674;
            }
            if (h1 < -681)
            {
                h1 = 674;
            }
            h2 -= 4;
            h1 -= 4;
            if (h2 < -681)
            {
                h2 = 674;
            }
            // Trigger repaint of form
            Invalidate();
        }
        private void tmParralax_Tick(object sender, EventArgs e)
        { // Adjusts the background layers every timer tick
            background_move();
        }
        private void frmAchievements_Paint(object sender, PaintEventArgs e)
        { // Paints on images required for parallax background affect
            // Creating moving parallax effect or just painting on background image instead depending on if parallax is enabled or not
            if (imagesLoaded == true && frmSplashScreen.CPlayer.Parallax == true)
            {
                e.Graphics.DrawImage(layer_1, b1, 0);
                e.Graphics.DrawImage(layer_1, b2, 0);
                e.Graphics.DrawImage(layer_2, x1, 0);
                e.Graphics.DrawImage(layer_2, x2, 0);
                e.Graphics.DrawImage(layer_3, g1, 60);
                e.Graphics.DrawImage(layer_3, g2, 60);
                e.Graphics.DrawImage(layer_4, h1, 0);
                e.Graphics.DrawImage(layer_4, h2, 0);
            }
            else if (imagesLoaded == true && frmSplashScreen.CPlayer.Parallax == false)
            {
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_3, 0, 60);
                e.Graphics.DrawImage(layer_3, 0, 60);
                e.Graphics.DrawImage(layer_4, 0, 0);
                e.Graphics.DrawImage(layer_4, 0, 0);
            }
        }
        public void ApplyAchievements()
        { // Checks if the achievement has been obtained or not and sets the achievement images accordingly
            if (frmSplashScreen.AchievementManager.IsAchievementCompleted(frmSplashScreen.CPlayer.PlayerId, 1))
            {
                pAchievementOne.BackgroundImage = Resources.Achieve1;
                pTreeOne.BackgroundImage = Resources.TreeTrue;
            }
            else
            {
                pAchievementOne.BackgroundImage = Resources.Achieve1False;
                pTreeOne.BackgroundImage = Resources.TreeFalse;
            }
            if (frmSplashScreen.AchievementManager.IsAchievementCompleted(frmSplashScreen.CPlayer.PlayerId, 2))
            {
                pAchievementTwo.BackgroundImage = Resources.Achieve2;
                pTreeTwo.BackgroundImage = Resources.TreeTrue;
            }
            else
            {
                pAchievementTwo.BackgroundImage = Resources.Achieve2False;
                pTreeTwo.BackgroundImage = Resources.TreeFalse;
            }
            if (frmSplashScreen.AchievementManager.IsAchievementCompleted(frmSplashScreen.CPlayer.PlayerId, 3))
            {
                pAchievementThree.BackgroundImage = Resources.Achieve3;
                pTreeThree.BackgroundImage = Resources.TreeTrue;
            }
            else
            {
                pAchievementThree.BackgroundImage = Resources.Achieve3False;
                pTreeThree.BackgroundImage = Resources.TreeFalse;
            }
            if (frmSplashScreen.AchievementManager.IsAchievementCompleted(frmSplashScreen.CPlayer.PlayerId, 4))
            {
                pAchievementFour.BackgroundImage = Resources.Achieve4;
                pTreeFour.BackgroundImage = Resources.TreeTrue;
            }
            else
            {
                pAchievementFour.BackgroundImage = Resources.Achieve4False;
                pTreeFour.BackgroundImage = Resources.TreeFalse;
            }
            if (frmSplashScreen.AchievementManager.IsAchievementCompleted(frmSplashScreen.CPlayer.PlayerId, 5))
            {
                pAchievementFive.BackgroundImage = Resources.Achieve5;
                pTreeFive.BackgroundImage = Resources.TreeTrue;
            }
            else
            {
                pAchievementFive.BackgroundImage = Resources.Achieve5False;
                pTreeFive.BackgroundImage = Resources.TreeFalse;
            }
        }
        private void frmAchievements_Load(object sender, EventArgs e)
        { // Loads custom Andy Bold font and sets imagesLoaded to be true
            imagesLoaded = true;
            LoadCustomFont();
            // Call ApplyFont method on all labels
            ApplyFont(font, lbQuizAchiever, 12);
            ApplyFont(font, lbQuizAchieverTitle, 12);
            ApplyFont(font, lbQuizmasterConqueror, 12);
            ApplyFont(font, lbQuizmasterConquerorTitle, 12);
            ApplyFont(font, lbBossVanquisher, 12);
            ApplyFont(font, lbBossVanquisherTitle, 12);
            ApplyFont(font, lbArmsMaestro, 12);
            ApplyFont(font, lbArmsMaestroTitle, 12);
            ApplyFont(font, lbCitizenScholar, 12);
            ApplyFont(font, lbCitizenScholarTitle, 12);
            ApplyFont(font, lbAchievements, 14);
        }
        // Method to translate text
        private void translate()
        {
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                // Checking what language the user has selected and applying accordingly
                lbQuizAchiever.Text = frmSplashScreen.Translator.TranslateText(lbQuizAchiever.Text, "en", frmSplashScreen.CPlayer.Language);
                lbQuizAchieverTitle.Text = frmSplashScreen.Translator.TranslateText(lbQuizAchieverTitle.Text, "en", frmSplashScreen.CPlayer.Language);
                lbQuizmasterConqueror.Text = frmSplashScreen.Translator.TranslateText(lbQuizmasterConqueror.Text, "en", frmSplashScreen.CPlayer.Language);
                lbQuizmasterConquerorTitle.Text = frmSplashScreen.Translator.TranslateText(lbQuizmasterConquerorTitle.Text, "en", frmSplashScreen.CPlayer.Language);
                lbBossVanquisher.Text = frmSplashScreen.Translator.TranslateText(lbBossVanquisher.Text, "en", frmSplashScreen.CPlayer.Language);
                lbBossVanquisherTitle.Text = frmSplashScreen.Translator.TranslateText(lbBossVanquisherTitle.Text, "en", frmSplashScreen.CPlayer.Language);
                lbArmsMaestro.Text = frmSplashScreen.Translator.TranslateText(lbArmsMaestro.Text, "en", frmSplashScreen.CPlayer.Language);
                lbArmsMaestroTitle.Text = frmSplashScreen.Translator.TranslateText(lbArmsMaestroTitle.Text, "en", frmSplashScreen.CPlayer.Language);
                lbCitizenScholar.Text = frmSplashScreen.Translator.TranslateText(lbCitizenScholar.Text, "en", frmSplashScreen.CPlayer.Language);
                lbCitizenScholarTitle.Text = frmSplashScreen.Translator.TranslateText(lbCitizenScholarTitle.Text, "en", frmSplashScreen.CPlayer.Language);
            }
        }
    }
}

