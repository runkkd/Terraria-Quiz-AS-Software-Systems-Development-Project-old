using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using static TerrariaQuiz.VeryHardQuestionsManager;
using System.Windows.Documents;

// Fully Commented [ ]

namespace TerrariaQuiz
{
    public partial class frmQuestionsVeryHard : Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;
        private int _time = 75;
        //int questionType = 0;
        string[] listBoxAnswers1;
        string[] listBoxAnswers2;
        string[] listBoxOneParts = new string[6];
        string[] listBoxTwoParts = new string[6];
        string time = "Time Remaining: ";
        string scoree = "Score: ";
        string noItem = "Please select an item/valid item";
        string noItemTitle = "No item selected";
        bool imagesLoaded = false;
        Image layer_1;
        Image layer_2;
        Image layer_3;
        Image layer_4;
        Image layer_5;
        List<VeryHardQuestionsManager.QuestionInfo> questionInfo;
        private int formScore = 0;
        private int wrong;
        public frmQuestionsVeryHard()
        {
            // Setting up program
            InitializeComponent();
            CenterToScreen();
            // Calling method to set up the question
            SetUpQuestions();
            lbScore.Text = "Score: " + (frmSplashScreen.CPlayer.Score);
            // Starts timer
            tmTime.Start();
            // Parenting the controls that need to be made transparent to the background picturebox and setting their backcolor to transparent
            btnHelp.BackColor = Color.Transparent; lbQuestionNum.Parent = panel1; lbTitle.Parent = panel1; lbCorrect.Visible = false;  lbScore.Parent = panel1;
            lbTime.BackColor = Color.Transparent; lbQuestionNum.BackColor = Color.Transparent; lbTitle.BackColor = Color.Transparent; lbCorrect.BackColor = Color.Transparent; lbScore.BackColor = Color.Transparent; lbVersion.BackColor = Color.Transparent; lbType1.BackColor = Color.Transparent; lbType2.BackColor = Color.Transparent; btnLeft.BackColor = Color.Transparent; btnRight.BackColor = Color.Transparent;
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
        public string[] shuffleList(string[] e)
        { // Gets 2 elements of the array to be swapped and sends them to the swap method
            int a = e.Length;
            Random ran = new Random();

            for (int i = 0; i < a; i++)
            {
                swap(e, i, i + ran.Next(a - i));
            }
            return e;
        }
        public static void swap(string[] arr, int a, int b)
        { // Swaps the two elements
            string temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        private void SetUpQuestions()
        { // Depending on the question type 2 questions are gotten from a text file to be picked at random
            string[] listShuffleTemp = new string[12];
            switch (frmSplashScreen.CPlayer.Type)
            {
                case 1:
                    panel1.BackColor = Color.FromArgb(32, 2, 3);
                    ltbTwo.BackColor = Color.FromArgb(32, 2, 3);
                    ltbOne.BackColor = Color.FromArgb(32, 2, 3);
                    btnCheck.BackColor = Color.FromArgb(32, 2, 3);
                    layer_1 = Resources.BackgroundCrimsonHillsLarge;
                    layer_2 = Resources.MiddlegroundCrimsonHillsLarge;
                    layer_3 = Resources.ForegroundCrimsonFieldLarge;
                    layer_4 = Resources.ForegroundCrimsonFieldLarge2;
                    layer_5 = Resources.ForegroundCrimsonFieldLarge3;
                    questionInfo = frmSplashScreen.VeryHardQuestionsMangaer.GetRandomQuestionInfo(QuestionType.bosses);
                    this.BackgroundImage = Resources.SkyCrimson;
                    imagesLoaded = true;
                    break;
                case 2:
                    panel1.BackColor = Color.FromArgb(26, 62, 106);
                    ltbTwo.BackColor = Color.FromArgb(26, 62, 106);
                    ltbOne.BackColor = Color.FromArgb(26, 62, 106);
                    btnCheck.BackColor = Color.FromArgb(26, 62, 106);
                    layer_1 = Resources.BackgroundMushroomLarge;
                    layer_2 = Resources.MiddlegroundMushroomLarge;
                    layer_3 = Resources.ForegroundMushroomLarge;
                    layer_4 = Resources.ForegroundMushroomLarge2;
                    layer_5 = Resources.ForegroundMushroomLarge3;
                    this.BackgroundImage = Resources.SkyMushroom;
                    questionInfo = frmSplashScreen.VeryHardQuestionsMangaer.GetRandomQuestionInfo(QuestionType.weapons);
                    imagesLoaded = true;
                    break;
                case 3:
                    panel1.BackColor = Color.FromArgb(124, 190, 249);
                    ltbTwo.BackColor = Color.FromArgb(124, 190, 249);
                    ltbOne.BackColor = Color.FromArgb(124, 190, 249);
                    btnCheck.BackColor = Color.FromArgb(124, 190, 249);
                    layer_1 = Resources.BackgroundSnowLarge;
                    layer_2 = Resources.MiddlegroundCloudLarge;
                    layer_3 = Resources.ForegroundCloudLarge;
                    layer_4 = Resources.ForegroundSnowLarge2;
                    layer_5 = Resources.ForegroundTreesLarge3;
                    questionInfo = frmSplashScreen.VeryHardQuestionsMangaer.GetRandomQuestionInfo(QuestionType.npcs);
                    this.BackgroundImage = Resources.Sky;
                    imagesLoaded = true;
                    break;
            }
            // Shuffling the list box answers to be random
            lbType1.Text = questionInfo[0].LeftText;
            lbType2.Text = questionInfo[0].RightText;
            listShuffleTemp = shuffleList(questionInfo[0].Items.Split('~'));
            for (int i = 0; i < 6; i++)
            {
                listBoxOneParts[i] = listShuffleTemp[i];
                listBoxTwoParts[i] = listShuffleTemp[i + 6];
            }
            listBoxAnswers1 = questionInfo[0].LeftItems.Split('~');
            listBoxAnswers2 = questionInfo[0].RightItems.Split('~');
            translate();
            ltbOne.Items.AddRange(listBoxOneParts);
            ltbTwo.Items.AddRange(listBoxTwoParts);
        }
        private void playAudioHover()
        { // set up to play the click sound played when buttons are hovered over like actual Terraria buttons do
            SoundPlayer click = new SoundPlayer(Resources.MenuClick);
            click.Play();
        }
        private void playAudioCorrect()
        { // Plays ding sound when called
            SoundPlayer clicked = new SoundPlayer(Resources.Ding___Sound_Effect__HD_);
            clicked.Play();
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
        private void UpdateScoreAndLabel()
        { // Sets the players score and updates the score label
            formScore++;
            frmSplashScreen.CPlayer.Score += 1;
            lbScore.Text = scoree + (frmSplashScreen.CPlayer.Score);
            lbCorrect.Text = "You got " + formScore + " correct and " + wrong + " incorrect!";
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                lbCorrect.Text = frmSplashScreen.Translator.TranslateText(lbCorrect.Text, "en", frmSplashScreen.CPlayer.Language);
            }
            lbCorrect.Visible = true; btnLeft.Enabled = false; btnRight.Enabled = false; btnCheck.Enabled = false;
        }
        private void frmQuestionsVeryHard_Load(object sender, EventArgs e)
        {
            // Starting parallax timer and setting version text
            tmParralax.Start();
            lbVersion.Text = Version.version;
            loadFont();
            // Applying custom font to specific controls
            ApplyFont(font, this.btnLeft, 18);
            ApplyFont(font, this.btnRight, 18);
            ApplyFont(font, this.btnCheck, 18);
            ApplyFont(font, this.lbTitle, 18);
            ApplyFont(font, this.lbType1, 13);
            ApplyFont(font, this.lbType2, 13);
            ApplyFont(font, this.ltbOne, 12);
            ApplyFont(font, this.ltbTwo, 12);
            ApplyFont(font, this.lbCorrect, 18);
            ApplyFont(font, this.lbQuestionNum, 14);
            ApplyFont(font, this.btnHelp, 16);
            ApplyFont(font, this.lbScore, 13);
        }
        // Method to translate text
        private void translate()
        {
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                // Checking what language the user has selected and translating accordingly
                lbType1.Text = frmSplashScreen.Translator.TranslateText(lbType1.Text, "en", frmSplashScreen.CPlayer.Language);
                lbType2.Text = frmSplashScreen.Translator.TranslateText(lbType2.Text, "en", frmSplashScreen.CPlayer.Language);
                lbQuestionNum.Text = frmSplashScreen.Translator.TranslateText(lbQuestionNum.Text, "en", frmSplashScreen.CPlayer.Language);
                lbTitle.Text = frmSplashScreen.Translator.TranslateText(lbTitle.Text, "en", frmSplashScreen.CPlayer.Language);
                lbCorrect.Text = frmSplashScreen.Translator.TranslateText(lbCorrect.Text, "en", frmSplashScreen.CPlayer.Language);
                scoree = frmSplashScreen.Translator.TranslateText(scoree, "en", frmSplashScreen.CPlayer.Language);
                time = frmSplashScreen.Translator.TranslateText(time, "en", frmSplashScreen.CPlayer.Language);
                lbVersion.Text = frmSplashScreen.Translator.TranslateText(lbVersion.Text, "en", frmSplashScreen.CPlayer.Language);
                btnHelp.Text = frmSplashScreen.Translator.TranslateText(btnHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                btnCheck.Text = frmSplashScreen.Translator.TranslateText(btnCheck.Text, "en", frmSplashScreen.CPlayer.Language);
                ltbOne.Text = frmSplashScreen.Translator.TranslateText(btnCheck.Text, "en", frmSplashScreen.CPlayer.Language);
                ltbTwo.Text = frmSplashScreen.Translator.TranslateText(btnCheck.Text, "en", frmSplashScreen.CPlayer.Language);
                for (int i = 0; i < listBoxAnswers1.Length; i++)
                {
                    listBoxAnswers1[i] = frmSplashScreen.Translator.TranslateText(listBoxAnswers1[i], "en", frmSplashScreen.CPlayer.Language);
                    listBoxAnswers2[i] = frmSplashScreen.Translator.TranslateText(listBoxAnswers2[i], "en", frmSplashScreen.CPlayer.Language);
                    listBoxOneParts[i] = frmSplashScreen.Translator.TranslateText(listBoxOneParts[i], "en", frmSplashScreen.CPlayer.Language);
                    listBoxTwoParts[i] = frmSplashScreen.Translator.TranslateText(listBoxTwoParts[i], "en", frmSplashScreen.CPlayer.Language);
                }
                noItem = frmSplashScreen.Translator.TranslateText(noItem, "en", frmSplashScreen.CPlayer.Language);
                noItemTitle = frmSplashScreen.Translator.TranslateText(noItemTitle, "en", frmSplashScreen.CPlayer.Language);
            }
        }

        // Event handler for check button clicked
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Looping through list boxes to check if answer is correct
            for (int i = 0; i < listBoxAnswers1.Length; i++)
            {
                if (ltbOne.Items.Contains(listBoxAnswers1[i]))
                {
                    UpdateScoreAndLabel();
                }
                else
                {
                    wrong++;
                }
            }
            for (int i = 0; i < listBoxAnswers2.Length; i++)
            {
                if (ltbTwo.Items.Contains(listBoxAnswers2[i]))
                {
                    UpdateScoreAndLabel();
                }
                else
                {
                    wrong++;
                }
            }
            // Calling method to play ding sound and stopping timer
            playAudioCorrect();
            tmTime.Stop();
            // Waiting 3 seconds then calling a method to show the next question
            Task.Delay(3000).Wait();
            ShowNextQuestion();
        }
        private void ShowNextQuestion()
        { // Stops timer and then shows the next question
            frmSplashScreen.AccountManager.ChangeScore(frmSplashScreen.CPlayer.PlayerId, frmSplashScreen.CPlayer.Score);
            frmSplashScreen.formExtreme.Show();
            Hide();
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            // Check if item is selected
            if (ltbOne.SelectedIndex < 0)
            {
                MessageBox.Show(noItem, noItemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // move from one list to the other
                ltbTwo.Items.Add(ltbOne.SelectedItem);
                ltbOne.Items.Remove(ltbOne.SelectedItem);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            // Check if item is selected
            if (ltbTwo.SelectedIndex < 0)
            {
                MessageBox.Show(noItem, noItemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // move from one list to the other
                ltbOne.Items.Add(ltbTwo.SelectedItem);
                ltbTwo.Items.Remove(ltbTwo.SelectedItem);
            }
        }
        private void DisableAll()
        { // Disables radio buttons and check answer button after question is complete
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            btnCheck.Enabled = false;
        }
        private void tmTime_Tick(object sender, EventArgs e)
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
        int b1 = 0, b2 = 816, x1 = 0, x2 = 816, g1 = 0, g2 = 816, h1 = 0, h2 = 816, t1 = 0, t2 = 816;

        private void btnHelp_Click(object sender, EventArgs e)
        {
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
        private void frmQuestionsVeryHard_Paint(object sender, PaintEventArgs e)
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
            background_move();
        }
    }
}
