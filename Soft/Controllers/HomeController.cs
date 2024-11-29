using Microsoft.AspNetCore.Mvc;
using Nc.Soft.Models;
using System.Diagnostics;

namespace Nc.Soft.Controllers; 
public class HomeController(ILogger<HomeController> logger) : Controller {
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index() => View();
    

    public IActionResult Privacy() => View();
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() =>
        View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    
}