using System;


namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {   //Вычислить Y=F(X)
            double a, b, c, SumSolution = 0;

            int k = 1, n,ch=0;
            Console.WriteLine("Введите начальное значение");
            a = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введите конечное занчение");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите шаг");
            c = Convert.ToDouble(Console.ReadLine());
            n = Convert.ToInt32( b - a);
            Console.WriteLine("Полученные значения");
            double[] mass = new double[n];
            for (double i = a; i < b; i = i + c)
            {
                bool skip = false;
                if (i == 0)
                {
                    skip = true;
                    Console.WriteLine("X не может быть нулем");
                }
                if (skip == false)
                {
                    double solution, x = i;
                    solution = (x * x * x) - (1 / Math.Sqrt(3) - Math.Log10(1.37 * 1.37 * 1.37 + x * x * x * x * x) + 4 / x);

                    

                    if (solution < 0)
                    {
                        solution = solution * -1;
                        Console.WriteLine($"{k++}: {solution}");
                        SumSolution += solution;
                        mass[ch] = solution;
                        ch++;
                    }
                    else
                    {
                        Console.WriteLine($"{k++}: {solution}");
                        SumSolution += solution;
                        mass[ch] = solution;
                        ch++;
                    }
                }
            }
            Console.WriteLine($"Сумма всех решений: {SumSolution}");
            Console.ReadLine();




            int startposx = 200;//Начало координат
            int startposy = 200;
           
            Console.Clear();
            for (int i = 0; i < 200; i += 10)
            {

                Console.SetCursorPosition((startposx + i) / 10, (startposy) / 10);
                Console.Write("*");
                Console.SetCursorPosition((startposx - i) / 10, (startposy) / 10);
                Console.Write("*");
                Console.SetCursorPosition((startposx) / 10, (startposy + i) / 10);
                Console.Write("*");
                Console.SetCursorPosition((startposx) / 10, (startposy - i) / 10);
                Console.Write("*");
            }
            Console.SetCursorPosition((startposx + 200) / 10, (startposy) / 10);
            Console.Write("200");
            Console.SetCursorPosition((startposx) / 10, (startposy - 200) / 10);
            Console.Write("200");
            Console.SetCursorPosition((startposx - 200) / 10, (startposy) / 10);
            Console.Write("-200");
            Console.SetCursorPosition((startposx) / 10, (startposy + 200) / 10);
            Console.Write("-200");
            Console.ForegroundColor = ConsoleColor.Red;

            for(double i = a; i < b; i = i + c)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    Console.SetCursorPosition((startposx + Convert.ToInt32(i)) / 10, (startposy - Convert.ToInt32(mass[j])) / 10); 
                    Console.Write("*");
                }
            }


            Console.ReadLine();

        }

        
    }
}
