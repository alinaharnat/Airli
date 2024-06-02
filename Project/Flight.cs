using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    [Serializable]
    public class Flight
    {
        protected string departureСity;
        protected string destinationСity;
        protected string intermediateLandingPoint;
        protected DateTime dateTime;
        protected TimeSpan flightDuration;
        protected int id;
        protected double price;
        protected string carrier;
        private int numberOfAvailableSeats;
        private int seatsEconom;
        private int seatsBuisiness;
        private int seatsFirst;


        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public string IntermediateLandingPoint { get; set; }
        public DateTime DateTime { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public string Carrier { get; set; }
        public TimeSpan FlightDuration { get; set; }
        public int NumberOfAvailableSeats { get; set; }
        public int SeatsEconom { get; set; }
        public int SeatsBuisiness { get; set; }
        public int SeatsFirst { get; set; }
        public Flight()
        {

        }
        public Flight(string depСity, string destСity, string interLandPoint, DateTime dTime, TimeSpan duration, int i, double p, string carr, int economy, int business, int first)
        {
            this.departureСity = depСity;
            this.destinationСity = destСity;
            this.intermediateLandingPoint = interLandPoint;
            this.dateTime = dTime;
            this.flightDuration = duration;
            this.id = i;
            this.price = p;
            this.carrier = carr;
            this.numberOfAvailableSeats = first + economy + business;
            this.seatsEconom = economy;
            this.seatsBuisiness = business;
            this.seatsFirst = first;
        }
        public string GetInfoAboutFlight()
        {
            var res = $"Номер рейсу:{Id} \nМісто відправлення:{DepartureCity} \nМісто прибуття:{DestinationCity}\nМісто пресадки:{IntermediateLandingPoint} \nДата:{DateTime}\nТривалість:{FlightDuration}\nЦіна:{Price}  \nАвіакомпанія:{Carrier}  \nКількість вільних місць:\nЕконом-клас:{SeatsEconom}\nБізнес-клас:{SeatsBuisiness}\nПерший клас:{SeatsFirst}";
            return res;
        }
    }
}
