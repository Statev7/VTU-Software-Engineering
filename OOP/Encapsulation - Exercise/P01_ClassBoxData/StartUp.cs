namespace P01_ClassBoxData
{
    using System;

    using P01_ClassBoxData.Models;

    public class StartUp
    {
        public static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(lenght, width, height);

            box.SurfaceArea(lenght, width, height);
            box.LateralSurfaceArea(lenght, width, height);
            box.Volume(lenght, width, height);
        }
    }
}
