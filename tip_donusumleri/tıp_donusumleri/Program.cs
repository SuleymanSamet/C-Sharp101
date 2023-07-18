internal class Program
{
    private static void Main(string[] args)
    {
        //implicit conversion (bilinçsiz dönüşüm) düşük kapatiseli değişkenin daha yüksek kapasiteli değişkene çevirimi
        Console.WriteLine("**********implicit conversion********");
        byte a = 5;
        sbyte b = 30;
        short c = 10;
        int d = a + b + c;
        Console.WriteLine("d:" + d);

        long h = d;
        Console.WriteLine("h:" + h);

        float i = h;
        Console.WriteLine("i:" + i);

        string e = "süleyman";
        char f = 'k';
        object g = e + f + d;

        Console.WriteLine("g:" + g);
        //explicit conversion(bilinçli dönüşüm) 
        Console.WriteLine("**********explicit conversion********");
        int x = 4;
        byte y = (byte)x;//sagındakı veri dönüştürür
        Console.WriteLine("y:" + y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t1" + t);

        float w = 10.3f;
        byte v = (byte)w;

        Console.WriteLine("v1" + v);

        //ToString methodu
        Console.WriteLine("**********ToString methodu********");
        int xx = 6;
        string yy = xx.ToString();
        Console.WriteLine("yy:" + yy);

        string zz = 15.5f.ToString();
        Console.WriteLine("zz:" + zz);

        //System.Convert
        Console.WriteLine("*********System.Convert********");
        string s1 = "10", s2 = "20";
        int sayi1, sayi2;
        int toplam;
        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);
        toplam = sayi1 + sayi2;
        Console.WriteLine("toplam: " + toplam);

        //parse
        Console.WriteLine("**********Parse ********");
        ParsMethod();

       
    }
     public static void ParsMethod()
        {
            string metin1="10";
            string metin2="10,25"; //double da 7.0 ile , kullanıyoruz
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1); //pars string ifadeleri dönüştürmek için kullanılır
            double1=Double.Parse(metin2);
            Console.WriteLine("rakam1:"+rakam1);
            Console.WriteLine("rakam1:"+double1);



        }
}