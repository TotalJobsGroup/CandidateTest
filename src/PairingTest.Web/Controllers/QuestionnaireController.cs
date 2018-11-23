using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PairingTest.Web.Models;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IConfiguration _config;

        public QuestionnaireController(IConfiguration config)
        {
            _config = config;
        }

        public ViewResult Index()
        {
            return View(new QuestionnaireViewModel());
        }

        /* ASYNC ACTION METHOD... IF REQUIRED... */
        //public async Task<ViewResult> Index()
        //{
        //}
    }
}
