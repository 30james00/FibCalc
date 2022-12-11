using FibCalc.Models;
using FibCalc.Services;
using Microsoft.AspNetCore.Mvc;

namespace FibCalc.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Calculate([Bind("Value")] FibonacciModel fibonacciModel)
    {
        fibonacciModel.Result = FibonacciService.Calculate(fibonacciModel.Value);
        return View(fibonacciModel);
    }
}