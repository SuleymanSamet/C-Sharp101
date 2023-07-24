namespace datetime_sınıf_metotları;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now); //günün tarihi
        Console.WriteLine(DateTime.Now.Date); //gün ay yıl
        Console.WriteLine(DateTime.Now.Day);//gün
        Console.WriteLine(DateTime.Now.Month);//ay
        Console.WriteLine(DateTime.Now.Year);//yıl
        Console.WriteLine(DateTime.Now.Hour);//saatini
        Console.WriteLine(DateTime.Now.Minute);//dakikasını
        Console.WriteLine(DateTime.Now.Second);//saniyesi

        Console.WriteLine(DateTime.Now.DayOfWeek);//haftanın gününü string halde getirir
        Console.WriteLine(DateTime.Now.DayOfYear);//içinde bulunan yılın kaçıncı günü
        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortDateString());

        //olan güne eklemeler yapar
        Console.WriteLine(DateTime.Now.AddDays(2));//2 gün ekler
        Console.WriteLine(DateTime.Now.AddHours(3));//3 saat ekler
        Console.WriteLine(DateTime.Now.AddSeconds(30));//30 saniye ekler
        Console.WriteLine(DateTime.Now.AddMonths(5));//5 ay ekler 
        Console.WriteLine(DateTime.Now.AddYears(10));//10 yıl ekler
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        //Datetime format
        //GÜN
        Console.WriteLine(DateTime.Now.ToString("dd")); //24
        Console.WriteLine(DateTime.Now.ToString("ddd"));//GÜNÜN KISALTMASI
        Console.WriteLine(DateTime.Now.ToString("dddd"));//GÜNÜN TAM İSMİ
        
        //AY
        Console.WriteLine(DateTime.Now.ToString("MM")); //07
        Console.WriteLine(DateTime.Now.ToString("MMM"));//AY KISALTMASI
        Console.WriteLine(DateTime.Now.ToString("MMMM"));//AYIN TAM İSMİ

        //YIL
        Console.WriteLine(DateTime.Now.ToString("yy")); //23
        Console.WriteLine(DateTime.Now.ToString("yyyy"));//2023


        //Math kütüphanesi
        Console.WriteLine(Math.Abs(-25));//mutlağını alır
        Console.WriteLine(Math.Sin(10));//sinüs hesabı alır
        Console.WriteLine(Math.Cos(-25));//cosinüs alır
        Console.WriteLine(Math.Tan(-25));//tanjantını alır

        //nokta (.) konur
        Console.WriteLine(Math.Ceiling(22.3));//22.3 den büyük tam sayı
        Console.WriteLine(Math.Round(22.3));////22.3 e hangisi yakınsa o tam sayıyı verir 
        Console.WriteLine(Math.Floor(22.7));//22.7 den en kücük tam sayıyı verir

        Console.WriteLine(Math.Max(2,7));
        Console.WriteLine(Math.Min(2,7));

        Console.WriteLine(Math.Pow(3,4));//3 üzeri 4 
        Console.WriteLine(Math.Sqrt(9));//KAREKÖK;
        Console.WriteLine(Math.Log(9));//logRİTMA
        Console.WriteLine(Math.Exp(3));//e üzeri 3 verir
        Console.WriteLine(Math.Log10(2)); // 2 sayısının log 10 tabanında karşılığı




        

    }
}
