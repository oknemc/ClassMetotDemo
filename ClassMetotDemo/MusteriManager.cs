using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Add(Musteri musteriler)
        {
            Console.WriteLine(musteriler.musteriIsım+" "+ musteriler.musteriSoyisim+ " sisteme eklendi.");
        }
        public void Delete(Musteri musteriler)
        {
            Console.WriteLine(musteriler.musteriIsım+" " + musteriler.musteriSoyisim + " sistemden silindi.");
        }
        public void Info(Musteri musteriler)
        {
            Console.WriteLine("Id: " + musteriler.musteriId +"\n"+ "İsim: " + musteriler.musteriIsım + "\n" + "Soyisim: " + musteriler.musteriSoyisim +
                "\n" + "Yaş: " + musteriler.musteriYas + "\n" + "TC Kimlik No: " + musteriler.musteriTc );
        }
    }
}
