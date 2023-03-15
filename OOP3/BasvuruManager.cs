using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class BasvuruManager
    {

        // Method injection:  BasvuruYap methodunun hangi credimanager ve hangi logger dservicde alacağını dışarıdan enjekte ediyoruz. Soyut halleri var b
        // somut hallerini enjekte ediyoruz.
        public void BasvuruYap(ICrediManager crediManager, List<ILoggerService> loggerServices) // ICrediManager hepsinin referansını tuttuğu için bunu yazarız.
        {
            crediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log(); // her bir loglayıcıyı çalıştır. 

            }

        }


        public void KrediOnBilgiYap(List<ICrediManager> krediler)
        {
            foreach (var kredi in krediler) // Listedeki her bir kredinin hesabını yap.
            {
                kredi.Hesapla();
            }
           
        }
    }
}
