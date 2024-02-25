using System;
using System.Diagnostics;

namespace DZ_7
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int Fibonachi(int n)
            {
                if (n == 0 || n == 1) return n;

                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }

            int fib5 = Fibonachi(5);
            int fib10 = Fibonachi(10);
            int fib20 = Fibonachi(20);
            
            Console.WriteLine($"5 число Фибоначчи (рекурсия) = {fib5}");
            Console.WriteLine($"10 число Фибоначчи (рекурсия) = {fib10}");
            Console.WriteLine($"20 число Фибоначчи (рекурсия) = {fib20}");


            stopWatch.Stop();
            Console.WriteLine("время выполнения рекурсии {0} ms", stopWatch.ElapsedMilliseconds);
            Console.WriteLine("время выполнения рекурсии {0} tiks", stopWatch.ElapsedTicks);
            
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            stopWatch.Restart();
            static int Fibonachi2(int n)
            {
                int result = 0;
                int b = 1;
                int tmp;

                for (int i = 0; i < n; i++)
                {
                    tmp = result;
                    result = b;
                    b += tmp;
                }

                return result;
            }
            int fibonachi5 = Fibonachi2(5);
            int fibonachi10 = Fibonachi2(10);
            int fibonachi20 = Fibonachi2(20);
            Console.WriteLine($"5 число Фибоначчи (цикл) = {fibonachi5}");
            Console.WriteLine($"10 число Фибоначчи (цикл) = {fibonachi10}");
            Console.WriteLine($"20 число Фибоначчи (цикл) = {fibonachi20}");
            stopWatch.Stop();
            Console.WriteLine("время выполнения цикла {0} ms", stopWatch.ElapsedMilliseconds);
            Console.WriteLine("время выполнения цикла {0} tiks", stopWatch.ElapsedTicks);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");



        }
    }
}
