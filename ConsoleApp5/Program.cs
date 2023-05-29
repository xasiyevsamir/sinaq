using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data;
            while (true)
            {
                try
                {
                    data = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception )
                {
                    Console.WriteLine("duzgun daxil edin !");

                }
            }
        }
    }
}