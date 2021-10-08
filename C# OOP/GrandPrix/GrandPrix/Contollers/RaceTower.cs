namespace GrandPrix.Contollers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using GrandPrix.Factories;
    using GrandPrix.Models.Drivers;

    public class RaceTower
    {
        private const double PIT_STOP_TIME = 20;

        private DriverFactory driverFactory;
        private TyreFactory tyreFactory;
        private CarFactory carFactory;
        private Dictionary<string, Driver> drivers;
        private Dictionary<Driver, string> unfinishedDrivers;
        private int numbersOfLaps;
        private int currentLap;
        private StringBuilder stringBuilder;
        public Driver Winner { get; private set; }

        public RaceTower()
        {
            this.tyreFactory = new TyreFactory();
            this.driverFactory = new DriverFactory();
            this.carFactory = new CarFactory();
            this.drivers = new Dictionary<string, Driver>();
            this.unfinishedDrivers = new Dictionary<Driver, string>();
            this.Weather = "Sunny";
            this.currentLap = 0;
            this.IsEndOfRace = false;
            this.stringBuilder = new StringBuilder();
        }

        public int NumberOfLaps
        {
            get
            {
                return numbersOfLaps;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException($"There is no time! On lap {this.currentLap}.");
                }

                this.numbersOfLaps = value;
            }
        }

        public string Weather { get; set; }
        public int LenghtOfTrack { get; set; }
        public bool IsEndOfRace { get; set; }

        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            this.NumberOfLaps = lapsNumber;
            this.LenghtOfTrack = trackLength;
        }

        public void RegisterDriver(List<string> commandArgs)
        {
            try
            {
                var tyreArguments = commandArgs.Skip(4).ToList();
                var carArguments = commandArgs.Skip(2).Take(2).ToList();
                var driverArguments = commandArgs.Take(2).ToList();

                var tyre = tyreFactory.Create(tyreArguments);
                var car = carFactory.Create(carArguments, tyre);
                var driver = driverFactory.Create(driverArguments, car);

                this.drivers.Add(driverArguments[1], driver);
            }
            catch (Exception ae)
            {

                Console.WriteLine(ae.Message);
            }
        }

        public void DriverBoxes(List<string> commandArgs)
        {
            string reason = commandArgs[0];
            string driversName = commandArgs[1];
            var driver = this.drivers[driversName];

            driver.TotalTime += PIT_STOP_TIME;

            switch (reason)
            {
                case "ChangeTyres":
                    var tyreArguments = commandArgs.Skip(2).ToList();
                    var newTyre = tyreFactory.Create(tyreArguments);
                    driver.Car.ChangeTyre(newTyre);
                    break;
                case "Refuel":
                    double refuel = double.Parse(commandArgs[2]);
                    driver.Car.Refuel(refuel);
                    break;
            }
        }

        public string CompleteLaps(List<string> commandArgs)
        {
            stringBuilder.Clear();

            int completeLap = int.Parse(commandArgs[0]);

            try
            {
                this.NumberOfLaps -= completeLap;


                for (int i = 0; i < completeLap; i++)
                {
                    this.SetTotalTimeOfDrivers();
                    this.DriversTakeALap();
                    this.RemoveUnfinishedDrivers();
                    this.currentLap++;

                    var driversToOvertaken = this.drivers.Values
                        .OrderByDescending(driver => driver.TotalTime)
                        .ToList();

                    this.Overtaking(stringBuilder, driversToOvertaken);

                }

                if (this.NumberOfLaps == 0)
                {
                    this.IsEndOfRace = true;
                    this.Winner = this.drivers.Values
                        .OrderBy(driver => driver.TotalTime)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                stringBuilder.Append(e.Message);
            }

            return stringBuilder.ToString().Trim();
        }

        private void Overtaking(StringBuilder result, List<Driver> driversToOvertaken)
        {
            for (int j = 0; j < driversToOvertaken.Count - 1; j++)
            {
                var firstDriver = driversToOvertaken[j];
                var secondDriver = driversToOvertaken[j + 1];
                var timeFirstDriver = firstDriver.TotalTime;
                var timeSecondDriver = secondDriver.TotalTime;
                var difference = Math.Abs(timeFirstDriver - timeSecondDriver);
                var interval = 2;

                bool isCrash = CheckConditions(firstDriver, ref interval);

                if (difference <= interval)
                {
                    if (isCrash)
                    {
                        this.unfinishedDrivers.Add(firstDriver, "Crashed");
                        foreach (var crashDriver in this.unfinishedDrivers)
                        {
                            if (this.drivers.ContainsKey(crashDriver.Key.Name))
                            {
                                this.drivers.Remove(crashDriver.Key.Name);
                            }
                        }
                        continue;
                    }

                    PrintOvertakenDrivers(result, firstDriver, secondDriver, interval);
                }
            }
        }

        private bool CheckConditions(Driver frontDriver, ref int interval)
        {
            bool isCrashed = false;

            if (frontDriver.GetType().Name == "AggressiveDriver" && frontDriver.Car.Tyre.GetType().Name == "UltrasoftTyre")
            {
                interval = 3;
                if (this.Weather == "Foggy")
                {
                    isCrashed = true;
                }
            }
            if (frontDriver.GetType().Name == "EnduranceDriver" && frontDriver.Car.Tyre.GetType().Name == "HardTyre")
            {
                interval = 3;
                if (this.Weather == "Rainy")
                {
                    isCrashed = true;
                }
            }

            return isCrashed;
        }

        private void RemoveUnfinishedDrivers()
        {
            foreach (var crashDriver in this.unfinishedDrivers)
            {
                if (this.drivers.ContainsKey(crashDriver.Key.Name))
                {
                    this.drivers.Remove(crashDriver.Key.Name);
                }
            }
        }

        private void PrintOvertakenDrivers(StringBuilder result, Driver firstDriver, Driver secondDriver, int intervalToOvertake)
        {
            firstDriver.TotalTime -= intervalToOvertake;
            secondDriver.TotalTime += intervalToOvertake;
            result.AppendLine(
                $"{firstDriver.Name} has overtaken {secondDriver.Name} on lap {this.currentLap}.");
        }

        private void DriversTakeALap()
        {
            foreach (var driver in this.drivers.Values)
            {
                try
                {
                    driver.ReduceFuelAmount(this.LenghtOfTrack);
                    driver.Car.Tyre.ReduceDegradation();
                }
                catch (Exception ae)
                {
                    this.unfinishedDrivers.Add(driver, ae.Message);
                }
            }
        }

        private void SetTotalTimeOfDrivers()
        {
            foreach (var driver in this.drivers.Values)
            {
                driver.TotalTime += 60 / (this.LenghtOfTrack / driver.Speed);
            }
        }

        public string GetLeaderboard()
        {
            stringBuilder.Clear();

            int count = 1;

            stringBuilder.AppendLine($"Lap {this.currentLap}/{this.currentLap +  this.NumberOfLaps}");

            foreach (var driver in this.drivers.Values.OrderBy(d => d.TotalTime))
            {
                stringBuilder.AppendLine($"{count++} {driver.Name} {driver.TotalTime:F3}");
            }

            var crashesToPrint = unfinishedDrivers;

            foreach (var driver in crashesToPrint)
            {
                stringBuilder.AppendLine($"{count++} {driver.Key.Name} {driver.Value}");
            }

            return stringBuilder.ToString().Trim();
        }

        public void ChangeWeather(List<string> commandArgs)
        {
            this.Weather = commandArgs[0];

        }
    }
}
