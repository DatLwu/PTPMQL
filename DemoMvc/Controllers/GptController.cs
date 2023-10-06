using Microsoft.AspNetCore.Mvc;
namespace DemoMvc.Controllers;
using DemoMvc.Models;
public class GptController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Solve(Abc DatLuu)
    {
        if (DatLuu.A == 0)
        {
            ViewBag.D = "A phai khac 0.";
            return View("Index", DatLuu);
        }

        DatLuu.Delta = DatLuu.B * DatLuu.B - 4 * DatLuu.A * DatLuu.C;
        ViewBag.A= "delta= " +DatLuu.Delta;
        if (DatLuu.Delta < 0)
        {
            ViewBag.B= "Phuong trinh khong vo nghiem.";
        }
        else if (DatLuu.Delta == 0)
        {
            DatLuu.X1 = -DatLuu.B / (2 * DatLuu.A);
            ViewBag.C = "Phuong trinh co nghiem kep: X1=X2="+DatLuu.X1;
        }
        else
        {
            DatLuu.X1 = (-DatLuu.B + Math.Sqrt(DatLuu.Delta)) / (2 * DatLuu.A);
            DatLuu.X2 = (-DatLuu.B - Math.Sqrt(DatLuu.Delta)) / (2 * DatLuu.A);
           ViewBag.D ="Phuong trinh co 2 nghiem: " + " X1= " + DatLuu.X1 + " ; "+ "X2 = " + DatLuu.X2;
        }
         
       
        return View("Index", DatLuu);
    }
}