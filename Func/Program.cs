using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {   //Вычислить Y=F(X)
            double a, b, c, SumSolution=0;
            int k = 1;
            Console.WriteLine("Введите начальное значение");
            a = Convert.ToDouble( Console.ReadLine());
           

            Console.WriteLine("Введите конечное занчение");
            b = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Введите шаг");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Полученные значения");

            for (double i = a; i < b; i = i + c)
            {
                
                double solution, x=i;
                solution = (x * x * x) - (1 / Math.Sqrt(3) - Math.Log10(1.37 * 1.37 * 1.37 + x * x * x * x * x) + 4 / x);
                if (solution < 0)
                {
                    solution = solution * -1;
                    Console.WriteLine($"{k++}: {solution}");
                    SumSolution +=solution;
                }
                else
                {
                    Console.WriteLine($"{k++}: {solution}");
                    SumSolution +=solution;
                }
                
            }
            Console.WriteLine($"Сумма всех решений: {SumSolution}");
            Console.ReadLine();
           

            
            }
        }
    }
}
