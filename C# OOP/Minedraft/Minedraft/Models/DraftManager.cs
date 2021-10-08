namespace Minedraft.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class DraftManager
    {
        public static string RegisterHarvester(List<string> arguments)
        {
            List<Harvester> harvesterRes = new List<Harvester>();

            Harvester harvester;

            try
            {

                if (arguments[1] == "Hammer")
                {
                    harvester = new HammerHarvester(arguments[2], double.Parse(arguments[3]), double.Parse(arguments[4]));
                }
                else
                {
                    harvester = new SonicHarvester(arguments[2], double.Parse(arguments[3]), double.Parse(arguments[4]), int.Parse(arguments[5]));
                }

            }
            catch (Exception)
            {

                throw new Exception();
            }

            harvesterRes.Add(harvester);
            return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";
        }

        public static string RegisterProvider(List<string> arguments)
        {
            List<Provider> harvesterRes = new List<Provider>();

            Provider provider;

            try
            {
                provider = new Provider(arguments[2], double.Parse(arguments[3]));
            }
            catch (Exception)
            {

                throw new Exception();
            }

            harvesterRes.Add(provider);
            return $"Successfully registered {arguments[1]} Provider – {arguments[2]}.";
        }



    }
}
