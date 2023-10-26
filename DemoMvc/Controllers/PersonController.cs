using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers{
    public class PersonController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
    
        public IActionResult Index(Person ps){
            String str = "Hello " + ps.PersonID + " - " + ps.FullName.ToUpper();
            ViewBag.Tb= str;
            return View();
    }
    }
}