using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atm'e Hoş Geldiniz");
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine("1 - Bakiye Görüntüleme");
            Console.WriteLine("2 - Para Çekme");
            Console.WriteLine("3 - Para Yatırma");
            Console.WriteLine("4 - Çıkış Yap");

            int islem = Convert.ToInt32(Console.ReadLine());
            int bakiye = 100;
            switch (islem)
            {
                case 1: Console.WriteLine("Güncel Bakiyeniz : " + bakiye + " TL"); break;
                case 2:
                    Console.WriteLine("Lütfen Çekmek İstediğiniz Tutarı Giriniz");
                    int cTutar = Convert.ToInt32(Console.ReadLine());
                    if (cTutar > bakiye) Console.WriteLine("Yetersiz Bakiye");
                    else
                    {
                        bakiye -= cTutar;
                        Console.WriteLine("İşlem Başarılı Güncel Bakiyeniz : " + bakiye + " TL");
                    }
                    break;
                case 3:
                    Console.WriteLine("Lütfen Yatırmak İstediğiniz Tutarı Giriniz");
                    int yTutar = Convert.ToInt32(Console.ReadLine());
                    bakiye += yTutar;
                    Console.WriteLine("İşlem Başarılı Güncel Bakiyeniz : " + bakiye + " TL");

                    break;
                case 4: Console.WriteLine("Çıkış Yapıldı!"); break;
                default: Console.WriteLine("Geçersiz İşlem"); break;
            }
            Console.ReadLine();
        }
    }
}
