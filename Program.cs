using System;
using System.Threading;
using System.Timers;
using System.Threading.Tasks;


namespace Master
{
    class Program
    {
        public static void Main(string[] args)
        {
            Action();
           
        }
        public static void Action()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;



            FibonachiAsync(n, token);
            


            Thread.Sleep(10000);
            cancellationTokenSource.Cancel();

        }
    
        public static int Fibo(int n, CancellationToken token)
        {
           
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
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Превышено ожид◙ние");
                    return 0;
                }
                var result = Fibo(n - 1,token) + Fibo(n - 2,token);
                return result;

            }
        }
        public static async void FibonachiAsync(int n,CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Превышено ожид◙ние");
                return;
            }
            int num = 0;
            await Task.Run(()=> num = Fibo(n, token));
            Console.WriteLine(num + " - фибоначи");
        }
        


    }
}




