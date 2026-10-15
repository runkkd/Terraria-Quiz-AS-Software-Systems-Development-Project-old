using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public class PlayerAchievement
    { // Declaring variables required for class then getting and setting them
        public string PlayerId { get; set; }
        public int AchievementId { get; set; }
        public bool Completed { get; set;}

        // Constructor to set up inital values
        public PlayerAchievement(string playerId, int achievementId, bool completed)
        {
            PlayerId = playerId;
            AchievementId = achievementId;
            Completed = completed;
        }
    }
}
