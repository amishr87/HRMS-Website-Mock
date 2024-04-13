using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HelloASPDotNET.Models;

namespace HelloASPDotNET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult DefaultPage()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]//my code***********************
    public IActionResult SubmitForm(string name, string email, string message)
    {
        // Perform validation and processing of the form data
        // ...

        // Example: Display a success message
        ViewBag.SuccessMessage = "Form submitted successfully!";

        return View("Index");
    }//my code***********************

    public IActionResult Leave()
    {
        return View();
    }

    [HttpPost]//my code***********************
    public IActionResult SubmitLeaveRequest(string name, string message)
    {
        // Perform validation and processing of the form data
        // ...

        // Example: Display a success message
        ViewBag.SuccessMessage = "Form submitted successfully!";

        return View("Leave");
    }//my code***********************

    public IActionResult Tanda()
    {
        return View();
    }

    public IActionResult Recruit()
    {
        return View();
    }

    public IActionResult Help()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

