using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
           
            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerServices = new DataBaseLoggerServices();
            ILoggerService fileLoggerServices = new FileLoggerServices();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new DataBaseLoggerServices());


            List<IKrediManager> krediler = new List<IKrediManager>() { };

            //basvuruManager.KrediOnBilgilendirmeYap(krediler);


        }
    }
}
