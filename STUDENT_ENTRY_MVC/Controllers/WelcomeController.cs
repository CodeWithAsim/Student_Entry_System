using Microsoft.AspNetCore.Mvc;

namespace STUDENT_ENTRY_MVC.Controllers
{
    public class WelcomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
