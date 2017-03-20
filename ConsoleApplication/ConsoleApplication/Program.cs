using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integer = new List<int>();
            integer.Add(1);
            integer.Add(2);
            integer.Add(3);
            for (int i = 0; i<integer.Count;i++)
                {
                    Console.WriteLine(integer[i]);
                }
        }
    }
}
