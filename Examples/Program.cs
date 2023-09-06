using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek = new Kopek()
            {
                Adi = "Po",
                Cinsiyeti = Cinsiyet.Erkek,
                DogumTarihi = DateTime.Parse("11.05.2023 12:35:21", new CultureInfo("tr-TR")),
                Irki = "CanIrk"
            };

            Console.WriteLine("Adi : " + kopek.Adi);
            Console.WriteLine("Cinsiyeti : " + kopek.Cinsiyeti);
            Console.WriteLine("DogumTarihi : " + kopek.DogumTarihi.ToShortDateString());
            Console.WriteLine("Irki : " + kopek.Irki);

            kopek.Uyu();
            kopek.YemekYe();
            kopek.SesCikar();
            Console.WriteLine();


            Kedi kedi = new Kedi()
            {
                Adi = "Minnos",
                Cinsiyeti = Cinsiyet.Disi,
                DogumTarihi = DateTime.Parse("31.03.2020 14:38:22", new CultureInfo("tr-TR")),
                Irki = "TatliIrk"
            };

            Console.WriteLine(kedi.ToString());
            

            kedi.Uyu();
            kedi.YemekYe();
            kedi.SesCikar();




            Console.Read();
        }
    }
}
