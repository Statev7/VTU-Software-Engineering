namespace Minedraft
{
    using System;
    using System.Collections.Generic;
    using Minedraft.Models;
    public class StartUp
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            list.Add("RegisterHarvester");
            list.Add("Sonic");
            list.Add("AS - 51");
            list.Add("100");
            list.Add("1000000");
            list.Add("10");
            string res = DraftManager.RegisterHarvester(list);
            Console.WriteLine(res);

            //List<string> list1 = new List<string>();
            //list1.Add("RegisterProvider");
            //list1.Add("Solar");
            //list1.Add("Falcon");
            //list1.Add("100");
            //string res = DraftManager.RegisterProvider(list1);
            //Console.WriteLine(res);
        }
    }
}
