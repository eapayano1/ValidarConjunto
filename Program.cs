using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TendenciasKataRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Range range = new Range("[21,34)");
            Range range1 = new Range("[22,29]");
            Console.WriteLine(range.OverlapsRange(range1));
            //int[] arr = range.EndPoints();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]},");
            //}
            Console.ReadKey();
        }
    }
}
