using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static int Add(int x, int y)
        {
            int ans = x + y;
            x = 10000;
            y = 88888;
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun With Methods *****\n");

            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is {0}", Add(x, y));
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.ReadLine();
        }
    }
}
