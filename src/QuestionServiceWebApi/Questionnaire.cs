using System.Collections.Generic;

namespace QuestionServiceWebApi
{
    public class Questionnaire
    {
        public string QuestionnaireTitle { get; set; }
        public IList<string> QuestionsText { get; set; }
    }
}