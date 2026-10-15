using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Management;
using System.Windows.Forms;
using Newtonsoft.Json;
using TerrariaQuiz;

// Fully Commented [X]

public class AccountManager
{
    public List<PlayerJson> players;
    private Dictionary<int, string> topicNames;
    private string jsonFilePath = "player_accounts.json"; // Adjust the file path

    public AccountManager()
    {
        // Calling methods to load player accounts from the json files and initialize a dictionary for the topic names
        LoadPlayersFromJson();
        InitializeTopicNames();
    }
    private void InitializeTopicNames()
    {
        // Initialize your achievementNames dictionary with the mapping of achievement IDs to names
        topicNames = new Dictionary<int, string>
            {
                { 1, "Bosses" },
                { 2, "Weapons" },
                { 3, "NPCs" },
            };
    }
    public string GetTopicName(int topicId)
    {
        // Check if the topic exists in the dictionary, return the corresponding name; otherwise, return a default value or handle it as needed
        return topicNames.ContainsKey(topicId) ? topicNames[topicId] : $"Unknown Topic ({topicId})";
    }
    public void LoadPlayersFromJson()   
    {
        // Checking if the json file for player accounts exists then loading in players if so
        if (File.Exists(jsonFilePath))
        {
            string json = File.ReadAllText(jsonFilePath);
            players = JsonConvert.DeserializeObject<List<PlayerJson>>(json);
        }
        else
        {
            players = new List<PlayerJson>();
        }
    }
    // Method to get all players
    public List<PlayerJson> GetAllPlayers()
    {
        // Return a copy of the players list to avoid exposing the internal list
        return new List<PlayerJson>(players);
    }
    private void SavePlayersToJson()
    {
        string json = JsonConvert.SerializeObject(players, Formatting.Indented);
        File.WriteAllText(jsonFilePath, json);
    }
    // method to save parallax and audio changes
    public void SaveSettings(string playerId, bool newParallaxValue, int newMusicVolume, string newLanguage)
    {
        PlayerJson playerAccount = players.Find(p => p.PlayerId == playerId);

        if (playerAccount != null)
        {
            // Update parallax and audio settings
            playerAccount.Parallax = newParallaxValue;
            playerAccount.MusicVolume = newMusicVolume;
            playerAccount.Language = newLanguage;

            // Save changes to JSON file
            SavePlayersToJson();
        }
        else
        {
            Console.WriteLine($"Player with ID {playerId} not found.");
        }
    }
    public void AddAccount(string playerId, string password, int age)
    {
        // If an account of the same name doesnt exist a new account is added
        if (players.Find(p => p.PlayerId == playerId) == null)
        {
            PlayerJson newPlayer = new PlayerJson
            {
                PlayerId = playerId,
                Password = password,
                Age = age
            };

            players.Add(newPlayer);
            SavePlayersToJson();
        }
        else
        {
            // Handle account already exists
            Console.WriteLine("Account already exists.");
        }
    }
    public void ChangeScore(string playerId, int newScore)
    {
        // Find the player account by playerId
        PlayerJson playerAccount = players.FirstOrDefault(p => p.PlayerId == playerId);

        if (playerAccount != null)
        {
            // Update the player's score
            playerAccount.Score = newScore;

            SavePlayersToJson();
        }
        else
        {
            // Player not found
            Console.WriteLine($"Player with ID {playerId} not found.");
        }
    }

    public void ChangeType(string playerId, int newType)
    {
        // Find the player account by playerId
        PlayerJson playerAccount = players.FirstOrDefault(p => p.PlayerId == playerId);

        if (playerAccount != null)
        {
            // Update the player's type
            playerAccount.Type = newType;

            SavePlayersToJson();
        }
        else
        {
            // Player not found
            Console.WriteLine($"Player with ID {playerId} not found.");
        }
    }
    public void RemoveAccount(string playerId)
    {
        PlayerJson playerToRemove = players.Find(p => p.PlayerId == playerId);
        // If the player exists then it is removed from the list and saved to the json
        if (playerToRemove != null)
        {
            players.Remove(playerToRemove);
            SavePlayersToJson();
        }
        else
        {
            // Handle account not foundo
            Console.WriteLine("Account not found.");
        }
    }

    public void ChangeUsername(string oldPlayerId, string newPlayerId)
    {
        PlayerJson playerToChange = players.Find(p => p.PlayerId == oldPlayerId);
        // If the player exists then 
        if (playerToChange != null)
        {
            playerToChange.PlayerId = newPlayerId;
            SavePlayersToJson();
        }
        else
        {
            // Handle account not found
            Console.WriteLine("Account not found.");
        }
    }
    public string ValidateUsername(string playerId)
    {
        string result = "";
        // Validating the new username by checking if its null the correct length of an account already exists with that username
        if (string.IsNullOrEmpty(playerId))
        {
            result = "Provided New Username is null!";
            return result;
        }
        if (playerId.Length < 3)
        {
            result = "Username must be atleast 3 characters long!";
            return result;
        }
        if (players.Any(p => p.PlayerId == playerId))
        {   
            result = "An account already exists with the provided new username!";
            return result;
        }
        result = "Username successfully changed!";
        return result;
    }
    public string ValidatePassword(string password, string playerId)
    {
        string result = "";
        // Validating the new password by checking if it is null, the correct length and checking if the account to have its password changed exists
        if (string.IsNullOrEmpty(password))
        {
            result = "Provided New Password is null!";
            return result;
        }
        if (password.Length < 8)
        {
            result = "New Password must be atleast 8 characters long!";
            return result;
        }
        if (!players.Any(p => p.PlayerId == playerId))
        {
            result = "Invalid username";
            return result;
        }
        result = "Password successfully changed!";
        return result;
    }
    public string ValidateAchievement(string achievementId, string Obtained, string playerId) 
    {
        int intId = 0;
        string result = "";
        try
        {
            intId = Convert.ToInt32(achievementId);
        }
        catch
        {
            result = "Achievement Id must be a number!  ";
            return result;
        }
        // Validating the achievement change by checking if the achievment exists, if a valid obtainment state has been entered and if the account to have it's achievement status changed exists
        if (intId != 1 && intId != 2 && intId != 3 && intId != 4 && intId != 5)
        {
            result = "Invalid achievement Id";
            return result;
        }
        if (Obtained != "true" && Obtained != "True" && Obtained != "false" && Obtained != "False")
        {
            result = "Obtained status must be either true or false in lowercase";
            return result;
        }
        if (!players.Any(p => p.PlayerId == playerId))
        {
            result = "Invalid username";
            return result;
        }
        result = "Successfully changed achievement status!";
        return result;
    }
    public string ValidateAge(string playerId, string age)
    {
        string result = "";
        int intAge = 0;
        // Validating the new age by checking if the age is a number, if its in the valid age range and if the account to have its age changed exists
        try
        {
            intAge = Convert.ToInt32(age);
        }
        catch
        {
            result = "Age must be an integer!";
            return result;
        }
        if (intAge < 14 || intAge > 99 )
        {
            result = "Invalid age!";
            return result;
        }
        if (!players.Any(p => p.PlayerId == playerId))
        {
            result = "Invalid username!";
            return result;
        }
        result = "Age successfully changed!";
        return result;
    }
    public string[] ValidateRegistration(string playerId, string password, string confirmPassword, string age)
    {
        string[] infoToReturn = new string[3];
        // Check for null values
        if (string.IsNullOrEmpty(playerId) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(age))
        {
            infoToReturn[0] = "True"; // Indicates if an error has occurred
            infoToReturn[1] = "All fields must be filled."; // Text to show in message box
            infoToReturn[2] = "Null fields"; // Text to show in message box title   
            return infoToReturn;
        }

        // Check if passwords match
        if (password != confirmPassword)
        {
            infoToReturn[0] = "True";
            infoToReturn[1] = "Passwords do not match";
            infoToReturn[2] = "Invalid password";
            return infoToReturn;
        }

        // Check password length
        if (password.Length < 8)
        {
            infoToReturn[0] = "True";
            infoToReturn[1] = "Password must be at least 8 characters long.";
            infoToReturn[2] = "Invalid password";
            return infoToReturn;
        }

        // Check playerId length
        if (playerId.Length < 3)
        {
            infoToReturn[0] = "True";
            infoToReturn[1] = "Username must be at least 3 characters long.";
            infoToReturn[2] = "Invalid username";
            return infoToReturn;
        }

        // Check if age is a valid integer
        if (!int.TryParse(age, out int parsedAge))
        {
            infoToReturn[0] = "True";
            infoToReturn[1] = "Age must be a valid number.";
            infoToReturn[2] = "Invalid age";
            return infoToReturn;
        }

        // Check if age is between 14 and 99
        if (parsedAge < 14 || parsedAge > 99)
        {
            infoToReturn[0] = "True";
            infoToReturn[1] = "Age must be between 14 and 99.";
            infoToReturn[2] = "Invlid Age";
            return infoToReturn;
        }

        // Check if playerId is unique
        if (players.Any(p => p.PlayerId == playerId))
        {
            infoToReturn[0] = "True";
            infoToReturn[1] = ("An account with this name \"" + playerId + "\" already exists");
            infoToReturn[2] = "Invalid username";
            return infoToReturn;
        }

        // All checks passed, registration is valid
        infoToReturn[0] = "False";
        infoToReturn[1] = "Account created with name \"" + playerId + "\".";
        infoToReturn[2] = "Registration Successful";
        return infoToReturn;
    }
    public void ChangePassword(string playerId, string newPassword)
    {
        PlayerJson playerToChange = players.Find(p => p.PlayerId == playerId);  
        // if the player exists then the password is changed
        if (playerToChange != null)
        {
            playerToChange.Password = newPassword;
            SavePlayersToJson();
        }
        else
        {
            // Handle account not found
            Console.WriteLine("Account not found.");
        }
    }

    public void ChangeAge(string playerId, int newAge)
    {
        PlayerJson playerToChange = players.Find(p => p.PlayerId == playerId);
        // if the player exists the age is changed
        if (playerToChange != null)
        {
            playerToChange.Age = newAge;
            SavePlayersToJson();
        }
        else
        {
            // Handle account not found
            Console.WriteLine("Account not found.");
        }
    }

    public bool ValidateLogin(string playerId, string password)
    {
        PlayerJson playerToValidate = players.Find(p => p.PlayerId == playerId && p.Password == password);

        if (playerToValidate != null)
        {
            // Successful login
            return true;
        }
        else
        {
            // Invalid credentials
            return false;
        }
    }
    public bool ValidateAdmin(string playerId)
    {
        PlayerJson playerToValidate = players.Find(p => p.PlayerId == playerId && p.Admin == true);

        if (playerToValidate != null)
        {
            // Account is an administrator
            return true;
        }
        else
        {
            // Account is not an administrator
            return false;
        }
    }
    // Reads and updates the MusicVolume property for existing players from the JSON file.
    public void LoadMusicVolume()
    {
        // Check if the JSON file exists
        if (File.Exists(jsonFilePath))
        {
            // Read the entire JSON content from the file
            string json = File.ReadAllText(jsonFilePath);

            // Deserialize the JSON content into a list of PlayerJson objects
            List<PlayerJson> loadedPlayers = JsonConvert.DeserializeObject<List<PlayerJson>>(json);

            // Iterate through the loaded players
            foreach (var loadedPlayer in loadedPlayers)
            {
                // Find the corresponding player in the existing players list
                PlayerJson existingPlayer = players.Find(p => p.PlayerId == frmSplashScreen.CPlayer.PlayerId);

                // If the player exists, update the MusicVolume property
                if (existingPlayer != null)
                {
                    frmSplashScreen.CPlayer.MusicVolume = existingPlayer.MusicVolume;
                }
            }
        }
    }

    // Reads and updates the Parallax property for existing players from the JSON file.
    public void LoadParallax()
    {
        // Check if the JSON file exists
        if (File.Exists(jsonFilePath))
        {
            // Read the entire JSON content from the file
            string json = File.ReadAllText(jsonFilePath);

            // Deserialize the JSON content into a list of PlayerJson objects
            List<PlayerJson> loadedPlayers = JsonConvert.DeserializeObject<List<PlayerJson>>(json);

            // Iterate through the loaded players
            foreach (var loadedPlayer in loadedPlayers)
            {
                // Find the corresponding player in the existing players list
                PlayerJson existingPlayer = players.Find(p => p.PlayerId == frmSplashScreen.CPlayer.PlayerId);

                // If the player exists, update the Parallax property
                if (existingPlayer != null)
                {
                    frmSplashScreen.CPlayer.Parallax = existingPlayer.Parallax;
                }
            }
        }
    }
    // Reads and updates the Language property for existing players from the JSON file.
    public void LoadLanguage()
    {
        // Check if the JSON file exists
        if (File.Exists(jsonFilePath))
        {
            // Read the entire JSON content from the file
            string json = File.ReadAllText(jsonFilePath);

            // Deserialize the JSON content into a list of PlayerJson objects
            List<PlayerJson> loadedPlayers = JsonConvert.DeserializeObject<List<PlayerJson>>(json);

            // Iterate through the loaded players
            foreach (var loadedPlayer in loadedPlayers)
            {
                // Find the corresponding player in the existing players list
                PlayerJson existingPlayer = players.Find(p => p.PlayerId == frmSplashScreen.CPlayer.PlayerId);

                // If the player exists, update the Language property
                if (existingPlayer != null)
                {
                    frmSplashScreen.CPlayer.Language = existingPlayer.Language;
                }
            }
        }
    }
}