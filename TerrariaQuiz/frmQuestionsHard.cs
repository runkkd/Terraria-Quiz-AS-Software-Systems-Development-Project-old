using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaQuiz
{
    public partial class frmQuestionsHard : Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;
        string combo1Answer = "";
        string combo2Answer = "";
        string combo3Answer = "";
        string combo4Answer = "";
        string combo5Answer = "";
        string[] items1;
        string[] items2;
        string[] items3;
        string[] items4;
        string[] items5;
        string time = "Time Remaining: ";
        string scoree = "Score: ";
        Image layer_1;
        Image layer_2;
        Image layer_3;
        Image layer_4;
        Image layer_5;
        List<HardQuestionsManager.HardQuestionInfo> questionInfo;
        private bool imagesLoaded = false;
        private int formScore = 0;
        private int _time = 100;

        // Fully Commented [X]

        public frmQuestionsHard()
        {
            // Setting up program
            InitializeComponent();
            CenterToScreen();
            // Calling method to fill combo boxes with data then set question and form parts
            SetUpComboBoxes();
            // Calling method to setup timer and setting the player score
            SetupTimer();
            lbScore.Text = "Score: " + frmSplashScreen.CPlayer.Score;
            // Parenting the controls that need to be made transparent to the background picturebox and setting their backcolor to transparent
            btnHelp.BackColor = Color.Transparent; lbScore.Parent = panel1; lbQuestionNum.BackColor = Color.Transparent; lbAnswer1.BackColor = Color.Transparent; lbAnswer2.BackColor = Color.Transparent; lbAnswer3.BackColor = Color.Transparent; lbAnswer4.BackColor = Color.Transparent; lbAnswer5.BackColor = Color.Transparent; lbVersion.BackColor = Color.Transparent; lbScore.BackColor = Color.Transparent; lbTime.BackColor = Color.Transparent; lbQuestion.BackColor = Color.Transparent;
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
        int b1 = 0, b2 = 726, x1 = 0, x2 = 726, g1 = 0, g2 = 726, h1 = 0, h2 = 726, t1 = 0, t2 = 726;
        void background_move()
        {
            /*
           * Moving each background layer horizontally
           * Resetting positions when they go off - screen
           * Invalidating the form to trigger repaint
           * This creates a parallax effect           
           */
            if (b1 < -726)
            {
                b1 = 719;
            }
            b1 -= 1;
            b2 -= 1;
            if (b2 < -726)
            {
                b2 = 719;
            }
            if (x1 < -726)
            {
                x1 = 719;
            }
            x2 -= 2;
            x1 -= 2;
            if (x2 < -726)
            {
                x2 = 719;
            }
            if (g1 < -726)
            {
                g1 = 719;
            }
            g2 -= 3;
            g1 -= 3;
            if (g2 < -726)
            {
                g2 = 719;
            }
            if (h1 < -726)
            {
                h1 = 719;
            }
            h2 -= 4;
            h1 -= 4;
            if (h2 < -726)
            {
                h2 = 719;
            }

            if (t1 < -726)
            {
                t1 = 719;
            }
            t2 -= 5;
            t1 -= 5;
            if (t2 < -726)
            {
                t2 = 719;
            }
            // Trigger a repaint of the form
            Invalidate();
        }
        private void SetUpComboBoxes()
        { // Reads in the combo box options and correct answers from a text file according to each question type and sets background images and form colours
            if (frmSplashScreen.CPlayer.Type == 1)
            {
                layer_1 = Resources.BackgroundCrimsonHillsSmall;
                layer_2 = Resources.MiddlegroundCrimsonHillsSmall;
                layer_3 = Resources.ForegroundCrimsonFieldSmall;
                layer_4 = Resources.ForegroundCrimsonFieldSmall2;
                layer_5 = Resources.ForegroundCrimsonFieldSmall3;
                imagesLoaded = true;
                lbAnswer1.ForeColor = SystemColors.ButtonFace; lbAnswer2.ForeColor = SystemColors.ButtonFace; lbAnswer3.ForeColor = SystemColors.ButtonFace; lbAnswer4.ForeColor = SystemColors.ButtonFace; lbAnswer5.ForeColor = SystemColors.ButtonFace;
                panel1.BackColor = Color.FromArgb(32, 2, 3);
                tbParagraph.BackColor = Color.FromArgb(32, 2, 3);
                btnCheck.BackColor = Color.FromArgb(32, 2, 3);
                questionInfo = frmSplashScreen.HardQuestionsManager.GetRandomQuestionInfo(HardQuestionsManager.QuestionType.bosses);
                tbParagraph.ForeColor = SystemColors.ButtonFace;
            }
            else if (frmSplashScreen.CPlayer.Type == 2)
            {
                layer_1 = Resources.BackgroundMushroomSmall;
                layer_2 = Resources.MiddlegroundMushroomSmall;
                layer_3 = Resources.ForegroundMushroomSmall;
                layer_4 = Resources.ForegroundMushroomSmall2;
                layer_5 = Resources.ForegroundMushroomSmall3;
                imagesLoaded = true;
                this.BackgroundImage = Resources.SkyMushroom;
                panel1.BackColor = Color.FromArgb(26, 62, 106);
                tbParagraph.BackColor = Color.FromArgb(26, 62, 106);
                btnCheck.BackColor = Color.FromArgb(26, 62, 106);
                questionInfo = frmSplashScreen.HardQuestionsManager.GetRandomQuestionInfo(HardQuestionsManager.QuestionType.weapons);
                tbParagraph.ForeColor = SystemColors.ButtonFace;
            }
            else if (frmSplashScreen.CPlayer.Type == 3)
            {
                layer_1 = Resources.BackgroundSnowSmall;
                layer_2 = Resources.MiddlegroundCloudSmall;
                layer_3 = Resources.ForegroundCloudSmall;
                layer_4 = Resources.ForegroundSnowSmall2;
                layer_5 = Resources.ForegroundTreesSmall3;
                this.BackgroundImage = Resources.Sky;
                imagesLoaded = true;
                panel1.BackColor = Color.FromArgb(124, 190, 249);
                tbParagraph.BackColor = Color.FromArgb(124, 190, 249);
                btnCheck.BackColor = Color.FromArgb(124, 190, 249);
                questionInfo = frmSplashScreen.HardQuestionsManager.GetRandomQuestionInfo(HardQuestionsManager.QuestionType.npcs);

            }
            // Filling combo boxes, text box and translating text
            combo1Answer = questionInfo[0].ComboBoxOneItems[0].CorrectAnswer;
            combo2Answer = questionInfo[0].ComboBoxTwoItems[0].CorrectAnswer;
            combo3Answer = questionInfo[0].ComboBoxThreeItems[0].CorrectAnswer;
            combo4Answer = questionInfo[0].ComboBoxFourItems[0].CorrectAnswer;
            combo5Answer = questionInfo[0].ComboBoxFiveItems[0].CorrectAnswer;
            tbParagraph.Text = questionInfo[0].QuestionText;
            translate();
            cb1.Items.AddRange(items1);
            cb2.Items.AddRange(items2);
            cb3.Items.AddRange(items3);
            cb4.Items.AddRange(items4);
            cb5.Items.AddRange(items5);
        }
        private void DisableAll()
        { // disables combo boxes and check answer button after question is complete
            cb1.Enabled = false;
            cb2.Enabled = false;
            cb3.Enabled = false;
            cb4.Enabled = false;
            cb5.Enabled = false;
            btnCheck.Enabled = false;
        }
        private void SetupTimer()
        { // Starts timer and sets it to tick every second
            tmTime.Interval = 1000;
            tmTime.Start();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        { // Checks to see if the drag and drop question is correct and gives visual and audio feedback accordingly
            DisableAll();
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(ComboBox))
                {
                    if (c.Text == combo1Answer || c.Text == combo2Answer || c.Text == combo3Answer || c.Text == combo4Answer || c.Text == combo5Answer)
                    {
                        c.Text = "√";
                        UpdateScoreAndLabel();
                    }
                    else
                    {
                        c.Text = "X";
                    }
                }
            }
            if (cb1.Text == "√" || cb2.Text == "√" || cb3.Text == "√" || cb4.Text == "√" || cb5.Text == "√")
            {
                playSoundCorrect();
            }
            else
            {
                playSoundIncorrect();
            }
            // Waiting 3 seconds then calling a method to Show the next form
            Task.Delay(3000).Wait();
            ShowNextQuestion();
        }

        private void frmQuestionsHard_Paint(object sender, PaintEventArgs e)
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

        private void tmParralax_Tick(object sender, EventArgs e)
        {
            // Calling method every timer tick to create parallax moving background effect
            background_move();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the help form subscribing event handlers and showing the help form
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

        private void UpdateScoreAndLabel()
        { // Sets the players score and updates the score label
            formScore++;
            frmSplashScreen.CPlayer.Score += 1;
            lbScore.Text = scoree + (frmSplashScreen.CPlayer.Score);
        }
        private void playSoundCorrect()
        { // set up to play the correct sound played when the right answer is given
            SoundPlayer wrong = new SoundPlayer(Resources.Ding___Sound_Effect__HD_);
            wrong.Play();
        }
        private void playSoundIncorrect()
        { // set up to play the incorrect sound played when the wrong answer is given
            SoundPlayer right = new SoundPlayer(Resources.Buzzer_Wrong_Answer___Sound_Effect__HD_);
            right.Play();
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
        private void ShowNextQuestion()
        { // Stops timer and then shows the next question
            tmParralax.Stop();
            tmTime.Stop();
            frmSplashScreen.AccountManager.ChangeScore(frmSplashScreen.CPlayer.PlayerId, frmSplashScreen.CPlayer.Score);
            new frmQuestionsVeryHard().Show();
            Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        { // Everytime the timer ticks the progress bars value increases until it reaches its maximum and calls the next question or stops timer when all questions are complete
            _time--;
            pgbTime.Value += 1;
            if (pgbTime.Value == pgbTime.Maximum)
            {
                tmTime.Stop();
                DisableAll();
                ShowNextQuestion();
            }
            lbTime.Text = time + _time;
        }

        private void frmQuestionsHard_Load(object sender, EventArgs e)
        {
            tmParralax.Start();
            // Changing the version text when form is loaded
            lbVersion.Text = Version.version;
            loadFont();
            // Applying the custom to font to all controls with text (Andy Bold)
            ApplyFont(font, this.btnCheck, 18);
            ApplyFont(font, this.lbQuestion, 16);
            ApplyFont(font, this.lbScore, 13);
            ApplyFont(font, this.lbVersion, 13);
            ApplyFont(font, this.lbTime, 12);
            ApplyFont(font, this.cb1, 12);
            ApplyFont(font, this.cb2, 12);
            ApplyFont(font, this.cb3, 12);
            ApplyFont(font, this.cb4, 12);
            ApplyFont(font, this.cb5, 12);
            ApplyFont(font, this.lbAnswer1, 12);
            ApplyFont(font, this.lbAnswer2, 12);
            ApplyFont(font, this.lbAnswer3, 12);
            ApplyFont(font, this.lbAnswer4, 12);
            ApplyFont(font, this.lbAnswer5, 12);
            ApplyFont(font, this.tbParagraph, 16);
            ApplyFont(font, this.lbQuestionNum, 14);
            ApplyFont(font, this.btnHelp, 16);
        }
        // Method to translate text
        private void translate()
        {
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                // Checking what language the user has selected and translating accordingly
                lbQuestion.Text = frmSplashScreen.Translator.TranslateText(lbQuestion.Text, "en", frmSplashScreen.CPlayer.Language);
                lbQuestionNum.Text = frmSplashScreen.Translator.TranslateText(lbQuestionNum.Text, "en", frmSplashScreen.CPlayer.Language);
                scoree = frmSplashScreen.Translator.TranslateText(scoree, "en", frmSplashScreen.CPlayer.Language);
                time = frmSplashScreen.Translator.TranslateText(time, "en", frmSplashScreen.CPlayer.Language);
                lbVersion.Text = frmSplashScreen.Translator.TranslateText(lbVersion.Text, "en", frmSplashScreen.CPlayer.Language);
                btnHelp.Text = frmSplashScreen.Translator.TranslateText(btnHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                btnCheck.Text = frmSplashScreen.Translator.TranslateText(btnCheck.Text, "en", frmSplashScreen.CPlayer.Language);
                cb1.Text = frmSplashScreen.Translator.TranslateText(cb1.Text, "en", frmSplashScreen.CPlayer.Language);
                cb2.Text = frmSplashScreen.Translator.TranslateText(cb2.Text, "en", frmSplashScreen.CPlayer.Language);
                cb3.Text = frmSplashScreen.Translator.TranslateText(cb3.Text, "en", frmSplashScreen.CPlayer.Language);
                cb4.Text = frmSplashScreen.Translator.TranslateText(cb4.Text, "en", frmSplashScreen.CPlayer.Language);
                cb5.Text = frmSplashScreen.Translator.TranslateText(cb5.Text, "en", frmSplashScreen.CPlayer.Language);
                lbAnswer1.Text = frmSplashScreen.Translator.TranslateText(lbAnswer1.Text, "en", frmSplashScreen.CPlayer.Language);
                lbAnswer2.Text = frmSplashScreen.Translator.TranslateText(lbAnswer2.Text, "en", frmSplashScreen.CPlayer.Language);
                lbAnswer3.Text = frmSplashScreen.Translator.TranslateText(lbAnswer3.Text, "en", frmSplashScreen.CPlayer.Language);
                lbAnswer4.Text = frmSplashScreen.Translator.TranslateText(lbAnswer4.Text, "en", frmSplashScreen.CPlayer.Language);
                lbAnswer5.Text = frmSplashScreen.Translator.TranslateText(lbAnswer5.Text, "en", frmSplashScreen.CPlayer.Language);
                tbParagraph.Text = frmSplashScreen.Translator.TranslateText(tbParagraph.Text, "en", frmSplashScreen.CPlayer.Language);
                combo1Answer = frmSplashScreen.Translator.TranslateText(combo1Answer, "en", frmSplashScreen.CPlayer.Language);
                combo2Answer = frmSplashScreen.Translator.TranslateText(combo2Answer, "en", frmSplashScreen.CPlayer.Language);
                combo3Answer = frmSplashScreen.Translator.TranslateText(combo3Answer, "en", frmSplashScreen.CPlayer.Language);
                combo4Answer = frmSplashScreen.Translator.TranslateText(combo4Answer, "en", frmSplashScreen.CPlayer.Language);
                combo5Answer = frmSplashScreen.Translator.TranslateText(combo5Answer, "en", frmSplashScreen.CPlayer.Language);
            }
            items1 = questionInfo[0].ComboBoxOneItems[0].Items.Split('~');
            items2 = questionInfo[0].ComboBoxTwoItems[0].Items.Split('~');
            items3 = questionInfo[0].ComboBoxThreeItems[0].Items.Split('~');
            items4 = questionInfo[0].ComboBoxFourItems[0].Items.Split('~');
            items5 = questionInfo[0].ComboBoxFiveItems[0].Items.Split('~');
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                for (int i = 0; i < items1.Length; i++)
                {
                    items1[i] = frmSplashScreen.Translator.TranslateText(items1[i], "en", frmSplashScreen.CPlayer.Language);
                }
                for (int i = 0; i < items2.Length; i++)
                {
                    items2[i] = frmSplashScreen.Translator.TranslateText(items2[i], "en", frmSplashScreen.CPlayer.Language);
                }
                for (int i = 0; i < items3.Length; i++)
                {
                    items3[i] = frmSplashScreen.Translator.TranslateText(items3[i], "en", frmSplashScreen.CPlayer.Language);
                }
                for (int i = 0; i < items4.Length; i++)
                {
                    items4[i] = frmSplashScreen.Translator.TranslateText(items4[i], "en", frmSplashScreen.CPlayer.Language);
                }
                for (int i = 0; i < items5.Length; i++)
                {
                    items5[i] = frmSplashScreen.Translator.TranslateText(items5[i], "en", frmSplashScreen.CPlayer.Language);
                }
            }
        }
    }
}
