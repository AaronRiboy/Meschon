using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Meshcon.Models;
using Meshcon.Interfaces;

namespace Meshcon.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEmailSender _emailSender;

    public HomeController(ILogger<HomeController> logger,IEmailSender emailSender)
    {
        _logger = logger;
        _emailSender = emailSender;
    }

    public async Task<IActionResult> IndexAsync()
    {
        return View();
    }

    public IActionResult Project()
    {
        return View();
    }

    public IActionResult Service()
    {
        return View();
    }

    public IActionResult Blog()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

