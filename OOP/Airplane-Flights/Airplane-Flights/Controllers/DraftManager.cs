namespace Airplane_Flights.Controllers
{

    using System;
    using System.Collections.Generic;
    using System.IO;

    using Models;
    using Factories;

    public class DraftManager
    {
        public static void Create(List<string> arguments)
        {
            Planes plane = PlaneFactory.CreatePlane(arguments);
            string fileName = "Planes.db";
            StreamWriter stream;

            string result = "The id is already registered!";

            if (File.Exists(fileName))
            {
                bool isRegister = IsItAlreadyRegistered(arguments[0]);

                if (isRegister == false)
                {
                    using (stream = new StreamWriter(fileName, true))
                    {
                        stream.Write(plane);
                    }

                    result = "Record saved!";
                }
            }
            else
            {
                File.Create(fileName).Close();

                using (stream = new StreamWriter(fileName))
                {
                    stream.Write(plane);
                }

                result = "Record saved!";
            }

            Console.WriteLine(result);
        }

        public static void Search(string id)
        {
            string fileName = "Planes.db";
            StreamReader stream;
            string result = "Record not found!";

            using (stream = new StreamReader(fileName))
            {
                string line = string.Empty;

                while ((line = stream.ReadLine()) != null)
                {
                    if (line.StartsWith(id))
                    {
                        result = line;
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }

        private static bool IsItAlreadyRegistered(string planeId)
        {
            bool isRegister = false;

            string fileName = "Planes.db";
            StreamReader stream;

            using (stream = new StreamReader(fileName))
            {
                string line = string.Empty;

                while ((line = stream.ReadLine()) != null)
                {
                    if (line.StartsWith(planeId))
                    {
                        isRegister = true;
                        break;
                    }
                }
            }

            return isRegister;
        }
    }
}
