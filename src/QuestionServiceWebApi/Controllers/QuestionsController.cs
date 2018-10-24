using Microsoft.AspNetCore.Mvc;
using QuestionServiceWebApi.Interfaces;

namespace QuestionServiceWebApi.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionsController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        // GET api/questions
        [HttpGet]
        public Questionnaire Get()
        {
            return _questionRepository.GetQuestionnaire();
        }

        // GET api/questions/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "";
        }

        // POST api/questions
        public void Post([FromBody]string value)
        {
        }

        // PUT api/questions/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/questions/5
        public void Delete(int id)
        {
        }
    }
}
