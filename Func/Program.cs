using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {   //Вычислить Y=F(X)
            int a, b, c;
            Console.WriteLine("Введите начальное значение");
            a = Convert.ToInt32( Console.ReadLine());
           

            Console.WriteLine("Введите конечное занчение");
            b = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Введите шаг");
            c = Convert.ToInt32(Console.ReadLine());
          

            for (double i = a; i < b; i = i + c)
            {
                
                double solution, x;
                solution = (x * x * x) - (1 / Math.Sqrt(3) - Math.Log10(1.37 * 1.37 * 1.37 + x * x * x * x * x) + 4 / x);
                if (solution < 0)
                {
                    solution = solution * -1;
                    Console.WriteLine(solution);
                    
                }
            }
        

        }
    }
}
