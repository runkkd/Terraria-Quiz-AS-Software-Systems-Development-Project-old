using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using static TerrariaQuiz.EasyQuestionsManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmQuestionsEasy : Form
    {
        // Importing method from gdi32.dll to add font from memory
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv,[In] ref uint pcFonts);
        FontFamily ff;
        Font font;

        // Private variables for font handling and animation
        int score = 0;
        int qNum = 0;
        List<EasyQuestionsManager.QuestionBase> questionInfo;
        string correct;
        string answerGiven;
        string time = "Time Remaining: ";
        string scoree = "Score: ";
        bool imagesLoaded = false;
        private int _time = 60;
        Image layer_1;
        Image layer_2;
        Image layer_3;
        Image layer_4;
        Image layer_5;
        public frmQuestionsEasy()
        { // Setting up program
            InitializeComponent();
            CenterToScreen();
            SetupTimer();
            // Set up Questions initially
            setUpQuestion();
            // Parenting the controls that need to be made transparent to the background picturebox and setting their backcolor to transparent
            lbQuestionNum.Parent = panel1;
            pFeedback.BackColor = Color.Transparent; lbVersion.BackColor = Color.Transparent; btnHelp.BackColor = Color.Transparent; lbTime.BackColor = Color.Transparent; rb1.BackColor = Color.Transparent; rb2.BackColor = Color.Transparent; rb3.BackColor = Color.Transparent; rb4.BackColor = Color.Transparent; lbQuestion.BackColor = Color.Transparent; lbQuestionNum.BackColor = Color.Transparent; lbScore.BackColor = Color.Transparent; lbAnswer.BackColor = Color.Transparent;
            // Changing form text to display Terraria Quiz and the splash text
            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;
            this.DoubleBuffered = true;
        }
        private void loadFont()
        { // loading the font terraria uses
            byte[] fontArray = Resources.ANDYB;
            int dataLength = Resources.ANDYB.Length;
            // Checking to see if it can get enough bytes of memory for the font and creates a pointer to point to the first location of the memory
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            // Allows it to copy the amount of bytes in the array
            Marshal.Copy(fontArray,0,ptrData,dataLength);

            uint cFonts = 0;
            // Converts data into a font
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddMemoryFont(ptrData,dataLength);
            // Freeing the memory to stop memory leaks
            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Bold);
        }
        private void ApplyFont(Font f, Control c,float size)
        { // Allocates the font
            FontStyle fontStyle = FontStyle.Regular;

            c.Font = new Font(ff, size, fontStyle);
        }

        // Method to set up the current question
        private void setUpQuestion()
        {
            // Switch to check which question topic the player has chosen and update accordingly
            switch (frmSplashScreen.CPlayer.Type)
            {
                case 1:
                    questionInfo = frmSplashScreen.EasyQuestionsManager.GetRandomQuestions(QuestionType.bosses);
                    layer_1 = Resources.BackgroundCrimsonHillsLarge;
                    layer_2 = Resources.MiddlegroundCrimsonHillsLarge;
                    layer_3 = Resources.ForegroundCrimsonFieldLarge;
                    layer_4 = Resources.ForegroundCrimsonFieldLarge2;
                    layer_5 = Resources.ForegroundCrimsonFieldLarge3;
                    this.BackgroundImage = Resources.SkyCrimson;
                    imagesLoaded = true;
                    panel1.BackColor = Color.FromArgb(32, 2, 3);
                    btnCheck.BackColor = Color.FromArgb(32, 2, 3);
                    break;
                case 2:
                    questionInfo = frmSplashScreen.EasyQuestionsManager.GetRandomQuestions(QuestionType.weapons);
                    layer_1 = Resources.BackgroundMushroomLarge;
                    layer_2 = Resources.MiddlegroundMushroomLarge;
                    layer_3 = Resources.ForegroundMushroomLarge;
                    layer_4 = Resources.ForegroundMushroomLarge2;
                    layer_5 = Resources.ForegroundMushroomLarge3;
                    this.BackgroundImage = Resources.SkyMushroom;
                    imagesLoaded = true;
                    panel1.BackColor = Color.FromArgb(26, 62, 106);
                    btnCheck.BackColor = Color.FromArgb(26, 62, 106);
                    break; 
                case 3:
                    questionInfo = frmSplashScreen.EasyQuestionsManager.GetRandomQuestions(QuestionType.npcs);
                    layer_1 = Resources.BackgroundSnowLarge;
                    layer_2 = Resources.MiddlegroundCloudLarge;
                    layer_3 = Resources.ForegroundCloudLarge;
                    layer_4 = Resources.ForegroundSnowLarge2;
                    layer_5 = Resources.ForegroundTreesLarge3;
                    this.BackgroundImage = Resources.Sky;
                    imagesLoaded = true;
                    panel1.BackColor = Color.FromArgb(124, 190, 249);
                    btnCheck.BackColor = Color.FromArgb(124, 190, 249);
                    break;
            }
            // Calling next question method
            nextQuestion();
        }

        // Method to update text controls with the new question data
        private void nextQuestion()
        {
            // Checking if the player isn't on the last question if they are then showing the next question level
            if (qNum < 3)
            {
                pFeedback.Visible = false;
                // Assign the question and answer text to the forms and updates answer label
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                lbQuestion.Text = questionInfo[qNum].QuestionText;
                rb1.Text = questionInfo[qNum].Answer1;
                rb2.Text = questionInfo[qNum].Answer2;
                rb3.Text = questionInfo[qNum].Answer3;
                rb4.Text = questionInfo[qNum].Answer4;
                lbAnswer.Visible = false;
                correct = questionInfo[qNum].CorrectAnswer;
                lbAnswer.Text = "The correct answer is " + questionInfo[qNum].CorrectAnswer;
                // Translating new question info
                translate();
            }
            else if (qNum == 3)
            {
                // Showing next question
                ShowNextQuestion();
            }
        }
        private void playAudioHover() // set up to play the click sound played when buttons are hovered over like actual Terraria buttons do
        {
            SoundPlayer click = new SoundPlayer(Resources.MenuClick);
            click.Play();
        }
        private void playSoundCorrect() // set up to play the correct sound played when the right answer is given
        {
            SoundPlayer wrong = new SoundPlayer(Resources.Ding___Sound_Effect__HD_);
            wrong.Play();
        }
        private void playSoundIncorrect() // set up to play the incorrect sound played when the wrong answer is given
        {
            SoundPlayer right = new SoundPlayer(Resources.Buzzer_Wrong_Answer___Sound_Effect__HD_);
            right.Play();
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
        private void SetupTimer()
        { // Starts the timer and sets it to tick once a second
            tmTime.Interval = 1000;
            tmTime.Start();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        { // Checks to see if the correct answer has been given and provides feedback if wrong or right and updates question number and calls method to display the next question
            if (rb1.Checked || rb2.Checked || rb3.Checked || rb4.Checked)
            {
                btnCheck.Visible = false;
                btnCheck.Enabled = false;
                tmTime.Stop();
                if (rb1.Checked == true)
                { answerGiven = rb1.Text; }
                else if (rb2.Checked == true)
                { answerGiven = rb2.Text; }
                else if (rb3.Checked == true)
                { answerGiven = rb3.Text; }
                else if (rb4.Checked == true)
                { answerGiven = rb4.Text; }
                // If the answer is correct
                if (answerGiven == correct)
                {
                    pFeedback.Visible = true;
                    pFeedback.BackgroundImage = Resources.correct;
                    score++;
                    lbScore.Text = scoree + score;
                    playSoundCorrect();
                }
                else
                {
                    pFeedback.Visible = true;
                    pFeedback.BackgroundImage = Resources.Incorrect;
                    playSoundIncorrect();
                }
                // Show the correct answer
                lbAnswer.Visible = true;
                // Wait for 1.5 seconds
                Task.Delay(1500).Wait();
                // Goes to next question if not on question 3 (last question), and starts the timer again after it's loaded and re-enables buttons
                if (qNum < 3)
                {
                    qNum++;
                    if (qNum == 4)
                    {
                        lbQuestionNum.Text = "Question " + qNum;
                    }
                    else
                    {
                        lbQuestionNum.Text = "Question " + (qNum + 1);
                    }

                    // Calling next question method
                    nextQuestion();
                }
                else
                {
                    btnCheck.Enabled = false;
                }
                if (qNum != 3)
                {
                    btnCheck.Enabled = true;
                    btnCheck.Visible = true;
                    tmTime.Start();
                }
            }
            else
            {
                MessageBox.Show("Please select an answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        { // Everytime the timer ticks the progress bars value increases until it reaches its maximum and calls the next question or stops timer when all questions are complete
            _time--;
            pgbTime.Value += 1;
            if (pgbTime.Value == pgbTime.Maximum)
            {
                tmTime.Stop();
                rb1.Enabled = false; rb2.Enabled = false; rb3.Enabled = false; rb4.Enabled = false;
                Task.Delay(50).Wait();
                setValues();
                ShowNextQuestion();
            }
            lbTime.Text = time + (_time + 1);
        }
        private void setValues()
        { // Sets the players score
            for (int i = 0; i < score; i++)
            {
                frmSplashScreen.CPlayer.Score += 1;
            }
        }
        private void ShowNextQuestion()
        { // Shows the next form when all questions are complete
            tmParralax.Stop();
            frmSplashScreen.CPlayer.Score = score;
            frmSplashScreen.AccountManager.ChangeScore(frmSplashScreen.CPlayer.PlayerId, frmSplashScreen.CPlayer.Score);
            new frmBossQuestionsNormal().Show();
            Hide();
            tmTime.Stop();
        }

        // Event handler for help button being clicked
        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Showing help form and subscribing events
            frmHelp formHelp = new frmHelp();
            formHelp.FormHelpShown += frmHelp_FormShown;
            formHelp.FormHelpClosed += frmHelp_FormClosed;
            formHelp.Show();
        }

        // Event handler for form closing
        private void frmHelp_FormShown(object sender, EventArgs e)
        {
            // This method will be called when frmHelp is shown
            Hide();
            tmTime.Stop();
            btnHelp.Enabled = false;
        }

        // Event handler for form closing
        private void frmHelp_FormClosed(object sender, EventArgs e)
        {
            // This method will be called when frmHelp is closed
            this.Show();
            tmTime.Start();
            btnHelp.Enabled = true;
        }

        // Event handler for form being loaded
        private void frmQuestionsEasy_Load(object sender, EventArgs e)
        {
            // Starting parallax timer to create parallax moving background effect
            tmParralax.Start();
            // Changing the version text when form is loaded
            lbVersion.Text = Version.version;
            // Loading custom font and applying it to text controls
            loadFont();
            ApplyFont(font, this.lbAnswer, 16);
            ApplyFont(font, this.lbQuestion, 16);
            ApplyFont(font, this.lbQuestionNum, 13);
            ApplyFont(font, this.lbScore, 14);
            ApplyFont(font, this.lbTime, 14);
            ApplyFont(font, this.lbVersion, 13);
            ApplyFont(font, this.rb1, 18);
            ApplyFont(font, this.rb2, 18);
            ApplyFont(font, this.rb3, 18);
            ApplyFont(font, this.rb4, 18);
            ApplyFont(font, this.btnCheck, 18);
            ApplyFont(font, this.btnHelp, 16);
        }

        // Method to translate text
        private void translate()
        {
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                // Checking what language the user has selected and applying accordingly
                correct = frmSplashScreen.Translator.TranslateText(correct, "en", frmSplashScreen.CPlayer.Language);
                lbAnswer.Text = frmSplashScreen.Translator.TranslateText("The correct answer is " + correct, "en", frmSplashScreen.CPlayer.Language);
                lbQuestion.Text = frmSplashScreen.Translator.TranslateText(lbQuestion.Text, "en", frmSplashScreen.CPlayer.Language);
                lbQuestionNum.Text = frmSplashScreen.Translator.TranslateText(lbQuestionNum.Text, "en", frmSplashScreen.CPlayer.Language);
                scoree = frmSplashScreen.Translator.TranslateText(scoree, "en", frmSplashScreen.CPlayer.Language);
                time = frmSplashScreen.Translator.TranslateText(time, "en", frmSplashScreen.CPlayer.Language);
                lbVersion.Text = frmSplashScreen.Translator.TranslateText(lbVersion.Text, "en", frmSplashScreen.CPlayer.Language);
                rb1.Text = frmSplashScreen.Translator.TranslateText(rb1.Text, "en", frmSplashScreen.CPlayer.Language);
                rb2.Text = frmSplashScreen.Translator.TranslateText(rb2.Text, "en", frmSplashScreen.CPlayer.Language);
                rb3.Text = frmSplashScreen.Translator.TranslateText(rb3.Text, "en", frmSplashScreen.CPlayer.Language);
                rb4.Text = frmSplashScreen.Translator.TranslateText(rb4.Text, "en", frmSplashScreen.CPlayer.Language);
                btnCheck.Text = frmSplashScreen.Translator.TranslateText(btnCheck.Text, "en", frmSplashScreen.CPlayer.Language);
                btnHelp.Text = frmSplashScreen.Translator.TranslateText(btnHelp.Text, "en", frmSplashScreen.CPlayer.Language);
            }
        }

        // Event handler for parallax timer ticking
        private void tmParralax_Tick(object sender, EventArgs e)
        {
            // Calling method to move background to create parallax moving background effect
            background_move();
        }

        // Variables for animation handling
        int b1 = 0, b2 = 816, x1 = 0, x2 = 816, g1 = 0, g2 = 816, h1 = 0, h2 = 816, t1 = 0, t2 = 816;

        // Method to create parallax moving background effect
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
            g2 -= 3;
            g1 -= 3;
            if (g2 < -816)
            {
                g2 = 809;
            }
            if (h1 < -816)
            {
                h1 = 809;
            }
            h2 -= 4;
            h1 -= 4;
            if (h2 < -816)
            {
                h2 = 809;
            }

            if (t1 < -816)
            {
                t1 = 809;
            }
            t2 -= 5;
            t1 -= 5;
            if (t2 < -816)
            {
                t2 = 809;
            }
            // Trigger a repaint of the form
            Invalidate();
        }

        // Event handler for form being painted
        private void frmQuestionsEasy_Paint(object sender, PaintEventArgs e)
        {
            // Creating moving parallax effect or just painting on background image instead depending on if parallax is enabled or not
            if (imagesLoaded == true && frmSplashScreen.CPlayer.Parallax == true)
            {
                e.Graphics.DrawImage(layer_1, b1, 57);
                e.Graphics.DrawImage(layer_1, b2, 57);
                e.Graphics.DrawImage(layer_2, x1, 57);
                e.Graphics.DrawImage(layer_2, x2, 57);
                e.Graphics.DrawImage(layer_3, g1, 57);
                e.Graphics.DrawImage(layer_3, g2, 57);
                e.Graphics.DrawImage(layer_4, h1, 57);
                e.Graphics.DrawImage(layer_4, h2, 57);
                e.Graphics.DrawImage(layer_5, t1, 57);
                e.Graphics.DrawImage(layer_5, t2, 57);
            }
            else if (imagesLoaded == true && frmSplashScreen.CPlayer.Parallax == false)
            {
                e.Graphics.DrawImage(layer_1, 0, 57);
                e.Graphics.DrawImage(layer_1, 0, 57);
                e.Graphics.DrawImage(layer_2, 0, 57);
                e.Graphics.DrawImage(layer_2, 0, 57);
                e.Graphics.DrawImage(layer_3, 0, 57);
                e.Graphics.DrawImage(layer_3, 0, 57);
                e.Graphics.DrawImage(layer_4, 0, 57);
                e.Graphics.DrawImage(layer_4, 0, 57);
                e.Graphics.DrawImage(layer_5, 0, 57);
                e.Graphics.DrawImage(layer_5, 0, 57);
            }
        }
    }
}
