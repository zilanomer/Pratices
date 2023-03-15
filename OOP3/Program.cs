using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
// ICrediManager konutKrediManager = new KonutKrediManager();  bu şekilde de kullanım olabilir interfaceler de implementasyonu yapılan class ın referansını tutar.
            KonutKrediManager konutKrediManager = new KonutKrediManager();  
            EsnakKredisi esnakKredisi = new EsnakKredisi();
            SmsLoggerService smsLoggerService = new SmsLoggerService(); 


            ILoggerService databaseLoggerService = new DatabaseLoggerService();   
            ILoggerService fileLoggerService = new FileLoggerService();   
            

            BasvuruManager basvuruManager = new BasvuruManager();              // bu şekilde de  instance oluşturulabilir.
            basvuruManager.BasvuruYap(esnakKredisi, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });

            List<ICrediManager> krediler = new List<ICrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgiYap(krediler);

        

        }
    }
}
