using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KasenovAE.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KasenovAE.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Z = ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {DataService.Calc(x, y, z)}");
            Console.ReadKey();
        }
    }
}
