using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Fully Commented [X]

public class ExtremeQuestionsManager
{
    private List<QuestionGroup> questionGroups;
    private string jsonFilePath = "extreme_questions.json";

    public ExtremeQuestionsManager()
    {
        // Method to load in the questions from the json file
        LoadQuestions(jsonFilePath);
    }

    private void LoadQuestions(string jsonFilePath)
    {
        // If the json file exists then it is deserialized and put into the question group class
        if (File.Exists(jsonFilePath))
        {
            string jsonContent = File.ReadAllText(jsonFilePath);
            questionGroups = JsonConvert.DeserializeObject<List<QuestionGroup>>(jsonContent) ?? new List<QuestionGroup>();
        }
        else
        {
            throw new FileNotFoundException($"JSON file not found at: {jsonFilePath}");
        }
    }

    public QuestionBase GetRandomQuestionByType(QuestionType questionType)
    {
        var questions = GetQuestions(questionType);
        // If the amount of questions is greater than 0 then a random question is returned
        if (questions.Count > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(questions.Count);
            return questions[randomIndex];
        }
        else
        {
            throw new InvalidOperationException($"No questions found for type: {questionType}");
        }
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
        public List<QuestionInfo> QuestionInfo { get; set; }
    }
    // Class to handle the parts of each question
    public class QuestionInfo
    {
        public string QuestionText { get; set; }
        public string VideoFileName { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string CorrectAnswer { get; set; }
    }
    // Class to group the questions together by type
    public class QuestionGroup
    {
        public string Type { get; set; }
        public List<QuestionSet> QuestionSets { get; set; }
    }
    // Class to group all questions together
    public class QuestionSet
    {
        public List<QuestionBase> Questions { get; set; }
    }
    // Enum values for question topic
    public enum QuestionType
    {
        bosses,
        weapons,
        npcs
    }
    
}
