using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using stdole;
using WMPLib;
using System.Diagnostics;
using System.Threading;
using System.Windows.Controls;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public partial class frmSplashScreen : Form
    {
        // Importing the AddFontMemResourceEx method from gdi32.dll
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        private FontFamily ff;
        private System.Drawing.Font font;

        // Instances of other forms and classes
        public static ExtremeQuestionsManager ExtremeQuestionsManager = new ExtremeQuestionsManager();
        public static VeryHardQuestionsManager VeryHardQuestionsMangaer = new VeryHardQuestionsManager();
        public static HardQuestionsManager HardQuestionsManager = new HardQuestionsManager();
        public static NormalQuestionManager NormalQuestionManager = new NormalQuestionManager();
        public static EasyQuestionsManager EasyQuestionsManager = new EasyQuestionsManager();
        public static AchievementManager AchievementManager = new AchievementManager();
        public static Translator Translator = new Translator();
        public static AccountManager AccountManager = new AccountManager();
        public static frmQuestionTypeChooser formType = new frmQuestionTypeChooser();
        public static frmStart formStart = new frmStart();
        public static frmQuestionsExtreme formExtreme = new frmQuestionsExtreme();
        public static frmAchievementObtained formAchieve = new frmAchievementObtained();
        public static frmSettings formSettings = new frmSettings();
        public static frmViewInfo formViewInfo = new frmViewInfo();
        public static frmLogin formLogin = new frmLogin();
        public static PlayerJson CPlayer;
        public static SplashText CSplashText;

        // Variables for the loading progress animation
        string textToShow = " ";
        int maxValue = 500;
        int minValue = 0;
        double currentProgress = 0;

        // Timer for the fade-in effect
        private System.Windows.Forms.Timer fadeInTimer;
        private const int animationDuration = 2000; // in milliseconds
        private const int timerInterval = 10;
        private double opacityIncrement;
        public frmSplashScreen()
        {
            // Setting up program and starting timer
            InitializeComponent();
            CenterToScreen();
            InitializeFadeInTimer();
            this.DoubleBuffered = true;
            SoundPlayer starting = new SoundPlayer(Resources.OnOpenSound);
            starting.Play();

            // Setting up background music
            mBackgroundMusic.settings.setMode("loop", true);
            mBackgroundMusic.Ctlcontrols.stop();

            // Setting up player class
            CPlayer = new PlayerJson();

            // Parenting the controls that need to be made transparent to the background picturebox and setting their backcolor to transparent
            lbVersion.Text = Version.version;
            lbLoadingLabel.Parent = pBackground;
            lbLoadingLabel.BackColor = Color.Transparent;
            lbVersion.Parent = pBackground;
            lbVersion.BackColor = Color.Transparent;

            // Gets a random number to display one of the 10 different loading screens one of them being very rare
            Random rdn = new Random();
            int rna = rdn.Next(1, 8);
            switch (rna)
            {
                // Setting background image and panel color based on the random number
                case 1:
                    pBackground.BackgroundImage = Resources.crimson;
                    lbLoadingLabel.ForeColor = SystemColors.ActiveCaptionText;
                    panel.BackColor = Color.FromArgb(145, 90, 95);
                    break;
                case 2:
                    pBackground.BackgroundImage = Resources.corruption;
                    panel.BackColor = Color.FromArgb(92, 84, 121);
                    break;
                case 3:
                    pBackground.BackgroundImage = Resources.beach;
                    panel.BackColor = Color.FromArgb(70, 92, 150);
                    break;
                case 4:
                    pBackground.BackgroundImage = Resources.desert;
                    panel.BackColor = Color.FromArgb(180, 177, 134);
                    break;
                case 5:
                    pBackground.BackgroundImage = Resources.jungle;
                    panel.BackColor = Color.FromArgb(65, 94, 50);
                    break;
                case 6:
                    pBackground.BackgroundImage = Resources.mushroom;
                    panel.BackColor = Color.FromArgb(54, 91, 135);
                    break;
                case 7:
                    pBackground.BackgroundImage = Resources.snow;
                    panel.BackColor = Color.FromArgb(161, 195, 223);
                    break;
                case 8:
                    pBackground.BackgroundImage = Resources.Hallow;
                    panel.BackColor = Color.FromArgb(100, 130, 94);
                    break;
                case 9:
                    pBackground.BackgroundImage = Resources.Forest;
                    panel.BackColor = Color.FromArgb(255, 216, 233);
                    break;
            }
            
            // Rolling change to get the rare splash screen
            rna = rdn.Next(1, 61);
            switch (rna)
            {
                case 25:
                    pBackground.BackgroundImage = Resources.Hell;
                    panel.BackColor = Color.FromArgb(136, 35, 22);
                    break;
            }

            // Changing form text to display Terraria Quiz and the splash text while also calling a method to get the random splash text
            rna = rdn.Next(1, 13);
            CSplashText = new SplashText(rna, " ");
            frmSplashScreen.CSplashText.getRandomSplash();
            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;
        }

        private void InitializeFadeInTimer()
        {
            // Create and configure the timer for the fade-in effect
            fadeInTimer = new System.Windows.Forms.Timer();
            fadeInTimer.Interval = timerInterval;
            fadeInTimer.Tick += FadeInTimer_Tick;

            // Calculate the incremental change in opacity for each timer tick
            opacityIncrement = 1.0 / (animationDuration / timerInterval);
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            // Check if the current opacity is less than 1
            if (Opacity < 1)
            {
                // Incrementally increase the opacity by the precalculated value
                Opacity += opacityIncrement;
            }
            else
            {
                // If the opacity reaches 1, stop the timer to end the fade-in effect
                fadeInTimer.Stop();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            // Start the fade-in effect when the form is loaded
            base.OnLoad(e);
            StartFadeIn();
        }

        private void StartFadeIn()
        {
            // Set the initial opacity to 0
            Opacity = 0;

            // Start the timer to begin the fade-in effect
            fadeInTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { // Incrementing the progress bar and updating the label for displaying loading status every tick of the timer and moving on to the next form if the progress bar reaches it's maximum value
            UpdateProgreessBar();
            UpdateLoadingStatus();

            if (currentProgress == maxValue)
            {
                StopTimerAndPlayMusic();
            }
        }

        // Enum to represent loading thresholds for better readability
        public enum LoadingThresholds
        {
            CreatingSounds = 1,
            LoadingButtons = 50,
            LoadingLabels = 100,
            BuildingApplication = 150,
            SortingUserData = 200,
            CreatingQuestions = 250,
            DrawingGraphics = 300,
            FindingBosses = 350,
            CraftingWeapons = 400,
            LocatingNpcs = 450
        }
        private void UpdateLoadingStatus()
        {
            // Increase currentProgress by 1
            currentProgress += 1;

            // Update the label to value of bar and what is being loaded (this is a feature in the actual terraria game)
            switch (currentProgress)
            {
                case (int)LoadingThresholds.CreatingSounds:
                    textToShow = "Creating Sounds ";
                    break;
                case (int)LoadingThresholds.LoadingButtons:
                    textToShow = "Loading Buttons ";
                    break;
                case (int)LoadingThresholds.LoadingLabels:
                    textToShow = "Loading Labels ";
                    break;
                case (int)LoadingThresholds.BuildingApplication:
                    textToShow = "Building Application ";
                    break;
                case (int)LoadingThresholds.SortingUserData:
                    textToShow = "Sorting User Data ";
                    break;
                case (int)LoadingThresholds.CreatingQuestions:
                    textToShow = "Creating Questions ";
                    break;
                case (int)LoadingThresholds.DrawingGraphics:
                    textToShow = "Drawing Graphics ";
                    panel.Width += 20;
                    break;
                case (int)LoadingThresholds.FindingBosses:
                    textToShow = "Finding Bosses ";
                    panel.Width += 20;
                    break;
                case (int)LoadingThresholds.CraftingWeapons:
                    textToShow = "Crafting Weapons ";
                    panel.Width += 20;
                    break;
                case (int)LoadingThresholds.LocatingNpcs:
                    textToShow = "Locating NPCs ";
                    panel.Width += 20;
                    break;
            }
            // Displaying the textToShow and calculating the percentage complete to display it
            lbLoadingLabel.Text = textToShow + Math.Round((currentProgress / 5), MidpointRounding.AwayFromZero) + "%...";
        }

        private void UpdateProgreessBar()
        {
            // Increase the panel's size by 1
            panel.Width += 1;
        }

        private void StopTimerAndPlayMusic()
        {
            // Stopping the timer when the progress bar reaches its maximum then playing the background music and displaying the login form
            tmTime.Stop();
            mBackgroundMusic.URL = "StartMusic.wav";
            mBackgroundMusic.settings.volume = 20;
            mBackgroundMusic.Ctlcontrols.play();
            Hide();
            formLogin.Show();
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
        public void ApplyFont(System.Drawing.Font f, System.Windows.Forms.Control c, float size)
        {
            // Set the default font style
            FontStyle fontStyle = FontStyle.Regular;

            // Set the font of the control using the specified size and style
            c.Font = new System.Drawing.Font(ff, size, fontStyle);
        }
        private void UpdateMusicVolume(object newVolume, EventArgs e)
        {
            // Updating the volume of the windows media player
            mBackgroundMusic.settings.volume = Convert.ToInt32(newVolume);
        }
        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            // Loads custom Andy Bold font and applies it to all text-containing controls, then subscribes the event to change music volume to the method for updating it
            frmSplashScreen.formSettings.changeMusicVolume += UpdateMusicVolume;
            frmSplashScreen.formLogin.changeMusicVolume += UpdateMusicVolume;
            panel.Width = minValue;
            LoadCustomFont();
            ApplyFont(font, this.lbLoadingLabel, 25);
            ApplyFont(font, this.lbVersion, 13);
        }
    }
}

