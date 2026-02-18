using Microsoft.AspNetCore.Mvc;
using BusBookingWeb.Models;

namespace BusBookingWeb.Controllers;

public class ScheduleController : Controller
{
    public IActionResult Index(string? departure, string? destination)
    {
        var schedules = GetMockSchedules();

        if (!string.IsNullOrWhiteSpace(departure))
        {
            schedules = schedules.Where(s => s.Departure.Contains(departure, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        if (!string.IsNullOrWhiteSpace(destination))
        {
            schedules = schedules.Where(s => s.Destination.Contains(destination, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        return View(schedules);
    }

    private static List<BusSchedule> GetMockSchedules()
    {
        return new List<BusSchedule>
        {
            new BusSchedule
            {
                RouteName = "TP.Hồ Chí Minh - Đà Lạt",
                BusType = "Giường nằm",
                Distance = "310 km",
                Duration = "11 giờ",
                Price = "350.000đ",
                Departure = "TP.Hồ Chí Minh",
                Destination = "Đà Lạt"
            },
            new BusSchedule
            {
                RouteName = "TP.Hồ Chí Minh - Cần Thơ",
                BusType = "Ghế ngồi",
                Distance = "167 km",
                Duration = "4 giờ 30 phút",
                Price = "150.000đ",
                Departure = "TP.Hồ Chí Minh",
                Destination = "Cần Thơ"
            },
            new BusSchedule
            {
                RouteName = "TP.Hồ Chí Minh - Nha Trang",
                BusType = "Giường nằm",
                Distance = "450 km",
                Duration = "8 giờ",
                Price = "280.000đ",
                Departure = "TP.Hồ Chí Minh",
                Destination = "Nha Trang"
            },
            new BusSchedule
            {
                RouteName = "Hà Nội - Hải Phòng",
                BusType = "Ghế ngồi",
                Distance = "120 km",
                Duration = "2 giờ 30 phút",
                Price = "100.000đ",
                Departure = "Hà Nội",
                Destination = "Hải Phòng"
            },
            new BusSchedule
            {
                RouteName = "Đà Nẵng - Huế",
                BusType = "Ghế ngồi",
                Distance = "103 km",
                Duration = "2 giờ 45 phút",
                Price = "80.000đ",
                Departure = "Đà Nẵng",
                Destination = "Huế"
            },
            new BusSchedule
            {
                RouteName = "Đà Lạt - Đà Nẵng",
                BusType = "Giường nằm",
                Distance = "757 km",
                Duration = "17 giờ",
                Price = "800.000đ",
                Departure = "Đà Lạt",
                Destination = "Đà Nẵng"
            }
        };
    }
}
