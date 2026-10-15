using System.Collections.Generic;
using TerrariaQuiz;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public class PlayerJson
    { // Declaring variables required for class then getting and setting them
        public string PlayerId { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public int Type { get; set; }
        public List<PlayerAchievement> Achievements { get; set; }
        public bool Admin { get; set; }
        public int MusicVolume { get; set; }
        public bool Parallax { get; set; }
        public string Language { get; set; }
    }
}
    
