using Microsoft.AspNetCore.Mvc;

namespace TASK_11_30_MusaMusazada.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is Home Page";
        }
        public string About()
        {
            return "This is About Page";
        }
        public string Boring()
        {
            return "THIS WEBSITE IS BORING";
        }
    }
}
