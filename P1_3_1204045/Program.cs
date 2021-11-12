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
            if (ayam >= 1 && ayam <= 10 )
            {
                if (ayam == 10)
                {
                    for (int i = 10; i > 1; i--)
                    {
                        Console.WriteLine("Anak ayam turunlah " + i + " mati satu tinggallah " + (i - 1));
                    }
                    Console.WriteLine("Anak ayam turunlah " + 1 + " mati satu tinggallah induknya");
                }else if (ayam == 9)
                {
                    for (int i = 9; i > 1; i--)
                    {
                        Console.WriteLine("Anak ayam turunlah " + i + " mati satu tinggallah " + (i - 1));
                    }
                    Console.WriteLine("Anak ayam turunlah " + 1 + " mati satu tinggallah induknya");
                }
                else if (ayam == 8)
                {
                    for (int i = 8; i > 1; i--)
                    {
                        Console.WriteLine("Anak ayam turunlah " + i + " mati satu tinggallah " + (i - 1));
                    }
                    Console.WriteLine("Anak ayam turunlah " + 1 + " mati satu tinggallah induknya");
                }
                else if (ayam == 7)
                {
                    for (int i = 7; i > 1; i--)
                    {
                        Console.WriteLine("Anak ayam turunlah " + i + " mati satu tinggallah " + (i - 1));
                    }
                    Console.WriteLine("Anak ayam turunlah " + 1 + " mati satu tinggallah induknya");
                }
                else if (ayam == 6)
                {
                    for (int i = 6; i > 1; i--)
                    {
                        Console.WriteLine("Anak ayam turunlah " + i + " mati satu tinggallah " + (i - 1));
                    }
                    Console.WriteLine("Anak ayam turunlah " + 1 + " mati satu tinggallah induknya");
                }
                else if (ayam == 5)
                {
                    for (int i = 5; i > 1; i--)
                    {
                        Console.WriteLine("Anak ayam turunlah " + i + " mati satu tinggallah " + (i - 1));
                    }
                    Console.WriteLine("Anak ayam turunlah " + 1 + " mati satu tinggallah induknya");
                }
                else if (ayam == 4)
                {
                    for (int i = 4; i > 1; i--)
                    {
                        Console.WriteLine("Anak ayam turunlah " + i + " mati satu tinggallah " + (i - 1));
                    }
                    Console.WriteLine("Anak ayam turunlah " + 1 + " mati satu tinggallah induknya");
                }
                else if (ayam == 3)
                {
                    for (int i = 3; i > 1; i--)
                    {
                        Console.WriteLine("Anak ayam turunlah " + i + " mati satu tinggallah " + (i - 1));
                    }
                    Console.WriteLine("Anak ayam turunlah " + 1 + " mati satu tinggallah induknya");
                }
                else if (ayam == 2)
                {
                    for (int i = 2; i > 1; i--)
                    {
                        Console.WriteLine("Anak ayam turunlah " + i + " mati satu tinggallah " + (i - 1));
                    }
                    Console.WriteLine("Anak ayam turunlah " + 1 + " mati satu tinggallah induknya");
                }
                else if (ayam == 1)
                {
                    Console.WriteLine("Anak ayam turunlah " + 1 + " mati satu tinggallah induknya");
                }
            }
            else
            {
                Console.WriteLine("Ups, Nilai input harus bernilai positif, tidak boleh nol dan kurang dari sepuluh");
            }
            
            
        }
    }
}
