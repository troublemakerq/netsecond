using System;

namespace Laba
{
    class Pyramide : Quadrate
    {
        private double apothem;
        private double heigth;

        public Pyramide(double lengthSide, double apothem) : base(lengthSide)
        {
            this.apothem = apothem;
            heigth = Height();
        }
        public double Height()
        {
            return Math.Sqrt(Math.Abs(Math.Pow(apothem,2)- Math.Pow(heigth/2,2)));
        }

        public override double Square()
        {
            return base.Square() + 4 * 1 / 2 * apothem * LengthSide;
        }

        public double Volume()
        {
            return Math.Round((Math.Pow(LengthSide, 2) * heigth)/3,2); 
        }

        public override string ToString()
        {
            return  string.Format($"Квадрат |{LengthSide,13}|{apothem,12}|{Volume(),12}|{Square(),12}|");
        }
    }
}
