using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 6;

            for(i=1; i<=5; i++)
            {
                Console.Write(i + "/5= " + i / 5.0 + "\n");
            }
            Console.Write("---------------------------\n");

            for(j=6;j<=10;j++)
            {
                Console.Write(j + "/5 = " + j / 5.0 +"\n");
            }
            Console.WriteLine("==========================\n");
        }
    }
}
