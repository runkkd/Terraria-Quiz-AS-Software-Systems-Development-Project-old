using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public class VeryHardQuestionsManager
    {
        private List<QuestionGroup> quizCategories;

        public VeryHardQuestionsManager()
        {
            // Calling method to load in questions from json file
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            // Reads in the data from the json file and deserializes it and puts it into the question group class
            string jsonFilePath = "veryhard_questions.json";
            string jsonText = File.ReadAllText(jsonFilePath);
            quizCategories = JsonConvert.DeserializeObject<List<QuestionGroup>>(jsonText) ?? new List<QuestionGroup>();
        }

        public List<QuestionInfo> GetRandomQuestionInfo(QuestionType questionType)
        {
            // Randomly returns questions so they are differemt every time
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

        private QuestionSet GetQuestionSet(QuestionType questionType)
        {
            // Returns a set of questions to be used
            return quizCategories.FirstOrDefault(category => category.Type == questionType.ToString())?.QuestionSets.FirstOrDefault();
        }
        // Class for the base of each question
        public class QuestionBase
        {
            public int QuestionId { get; set; }
            public List<QuestionInfo> QuestionInfo { get; set; }
        }
        // Class to hold the parts of each question
        public class QuestionInfo
        {
            public string LeftText { get; set; }
            public string RightText { get; set; }
            public string LeftItems { get; set; }
            public string RightItems { get; set; }
            public string Items { get; set; }
        }
        // Class to group each question together by type
        public class QuestionGroup
        {
            public string Type { get; set; }
            public List<QuestionSet> QuestionSets { get; set; }
        }
        // Class to hold all questions
        public class QuestionSet
        {
            public List<QuestionBase> Questions { get; set; }
        }
        // Enum values to represent question topics
        public enum QuestionType
        {
            bosses,
            weapons,
            npcs
        }
    }
}
