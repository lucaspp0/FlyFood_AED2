using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFoodGit.models
{
    public class Flight
    {
        public string Company { get; set; }
        public int Id { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public DateTime DepartureTime { get; set; }

        public Flight(string company, string departure, string arrival, string departureTime)
        {
            // TO DO
            // i dont know if do here or other  place
            throw new NotImplementedException();
        }

        public static void ShowPanel()
        {
            // TO DO
            throw new NotImplementedException();
        }

    }
}
