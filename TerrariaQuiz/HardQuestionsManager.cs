using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public class HardQuestionsManager
    {
        private List<HardQuestionGroup> questionGroups;

        public HardQuestionsManager()
        {
            // Calling method to load in the question data from the json file
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            // Reads in the json file and deserializes it
            string jsonText = File.ReadAllText("hard_questions.json");
            questionGroups = JsonConvert.DeserializeObject<List<HardQuestionGroup>>(jsonText) ?? new List<HardQuestionGroup>();
        }

        public List<HardQuestionInfo> GetRandomQuestionInfo(QuestionType questionType)
        {
            // Gets the question set based on the question topic
            var questionSet = GetQuestionSet(questionType);

            if (questionSet != null && questionSet.Questions.Count > 0)
            {
                // Get a random question from the set
                Random random = new Random();
                int randomIndex = random.Next(0, questionSet.Questions.Count);
                return questionSet.Questions[randomIndex].QuestionInfo;
            }

            return null;
        }

        private HardQuestionSet GetQuestionSet(QuestionType questionType)
        {
            // Loads in a the questions grouped by the specified topic
            return questionGroups.FirstOrDefault(group => group.Type == questionType.ToString())?.QuestionSets.FirstOrDefault();
        }
        // Class for base of each question
        public class HardQuestionBase
        {
            public int QuestionId { get; set; }
            public List<HardQuestionInfo> QuestionInfo { get; set; }
        }
        // Class for the parts of each question
        public class HardQuestionInfo
        {
            public string QuestionText { get; set; }
            public List<ComboBoxItems> ComboBoxOneItems { get; set; }
            public List<ComboBoxItems> ComboBoxTwoItems { get; set; }
            public List<ComboBoxItems> ComboBoxThreeItems { get; set; }
            public List<ComboBoxItems> ComboBoxFourItems { get; set; }
            public List<ComboBoxItems> ComboBoxFiveItems { get; set; }
        }
        // Class for combo box parts
        public class ComboBoxItems
        {
            public string Items { get; set; }
            public string CorrectAnswer { get; set; }
        }
        // Class to group all questions sets by type
        public class HardQuestionGroup
        {
            public string Type { get; set; }
            public List<HardQuestionSet> QuestionSets { get; set; }
        }
        // Class to contain all question sets
        public class HardQuestionSet
        {
            public List<HardQuestionBase> Questions { get; set; }
        }
        // Enum values for topic type
        public enum QuestionType
        {
            bosses,
            weapons,
            npcs
        }
    }
}
