using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Master
{
    class Program
    {
        Dictionary<int, int> hash = new Dictionary<int, int>();
        public static void Main(string[] args)
        {
            ActionsAsync();         


        }
        private static async void ActionsAsync()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var list = new List<Task>();

            list.Add(Task.Run(() => Factorial(n)));

            list.Add(Task.Run(() => Fibonachi(n)));

            list.Add(Task.Run(() => Exponentation(n)));

            await Task.WhenAll(list);

            Console.WriteLine("Programm complited");
            

        }
        public static void Exponentation(int n)
        {
            Console.WriteLine(Convert.ToInt32(Math.Pow(n, n)) + " в степени");
        }
        public static void Fibonachi(int n)
        {
            Console.WriteLine(Fibo(n) + " фибоначи");
        }

        public static int Fibo(int n)
        {
            //if (hash.ContainsKey(n))
            //    return hash[n];
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                var result = Fibo(n - 1) + Fibo(n - 2);
                //hash.Add(n, result);
                return result;

            }
        }
        public static void Factorial(int n)
        {
            var result = 1;
            if (n == 0)
                result = 0;
            else if (n == 1)
                result = 1;
            else
            {
                for (int i = 1; i < n+1; i++)
                {
                    result *= i;
                }
            }
            Console.WriteLine(result + " факториал");
        }
    }
}
