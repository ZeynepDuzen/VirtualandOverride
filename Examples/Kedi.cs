using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Kedi : EvcilHayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Kedi miyavliyor");
        }

        public override string ToString()
        {
            return $"Kedi Adi : {Adi}\nCinsiyeti : {Cinsiyeti}\nIrki : {Irki}\nDogumTarihi : {DogumTarihi}";
        }
    }
}
