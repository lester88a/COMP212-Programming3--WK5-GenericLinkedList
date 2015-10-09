using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEfficiency
{
    class Program
    {
        const int MAX = 10000;
        static void Main(string[] args)
        {
            //creating a list and a linked list
            var list = new List<string>();
            var link = new LinkedList<string>();

            //adding a elements to both
            for (int i = 0; i < 100; i++)
            {
                list.Add("OK");
                link.AddLast("OK");
            }



            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < MAX; i++)
            {
                foreach (string v in list)
                {
                    if (v.Length != 2)
                    {
                        throw new Exception();
                    }
                }                
            }
            s1.Stop();


            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < MAX; i++)
            {
                foreach (string v2 in link)
                {
                    if (v2.Length!=2)
                    {
                        throw new Exception();
                    }
                }
                
            }
            s2.Stop();
            Console.WriteLine( ((double)(s1.Elapsed.TotalMilliseconds*1000000) / MAX).ToString("0.00 ns") );
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / MAX).ToString("0.00 ns"));

        }
    }
}
