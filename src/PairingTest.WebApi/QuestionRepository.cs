using System.Collections.Generic;
using PairingTest.WebApi.Interfaces;

namespace PairingTest.WebApi
{
    public class QuestionRepository : IQuestionRepository
    {
        public Questionnaire GetQuestionnaire()
        {
            return new Questionnaire
            {
                QuestionnaireTitle = "Geography Questions",
                QuestionsText = new List<string>
                {
                    "What is the capital of Cuba?",
                    "What is the capital of France?",
                    "What is the capital of Poland?",
                    "What is the capital of Germany?"
                }
            };
        }
    }
}