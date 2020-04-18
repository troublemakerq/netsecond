using System;

namespace Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrate quadrate = new Quadrate(3.5);
            Console.WriteLine($"        |{new string("Длина стороны"),12}|{ new string("Диагональ"),12}|{ new string("Периметр"),12}|{ new string("Площадь"),12}| ");
            Console.WriteLine(quadrate.ToString());
            Pyramide pyramide = new Pyramide(3.5, 1.5);
            Console.WriteLine($"        |{new string("Длина стороны"),12}|{ new string("Апофема"),12}|{ new string("Объем"),12}|{ new string("Площадь"),12}| ");
            Console.WriteLine(pyramide.ToString());
        }
    }
}
