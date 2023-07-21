using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main()
        {
            // out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Metotlar instance =new Metotlar();
            instance.Topla(4,5,out int toplamsonuc);
            Console.WriteLine(toplamsonuc);

            // metot aşırı yükleme
            int ifade=999;
            instance.ekranayazdir(Convert.ToString(ifade));
            instance.ekranayazdir(ifade);
            //metot imzasına göre karar verir
            //metot adı + parametre sayısı+parametre tipi bu üçü aynı olursa bize hata verir
        }
    }

    class Metotlar
    {
        // "out" parametreli topla metodu
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        // string ve int kullanabildiğimiz için bunu overloading yapmış olduk
        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }

          public void ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}

