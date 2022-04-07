using Microsoft.AspNetCore.Mvc;

namespace portfolio_practice_c
{

    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public string Index()
        {
            return "This is my Index!";
        }

        [Route("projects")]
        [HttpGet]
        public string Projects()
        {
            return "This is my Projects!";
        }

        [Route("contact")]
                [HttpGet]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}