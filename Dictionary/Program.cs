namespace Dictionary;

class Program
{
    static void Main(string[] args)
    {
        
        //System.Collections.Generic altında bulunur
        //key anaktarının veri tipi
        Dictionary<int,string>kullanıcılar =new Dictionary<int, string>();

        kullanıcılar.Add(10,"ayşe yılmaz");
        kullanıcılar.Add(12,"ahmet yılmaz");
        kullanıcılar.Add(21,"mehmet yılmaz");
        kullanıcılar.Add(22,"özcan çosar");

        //dizinin elemanlarına erişim 
        Console.WriteLine("******elemanlara erişim***********");
        Console.WriteLine(kullanıcılar[12]);// 12 anahtarına sahip elemanı getirir
        foreach (var item in kullanıcılar)// tüm elemanları yazdırır
        {
            Console.WriteLine(item);
            
        }

        //Count;
        Console.WriteLine("******Count***********");
        Console.WriteLine(kullanıcılar.Count);// eleman sayısını verir
        //Conteins
        Console.WriteLine("******Conteins***********");
        Console.WriteLine(kullanıcılar.ContainsKey(12));// 12 ANAHTARINA SAHİP KULLANICI VARMI
        Console.WriteLine(kullanıcılar.ContainsValue("Ayşe"));//ayşe diye eleman varmı
        //remove eleman çıkarma
        Console.WriteLine("******remove***********");
        kullanıcılar.Remove(12);
        foreach (var item in kullanıcılar)
        {
            Console.WriteLine(item);
        }

        //keys
        Console.WriteLine("******keys***********");
        foreach (var item in kullanıcılar.Keys)
        {
            Console.WriteLine(item);
        }

        //values  
        Console.WriteLine("******values***********");
        foreach (var item in kullanıcılar.Values)
        {
            Console.WriteLine(item);
            
        }

    }
}

