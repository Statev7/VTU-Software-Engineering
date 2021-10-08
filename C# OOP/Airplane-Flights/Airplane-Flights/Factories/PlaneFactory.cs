namespace Airplane_Flights.Factories
{

    using System.Collections.Generic;

    using Airplane_Flights.Models;

    public class PlaneFactory
    {
        public static Planes CreatePlane(List<string> arguments)
        {
            Planes planes = null;

            int id = int.Parse(arguments[0]);
            string plane = arguments[1];
            string type = arguments[2];
            int flights = int.Parse(arguments[3]);

            planes = new Planes(id, plane, type, flights);

            return planes;
        }
    }
}
