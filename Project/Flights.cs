
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;



namespace Project
{

    public class Flights
    {
        public List<Flight> FlightsList { get; set; }
        public Flights()
        {
            FlightsList = new List<Flight>();
        }
        //Loading data
        public Flights GetAvailableFlights(string path)
        {
            var jsonStr = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Flights>(jsonStr);
        }
        //
        public void SaveFlightsData(string path)
        {
            var jsonStr = JsonSerializer.Serialize(this);
            File.WriteAllText(path, jsonStr);
        }
        public List<Flight> SearchAvailableFlights(string from, string to, DateTime date, bool anywhen, bool straight, string path)
        {
            var res = new List<Flight>();
            if (!anywhen)
            {
                foreach (var flight in FlightsList)
                {
                    if ((flight.DepartureCity.Equals(from, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(from)) &&
                       (flight.DestinationCity.Equals(to, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(to)) &&
                        (flight.DateTime.Date == date) && (flight.DateTime.Date >= DateTime.Now) && (flight.NumberOfAvailableSeats > 0))
                    {

                        res.Add(flight);

                    }
                }
            }
            else
            {
                foreach (var flight in FlightsList)
                {
                    if ((flight.DepartureCity.Equals(from, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(from)) &&
                       (flight.DestinationCity.Equals(to, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(to)) && (flight.DateTime.Date >= DateTime.Now) && (flight.NumberOfAvailableSeats > 0))
                    {
                        res.Add(flight);
                    }
                }
            }

            if (res.Count > 0 && straight)
            {
                
                foreach (var flight in res)
                {
                    if (!flight.IntermediateLandingPoint.Equals("-"))
                    {
                        res.Remove(flight);
                    }
                }
               
            }
     
            return res;
        }

        public List<Flight> SearchFlightsForEditing(string from, string to, DateTime date,int id, bool anywhen, bool straight, string path)
        {
            var res = new List<Flight>();
            if (!anywhen)
            {
                foreach (var flight in FlightsList)
                {
                    if ((flight.DepartureCity.Equals(from, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(from)) &&
                       (flight.DestinationCity.Equals(to, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(to)) &&
                        (flight.DateTime.Date == date) || (flight.Id == 0) ||( flight.Id.Equals(id)))
                    {

                        res.Add(flight);

                    }
                }
            }
            else
            {
                foreach (var flight in FlightsList)
                {
                    if ((flight.DepartureCity.Equals(from, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(from)) &&
                       (flight.DestinationCity.Equals(to, StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(to)) || (flight.Id == 0) || (flight.Id.Equals(id)))
                    {
                        res.Add(flight);
                    }
                }
            }
            List<Flight> list = new List<Flight>();
            list = res;
            if (list.Count > 0 && straight)
            {

                foreach (var flight in res)
                {
                    if (flight.IntermediateLandingPoint == "-")
                    {
                        list.Remove(flight);
                    }
                }
                res = list;
            }

            return res;
        }
        public bool UpdateInfo(Flight flight, string path)
        {

            for (int i = 0; i < FlightsList.Count; i++)
            {
                if (FlightsList[i].Id == flight.Id)
                {

                    FlightsList[i] = flight;
                    SaveFlightsData(path);
                    return true;
                }
            }
            return false;

        }
        public void AddFlight(Flight flight,string path)
        {
            FlightsList.Add(flight);
            SaveFlightsData(path);
        }

           public void DeleteInvalidFlights(string path)
           {
           

            foreach (var flight in FlightsList)
            {
                if (flight.DateTime >= DateTime.Now)
                {
                   FlightsList.Remove(flight);
                   SaveFlightsData(path);
                }
            }
           
            
        }
        public bool RemoveFlight(Flight flight, string path)
        {
            foreach(var f in FlightsList)
            {
                if(f == flight)
                {
                    FlightsList.Remove(flight);
                    SaveFlightsData(path);
                    return true;    
                }
              
                
            }
            return false;
           
        }

    }
            

}
 
  

