namespace Airplane_Flights.Models
{

    using System;
    using System.Text;

    public class Planes
    {
        private int MIN_ID_VALUE = 1;
        private int MIN_FLIGHTS_VALUE = 1;
        private int MAX_TYPE_LENGHT_VALUE = 20;
        private const string ID_ZERO_OR_NEGATIVE_ERROR_MESSAGE = "The Id can't be zero or negative!";
        private const string TYPE_LENGHT_ERROR_MESSAGE = "The type can't be more 20 symbols!";
        private const string FLIGHTS_ZERO_OR_NEGATIVE_ERROR_MESSAGE = "The flights can't be zero or negative!";

        private int id;
        private string plane;
        private string type;
        private int flights;


        public Planes(int id, string plane, string type, int flights)
        {
            this.Id = id;
            this.Plane = plane;
            this.Type = type;
            this.Flights = flights;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                bool isInvalid = value < MIN_ID_VALUE;

                if (isInvalid)
                {
                    throw new Exception(ID_ZERO_OR_NEGATIVE_ERROR_MESSAGE);
                }

                this.id = value;
            }
        }

        public string Plane
        {
            get
            {
                return this.plane;
            }
            set
            {
                this.plane = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                bool isInvalid = value.Length > MAX_TYPE_LENGHT_VALUE;

                if (isInvalid)
                {
                    throw new Exception(TYPE_LENGHT_ERROR_MESSAGE);
                }

                this.type = value;
            }
        }

        public int Flights
        {
            get
            {
                return this.flights; 
            }
            set
            {
                bool isInvalid = value < MIN_FLIGHTS_VALUE;

                if (isInvalid)
                {
                    throw new Exception(FLIGHTS_ZERO_OR_NEGATIVE_ERROR_MESSAGE);
                }

                this.flights = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.Id} {this.Plane} {this.Type} {this.Flights}");

            return str.ToString();
        }

    }
}
