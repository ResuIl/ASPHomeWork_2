using ASPHomeWork_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace ASPHomeWork_2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Content()
    {
        return Content("SALAM DUNYA");
    }

    public ViewResult URLQueryTest(TestController fm)
    {
        return View(fm);
    }

    public JsonResult Json()
    {
        var json = JsonSerializer.Serialize("{Id: 1, Name: Resul, Surname: Black, Age: 31}");
        return Json(json);
    }
}
