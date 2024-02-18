using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pd_week3_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 1, 1, 2, 2, 3,3,3,3,3 };
            int result = NUmCheck(arr);
            Console.WriteLine("Higest Repeated Number is: "+result);
            Console.ReadKey();

        }
        static int NUmCheck(int[] n)
        {
            int count = 0;
            int highestRepeatedValue =0;
            int value = 0;
            int value2 = 0;
            for (int i = 0; i < n.Length ;i++)
            {
                if (n[i] != value2)
                {
                    for (int j = 0; j < n.Length ; j++)
                    {
                        if (n[j] == n[i])
                        {
                            count++;
                            value2 = n[i];
                        }
                    }
                    if (count > highestRepeatedValue)
                    {
                        highestRepeatedValue = count;
                        value = n[i];
                    }
                    count = 0;
                }
            }
            return value;
        }
    }
}
