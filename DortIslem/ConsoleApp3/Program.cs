using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam,carpim,bolum,fark;
            Console.WriteLine("Birinci Sayıyı Giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz:");
            sayi2=Convert.ToInt32(Console.ReadLine());
            toplam=sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);
            carpim=sayi1 * sayi2;
            Console.WriteLine("Çarpım:"+carpim);
            bolum=sayi1 / sayi2;
            Console.WriteLine("Bölüm:" + bolum);
            fark=sayi1 -sayi2;
            Console.WriteLine("Fark:"+fark);
            Console.ReadKey();
        }
    }
}
