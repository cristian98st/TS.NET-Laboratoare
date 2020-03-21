using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EventClass
    {

    }

    class Program
    {
        public static int nr; 

        static bool isPrime(int n)
        {
            if(n <= 1)
            {
                return false;
            }

            for(int i = 2; i < n; i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static async Task<int> Prime1()
        {
            int ret_value = -1;

            Console.WriteLine("Start fir: " + " 1 " + " Numar natural dat: " + nr + " Timestamp: " + DateTime.Now + "\n");

            for (int i = 2; i < nr; i++)
            {
                if(i > ret_value)
                {
                    if (isPrime(i))
                    {
                        ret_value = i;
                    }
                }
            }

            Console.WriteLine("End fir: " + " 1 " + " Timestamp: " + DateTime.Now + " Numar prim = " + ret_value + "\n");
            return ret_value;
        }


        static bool betterIsPrime(int n)
        {
            if (n <= 1)
                return false;

            if (n <= 3)
                return true;

            if(n % 2 == 0 || n % 3 == 0)
                return false;

            for(int i = 5; i*i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        static async Task<int> Prime2()
        {

            Console.WriteLine("Start fir: " + " 2 " + " Numar natural dat: " + nr + " Timestamp: " + DateTime.Now + "\n");

            for (int i = nr - 1; i >= 2; i--)
            {
                if (betterIsPrime(i))
                {
                    Console.WriteLine("End fir: " + " 2 " + " Timestamp: " + DateTime.Now + " Numar prim = " + i + "\n");
                    return i;
                }
            }

            Console.WriteLine("End fir: " + " 2 " + " Timestamp: " + DateTime.Now + " Numar prim = -1" + "\n");
            return -1;  
        }

        static async Task Main(string[] args)
        {
            Console.Write("Enter number: ");
            nr = int.Parse(Console.ReadLine());

            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Run(() => { Prime2(); }));
            tasks.Add(Task.Run(() => { Prime1(); }));
            Task.WaitAll(tasks.ToArray());
        }
    }
}
