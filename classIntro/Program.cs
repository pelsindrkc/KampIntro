using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin demirog";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "kerem varış";
            kurs2.IzlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "pyhton";
            kurs3.Egitmen = "berkay bilgin";
            kurs3.IzlenmeOrani = 80;

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " :" + kurs.Egitmen);
            }
        }
    }


    class kurs // kurs adında kendimize bir değişken yaptık önceden string kullanıyorduk ama metinsel ifadelerde bu değişken kendi istediğimiz herşeyi kaplayabilişr ayrı ayrı değişkenimizin ismnş yapmamıza gerek yok
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
