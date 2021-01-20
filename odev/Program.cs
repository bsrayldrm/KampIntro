using System;

namespace odev
{
    class Program
    {
        public string Adı { get; private set; }

        private int süresi;
        private string linki;

        static void Main(string[] args)
        {
            Program program1 = new Program();
            program1.Adı = "lean arms";
            program1.süresi = 20 - 50;
            program1.linki = "scskdflkfjsdlfjsdglkdsşdkfş";


            Program program2 = new Program();
            program2.Adı = "lean legs";
            program2.süresi = 35;
            program2.linki = "kflkdggdksdşgkşgkdgk";


            Program program3 = new Program();
            program3.Adı = "sixpack";
            program3.süresi = 40;
            program3.linki = "ıjıjjefoeskfosekdkg";

            // Console.WriteLine(kurs1.kursAdı + ":" + kurs1.egitmen);


            Program[] listeprogramlar = new Program[] { program1, program2, program3 };
            foreach (var Program in listeprogramlar)
            {
                Console.WriteLine("program adı"
                    + ":"
                    + Adı);
            }
        }
    }
    class Kurs
    {
        public string Adı { get; set; }
        public int süresi { get; set; }
        public string linki { get; set; }
    }

}
