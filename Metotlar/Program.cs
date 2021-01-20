using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string productAdi = "elma";
            double fiyat = 15;
            string aciklama = "amasya elması";

            string [] meyveler = new string [] { };

            Product product1 = new Product();
            product1.Adi = "elma";
            product1.Fiyatı = 15;
            product1.Açıklama = "amasya elması";

            Product product2 = new Product();
            product2.Adi = "kapuz";
            product2.Fiyatı = 80;
            product2.Açıklama = "diyarbakır karpuzu";

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyatı);
                Console.WriteLine(product.Açıklama);
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("-----------------metotlar------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);


            sepetManager.Ekle2("armut", "yeşil armut", 12, 10);
            sepetManager.Ekle2("elma", "amasya elması", 15, 9);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 80, 8);



        }
    }
}
