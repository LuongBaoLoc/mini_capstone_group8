using Microsoft.AspNetCore.Mvc;

namespace BusBookingWeb.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
