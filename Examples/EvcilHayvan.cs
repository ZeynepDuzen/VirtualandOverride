using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class EvcilHayvan
    {
        public string Adi { get; set; }
        public Cinsiyet Cinsiyeti { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Irki { get; set; }


        public void YemekYe()
        {
            Console.WriteLine("Evcil hayvan yemek yiyiyor");
        }

        public void Uyu()
        {
            Console.WriteLine("Evcil hayvan uyuyor");
        }

        public virtual void SesCikar()
        {
            Console.WriteLine("Hayvan ses cikariyor");
        }
    }
}
