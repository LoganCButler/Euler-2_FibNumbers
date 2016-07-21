using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace EvenFibNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            AppLogic a = new AppLogic();
            
            Console.WriteLine("The sum of even numbers in Fib not over 4 mil:{0}",a.getEvenFibNumbers(a.topNumberDefault).ToString());
            Console.ReadLine();
        }
    }
}
