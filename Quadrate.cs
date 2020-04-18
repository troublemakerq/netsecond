using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba
{
    class Quadrate
    {
        private double lengthSide;

        public Quadrate(double lengthSide)
        {
            LengthSide = lengthSide;
        }

        public double LengthSide { get => lengthSide; set => lengthSide = value; }

        public double Diagonal()
        {
            return Math.Round(lengthSide * Math.Sqrt(2),2);
        }

        public double Perimetr()
        {
            return Math.Round(4 * lengthSide,2);
        }

        public virtual double Square()
        {
            return Math.Round(Math.Pow(lengthSide, 2));
        }

        public override string ToString()
        {
            return string.Format($"Квадрат |{LengthSide,13}|{Diagonal(),12}|{Perimetr(),12}|{Square(),12}|");
        }
    }
}
