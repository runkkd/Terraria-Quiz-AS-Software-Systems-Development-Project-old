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
using System.Media;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Collections.Specialized;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmQuestionsExtreme : Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;
        private int _time = 30;
        string answerGiven = "";
        string correct = "";
        List<ExtremeQuestionsManager.QuestionBase> questionInfo = new List<ExtremeQuestionsManager.QuestionBase>();
        bool imagesLoaded = false;
        Image layer_1;
        Image layer_2;
        Image layer_3;
        Image layer_4;
        Image layer_5;
        string time = "Time Remaining: ";
        string scoree = "Score: ";
        string answerPart = "The answer is: ";
        public frmQuestionsExtreme()
        {
            // Settiing up program
            InitializeComponent();
            CenterToScreen();
            // Parenting the controls that need to be made transparent to the background picturebox and setting their backcolor to transparent
            btnHelp.BackColor = Color.Transparent; lbQuestion.BackColor = Color.Transparent; lbQuestionNum.Parent = panel1; lbQuestion.Parent = panel1; lbTime.BackColor = Color.Transparent;  lbScore.BackColor = Color.Transparent; lbQuestionNum.BackColor = Color.Transparent; lbQuestion.BackColor = Color.Transparent; lbVersion.BackColor = Color.Transparent; lbAnswer.BackColor = Color.Transparent; rb1.BackColor = Color.Transparent; rb2.BackColor = Color.Transparent; rb3.BackColor = Color.Transparent; btnPlayVideo.BackColor = Color.Transparent; btnSkip.BackColor = Color.Transparent;
            // Setting double buffered to be true for animation handling
            this.DoubleBuffered = true;
        }

        // Method to setup questions
        private void setUpQuestion()
        {
            // Switch on the question topic to load in the correct questions and set background images and colours
            switch(frmSplashScreen.CPlayer.Type)
            {
                case 1:
                    layer_1 = Resources.BackgroundCrimsonHillsLarge;
                    layer_2 = Resources.MiddlegroundCrimsonHillsLarge;
                    layer_3 = Resources.ForegroundCrimsonFieldLarge;
                    layer_4 = Resources.ForegroundCrimsonFieldLarge2;
                    layer_5 = Resources.ForegroundCrimsonFieldLarge3;
                    questionInfo.Add(frmSplashScreen.ExtremeQuestionsManager.GetRandomQuestionByType(ExtremeQuestionsManager.QuestionType.bosses));
                    this.BackgroundImage = Resources.SkyCrimson;
                    panel1.BackColor = Color.FromArgb(32, 2, 3);
                    btnCheck.BackColor = Color.FromArgb(32, 2, 3);
                    btnCheck.BackColor = Color.FromArgb(32, 2, 3);
                    break;
                case 2:
                    layer_1 = Resources.BackgroundMushroomLarge;
                    layer_2 = Resources.MiddlegroundMushroomLarge;
                    layer_3 = Resources.ForegroundMushroomLarge;
                    layer_4 = Resources.ForegroundMushroomLarge2;
                    layer_5 = Resources.ForegroundMushroomLarge3;
                    questionInfo.Add(frmSplashScreen.ExtremeQuestionsManager.GetRandomQuestionByType(ExtremeQuestionsManager.QuestionType.weapons));
                    this.BackgroundImage = Resources.SkyMushroom;
                    panel1.BackColor = Color.FromArgb(26, 62, 106);
                    btnCheck.BackColor = Color.FromArgb(26, 62, 106);
                    btnCheck.BackColor = Color.FromArgb(26, 62, 106);
                    break; 
                case 3:
                    layer_1 = Resources.BackgroundSnowLarge;
                    layer_2 = Resources.MiddlegroundCloudLarge;
                    layer_3 = Resources.ForegroundCloudLarge;
                    layer_4 = Resources.ForegroundSnowLarge2;
                    layer_5 = Resources.ForegroundTreesLarge3;
                    questionInfo.Add(frmSplashScreen.ExtremeQuestionsManager.GetRandomQuestionByType(ExtremeQuestionsManager.QuestionType.npcs));
                    this.BackgroundImage = Resources.Sky;
                    panel1.BackColor = Color.FromArgb(124, 190, 249);
                    btnCheck.BackColor = Color.FromArgb(124, 190, 249);
                    btnCheck.BackColor = Color.FromArgb(124, 190, 249);
                    break;
            }
            // Seting the windows media player to none to start with and calling the method to apply the question info to the controls and variables
            mVideo.uiMode = "none";
            NextQuestion();
        }
        // Method to translate text
        private void translate()
        {
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                // Checking what language the user has selected and applying accordingly
                lbQuestionNum.Text = frmSplashScreen.Translator.TranslateText(lbQuestionNum.Text, "en", frmSplashScreen.CPlayer.Language);
                lbQuestion.Text = frmSplashScreen.Translator.TranslateText(lbQuestion.Text, "en", frmSplashScreen.CPlayer.Language);
                lbAnswer.Text = frmSplashScreen.Translator.TranslateText(lbAnswer.Text, "en", frmSplashScreen.CPlayer.Language);
                scoree = frmSplashScreen.Translator.TranslateText(scoree, "en", frmSplashScreen.CPlayer.Language);
                time = frmSplashScreen.Translator.TranslateText(time, "en", frmSplashScreen.CPlayer.Language);
                correct = frmSplashScreen.Translator.TranslateText(correct, "en", frmSplashScreen.CPlayer.Language);
                answerPart = frmSplashScreen.Translator.TranslateText(answerPart, "en", frmSplashScreen.CPlayer.Language);
                lbVersion.Text = frmSplashScreen.Translator.TranslateText(lbVersion.Text, "en", frmSplashScreen.CPlayer.Language);
                btnHelp.Text = frmSplashScreen.Translator.TranslateText(btnHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                btnCheck.Text = frmSplashScreen.Translator.TranslateText(btnCheck.Text, "en", frmSplashScreen.CPlayer.Language);
                rb1.Text = frmSplashScreen.Translator.TranslateText(rb1.Text, "en", frmSplashScreen.CPlayer.Language);
                rb2.Text = frmSplashScreen.Translator.TranslateText(rb2.Text, "en", frmSplashScreen.CPlayer.Language);
                rb3.Text = frmSplashScreen.Translator.TranslateText(rb3.Text, "en", frmSplashScreen.CPlayer.Language);
                btnPlayVideo.Text = frmSplashScreen.Translator.TranslateText(btnPlayVideo.Text, "en", frmSplashScreen.CPlayer.Language);
                btnSkip.Text = frmSplashScreen.Translator.TranslateText(btnSkip.Text, "en", frmSplashScreen.CPlayer.Language);
            }
        }
        private void NextQuestion()
        {
            // Setting question info to controls and variables
            lbQuestion.Text = questionInfo[0].QuestionInfo[0].QuestionText;
            correct = questionInfo[0].QuestionInfo[0].CorrectAnswer;
            rb1.Text = questionInfo[0].QuestionInfo[0].Answer1;
            rb2.Text = questionInfo[0].QuestionInfo[0].Answer2;
            rb3.Text = questionInfo[0].QuestionInfo[0].Answer3;
            mVideo.URL = questionInfo[0].QuestionInfo[0].VideoFileName;
            // Stopping the windows media player to start with then calling method to translate text
            mVideo.Ctlcontrols.stop();
            translate();
        }
        private void loadFont()
        { // loading the font terraria uses
            byte[] fontArray = Resources.ANDYB;
            int dataLength = Resources.ANDYB.Length;
            // Checking to see if it can get enough bytes of memory for the font and creates a pointer to point to the first location of the memory
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            // Allows it to copy the amount of bytes in the array
            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;
            // Converts data into a font
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddMemoryFont(ptrData, dataLength);
            // Freeing the memory to stop memory leaks
            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Bold);
        }
        private void ApplyFont(Font f, Control c, float size)
        { // Allocates the font
            FontStyle fontStyle = FontStyle.Regular;

            c.Font = new Font(ff, size, fontStyle);
        }

        private void frmQuestionsTrueFalse_Load(object sender, EventArgs e)
        {
            // Calling method to setup next question then starting the parallax timer
            setUpQuestion();
            tmParralax.Start();
            // Setting variable for background images and then setting player score
            imagesLoaded = true;
            lbScore.Text = scoree + (frmSplashScreen.CPlayer.Score);
            // Changing form text to display Terraria Quiz and the splash text
            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;
            lbVersion.Text = Version.version;
            // Calling method to load custom font and applying it to certain controls
            loadFont();
            ApplyFont(font, this.lbScore, 13);
            ApplyFont(font, this.lbVersion, 13);
            ApplyFont(font, this.lbQuestionNum, 13);
            ApplyFont(font, this.lbQuestion, 16);
            ApplyFont(font, this.btnCheck, 18);
            ApplyFont(font, this.rb1, 14);
            ApplyFont(font, this.rb2, 14);
            ApplyFont(font, this.rb3, 14);
            ApplyFont(font, this.btnPlayVideo, 16);
            ApplyFont(font, this.btnSkip, 16);
            ApplyFont(font, this.lbAnswer, 18);
            ApplyFont(font, this.btnHelp, 16);
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
        private void ShowNextForm()
        { // Takes user to next form
            Task.Delay(1500).Wait();
            // code to show next form
            tmParralax.Stop();
            string toShow = (frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText($"You scored {frmSplashScreen.CPlayer.Score}/39 on the {frmSplashScreen.AccountManager.GetTopicName(frmSplashScreen.CPlayer.Type)} topic!", "en", frmSplashScreen.CPlayer.Language) : $"You scored {frmSplashScreen.CPlayer.Score}/39 on the {frmSplashScreen.AccountManager.GetTopicName(frmSplashScreen.CPlayer.Type)} topic!";
            MessageBox.Show(toShow, (frmSplashScreen.CPlayer.Language != "en") ? frmSplashScreen.Translator.TranslateText("Overview", "en",  frmSplashScreen.CPlayer.Language) : "Overview", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            frmSplashScreen.formViewInfo.Show();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Checking if the player has answered
            if (rb1.Checked || rb2.Checked || rb3.Checked)
            {
                // Setting controls for question to be disabled while changing question and checking
                btnCheck.Visible = false;
                btnCheck.Enabled = false;
                tmTime.Stop();
                if (rb1.Checked == true)
                { answerGiven = rb1.Text; }
                else if (rb2.Checked == true)
                { answerGiven = rb2.Text; }
                else if (rb3.Checked == true)
                { answerGiven = rb3.Text; }
                // If the answer is correct
                if (answerGiven == correct)
                {
                    frmSplashScreen.CPlayer.Score++;
                    lbScore.Text = scoree + frmSplashScreen.CPlayer.Score;
                    playSoundCorrect();
                }
                else
                {
                    playSoundIncorrect();
                }
                // Show the correct answer
                lbAnswer.Visible = true;
                lbAnswer.Text = answerPart + correct;
                // Wait for 1.5 seconds then calling method to show next question
                Task.Delay(1500).Wait();
                ShowNextForm();
            }
        }
        private void DisableAll()
        { 
            // Method to disable button
            btnCheck.Enabled = false;
        }
        private void tmTIme_Tick(object sender, EventArgs e)
        { // Everytime the timer ticks the progress bars value increases until it reaches its maximum and calls the next question or stops timer when all questions are complete
            _time--;
            pgbTime.Increment(1);
            if (pgbTime.Value >= pgbTime.Maximum)
            {
                tmTime.Stop();
                DisableAll();
                ShowNextForm();
            }

            lbTime.Text = time + _time;
        }
        private void tmParralax_Tick(object sender, EventArgs e)
        {
            // Calling background move method every timer tick to create parallax moving background effect
            background_move();
        }

        private void frmQuestionsExtreme_Paint(object sender, PaintEventArgs e)
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
        int b1 = 0, b2 = 816, x1 = 0, x2 = 816, g1 = 0, g2 = 816, h1 = 0, h2 = 816, t1 = 0, t2 = 816;

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Creating new instance of the help form, subscribing event handlers and showing the form
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

        private void btnSkip_Click(object sender, EventArgs e)
        {
                // Stops and resets the windows media player control
            mVideo.Ctlcontrols.stop();
            mVideo.Ctlcontrols.currentPosition = 0;
            // Disables skip button and shows controls for answering question and starting video
            btnSkip.Enabled = false;
            btnPlayVideo.Enabled = true;
            rb1.Visible = true; rb2.Visible = true; rb3.Visible = true;
            // Enabling answer button and starting timer
            btnCheck.Enabled = true;
            tmTime.Start();
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            // Resuming windows media player's video
            mVideo.Ctlcontrols.play();
        }

        private void mVideo_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Checking if video is playing or stopping and changing controls accordingly
            if (mVideo.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                tmTime.Stop();
                mVideo.Ctlcontrols.currentPosition = 0;
                btnSkip.Enabled = true;
                rb1.Visible = false; rb2.Visible = false; rb3.Visible = false;
                btnCheck.Enabled = false;
                btnPlayVideo.Enabled = false;
            }
            else if (mVideo.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                rb1.Visible = true; rb2.Visible = true; rb3.Visible = true;
                btnSkip.Enabled = false;
                btnCheck.Enabled = true;
                btnPlayVideo.Enabled = true;
                tmTime.Start();
            }
        }

        private void frmQuestionsExtreme_FormClosing(object sender, FormClosingEventArgs e)
        { 
            // Save player achievements to JSON file
            frmSplashScreen.AchievementManager.SaveAchievements();
        }

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
            Invalidate();
        }
    }
}
