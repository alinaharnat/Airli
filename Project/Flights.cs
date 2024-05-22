using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Flights
    {
        private string departureСity;
        private string destinationСity;
        private string intermediateLandingPoint;
        private DateTime dateTime;
        private TimeSpan flightDuration;
        private int id;
        private decimal price;
        private string carrier;
        private int numberOfAvailableSeats;

        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public string IntermediateLandingPoint { get; set; }
        public DateTime DateTime { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Carrier { get; set; }
        public TimeSpan FlightDuration { get; set; }
        public int NumberOfAvailableSeats { get; set; } 

        public static List<Flights> GetAvailableFlights(string path)
        {
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Flights>>(json);
        }
        public static List<Flights> SearchAvailableFlights(string from, string to, DateTime date,bool anywhen, string path)
        {
            var flights = GetAvailableFlights(path);

            var res = new List<Flights>();
            if (!anywhen)
            {
                foreach (var flight in flights)
                {
                    if ((flight.DepartureCity.Equals(from, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(from) )&&
                       ( flight.DestinationCity.Equals(to, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(to)) &&
                        (flight.DateTime.Date == date) &&( flight.NumberOfAvailableSeats > 0))
                    {
                        if (flight.DateTime.Date >= DateTime.Now)
                        {
                            res.Add(flight);
                        }
                    }
                }
            }
            else
            {
                foreach (var flight in flights)
                {
                    if ((flight.DepartureCity.Equals(from, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(from) )&&
                       ( flight.DestinationCity.Equals(to, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(to)) && (flight.NumberOfAvailableSeats > 0))
                    {
                        if (flight.DateTime.Date >= DateTime.Now)
                        {
                            res.Add(flight);
                        }
                    }
                }
            }
            return res;
        }

    }
}
