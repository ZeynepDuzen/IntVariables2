using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntVariables2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi;
            //Console.WriteLine("Lütfen bir sayi giriniz : ");
            //Console.WriteLine();
            //sayi = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Girmis oldugunuz sayi : " + sayi);

            int sayi1, sayi2, toplam;
            
            Console.WriteLine("Lütfen iki sayı giriniz : ");
            Console.WriteLine();
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            sayi2 = Convert.ToInt16(Console.ReadLine());


            toplam = sayi1 + sayi2;
            Console.WriteLine();
            Console.WriteLine("Girmis oldugunuz sayilarin toplami = " + toplam);


            Console.Read();

        }
    }
}
