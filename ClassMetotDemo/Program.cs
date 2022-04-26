using ClassMetotDemo;

class MusteriTakip
{
    static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.musteriIsım = "Okan";
        musteri1.musteriSoyisim = "Emecen";
        musteri1.musteriYas = 20;
        musteri1.musteriTc = 14556740976;

        Musteri musteri2 = new Musteri();
        musteri2.musteriIsım = "Emir";
        musteri2.musteriSoyisim = "Aydoğdu";
        musteri2.musteriYas = 20;
        musteri2.musteriTc = 14556310976;

        Musteri musteri3 = new Musteri();
        musteri3.musteriIsım = "Uğur";
        musteri3.musteriSoyisim = "Çınar";
        musteri3.musteriYas = 20;
        musteri3.musteriTc = 145567474976;

        Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

        MusteriManager musteriManager = new MusteriManager();

        musteriManager.Add(musteri1);
        musteriManager.Add(musteri2);
        musteriManager.Add(musteri3);

        musteriManager.Info(musteri1);
        musteriManager.Delete(musteri2);
    }
}