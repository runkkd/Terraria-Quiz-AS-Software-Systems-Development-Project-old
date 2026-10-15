using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using static TerrariaQuiz.EasyQuestionsManager;

// Fully Commented [X]

namespace TerrariaQuiz
{
    public class EasyQuestionsManager
    {
        private List<QuestionGroup> questionGroups;

        public EasyQuestionsManager()
        {
            // Loading in the questions from a json file
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            // String value to contain name of questions json
            string jsonText = File.ReadAllText("easy_questions.json");
            questionGroups = JsonConvert.DeserializeObject<List<QuestionGroup>>(jsonText) ?? new List<QuestionGroup>();
        }

        public List<QuestionBase> GetRandomQuestions(QuestionType questionType)
        {
            var questions = GetQuestions(questionType);

            // Shuffle the questions and take three random questions
            List<QuestionBase> randomQuestions = questions.OrderBy(q => Guid.NewGuid()).Take(3).ToList();

            return randomQuestions;
        }

        private List<QuestionBase> GetQuestions(QuestionType questionType)
        {
            var questions = new List<QuestionBase>();

            // Find the appropriate question group
            var questionGroup = questionGroups.FirstOrDefault(group => group.Type == questionType.ToString());
            if (questionGroup != null)
            {
                foreach (var questionSet in questionGroup.QuestionSets)
                {
                    questions.AddRange(questionSet.Questions);
                }
            }

            return questions;
        }
        // Class for the base of each question
        public class QuestionBase
        {
            public int QuestionId { get; set; }
            public string QuestionText { get; set; }
            public string Answer1 { get; set; }
            public string Answer2 { get; set; }
            public string Answer3 { get; set; }
            public string Answer4 { get; set; }
            public string CorrectAnswer { get; set; }
        }
        // Class to group all questions
        public class QuestionGroup
        {
            public string Type { get; set; }
            public List<QuestionSet> QuestionSets { get; set; }
        }
        // Class to group the grouped questions by question type
        public class QuestionSet
        {
            public List<QuestionBase> Questions { get; set; }
        }
        // Enum values for question topics
        public enum QuestionType
        {
            bosses,
            weapons,
            npcs
        }
    }
}