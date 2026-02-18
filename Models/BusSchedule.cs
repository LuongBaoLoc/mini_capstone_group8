namespace BusBookingWeb.Models;

public class BusSchedule
{
    public string RouteName { get; set; } = string.Empty;
    public string BusType { get; set; } = string.Empty;
    public string Distance { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Departure { get; set; } = string.Empty;
    public string Destination { get; set; } = string.Empty;
}
