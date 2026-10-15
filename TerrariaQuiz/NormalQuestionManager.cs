using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Drawing;
using static TerrariaQuiz.EasyQuestionsManager;

// Fully Commented [X]

namespace TerrariaQuiz
    {
        public class NormalQuestionManager
        {
            public Dictionary<QuestionType, List<DragAndDropQuestion>> questionGroups;

            public NormalQuestionManager()
            {
            // Calling method to load in the questions for the json file
                LoadQuestions();
            }

            private void LoadQuestions()
            {
                // Loads in the data in the json file then deserializes it and puts it through the class
                string jsonText = File.ReadAllText("normal_questions.json");

                var allQuestionGroups = JsonConvert.DeserializeObject<List<DragAndDropQuestionGroup>>(jsonText);

                questionGroups = new Dictionary<QuestionType, List<DragAndDropQuestion>>();

                foreach (var group in allQuestionGroups)
                {
                    var questionType = (QuestionType)Enum.Parse(typeof(QuestionType), group.Type, true);
                    questionGroups.Add(questionType, group.Questions);
                }
            }

            public List<DragAndDropQuestion> GetRandomQuestions(QuestionType questionType, int count)
            {
                if (questionGroups.TryGetValue(questionType, out var questions))
                {
                    // Shuffle the questions
                    List<DragAndDropQuestion> shuffledQuestions = questions.OrderBy(q => Guid.NewGuid()).ToList();

                    // Ensure no duplicate questions
                    List<DragAndDropQuestion> selectedQuestions = new List<DragAndDropQuestion>();
                    HashSet<int> selectedQuestionIds = new HashSet<int>();

                    for (int i = 0; i < shuffledQuestions.Count && selectedQuestions.Count < count; i++)
                    {
                        var currentQuestion = shuffledQuestions[i];

                        // Check if the question ID is not already selected`
                        if (selectedQuestionIds.Add(currentQuestion.QuestionId))
                        {
                            selectedQuestions.Add(currentQuestion);
                        }
                    }
                return selectedQuestions;
            }
            return null;
        }

            public Image GetImageFromFile(string imageName)
            {
            // Gets the image from the image folder in the bin using the file name
                Image image = Image.FromFile(imageName);
                return image;
            }
            // Enum values to represent topic types
            public enum QuestionType
            {
                bosses,
                weapons,
                npcs
            }
            // Class to represent question parts
            public class DragAndDropQuestion
            {
                public int QuestionId { get; set; }
                public string QuestionText { get; set; }
                public string ImageFileName { get; set; }
            }
            // Class to represent each question by topic
            public class DragAndDropQuestionGroup
            {
                public string Type { get; set; }
                public List<DragAndDropQuestion> Questions { get; set; }
            }
        }
    }
