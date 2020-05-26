using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Automobile
    {
        public double HorsePowers { get; set; }
        public string Brand { get; set; }
        public int Weight { get; set; }
        private string boost;
        public string Boost
        {
            get
            {
                return boost;
            }
            set
            {
                if (value == "do-100" || value == "do-200")
                    boost = value;
                else
                    throw new Exception("BOOST Can only be do-100 or do-200!");
            }
        }

        private double accelerationFrom100To200;
        public double AccelerationFrom100To200
        {
            get
            {
                if (boost == "do-200")
                    accelerationFrom100To200 = (1 / HorsePowers * 1000) * 0.8;
                else
                    accelerationFrom100To200 = 1 / HorsePowers * 1000;

                return accelerationFrom100To200;
            }
        }
        private double accelerationFrom0To100;
        public double AccelerationFrom0To100
        {
            get
            {
                if (boost == "do-100")
                    accelerationFrom0To100 = (1 / HorsePowers * 500) * 0.7;
                else
                    accelerationFrom0To100 = 1 / HorsePowers * 500;

                return accelerationFrom0To100;
            }
        }

        public Automobile(double horsePowers, string boost)
        {
            HorsePowers = horsePowers;
            Boost = boost;
        }
    }
}
