using System;

public class Program
{
    static void Main()
    {
        int Result = 1;
        for (int i = 1; i <= 4; i++)
        {
            Result = Result * 3;
        }
        Console.WriteLine(Result);

        Islemler instance = new Islemler();
        Console.WriteLine(instance.Expo(3, 4));

        // Extension methods
        string ifade = "Süleyman samet yumusak";
        Console.WriteLine(ifade.CheckSpaces());

        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);

        if (sonuc)
        {
            Console.WriteLine(ifade.RemoveWhiteSpace());
        }
        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.LowerCase());

        int[] dizi={9,3,6,2,1,5,0}; 
        dizi.SortArray();
        dizi.ekranayazdır();
        int sayı=5;
        Console.WriteLine(sayı.İsEvenNumber());
        
    }
}

public class Islemler
{
    public int Expo(int sayi, int üs)
    {
        if (üs == 0)
        {
            return 1;
        }
        else if (üs == 1)
        {
            return sayi;
        }
        else
        {
            return Expo(sayi, üs - 1) * sayi;
        }
    }
}

public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpace(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }
     public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

     public static string LowerCase(this string param)
    {
        return param.ToLower();
    }
     public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
        
    //dizi.SortArray();SortArray
    public static void ekranayazdır(this int[] param)
    {
       foreach (int item in param)
       {
        Console.WriteLine(item);
       }
    }
     public static bool İsEvenNumber(this int param)
    {
        return param %2==0;
    }

}
