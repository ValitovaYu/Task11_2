using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation = new Equation(0, 9);
            equation.Root();
            Console.ReadKey();

        }
        struct Equation
        {
            public double k { get; set; }
            public double b { get; set; }

            public Equation(double k, double b)
            {
                this.k = k;
                this.b = b;
            }
            public void Root()
            {
                if (k == 0)
                {
                    Console.WriteLine("нет решения");
                }
                else
                {
                    if (b == 0)
                    {
                        Console.WriteLine("x=любое число");
                    }
                    else
                    {
                        double x = -b / k;
                        Console.WriteLine("Решение линейного уравнения: x={0:F2}", x);
                    }
                }
            }
        }
    }
}
