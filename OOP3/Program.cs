using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService(); //alttakini yapmak yerine böylede yapabiliriz
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() }); //new DatabaseLoggerService(); yada new fileLoggerService();buraya yazarsakta olur
            //istersek 14 ve 15. satırdaki gibi yapıpı buraya new demeden ismini yazarsakta olur.

            //üst kısma hangi krediyi yazarsak bizi o kredinin hesapla kısmına gönderecek.
            //bu yaptığımız clasları interfaceye bağlamak işlemi "Depented İnjection"deriz. 
            //bu işlem çok önemlidir.
            //alt kısma list açmamızın sebebi birden çok krediyi seçersem eğer seçtiklerimmi 
            //aynı anda hesaplasın diye üstte sadecde tek bir krediyi hesaplar list sayesinde birden 
            //fazla krediyi hesaplayabilir.


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
