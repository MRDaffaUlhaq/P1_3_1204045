using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P1_4_1204045
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("ANAK AYAM TURUN ");

            int ayam = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            if (ayam == 10)
            {
                for (int i = 10; i > 1; i--)
                {
                    Console.WriteLine("Anak ayam turunlah " + i + " mati satu tinggallah " + (i - 1));
                }
                Console.WriteLine("Anak ayam turunlah " + 1 + " mati satu tinggallah induknya");

            }
            
            
        }
    }
}
