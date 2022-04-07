using Microsoft.AspNetCore.Mvc;

namespace portfolio_practice_c
{

    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }

        [Route("projects")]
        [HttpGet]
        public ViewResult Projects()
        {
            return View("Projects");
        }

        [Route("contact")]
                [HttpGet]
        public ViewResult Contact()
        {
            return View("Contact");
        }
    }
}