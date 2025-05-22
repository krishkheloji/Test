using AprilBatchCoreProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AprilBatchCoreProject.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string User,string Pass)
        {
            var obj = new Login()
            {
                Username=User,
                Password=Pass
            };
            return View(obj);
        }

        public IActionResult CheckData()
        {
            var tdata = new List<Login>()
            {
                new Login{ Username="Johnson",Password="123"},
                new Login{ Username="Sameer",Password="123"},
                new Login{ Username="Gulam",Password="123"}
            };
            var t = new Login();
            var m = new Mixed()
            {
                log = t,
                logs = tdata
            };
            return View(m);
        }

        [HttpPost]
        public IActionResult CheckData(Mixed mul)
        {
            var tdata = new List<Login>()
            {
                new Login{ Username="Johnson",Password="123"},
                new Login{ Username="Sameer",Password="123"},
                new Login{ Username="Gulam",Password="123"}
            };
            
            var m = new Mixed()
            {
                log=mul.log,
                logs=tdata
            };


            if(m.log.Username.Equals(m.log.Password))
            {
                return RedirectToAction("Home","Test"); //RedirectToAction("ActionName","ControllerName");
            }
            else
            {
                return View(m);
            }
            //return View(log);
        }
        public string displayName(string name)
        {
            return $"Your Name {name}";
        }

        public string Add(int a,int b)
        {
            return $"Add is {a+b}";
        }

    }
}
