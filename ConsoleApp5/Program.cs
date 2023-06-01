using System.Text;
using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var name = "Elnur";
           String lastName = "Maharramov";
           int a = 5;
            while (true)
            {
                try
                {

                   var data = int.Parse(Console.ReadLine());
                    Console.WriteLine("salam");

                    data = int.Parse(Console.ReadLine());
                    Console.WriteLine("sagol getdik");

                    Console.ReadLine();

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