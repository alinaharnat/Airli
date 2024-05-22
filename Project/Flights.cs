using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

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
        private int numberOfAvaliableSeats;

        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public string IntermediateLandingPoint { get; set; }
        public DateTime DateTime { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        private string Carrier { get; set; }

        public static List<Flights> GetAvaliableFlights(string path)
        {
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Flights>>(json);
        }
    }
}
