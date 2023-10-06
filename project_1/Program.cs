using System;

namespace project_1
{
    internal class Program
    { 
        
        static double Heron( double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double w = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return w;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj boki trójkąta:");
            double.TryParse(Console.ReadLine(), out double a);
            double.TryParse(Console.ReadLine(), out double b);
            double.TryParse(Console.ReadLine(), out double c);
            /*if(a+b<=c || a+c<=b || b+c<=a)
            {
                Console.WriteLine("nie ma takiego");

            }*/
            Console.WriteLine("Pole trójkąta:"+Heron(a,b,c));

        }
    }
}