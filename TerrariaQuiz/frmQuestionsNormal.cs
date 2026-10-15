using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmBossQuestionsNormal : Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;
        private bool imagesLoaded = false;
        private string toShow;
        private int formScore = 0;
        private int _time = 60;
        private string correct1 = "";
        private string correct2 = "";
        private string correct3 = "";
        private string correct4 = "";
        private string correct5 = "";
        private string correct6 = "";
        string time = "Time Remaining: ";
        string scoree = "Score: ";
        Image layer_1;
        Image layer_2;
        Image layer_3;
        Image layer_4;
        Image layer_5;
        numberClass[] numbers = new numberClass[3];
        public List<NormalQuestionManager.DragAndDropQuestion> questionInfo;
        int qNum = 0;

        public class numberClass
        {
            public int One { get; private set; }
            public int Two { get; private set; }
            public int Three { get; private set; }
            public int Four { get; private set; }
            public int Five { get; private set; }
            public int Six { get; private set; }
            public numberClass(int one, int two, int three, int four, int five, int six)
            {
                One = one;
                Two = two;
                Three = three;
                Four = four;
                Five = five;
                Six = six;
            }
        }
        public frmBossQuestionsNormal()
        {
            InitializeComponent();
            CenterToScreen();
            AllowDropping();
            SetUpQuestions();
            // Setting score and timer
            lbScore.Text = "Score: " + frmSplashScreen.CPlayer.Score;
            SetupTimer();
            // Parenting the controls that need to be made transparent to the background picturebox and setting their backcolor to transparent
            lbQuestionNum.Parent = panel1;
            btnHelp.BackColor = Color.Transparent; lbVersion.BackColor = Color.Transparent; lbTime.BackColor = Color.Transparent; lbScore.BackColor = Color.Transparent; pImage6.BackColor = Color.Transparent; pImage5.BackColor = Color.Transparent; pImage4.BackColor = Color.Transparent; pImage3.BackColor = Color.Transparent; pImage2.BackColor = Color.Transparent; lbDrag6.BackColor = Color.Transparent; lbDrag5.BackColor = Color.Transparent; lbDrag4.BackColor = Color.Transparent; lbDrag3.BackColor = Color.Transparent; lbDrag2.BackColor = Color.Transparent; pImage1.BackColor = Color.Transparent; lbQuestionNum.BackColor = Color.Transparent; lbQuestion.BackColor = Color.Transparent; lbDrag1.BackColor = Color.Transparent;
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
        private void AllowDropping()
        { // Sets up all the picture boxes to allow drag and drop
            pImage1.AllowDrop = true;
            pImage2.AllowDrop = true;
            pImage3.AllowDrop = true;
            pImage4.AllowDrop = true;
            pImage5.AllowDrop = true;
            pImage6.AllowDrop = true;
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
        private void SetUpQuestions()
        { // Sets up the questions depending on the chosen question type
            switch (frmSplashScreen.CPlayer.Type)
            {
                case 1:
                    layer_1 = Resources.BackgroundCrimsonHillsSmall;
                    layer_2 = Resources.MiddlegroundCrimsonHillsSmall;
                    layer_3 = Resources.ForegroundCrimsonFieldSmall;
                    layer_4 = Resources.ForegroundCrimsonFieldSmall2;
                    layer_5 = Resources.ForegroundCrimsonFieldSmall3;
                    questionInfo = frmSplashScreen.NormalQuestionManager.GetRandomQuestions(NormalQuestionManager.QuestionType.bosses, 18);
                    imagesLoaded = true;
                    this.BackgroundImage = Resources.SkyCrimson;
                    lbQuestion.Text = "Drag and Drop the boss name with the correct boss";
                    panel1.BackColor = Color.FromArgb(32, 2, 3);
                    break;
                case 2:
                    layer_1 = Resources.BackgroundMushroomSmall;
                    layer_2 = Resources.MiddlegroundMushroomSmall;
                    layer_3 = Resources.ForegroundMushroomSmall;
                    layer_4 = Resources.ForegroundMushroomSmall2;
                    layer_5 = Resources.ForegroundMushroomSmall3;
                    questionInfo = frmSplashScreen.NormalQuestionManager.GetRandomQuestions(NormalQuestionManager.QuestionType.weapons, 18);
                    imagesLoaded = true;
                    this.BackgroundImage = Resources.SkyMushroom;
                    lbQuestion.Text = "Drag and Drop the weapon name to the correct weapon";
                    panel1.BackColor = Color.FromArgb(26, 62, 106);
                    break;
                case 3:
                    layer_1 = Resources.BackgroundSnowSmall;
                    layer_2 = Resources.MiddlegroundCloudSmall;
                    layer_3 = Resources.ForegroundCloudSmall;
                    layer_4 = Resources.ForegroundSnowSmall2;
                    layer_5 = Resources.ForegroundTreesSmall3;
                    questionInfo = frmSplashScreen.NormalQuestionManager.GetRandomQuestions(NormalQuestionManager.QuestionType.npcs, 18);
                    this.BackgroundImage = Resources.Sky;
                    imagesLoaded = true;
                    lbQuestion.Text = "Drag and Drop the NPC name with the correct NPC";
                    panel1.BackColor = Color.FromArgb(124, 190, 249);
                    break;
            }
            NextQuestion();
        }
        private void NextQuestion()
        { // Sets the labels text, correct answers and picture boxes images for each question then calls the method to show all
            InvisibleAll();
            ResetDragAndDropState();
            switch (qNum)
            {
                case 0:
                    toShow = "Question 4a";
                    numbers[0] = new numberClass(0, 1, 2, 3, 4, 5);
                    break;
                case 1:
                    toShow = "Question 4b";
                    numbers[1] = new numberClass(6, 7, 8, 9, 10, 11);
                    break;
                case 2:
                    toShow = "Question 4c";
                    numbers[2] = new numberClass(12, 13, 14, 15, 16, 17);
                    break;
            }
            // Sets picturebox images
            pImage1.BackgroundImage = frmSplashScreen.NormalQuestionManager.GetImageFromFile(questionInfo[numbers[qNum].One].ImageFileName);
            pImage2.BackgroundImage = frmSplashScreen.NormalQuestionManager.GetImageFromFile(questionInfo[numbers[qNum].Two].ImageFileName);
            pImage3.BackgroundImage = frmSplashScreen.NormalQuestionManager.GetImageFromFile(questionInfo[numbers[qNum].Three].ImageFileName);
            pImage4.BackgroundImage = frmSplashScreen.NormalQuestionManager.GetImageFromFile(questionInfo[numbers[qNum].Four].ImageFileName);
            pImage5.BackgroundImage = frmSplashScreen.NormalQuestionManager.GetImageFromFile(questionInfo[numbers[qNum].Five].ImageFileName);
            pImage6.BackgroundImage = frmSplashScreen.NormalQuestionManager.GetImageFromFile(questionInfo[numbers[qNum].Six].ImageFileName);
            // Sets values to hold correct answers
            correct1 = questionInfo[numbers[qNum].One].QuestionText;
            correct2 = questionInfo[numbers[qNum].Two].QuestionText;
            correct3 = questionInfo[numbers[qNum].Three].QuestionText;
            correct4 = questionInfo[numbers[qNum].Four].QuestionText;
            correct5 = questionInfo[numbers[qNum].Five].QuestionText;
            correct6 = questionInfo[numbers[qNum].Six].QuestionText;
            // Sets the text of the drag and drop labels
            lbDrag1.Text = questionInfo[numbers[qNum].One].QuestionText;
            lbDrag2.Text = questionInfo[numbers[qNum].Two].QuestionText;
            lbDrag3.Text = questionInfo[numbers[qNum].Three].QuestionText;
            lbDrag4.Text = questionInfo[numbers[qNum].Four].QuestionText;
            lbDrag5.Text = questionInfo[numbers[qNum].Five].QuestionText;
            lbDrag6.Text = questionInfo[numbers[qNum].Six].QuestionText;
            // Increases qNum and sets the question text
            qNum++;
            lbQuestionNum.Text = toShow;
            translate();
        }
        private void ResetDragAndDropState()
        {
            // Resets the drag and drop state of each image
            pImage1.Visible = true;
            pImage2.Visible = true;
            pImage3.Visible = true;
            pImage4.Visible = true;
            pImage5.Visible = true;
            pImage6.Visible = true;

            lbDrag1.Visible = true;
            lbDrag2.Visible = true;
            lbDrag3.Visible = true;
            lbDrag4.Visible = true;
            lbDrag5.Visible = true;
            lbDrag6.Visible = true;
        }
        private void SetupTimer()
        { // set up to play the correct sound played when the answer is given
            tmTime.Interval = 1000;
            tmTime.Start();
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
        private void UpdateScoreAndLabel()
        { // Sets the players score, updates the score label and shows next question when all are completed
            formScore++;
            frmSplashScreen.CPlayer.Score += 1;
            lbScore.Text = scoree + (frmSplashScreen.CPlayer.Score);
            playSoundCorrect();

            if (formScore == 18)
            {
                Task.Delay(500).Wait();
                ShowNextQuestion();
                tmTime.Stop();
            }
        }
        private void ShowNextQuestion()
        { // Shows the next form
            tmParralax.Stop();
            frmSplashScreen.AccountManager.ChangeScore(frmSplashScreen.CPlayer.PlayerId, frmSplashScreen.CPlayer.Score);
            new frmQuestionsHard().Show();
            Hide();
        }
        private void AllowDragDropCopy(object sender, DragEventArgs e)
        { // Sets up drag and drop effects
            e.Effect = DragDropEffects.Copy;
        }

        private void SlimeDragDrop(object sender, DragEventArgs e)
        { // Checks to see if drag and drop was correct and plays the respective sound then sets up next questions when neccessary
            string result = (string)e.Data.GetData(DataFormats.Text);

            if (lbDrag4.Text == result)
            {
                UpdateScoreAndLabel();
                pImage4.Visible = false;
                lbDrag4.Visible = false;
            }
            else if (result != correct4)
            {
                playSoundIncorrect();
                frmSplashScreen.CPlayer.Score -= 1;
                lbScore.Text = scoree + (frmSplashScreen.CPlayer.Score);
            }
            if (formScore == 6 || formScore == 12)
            {
                Debug.WriteLine("Next Question!");
                ResetDragAndDropState();
                NextQuestion();
                Task.Delay(10).Wait();
            }
        }

        private void LabelGrabbed(object sender, MouseEventArgs e)
        { // Shows drag and drop effects when the label is grabbed
            Label selectedLabel = (Label)sender;
            selectedLabel.DoDragDrop(selectedLabel.Text, DragDropEffects.Copy);
        }

        private void tmParralax_Tick(object sender, EventArgs e)
        {
            // Calls the background move method every timer tick to create moving background effect
            background_move();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Creates a new instance of the help form subscribes events then shows the help form
            frmHelp formHelp = new frmHelp();
            formHelp.FormHelpShown += frmHelp_FormShown;
            formHelp.FormHelpClosed += frmHelp_FormClosed;
            formHelp.Show();
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

        private void InvisibleAll()
        { // Disables all labels and picture boxes between questions
            lbDrag1.Visible = false;
            lbDrag2.Visible = false;
            lbDrag3.Visible = false;
            lbDrag4.Visible = false;
            lbDrag5.Visible = false;
            lbDrag6.Visible = false;
            pImage1.Visible = false;
            pImage2.Visible = false;
            pImage3.Visible = false;
            pImage4.Visible = false;
            pImage5.Visible = false;
            pImage6.Visible = false;
        }

        private void EaterDragDrop(object sender, DragEventArgs e)
        { // Checks to see if drag and drop was correct and plays the respective sound then sets up next questions when neccessary
            string result = (string)e.Data.GetData(DataFormats.Text);

            if (lbDrag6.Text == result)
            {
                UpdateScoreAndLabel();
                pImage6.Visible = false;
                lbDrag6.Visible = false;
            }
            else if (result != correct6)
            {
                playSoundIncorrect();
                frmSplashScreen.CPlayer.Score -= 1;
                lbScore.Text = scoree + (frmSplashScreen.CPlayer.Score);
            }
            if (formScore == 6 || formScore == 12)
            {
                Debug.WriteLine("Next Question!");
                ResetDragAndDropState();
                NextQuestion();
                Task.Delay(10).Wait();
            }
        }

        private void MoonDragDrop(object sender, DragEventArgs e)
        { // Checks to see if drag and drop was correct and plays the respective sound then sets up next questions when neccessary
            string result = (string)e.Data.GetData(DataFormats.Text);

            if (lbDrag3.Text == result)
            {
                UpdateScoreAndLabel();
                pImage3.Visible = false;
                lbDrag3.Visible = false;
            }
            else if (result != correct3)
            {
                playSoundIncorrect();
                frmSplashScreen.CPlayer.Score -= 1;
                lbScore.Text = scoree + (frmSplashScreen.CPlayer.Score);
            }
            if (formScore == 6 || formScore == 12)
            {
                Debug.WriteLine("Next Question!");
                ResetDragAndDropState();
                NextQuestion();
                Task.Delay(10).Wait();
            }
        }

        private void QueenDragDrop(object sender, DragEventArgs e)
        { // Checks to see if drag and drop was correct and plays the respective sound then sets up next questions when neccessary
            string result = (string)e.Data.GetData(DataFormats.Text);

            if (lbDrag2.Text == result)
            {
                UpdateScoreAndLabel();
                pImage2.Visible = false;
                lbDrag2.Visible = false;
            }
            else if (result != correct2)
            {
                playSoundIncorrect();
                frmSplashScreen.CPlayer.Score -= 1;
                lbScore.Text = scoree + (frmSplashScreen.CPlayer.Score);
            }
            if (formScore == 6 || formScore == 12)
            {
                Debug.WriteLine("Next Question!");
                ResetDragAndDropState();
                NextQuestion();
                Task.Delay(10).Wait();
            }
        }

        private void WallDragDrop(object sender, DragEventArgs e)
        { // Checks to see if drag and drop was correct and plays the respective sound then sets up next questions when neccessary
            string result = (string)e.Data.GetData(DataFormats.Text);

            if (lbDrag1.Text == result)
            {
                UpdateScoreAndLabel();
                pImage1.Visible = false;
                lbDrag1.Visible = false;
            }
            else if (result != correct1)
            {
                playSoundIncorrect();
                frmSplashScreen.CPlayer.Score -= 1;
                lbScore.Text = scoree + (frmSplashScreen.CPlayer.Score);
            }
            if (formScore == 6 || formScore == 12)
            {
                Debug.WriteLine("Next Question!");
                ResetDragAndDropState();
                NextQuestion();
                Task.Delay(10).Wait();
            }
        }

        private void PlanteraDragDrop(object sender, DragEventArgs e)
        { // Checks to see if drag and drop was correct and plays the respective sound then sets up next questions when neccessary
            string result = (string)e.Data.GetData(DataFormats.Text);

            if (lbDrag5.Text == result)
            {
                UpdateScoreAndLabel();
                pImage5.Visible = false;
                lbDrag5.Visible = false;
            }
            else if (result != correct5)
            {
                playSoundIncorrect();
                frmSplashScreen.CPlayer.Score -= 1;
                lbScore.Text = scoree + (frmSplashScreen.CPlayer.Score);
            }
            if (formScore == 6 || formScore == 12)
            {
                Debug.WriteLine("Next Question!");
                ResetDragAndDropState();
                NextQuestion();
                Task.Delay(10).Wait();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  // Everytime the timer ticks the progress bars value increases until it reaches its maximum and calls the next question or stops timer when all questions are complete
            _time--;
            pgbTime.Value += 1;
            if (pgbTime.Value == pgbTime.Maximum)
            {
                tmTime.Stop();
                InvisibleAll();
                ShowNextQuestion();
            }

            lbTime.Text = time + _time;
        }

        private void frmBossQuestionsNormal_Load(object sender, EventArgs e)
        {
            tmParralax.Start();
            // Changing the version text when form is loaded
            lbVersion.Text = Version.version;
            loadFont();
            ApplyFont(font, this.lbDrag1, 16);
            ApplyFont(font, this.lbDrag2, 16);
            ApplyFont(font, this.lbDrag3, 16);
            ApplyFont(font, this.lbDrag4, 16);
            ApplyFont(font, this.lbDrag5, 16);
            ApplyFont(font, this.lbDrag6, 16);
            ApplyFont(font, this.lbQuestion, 16);
            ApplyFont(font, this.lbQuestionNum, 13);
            ApplyFont(font, this.lbScore, 14);
            ApplyFont(font, this.lbTime, 14);
            ApplyFont(font, this.lbVersion, 13);
            ApplyFont(font, this.btnHelp, 16);
        }
        // Method to translate text
        private void translate()
        {
            if (frmSplashScreen.CPlayer.Language != "en")
            {
                // Checking what language the user has selected and applying accordingly
                lbQuestion.Text = frmSplashScreen.Translator.TranslateText(lbQuestion.Text, "en", frmSplashScreen.CPlayer.Language);
                lbQuestionNum.Text = frmSplashScreen.Translator.TranslateText(lbQuestionNum.Text, "en", frmSplashScreen.CPlayer.Language);
                scoree = frmSplashScreen.Translator.TranslateText(scoree, "en", frmSplashScreen.CPlayer.Language);
                time = frmSplashScreen.Translator.TranslateText(time, "en", frmSplashScreen.CPlayer.Language);
                lbVersion.Text = frmSplashScreen.Translator.TranslateText(lbVersion.Text, "en", frmSplashScreen.CPlayer.Language);
                btnHelp.Text = frmSplashScreen.Translator.TranslateText(btnHelp.Text, "en", frmSplashScreen.CPlayer.Language);
                lbDrag1.Text = frmSplashScreen.Translator.TranslateText(lbDrag1.Text, "en", frmSplashScreen.CPlayer.Language);
                lbDrag2.Text = frmSplashScreen.Translator.TranslateText(lbDrag2.Text, "en", frmSplashScreen.CPlayer.Language);
                lbDrag3.Text = frmSplashScreen.Translator.TranslateText(lbDrag3.Text, "en", frmSplashScreen.CPlayer.Language);
                lbDrag4.Text = frmSplashScreen.Translator.TranslateText(lbDrag4.Text, "en", frmSplashScreen.CPlayer.Language);
                lbDrag5.Text = frmSplashScreen.Translator.TranslateText(lbDrag5.Text, "en", frmSplashScreen.CPlayer.Language);
                lbDrag6.Text = frmSplashScreen.Translator.TranslateText(lbDrag6.Text, "en", frmSplashScreen.CPlayer.Language);
            }
        }
        private void frmBossQuestionsNormal_Paint(object sender, PaintEventArgs e)
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
