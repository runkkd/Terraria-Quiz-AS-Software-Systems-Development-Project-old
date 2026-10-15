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
using Microsoft.VisualBasic.Logging;

// Fully Commented [ ]

namespace TerrariaQuiz
{
    public partial class frmQuestionTypeChooser : Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;
        private int type;
        Image layer_1 = Resources.BackgroundFloatingIslands;
        Image layer_2 = Resources.BackgroundHills;
        Image layer_3 = Resources.MiddlegroundHallowForest;
        Image layer_4 = Resources.ForegroundHallowTrees;
        Image layer_Clouds = Resources.Clouds;
        Image layer_Rainbow = Resources.Rainbow;
        public frmQuestionTypeChooser()
        {
            InitializeComponent();
            CenterToScreen();
            {
                // Setting version label and transparent backgrounds
                lbVersion.Text = Version.version; btnRandom.BackColor = Color.Transparent; btnNpcs.BackColor = Color.Transparent; btnWeapons.BackColor = Color.Transparent; lbTitle.BackColor = Color.Transparent; lbVersion.BackColor = Color.Transparent; btnBosses.BackColor = Color.Transparent;
            }
            // Animation smoothing
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
        int b1 = 0, b2 = 816, x1 = 0, x2 = 816, g1 = 0, g2 = 816, a1 = 0, t1 = 0, t2 = 816, s1 = 0, s2 = 816;

        private void tmParralax_Tick(object sender, EventArgs e)
        { // Adjusts the background layers every timer tick
            background_move();
        }

        private void frmQuestionTypeChooser_Paint(object sender, PaintEventArgs e)
        {
            // Creating moving parallax effect or just painting on background image instead depending on if parallax is enabled or not
            if (frmSplashScreen.CPlayer.Parallax == true)
            {
                e.Graphics.DrawImage(layer_Clouds, t1, 0);
                e.Graphics.DrawImage(layer_Clouds, t2, 0);
                e.Graphics.DrawImage(layer_Rainbow, a1, 0);
                e.Graphics.DrawImage(layer_1, b1, 0);
                e.Graphics.DrawImage(layer_1, b2, 0);
                e.Graphics.DrawImage(layer_2, x1, 0);
                e.Graphics.DrawImage(layer_2, x2, 0);
                e.Graphics.DrawImage(layer_3, g1, 0);
                e.Graphics.DrawImage(layer_3, g2, 0);
                e.Graphics.DrawImage(layer_4, s1, 0);
                e.Graphics.DrawImage(layer_4, s2, 0);
            }
            else if (frmSplashScreen.CPlayer.Parallax == false)
            {
                e.Graphics.DrawImage(layer_Clouds, 0, 0);
                e.Graphics.DrawImage(layer_Clouds, 0, 0);
                e.Graphics.DrawImage(layer_Rainbow, 0, 0);
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_1, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_2, 0, 0);
                e.Graphics.DrawImage(layer_3, 0, 0);
                e.Graphics.DrawImage(layer_3, 0, 0);
                e.Graphics.DrawImage(layer_4, 0, 0);
                e.Graphics.DrawImage(layer_4, 0, 0);
            }
        }

        // Method to translate text
        private void translate()
        {
            // Checking what language the user has selected and applying accordingly
            switch (frmSplashScreen.CPlayer.Language)
            {
                case "en":
                    lbTitle.Text = "Please choose a question type";
                    btnBosses.Text = "Bosses";
                    btnWeapons.Text = "Weapons";
                    btnNpcs.Text = "Npcs";
                    btnRandom.Text = "Random";
                    break;
                case "es":
                    lbTitle.Text = frmSplashScreen.Translator.TranslateText("Please choose a question type", "en", "es");
                    btnBosses.Text = frmSplashScreen.Translator.TranslateText("Bosses", "en", "es");
                    btnWeapons.Text = frmSplashScreen.Translator.TranslateText("Weapons", "en", "es");
                    btnNpcs.Text = frmSplashScreen.Translator.TranslateText("Npcs", "en", "es");
                    btnRandom.Text = frmSplashScreen.Translator.TranslateText("Random", "en", "es");
                    break;
                case "fr":
                    lbTitle.Text = frmSplashScreen.Translator.TranslateText("Please choose a question type", "en", "fr");
                    btnBosses.Text = frmSplashScreen.Translator.TranslateText("Bosses", "en", "fr");
                    btnWeapons.Text = frmSplashScreen.Translator.TranslateText("Weapons", "en", "fr");
                    btnNpcs.Text = frmSplashScreen.Translator.TranslateText("Npcs", "en", "fr");
                    btnRandom.Text = frmSplashScreen.Translator.TranslateText("Random", "en", "fr");
                    break;
                case "de":
                    lbTitle.Text = frmSplashScreen.Translator.TranslateText("Please choose a question type", "en", "de");
                    btnBosses.Text = frmSplashScreen.Translator.TranslateText("Bosses", "en", "de");
                    btnWeapons.Text = frmSplashScreen.Translator.TranslateText("Weapons", "en", "de");
                    btnNpcs.Text = frmSplashScreen.Translator.TranslateText("Npcs", "en", "de");
                    btnRandom.Text = frmSplashScreen.Translator.TranslateText("Random", "en", "de");
                    break;
            }
        }
        void background_move()
        {
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
            if (s1 < -816)
            {
                s1 = 809;
            }
            s2 -= 5;
            s1 -= 5;
            if (s2 < -816)
            {
                s2 = 809;
            }
            Invalidate();
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
        private void setUpPlayer()
        {
            // Sets the question type that the player has chosen
            frmSplashScreen.CPlayer.Type = type;
            frmSplashScreen.AccountManager.ChangeType(frmSplashScreen.CPlayer.PlayerId, type);
            switch(type)
            {
                case 1:
                    if (!frmSplashScreen.AchievementManager.IsAchievementCompleted(frmSplashScreen.CPlayer.PlayerId, 3))
                    {
                        frmSplashScreen.formAchieve.Show();
                        frmSplashScreen.AchievementManager.MarkAchievementCompleted(frmSplashScreen.CPlayer.PlayerId, 3);
                    }
                    break;
                case 2:
                    if (!frmSplashScreen.AchievementManager.IsAchievementCompleted(frmSplashScreen.CPlayer.PlayerId, 4))
                    {
                        frmSplashScreen.formAchieve.Show();
                        frmSplashScreen.AchievementManager.MarkAchievementCompleted(frmSplashScreen.CPlayer.PlayerId, 4);
                    }
                    break;
                case 3:
                    if (!frmSplashScreen.AchievementManager.IsAchievementCompleted(frmSplashScreen.CPlayer.PlayerId, 5))
                    {
                        frmSplashScreen.formAchieve.Show();
                        frmSplashScreen.AchievementManager.MarkAchievementCompleted(frmSplashScreen.CPlayer.PlayerId, 5);
                    }
                    break;
            }
        }

        private void btnBosses_Click(object sender, EventArgs e)
        {
            // Sets the question type on the form then calls the method to update it and shows the next form
            type = 1;
            setUpPlayer();
            Hide();
            new frmQuestionsEasy().Show();
        }

        private void btnWeapons_Click(object sender, EventArgs e)
        {
            // Sets the question type on the form then calls the method to update it and shows the next form
            type = 2;
            setUpPlayer();
            Hide();
            new frmQuestionsEasy().Show();
        }

        private void btnNpcs_Click(object sender, EventArgs e)
        {
            // Sets the question type on the form then calls the method to update it and shows the next form
            type = 3;
            setUpPlayer();
            Hide();
            new frmQuestionsEasy().Show();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            // Sets the random question type on the form then calls the method to update it and shows the next form
            Random ran = new Random();
            int rnd = ran.Next(1, 4);
            type = rnd;
            setUpPlayer();
            Hide();
            new frmQuestionsEasy().Show();
        }

        private void frmQuestionTypeChooser_Load(object sender, EventArgs e)
        {
            // Changing the version text when form is loaded
            lbVersion.Text = Version.version;
            loadFont();
            translate();
            ApplyFont(font, this.btnBosses, 22);
            ApplyFont(font, this.btnWeapons, 22);
            ApplyFont(font, this.btnNpcs, 22);
            ApplyFont(font, this.btnRandom, 22);
            ApplyFont(font, this.lbVersion, 13);
            ApplyFont(font, this.lbTitle, 22);
            // Changing form text to display Terraria Quiz and the splash text
            this.Text = "Terraria Quiz: " + frmSplashScreen.CSplashText.SplashT;
        }
    }
}
