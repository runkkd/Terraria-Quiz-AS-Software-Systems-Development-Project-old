using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;


// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmStart : Form
    {
        // Importing method from gdi32.dll to add font from memory
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        private FontFamily ff;
        private Font font;
        
        // Private variables for font handling and animation
        Random rnd = new Random();
        Image layer_1 = Resources.BackgroundMountain3;
        Image layer_2 = Resources.MiddlegroundHills;
        Image layer_3 = Resources.ForegroundLake;
        Image layer_Clouds = Resources.Clouds;
        Image layer_Sun = Resources.Sun;
        Image logo = Resources.Terraria_Logo;
        Image airship1 = Resources.Air1;
        Image airship2 = Resources.Air2;
        Image airship3 = Resources.Air3;
        Image airship4 = Resources.Air4;
        Image airship = Resources.Air1;
        SoundPlayer openStart = new SoundPlayer(Resources.OpenStart);
        bool imagesLoaded = false;
        int turns = 1;
        private double angle;
        private Timer pulseTimer;
        private Timer rotateTimer;
        private int pulseCount = 0;
        private float rotationAngle = 0f;
        private float rotationSpeed = .01f; 
        private int rotationDirection = 1;
        public frmStart()
        { // Setting up program
            InitializeComponent();
            CenterToScreen();
            this.DoubleBuffered = true;
            {
                // Setting controls backcolor to transparent and starting timer
                btnLogout.BackColor = Color.Transparent; btnSettings.BackColor = Color.Transparent; btnStartQuiz.BackColor = Color.Transparent; btnHelp.BackColor = Color.Transparent; btnExit.BackColor = Color.Transparent; lbVersion.BackColor = Color.Transparent; tmParralax.Start();
                btnAchievements.BackColor = Color.Transparent; btnStartQuiz.FlatAppearance.MouseDownBackColor = Color.Transparent; btnStartQuiz.FlatAppearance.MouseOverBackColor = Color.Transparent; btnHelp.FlatAppearance.MouseDownBackColor = Color.Transparent; btnHelp.FlatAppearance.MouseOverBackColor = Color.Transparent; btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent; btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent; btnAchievements.FlatAppearance.MouseDownBackColor = Color.Transparent; btnAchievements.FlatAppearance.MouseOverBackColor = Color.Transparent;
            }
            // Initialize and start the pulse timer
            pulseTimer = new Timer();
            pulseTimer.Interval = 15; // Adjust as needed for desired pulsation speed
            pulseTimer.Tick += PulseTimer_Tick;
            pulseTimer.Start();

            // Initialize and start the rotation timer
            rotateTimer = new Timer();
            rotateTimer.Interval = 2; // Adjust as needed for desired rotation speed
            rotateTimer.Tick += RotateTimer_Tick;
            rotateTimer.Start();
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
        private void PulseTimer_Tick(object sender, EventArgs e)
        {
            // Update pulsation factor (scaling)
            pulseCount++;
            Invalidate(); // Trigger form redraw
        }

        private void RotateTimer_Tick(object sender, EventArgs e)
        {
            // Update rotation angle
            rotationAngle += rotationSpeed * rotationDirection; // Adjust the rotation speed as needed
            if (rotationAngle >= 15 || rotationAngle <= -15)
            {
                // Change the rotation direction immediately
                rotationDirection *= -1;
            }
            Invalidate(); // Trigger form redraw
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
        int b1 = 0, b2 = 816, x1 = 0, x2 = 816, g1 = 0, g2 = 816, a1 = 0,t1 = 0, t2 = 816, s1 = 0, s2 = 0;
        void background_move()
        {
            /*
            * Moving each background layer horizontally
            * Resetting positions when they go off - screen
            * Invalidating the form to trigger repaint
            * This creates a parallax effect 
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
            if (a1 > 2500)
            {
                a1 = -100;
            }
            a1 += 1; 
            if (t1 < -816)
            {
                t1 = 809;
            }
            t2 -= 3;
            t1 -= 3;
            if (t2 < -816)
            {
                t2 = 809;
            }
            // Calculate the position of the sun in an orbit
            int orbitRadius = 450;
            int centerX = Width / 2;
            int centerY = Height;

            // Calculate new position
            int newX = centerX + (int)(orbitRadius * Math.Cos(angle));
            int newY = centerY + (int)(orbitRadius * Math.Sin(angle));

            // Set the sun's location
            s1 = (newX - 40 / 2);
            s2 = (newY - 40 / 2);

            // Increment the angle for the next position
            angle += 0.005; // Adjust the increment for the speed of orbit

            // Keep the angle within a reasonable range
            if (angle >= 2 * Math.PI)
            {
                angle = 0;
            }

            // Trigger a repaint of the form
            Invalidate();
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

        // Event handler for form load
        private void frmStart_Load(object sender, EventArgs e)
        {
            // Changing the version text when form is loaded
            LoadFont();
            lbVersion.Text = Version.version;
            ApplyFont(font, this.btnStartQuiz, 22);
            ApplyFont(font, this.btnHelp, 22);
            ApplyFont(font, this.btnExit, 22);
            ApplyFont(font, this.btnAchievements, 22);
            ApplyFont(font, this.btnSettings, 22);
            ApplyFont(font, this.btnLogout, 18);
            ApplyFont(font, this.lbVersion, 13);

            // Changing form text to display Terraria Quiz and the splash text
            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;

            int ran = rnd.Next(0, 3);
            switch (ran)
            { // Switch to get layer 1
                case 0:
                    layer_1 = Resources.BackgroundMountain1;
                    break;
                case 1:
                    layer_1 = Resources.BackgroundMountain2;
                    break;
                case 2:
                    layer_1 = Resources.BackgroundMountain3;
                    break;
            }
            ran = rnd.Next(0, 4);
            switch (ran)
            { // Switch to get layer 2
                case 0:
                    layer_2 = Resources.MiddlegroundMountains;
                    break;
                case 1:
                    layer_2 = Resources.MiddlegroundPineTrees;
                    break;
                case 2:
                    layer_2 = Resources.MiddlegroundPineTrees2;
                    break;
                case 3:
                    layer_2 = Resources.MiddlegroundHills;
                    break;
            }
            ran = rnd.Next(0, 4);
            switch (ran)
            { // Switch to get layer 3
                case 0:
                    layer_3 = Resources.ForegroundHills;
                    break;
                case 1:
                    layer_3 = Resources.ForegroundPineTrees;
                    break;
                case 2:
                    layer_3 = Resources.ForegroundSmallMountains;
                    break;
                case 3:
                    layer_3 = Resources.ForegroundLake;
                    break;
            }
            imagesLoaded = true;
        }

        // Event handler for airship animation timer tick
        private void tmAirship_Tick(object sender, EventArgs e)
        {
            if (frmSplashScreen.CPlayer.Parallax == true)
            {
                switch (turns)
                { // Switch to animate airship
                    case 1:
                        airship = airship1;
                        break;
                    case 2:
                        airship = airship2;
                        break;
                    case 3:
                        airship = airship3;
                        break;
                    case 4:
                        airship = airship4;
                        break;
                }
                turns++;
                if (turns == 5)
                { // Restarts animation when it reaches the end to loop it
                    turns = 1;
                }
            }
        }

        // Event handler for form closing
        private void frmStart_FormClosing(object sender, FormClosingEventArgs e)
        { // Stops animations to prevent choppy animations on other forms
            tmAirship.Stop();
            tmParralax.Stop();
        }
        // Event handler for settings button being clicked
        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Opening settings form
            frmSplashScreen.formSettings.Show();
            this.Hide();
        }

        // Event Handler for form's visibility being changed
        private void frmStart_VisibleChanged(object sender, EventArgs e)
        {
            // If the form is being shown then the text is translated
            if (this.Visible == true)
            {
                translate();
            }
        }

        // Method to translate text
        private void translate()
        {
            // Checking what language the user has selected and applying accordingly
            switch (frmSplashScreen.CPlayer.Language)
            {
                case "en":
                    btnStartQuiz.Text = "Start Quiz";
                    btnAchievements.Text = "Achievements";
                    btnHelp.Text = "Help";
                    btnSettings.Text = "Settings";
                    btnExit.Text = "Exit";
                    break;
                case "es":
                    btnStartQuiz.Text = frmSplashScreen.Translator.TranslateText("Start Quiz", "en", "es");
                    btnAchievements.Text = frmSplashScreen.Translator.TranslateText("Achievements", "en", "es");
                    btnHelp.Text = frmSplashScreen.Translator.TranslateText("Help", "en", "es");
                    btnSettings.Text = frmSplashScreen.Translator.TranslateText("Settings", "en", "es");
                    btnExit.Text = frmSplashScreen.Translator.TranslateText("Exit", "en", "es");
                    break;
                case "fr":
                    btnStartQuiz.Text = frmSplashScreen.Translator.TranslateText("Start Quiz", "en", "fr");
                    btnAchievements.Text = frmSplashScreen.Translator.TranslateText("Achievements", "en", "fr");
                    btnHelp.Text = frmSplashScreen.Translator.TranslateText("Help", "en", "fr");
                    btnSettings.Text = frmSplashScreen.Translator.TranslateText("Settings", "en", "fr");
                    btnExit.Text = frmSplashScreen.Translator.TranslateText("Exit", "en", "fr");
                    break;
                case "de":
                    btnStartQuiz.Text = frmSplashScreen.Translator.TranslateText("Start Quiz", "en", "de");
                    btnAchievements.Text = frmSplashScreen.Translator.TranslateText("Achievements", "en", "de");
                    btnHelp.Text = frmSplashScreen.Translator.TranslateText("Help", "en", "de");
                    btnSettings.Text = frmSplashScreen.Translator.TranslateText("Settings", "en", "de");
                    btnExit.Text = frmSplashScreen.Translator.TranslateText("Exit", "en", "de");
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmSplashScreen.formLogin.Show();
            this.Hide();
            frmSplashScreen.CPlayer = new PlayerJson();
        }

        // Event handler for achievements button click
        private void btnAchievements_Click(object sender, EventArgs e)
        {
            // Opens frmAchievements and subscribes event handlers
            frmAchievements formAchieve = new frmAchievements();
            formAchieve.FormAchieveShown += frmAchievements_FormShown;
            formAchieve.FormAchieveClosed += frmAcvievements_FormClosed;
            formAchieve.Show();
        }

        // Event handler for start quiz button click
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            // Brings the user to the beginning of the quiz when clicked and plays the menu opening sound from Terraria
            openStart.Play();
            tmParralax.Stop();
            frmSplashScreen.formType.Show();
            Close();
        }

        // Event handler for form paint
        private void frmStart_Paint(object sender, PaintEventArgs e)
        {
            // Creating moving parallax effect or just painting on background image instead depending on if parallax is enabled or not
            if (imagesLoaded == true && frmSplashScreen.CPlayer.Parallax == true)
            {
                // Draws background layers, sun, airship, and logo
                e.Graphics.DrawImage(layer_Sun, s1, s2);
                e.Graphics.DrawImage(layer_1, b1, 0);
                e.Graphics.DrawImage(layer_1, b2, 0);
                e.Graphics.DrawImage(layer_Clouds, t1, 0);
                e.Graphics.DrawImage(layer_Clouds, t2, 0);
                e.Graphics.DrawImage(layer_2, x1, 0);
                e.Graphics.DrawImage(layer_2, x2, 0);
                e.Graphics.DrawImage(layer_3, g1, 0);
                e.Graphics.DrawImage(layer_3, g2, 0);
                e.Graphics.DrawImage(airship, a1, 36);

             // Calculate the position and size of the logo
             int logoWidth = logo.Width;
             int logoHeight = logo.Height;
             int logoX = 275;
             int logoY = 27;

             // Apply pulsation and rotation transformations to logo
             e.Graphics.TranslateTransform(logoX + logoWidth / 2, logoY + logoHeight / 2);
             e.Graphics.ScaleTransform(1.0f + (float)Math.Sin(pulseCount * Math.PI / 400) * 0.2f, 1.0f + (float)Math.Sin(pulseCount * Math.PI / 400) * 0.2f); // Pulsate between 0.9x and 1.1x

             // Calculate limited rotation angle
             float limitedRotationAngle = (float)Math.Sin(rotationAngle * Math.PI / 180); // Convert to radians 
            
            if (limitedRotationAngle > 0.1745) // Approximately equivalent to 10 degrees in radians
            { limitedRotationAngle = 0.1745f; }// Cap at approximately 10 degrees
            else if (limitedRotationAngle < -0.1745)
            { limitedRotationAngle = -0.1745f; } // Cap at approximately -10 degrees

            e.Graphics.RotateTransform(limitedRotationAngle * 180 / (float)Math.PI); // Convert back to degrees
            // Draw the logo
            e.Graphics.DrawImage(logo, -logoWidth / 2, -logoHeight / 2, logoWidth, logoHeight);
            }
            else if (frmSplashScreen.CPlayer.Parallax == false)
            {
                // Draws background layers, sun, airship, and logo
                e.Graphics.DrawImage(layer_Sun, 0, 0);
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_Clouds, 0, 0);
                e.Graphics.DrawImage(layer_Clouds, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_3, 0, 0);
                e.Graphics.DrawImage(layer_3, 0, 0);
                e.Graphics.DrawImage(airship, 10, 36);
                e.Graphics.DrawImage(logo, 275, 27);
            }
        }

        // Event handler for background movement timer tick
        private void tmParralax_Tick(object sender, EventArgs e)
        {
            background_move();
        }
        // Event handler to Open frmAchievements and subscribes event handlers
        private void btnHelp_Click(object sender, EventArgs e)
        { 
            // Showing the help form and subscribing events
            frmHelp formHelp = new frmHelp();
            formHelp.FormHelpShown += frmHelp_FormShown;
            formHelp.FormHelpClosed += frmHelp_FormClosed;
            formHelp.Show();
        }

        // Event handler for form closing
        private void frmHelp_FormShown(object sender, EventArgs e)
        {
            // This method will be called when frmHelp is shown and disables the help button
            btnHelp.Enabled = false;
        }

        // Event handler for form closing
        private void frmHelp_FormClosed(object sender, EventArgs e)
        {
            // This method will be called when frmHelp is closed and enables the help button
            btnHelp.Enabled = true;
        }

        // Event handler for form closing
        private void frmAchievements_FormShown(object sender, EventArgs e)
        {
            // This method will be called when achievements is shown
            btnAchievements.Enabled = false;
        }

        // Event handler for form closing
        private void frmAcvievements_FormClosed(object sender, EventArgs e)
        {
            // This method will be called when frmAchievements is closed
            btnAchievements.Enabled = true;
        }

        // Event handler for exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the program when clicked and dialog option "Yes" is chosen
            if (MessageBox.Show("Are you sure you want to close Terraria Quiz?", "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}