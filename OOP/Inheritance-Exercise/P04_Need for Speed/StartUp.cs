namespace NeedForSpeed
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            Motorcycle motorcycle = new Motorcycle(200, 100);
            motorcycle.Drive(2);
        }
    }
}
