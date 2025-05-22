using AprilBatchCoreProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AprilBatchCoreProject.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Emp e)
        {
            if(ModelState.IsValid)
            {
                return View(e);
            }
            else
            {
                return View();
            }
                
        }
    }
}
