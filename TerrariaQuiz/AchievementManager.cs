using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Newtonsoft.Json;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public class AchievementManager
    {
        public event EventHandler<PlayerAchievement> AchievementUnlocked;
        private Dictionary<int, string> achievementNames;
        public List<PlayerAchievement> playerAchievements;
        private List<PlayerJson> loadedPlayers;

        public AchievementManager()
        {
            playerAchievements = new List<PlayerAchievement>();
            LoadAchievements(); // Load achievements from file when the manager is created.
            InitializeAchievementNames(); // Initializes a dictionary of the achievements w ith their achievement ids
        }
        private void InitializeAchievementNames()
        {
            // Initialize your achievementNames dictionary with the mapping of achievement IDs to names
            achievementNames = new Dictionary<int, string>
            {
                { 1, "Quiz Achiever" },
                { 2, "Quizmaster Conqueror" },
                { 3, "Boss Vanquisher" },
                { 4, "Arms Maestro" },
                { 5, "Citizen Scholar" },
            };
        }

        public string GetAchievementName(int achievementId)
        {
            // Check if the achievementId exists in the dictionary, return the corresponding name; otherwise, return a default value or handle it as needed
            return achievementNames.ContainsKey(achievementId) ? achievementNames[achievementId] : $"Unknown Achievement ({achievementId})";
        }
        protected virtual void OnAchievementUnlocked(PlayerAchievement e)
        {
            // Invokes the AchievementUnlocked event
            AchievementUnlocked?.Invoke(this, e);
        }

        public List<PlayerJson> LoadPlayersFromJson(string filePath)
        {
            loadedPlayers = new List<PlayerJson>();

            // Read the JSON file and deserialize it into a list of Player objects
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                loadedPlayers = JsonConvert.DeserializeObject<List<PlayerJson>>(json);
            }
            // Load achievements for each player
            foreach (var player in loadedPlayers)
            {
                    if (File.Exists(filePath))
                    {
                        string json = File.ReadAllText(filePath);
                        List<PlayerAchievement> allAchievements = JsonConvert.DeserializeObject<List<PlayerAchievement>>(json);

                        // Filter achievements based on the specified playerId
                        player.Achievements = allAchievements.Where(a => a.PlayerId == player.PlayerId).ToList();
                    }
                }

            return loadedPlayers;
    }
        public void LoadAchievements()
        {
            // Load player-specific achievements from a JSON file
            string json = File.ReadAllText("player_achievements.json");
            playerAchievements = JsonConvert.DeserializeObject<List<PlayerAchievement>>(json) ?? new List<PlayerAchievement>(); 
        }

        public void SaveAchievements()
        {
            // Save player-specific achievements to a JSON file
            string json = JsonConvert.SerializeObject(playerAchievements, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("player_achievements.json", json); 
        }     

        public bool IsAchievementCompleted(string playerId, int achievementId)
        {
            // Check if a specific achievement is completed for a player
            string json = File.ReadAllText("player_achievements.json");
            playerAchievements = JsonConvert.DeserializeObject<List<PlayerAchievement>>(json) ?? new List<PlayerAchievement>();
            return playerAchievements.Any(a => a.PlayerId == playerId && a.AchievementId == achievementId && a.Completed);
        }       
        // Changes player username in the achievements file 
        public void ChangePlayerUsername(string oldPlayerId, string newPlayerId)
        {
            // Loops through players
            for (int i = 0; i < 5; i++) 
            {
                // Find the player in loadedPlayers by oldPlayerId
                var playerToChange = playerAchievements.Find(p => p.PlayerId == oldPlayerId);

                if (playerToChange != null)
                {
                    // Update the player's username
                    playerToChange.PlayerId = newPlayerId;

                    // Update the corresponding achievements
                    foreach (var achievement in playerAchievements.Where(a => a.PlayerId == oldPlayerId))
                    {
                        achievement.PlayerId = newPlayerId;
                    }

                    // Save changes to JSON files
                    SaveAchievements();

                    Console.WriteLine($"Player username changed from {oldPlayerId} to {newPlayerId}.");
                }
                else
                {
                    // Handle account not found
                    Console.WriteLine("Player not found.");
                }
            }
        }
        public void MarkAchievementCompleted(string playerId, int achievementId)
        {
            // Mark a specific achievement as completed for a player
            var playerAchievement = playerAchievements.FirstOrDefault(a => a.PlayerId == playerId && a.AchievementId == achievementId);

            if (playerAchievement != null)
            {
                playerAchievement.Completed = true;
                SaveAchievements(); // Save changes after marking completion
                OnAchievementUnlocked(new PlayerAchievement(playerId, achievementId, true));
            }     
        }
        public void MarkAchievementUncompleted(string playerId, int achievementId)
        {
            // Mark a specific achievement as completed for a player
            var playerAchievement = playerAchievements.FirstOrDefault(a => a.PlayerId == playerId && a.AchievementId == achievementId);

            if (playerAchievement != null)
            {
                playerAchievement.Completed = false;
                SaveAchievements(); // Save changes after marking completion
                OnAchievementUnlocked(new PlayerAchievement(playerId, achievementId, false));
            }
        }
    }
}
