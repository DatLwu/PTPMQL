using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers;
public class EmployeeController : Controller{
    public IActionResult Index(){
        return View();
    }
    [HttpPost]
    public IActionResult Index(Employee emp){
        string str = "Hello " + emp.EmployeeID + " - "  + emp.FullName;
        ViewBag.A = str;
        return View();
    }
}