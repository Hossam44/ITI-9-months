using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Count_1__in_Million
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 100000000;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string tempStr;
            int tempInt, degit,count = 0;

            for (int i = 1; i < 1e8; i++)
            {
                tempStr= i.ToString();
                for(int j=0;j<tempStr.Length;j++)
                {
                    if (tempStr[j]== '1')
                    {
                        count++;
                    }
                }

            }
            sw.Stop();
            Console.WriteLine($"Number of 1s :{count}");
            Console.WriteLine($"Seconds :{sw.ElapsedMilliseconds / 1000}");

            count= 0;
            sw= new Stopwatch();
            sw.Start();
            for (int i = 1; i < 1e8; i++)
            {
                tempInt = i;
                while (tempInt > 0)
                {
                    degit = tempInt % 10;
                    tempInt /= 10;

                    if (degit == 1)
                        count++;
                }
            }
            sw.Stop();
            Console.WriteLine($"Number of 1s :{count}");
            Console.WriteLine($"Seconds :{sw.ElapsedMilliseconds / 1000}");

            count = 0;
            sw.Start();
            sw = new Stopwatch();
            
            int n = 0;
            while (s>1)
            {
                s/= 10;
                n++;
            }

            count = ((int)(n * Math.Pow(10, n-1)));
            sw.Stop();
            Console.WriteLine($"Number of 1s :{count}");

            Console.WriteLine($"Seconds :{sw.ElapsedMilliseconds / 1000}");



        }
    }
}