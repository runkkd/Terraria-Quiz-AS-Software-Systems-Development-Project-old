
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Cryptography;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmHelp : Form
    {
        // Importing method from gdi32.dll to add font from memory
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;

        // Events used for disabling and enabling help button when form is shown or invisible
        public event EventHandler FormHelpShown;
        public event EventHandler FormHelpClosed; 

        // Variables for animation
        Image layer_1 = Resources.BackgroundHell2;
        Image layer_2 = Resources.BackgroundHell;
        Image layer_3 = Resources.MiddlegroundHell;
        Image layer_4 = Resources.ForegroundHell;
        bool imagesLoaded = false;
        public frmHelp()
        {
            // Setting up program and Event Handlers
            InitializeComponent();
            CenterToScreen();
            this.Shown += frmHelp_Shown;
            this.FormClosed += frmHelp_FormClosed;

            // Parenting the controls that need to be made transparent to the background picturebox and setting their backcolor to transparent
            lbVersion.BackColor = Color.Transparent; btnViewInfoHelp.BackColor = Color.Transparent; btn5thQuesHelp.BackColor = Color.Transparent; btn4thQuesHelp.BackColor = Color.Transparent; btn3rdQuesHelp.BackColor = Color.Transparent; btnExit.BackColor = Color.Transparent; btnSecondQuesHelp.BackColor = Color.Transparent; btnFirstQuesHelp.BackColor = Color.Transparent; pTitle.BackColor = Color.Transparent; btnStartHelp.BackColor = Color.Transparent; lbTitle.BackColor = Color.Transparent; btnQuestionPickerHelp.BackColor = Color.Transparent;
           
            // Changing form text to display Terraria Quiz + the splash text and turning on DoubleBuffered to help animation smoothing
            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;
            this.DoubleBuffered = true;
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

        // Variables for parallax affect
        int b1 = 0, b2 = 681, x1 = 0, x2 = 681, g1 = 0, g2 = 681, h1 = 0, h2 = 681;

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
        private void playAudioHover()
        { // set up to play the click sound played when buttons are hovered over like actual Terraria buttons do
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
        // Displays information depending on what help button was clicked
        private void HelpButton_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Tag.ToString())
            {
                case "Start":
                    // Displaying information about start screen
                    MessageBox.Show("On the start form you can either press \"Start Quiz\" to begin the quiz, \"Achievements\" to view your achievements or \"Exit\" to exit the program.", "frmStart Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case "QuestionPicker":
                    // Displaying information about question type picker screen
                    MessageBox.Show("On the question picker form you can choose between 3 question topics \"Bosses\", \"Weapons\", \"NPCs\" or \"Random\" these options will determine the topic of the questions throughout the quiz.", "frmQuestionTypeChooser Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case "1stQuestion":
                    // Displaying information about the first question
                    MessageBox.Show("On this form there are 3 multiple choice questions each containing 4 options, you will have to choose the correct option.", "frmQuestionsEasy Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case "2ndQuestion":
                    // Displaying information about the second question
                    MessageBox.Show("On this form there are 3 Drag and Drop questions each containing 6 images you will have to match the corresponding text to.", "frmQuestionsNormal Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case "3rdQuestion":
                    // Displaying information about the third question
                    MessageBox.Show("On this form there is a paragraph of text with 5 blanks, you will need to fill in the blanks with the below combo boxes.", "frmQuestionsHard Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case "4thQuestion":
                    // Displaying information about the fourth question
                    MessageBox.Show("On this form there are two list boxes randomly filled with data, each list box will have a category and you will have to sort the data into the correct category.", "frmQuestionsVeryHard Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case "5thQuestion":
                    // Displaying information about the fifth question
                    MessageBox.Show("On this form there will be video that you can start at any time, there will be a question at the top and once the video is done playing there will be 3 multiple choice answer option to the question, you can skip and replay the video as many times as needed but it is timed while the answer options are visible.", "frmQuestionsExtreme Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case "Leaderboard":
                    // Displaying information about the leaderboards
                    MessageBox.Show("On this form there are two datagrids one for viewing player information and one for viewing player achievements each of them have a variety of sorting options to percieve the data differently.", "frmViewInfo Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
        }

        private void frmHelp_Paint(object sender, PaintEventArgs e)
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
            else if (frmSplashScreen.CPlayer.Parallax == false)
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
        
        private void tmParralax_Tick(object sender, EventArgs e)
        { // Adjusts the background layers every timer tick
            background_move();
        }

        private void btnExit_Click(object sender, EventArgs e)
        { // Confirming if the user wants to exit the help form, if yes then the parallax animations are stopped and the form is closed
            if  (MessageBox.Show("Are you sure you want to exit the help form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tmParralax.Stop();
                Close();
            }
        }
        private void frmHelp_Load(object sender, EventArgs e)
        { // Loading and applying custom Andy Bold font to all text containing controls, sets lbVersion to display the current version and sets imagesLoaded to be true
            lbVersion.Text = Version.version;
            imagesLoaded = true;
            LoadCustomFont();
            ApplyFont(font, this.btnStartHelp, 13);
            ApplyFont(font, this.btnQuestionPickerHelp, 13);
            ApplyFont(font, this.btnFirstQuesHelp, 13);
            ApplyFont(font, this.btnSecondQuesHelp, 13);
            ApplyFont(font, this.btn3rdQuesHelp, 13);
            ApplyFont(font, this.btn4thQuesHelp, 13);
            ApplyFont(font, this.btn5thQuesHelp, 13);
            ApplyFont(font, this.btnViewInfoHelp, 13);
            ApplyFont(font, this.btnExit, 13);
            ApplyFont(font, this.lbVersion, 13);
            ApplyFont(font, this.lbTitle, 15);
        }
        // Method to translate text
        private void translate()
        {
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                // Checking what language the user has selected and applying accordingly
                lbVersion.Text = frmSplashScreen.Translator.TranslateText(lbVersion.Text, "en", frmSplashScreen.CPlayer.Language);
                btnStartHelp.Text = frmSplashScreen.Translator.TranslateText(btnStartHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                btnQuestionPickerHelp.Text = frmSplashScreen.Translator.TranslateText(btnQuestionPickerHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                btnFirstQuesHelp.Text = frmSplashScreen.Translator.TranslateText(btnFirstQuesHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                btnSecondQuesHelp.Text = frmSplashScreen.Translator.TranslateText(btnSecondQuesHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                btn3rdQuesHelp.Text = frmSplashScreen.Translator.TranslateText(btn3rdQuesHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                btn4thQuesHelp.Text = frmSplashScreen.Translator.TranslateText(btn4thQuesHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                btn5thQuesHelp.Text = frmSplashScreen.Translator.TranslateText(btn5thQuesHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                btnViewInfoHelp.Text = frmSplashScreen.Translator.TranslateText(btnViewInfoHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                btnExit.Text = frmSplashScreen.Translator.TranslateText(btnExit.Text, "en", frmSplashScreen.CPlayer.Language);
                lbTitle.Text = frmSplashScreen.Translator.TranslateText(lbTitle.Text, "en", frmSplashScreen.CPlayer.Language);
            }
        }

        private void frmHelp_Shown(object sender, EventArgs e)
        { // Event to tell the form to disable Help button as a help window is currently open
            FormHelpShown?.Invoke(this, EventArgs.Empty);
            tmParralax.Start();
            translate();
        }

        private void frmHelp_FormClosed(object sender, FormClosedEventArgs e)
        { // Event to tell the form to enable Help button as the help window has been closed
            FormHelpClosed?.Invoke(this, EventArgs.Empty);
            tmParralax.Stop();
        }
    }
}
