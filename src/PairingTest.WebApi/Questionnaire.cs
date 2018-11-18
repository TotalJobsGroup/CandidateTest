using System.Collections.Generic;

namespace PairingTest.WebApi
{
    public class Questionnaire
    {
        public string QuestionnaireTitle { get; set; }
        public IList<string> QuestionsText { get; set; }
    }
}