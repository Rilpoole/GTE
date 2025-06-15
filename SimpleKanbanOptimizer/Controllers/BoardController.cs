using Microsoft.AspNetCore.Mvc;

namespace SimpleKanbanOptimizer.Controllers
{
    public class BoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
