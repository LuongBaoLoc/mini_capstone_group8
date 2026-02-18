using Microsoft.AspNetCore.Mvc;

namespace BusBookingWeb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
