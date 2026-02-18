using Microsoft.AspNetCore.Mvc;

namespace BusBookingWeb.Controllers;

public class BookingController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
