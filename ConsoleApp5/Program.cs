using System.Text;
using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var name = Console.ReadLine();
            int a=Convert.ToInt32(name);
            var name1 = "dana";
            char dat=Convert.ToChar(name1);
            Console.WriteLine(dat);
            int number=10;
            int data;
            while (true)
            {
                try
                {
                    data = int.Parse(Console.ReadLine());
                    Console.WriteLine("salam");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("duzgun daxil edin !");
                }
            }
            Console.WriteLine("samir");
        }
    }
}