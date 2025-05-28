using AprilBatchCoreProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AprilBatchCoreProject.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            var e = new Emp()
            {
                id = 101,
                name = "John",
                salary = 20000
            };

            var e1 = new List<Emp>()
            {
                new Emp{id=101,name="John",salary=1000},
                new Emp{id=102,name="Ram",salary=2000},
                
            };

            var m1 = new List<Manager>()
            {
                new Manager{Mid=1,Mname="Rohan"},
                new Manager{Mid=2,Mname="Mohan"},
                new Manager{Mid=3,Mname="Sohan"},
            };

            var h1 = new Hybrid()
            {
                emps = e1,
                mngs = m1
            };
            
            return View(h1);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
