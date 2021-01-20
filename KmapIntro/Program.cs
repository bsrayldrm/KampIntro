using System;

namespace KmapIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmışMı = true;
            double dolarDün = 7.35;
            double dolarBugun = 7.45;


            if (dolarDün<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else if (dolarBugun<dolarDün)
            {
                Console.WriteLine("azalış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirişYapmışMı == true) 
            {
                Console.WriteLine("kullanıcı ayarlar butonu");

            }
            else
            {
                Console.WriteLine("girişi yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}

