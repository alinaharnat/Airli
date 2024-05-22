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
        private double price;
        private string carrier;
        private int numberOfAvailableSeats;

        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public string IntermediateLandingPoint { get; set; }
        public DateTime DateTime { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public string Carrier { get; set; }
        public TimeSpan FlightDuration { get; set; }
        public int NumberOfAvailableSeats { get; set; } 
        public Flights()
        {

        }
        public Flights(string depСity, string destСity, string interLandPoint, DateTime dTime, TimeSpan duration, int i, double p, string carr, int AvailableSeats)
        {
          this.departureСity = depСity;
          this.destinationСity = destСity;
          this.intermediateLandingPoint = interLandPoint;
         this.dateTime = dTime;
        this.flightDuration = duration;
        this.id = i;
        this.price = p;
        this.carrier = carr;
       this.NumberOfAvailableSeats = AvailableSeats;
        }

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
                        (flight.DateTime.Date == date) && (flight.DateTime.Date >= DateTime.Now) && ( flight.NumberOfAvailableSeats > 0))
                    {
                       
                            res.Add(flight);
                        
                    }
                }
            }
            else
            {
                foreach (var flight in flights)
                {
                    if ((flight.DepartureCity.Equals(from, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(from) )&&
                       ( flight.DestinationCity.Equals(to, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(to)) && (flight.DateTime.Date >= DateTime.Now)&&(flight.NumberOfAvailableSeats > 0))
                    {
                            res.Add(flight);
                    }
                }
            }
            return res;
        }

    }
}
