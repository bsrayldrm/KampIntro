using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdı = "C#";
            kurs1.egitmen = "Engin Demiog";
            kurs1.izlenmeOranı = 68;

            
            Kurs kurs2 = new Kurs();
            kurs2.kursAdı = "Java";
            kurs2.egitmen = "kerem";
            kurs2.izlenmeOranı = 64;

            
            Kurs kurs3 = new Kurs();
            kurs3.kursAdı = "phyton";
            kurs3.egitmen = "berkay";
            kurs3.izlenmeOranı = 72;

           // Console.WriteLine(kurs1.kursAdı + ":" + kurs1.egitmen);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdı + ":" + kurs.egitmen);
            }
        }
    }
    class Kurs
    {
        public string kursAdı { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOranı { get; set; }
    }
    
        
}




