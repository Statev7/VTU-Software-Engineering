namespace NeedForSpeed
{
    using System;
    public class StartUp
    {
        
        public static void Main()
        {
            Motorcycle motorcycle = new Motorcycle(100, 100);
            motorcycle.Drive(20);
        }
    }
}
