using AviaticketManagment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace AviaticketManagment.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            List<Ticket> tickets = new List<Ticket>
            {
                new Ticket
                {
                    Type = "Premium",
                    Country = "Italy",
                    City = "Roma",
                    FlightDate = DateTime.Now.AddDays(5),
                    Price = 1200,
                    BaggageKg = 40,
                    Meal = true,
                    SeatSelection = true,
                    Wifi = true,
                    FastCheckIn = true
                },

                new Ticket
                {
                    Type = "Standard",
                    Country = "Turkey",
                    City = "İstanbul",
                    FlightDate = DateTime.Now.AddDays(10),
                    Price = 700,
                    BaggageKg = 35,
                    Meal = true,
                    SeatSelection = true,
                    Wifi = false,
                    FastCheckIn = false
                },

                new Ticket
                {
                    Type = "Economy",
                    Country = "Georgia",
                    City = "Tbilisi",
                    FlightDate = DateTime.Now.AddDays(3),
                    Price = 400,
                    BaggageKg = 30,
                    Meal = false,
                    SeatSelection = false,
                    Wifi = false,
                    FastCheckIn = false
                }

            };
            return View(tickets);
        }
    }
}
