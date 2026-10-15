using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public class SplashText
    { // Declare the variables required in the class
        private int randomNum = 0;
        private string splashT = "";
        // Constructor to set up the inital values
        public SplashText(int RandomNum, string SplashT)
        {  
            randomNum = RandomNum;
            splashT = SplashT;
        }
        public int RandomNum
        {
            get { return randomNum; }
        }
        public string SplashT
        {
            get { return splashT; }
            set { splashT = value; }
        }
        public void getRandomSplash()
        { // Gets a random splash text out of a list containing splash texts from Terraria and custom splash texts I created
            Random rnd = new Random();
            int ran = rnd.Next(1, 61);
            switch (ran)
            {
                case 1:
                    splashT = "You should also try Minecraft!";
                    break;
                case 2:
                    splashT = "Dig Peon, Dig!";
                    break;
                case 3:
                    splashT = "Judgement Clay";
                    break;
                case 4:
                    splashT = "Obsessive-Compulsive Discovery Simulator";
                    break;
                case 5:
                    splashT = "Red Dev Redemption";
                    break;
                case 6:
                    splashT = "Rumors of the Guides' death were greatly exaggerated";
                    break;
                case 7:
                    splashT = "I Pity the Tools...";
                    break;
                case 8:
                    splashT = "Now in 1D";
                    break;
                case 9:
                    splashT = "Can You Re-Dig-It?";
                    break;
                case 10:
                    splashT = "I don't know that-- aaaaa!";
                    break;
                case 11:
                    splashT = "NOT THE BEES!!!";
                    break;
                case 12:
                    splashT = "1 + 1 = 10";
                    break;
                case 13:
                    splashT = "Shut Up and Dig Gaiden!";
                    break;
                case 14:
                    splashT = "Sand is Overpowered";
                    break;
                case 15:
                    splashT = "Digger T' Blocks";
                    break;
                case 16:
                    splashT = "There is No Cow Layer";
                    break;
                case 17:
                    splashT = "Purple Grass!";
                    break;
                case 18:
                    splashT = "A spelunker says 'What'?";
                    break;
                case 19:
                    splashT = "May the blocks be with you";
                    break;
                case 20:
                    splashT = "Now with more ducks!";
                    break;
                case 21:
                    splashT = "Also try Stardew Valley!";
                    break;
                    // Beginning of custom splash texts
                case 22:
                    splashT = "Gelatinous fun for everyone!";
                    break;
                case 23:
                    splashT = "Breaking pots, breaking hearts.";
                    break;
                case 24:
                    splashT = "Eye of Cthulhu sees you studying.";
                    break;
                case 25:
                    splashT = "NPCs have feelings too!";
                    break;
                case 26:
                    splashT = "Cacti: Sharp and to the point.";
                    break;
                case 27:
                    splashT = "Skeletron says: Quiz or be quizzed!";
                    break;
                case 28:
                    splashT = "Minishark: The pen is mightier!";
                    break;
                case 29:
                    splashT = "Crafting your knowledge, one question at a time.";
                    break;
                case 30:
                    splashT = "Moon Lord approves of your quiz skills.";
                    break;
                case 31:
                    splashT = "Meteorites fall, knowledge rises.";
                    break;
                case 32:
                    splashT = "Fishing for answers in the vast ocean of wisdom.";
                    break;
                case 33:
                    splashT = "Wyverns can't answer quiz questions!";
                    break;
                case 34:
                    splashT = "Potion of Enlightenment: +50 Intelligence.";
                    break;
                case 35:
                    splashT = "Just don't dig straight down!";
                    break;
                case 36:
                    splashT = "Plantera wants you to grow your knowledge.";
                    break;
                case 37:
                    splashT = "Demolitionist: Boom, you're smarter!";
                    break;
                case 38:
                    splashT = "Wallof Flesh: Separating facts from fiction.";
                    break;
                case 39:
                    splashT = "The spelunker potion reveals the depths of your knowledge.";
                    break;
                case 40:
                    splashT = "Wizard knows all the magical answers.";
                    break;
                case 41:
                    splashT = "Terra Blade: Crafting excellence in every question.";
                    break;
                case 42:
                    splashT = "Starbound? More like Quizbound!";
                    break;
                case 43:
                    splashT = "Goblin Invasion: A wave of questions approaches!";
                    break;
                case 44:
                    splashT = "Dryad wants you to be environmentally conscious... in your answers.";
                    break;
                case 45:
                    splashT = "Crystal Hearts beat with the rhythm of knowledge.";
                    break;
                case 46:
                    splashT = "Lunar Events: The ultimate quiz challenge.";
                    break;
                case 47:
                    splashT = "Expert mode: Because quizzes should be hardcore!";
                    break;
                case 48:
                    splashT = "Guide to the Galaxy: Your quest for answers begins here.";
                    break;
                case 49:
                    splashT = "Eater of Worlds, eater of ignorance.";
                    break;
                case 50:
                    splashT = "Unicorn says: Quiz with rainbow power!";
                    break;
                case 51:
                    splashT = "Queen Bee would bee-lieve in your quiz abilities.";
                    break;
                case 52:
                    splashT = "Duke Fishron: Swimming in a sea of questions.";
                    break;
                case 53:
                    splashT = "Frost Moon: Chilling questions, hot answers.";
                    break;
                case 54:
                    splashT = "Martian Madness: Invading your mind with facts.";
                    break;
                case 55:
                    splashT = "Hallowed be thy quiz scores.";
                    break;
                case 56:
                    splashT = "Pumpkin Moon: Gourd-geous quiz mastery.";
                    break;
                case 57:
                    splashT = "Stardust Dragon: A quiz guardian from the cosmos.";
                    break;
                case 58:
                    splashT = "Nebula Brain: Expanding your knowledge.";
                    break;
                case 59:
                    splashT = "Solar Eclipse: Even vampires can't hide from the quiz!";
                    break;
                case 60:
                    splashT = "Platinum Coin: Your quiz winnings await!";
                    break;
                default:
                    splashT = "Also try Project Moon Quiz!";
                    break;
            }
        }
    }
}
