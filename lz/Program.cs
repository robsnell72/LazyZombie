using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();

            for (int x=4;x<=5000;x++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        for (int k = 1; k <= 10; k++)
                        {
                            for (int l = 1; l <= 10; l++)
                            {
                                if (Math.Pow(i, 2) + Math.Pow(j, 2) + Math.Pow(k, 2) + Math.Pow(l, 2) == x)
                                {
                                    String msg = string.Format("x:{4} i:{0} j:{1} k:{2} l:{3}", i, j, k, l, x);
                                    Console.WriteLine(msg);
                                    result.AppendLine(msg);
                                }
                            }
                        }
                    }
                }
            }

            File.AppendAllText("cara.txt", result.ToString());
            Console.ReadLine();
        }
    }
}
