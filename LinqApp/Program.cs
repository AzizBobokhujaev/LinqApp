using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //HW-1
            Console.WriteLine("HW-1");
            Console.WriteLine();
            var a = Convert.ToInt32(Console.ReadLine());
            foreach (var item in a.ToString().ToCharArray().Reverse())
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            Console.WriteLine();
            //HW-2
            Console.WriteLine("HW-2");
            Console.WriteLine();
            int[] num = { -3,-2,-4,-1,0,1,2,3,4,5,6 };
            int[] outp = new int[2];
            outp[0] = num.Where(p => p > 0).Count();
            outp[1] = num.Where(p => p < 0).Sum();
            foreach (var item in num)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.Write($"[{outp[0]}, {outp[1]}]");
            //HW-3
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("HW-3");
            Console.WriteLine();
            string[] cars = { "Toyota", "Mercedes", "Lamborgini", "Audi", "Range Rover" };
            var result = cars.OrderBy(t=>t.Length);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //HW-4
            Console.WriteLine("HW-4");
            Console.WriteLine();
            int[] num1 = {1,1,1,1,2,1,1,1,1};
            foreach (var item in num1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            var res = num1.Single(p => num1.Count(t => t == num1.Max()) == 1 && p == num1.Max()|| num1.Count(t=> t == num1.Min())==1 && p == num1.Min());
            Console.WriteLine(res);
            
        
        }


    }
    
}
