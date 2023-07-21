using System;

class Program
{
    static void Main()
    {
        int a = 2;
        int b = 3;

        Console.WriteLine(a + b);

        int sonuc = topla(a, b);
        Console.WriteLine(sonuc);

        Metotlar ornek = new Metotlar();
        ornek.ekranayazdır(Convert.ToString(sonuc));
        ornek.ekranayazdır(Convert.ToString(a+b));
        int sonuc2 = ornek.arttırvetopla(a, b);
         ornek.ekranayazdır(Convert.ToString(sonuc2));
         ornek.ekranayazdır(Convert.ToString(a+b));
    }

    static int topla(int deger1, int deger2)
    {
        return deger1 + deger2;
    }
}

class Metotlar
{
    public void ekranayazdır(string veri)
    {
        Console.WriteLine(veri);
    }

    public int arttırvetopla(int deger1, int deger2)
    {
        deger1 += 1;
        deger2 += 1;
        return deger1 + deger2;
    }
}
