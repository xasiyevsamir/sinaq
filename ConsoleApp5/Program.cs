﻿using System.Text;
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
                    Console.WriteLine("sagol getdik");

                    Console.ReadLine();

                    break;
                }
                catch (Exception)
                {
                     System.Console.WriteLine("saalaaaaamma");
                     Console.WriteLine("duzgun daxil edin !");
                }
            }

            Console.WriteLine("salam");
            System.Console.WriteLine("saalaaaaamma");

            Console.WriteLine("samir");
            
            Console.WriteLine("samir");
            Console.WriteLine("main branch deyisirik");
            int da=124;
            int k=22;
        }
    }
}