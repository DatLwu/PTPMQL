using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers;
public class DemoController : Controller{
    public IActionResult Index(){
        return View();
    }
    [HttpPost]
    public IActionResult Index(string Tk, string Mk){
        string str = "Hello " + Tk + " - "  + Mk;
        ViewBag.A = str;
        return View();
    }
}