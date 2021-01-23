using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adı = "engin";
            //musteri1.Soyadı = "demirog";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdı = "?";



            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "123355";
            musteri1.Adı = "Engin";
            musteri1.Soyadı = "Demirog";
            musteri1.TcNo = "2255412254556";



            TuzelMusteri muster2 = new TuzelMusteri();
            muster2.Id = 2;
            muster2.MusteriNo = "547896";
            muster2.SirketAdı = "kodlama";
            muster2.VergiNo = "02255589";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();





        }
    }
}
