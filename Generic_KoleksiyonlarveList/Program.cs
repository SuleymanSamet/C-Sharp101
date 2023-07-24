namespace Generic_KoleksiyonlarveList;

class Program
{
    static void Main(string[] args)
    {
        List<int> sayilistesi = new List<int>();
        sayilistesi.Add(10);
        sayilistesi.Add(3);
        sayilistesi.Add(23);
        sayilistesi.Add(19);
        sayilistesi.Add(13);
        sayilistesi.Add(93);

        List<string> renklistesi = new List<string>();
        renklistesi.Add("kırmızı");
        renklistesi.Add("sari");
        renklistesi.Add("mavi");
        renklistesi.Add("mor");
        renklistesi.Add("Yeşil");

        //Count liste içindekş eleman sayısını getirir
        Console.WriteLine(renklistesi.Count);
        Console.WriteLine(sayilistesi.Count);


        //foreach ve List.ForEach ile elemanlara erişim
        foreach (var sayi in sayilistesi)
        {
            Console.WriteLine(sayi);
        }

        foreach (var renk in renklistesi)
        {
            Console.WriteLine(renk);
        }

        sayilistesi.ForEach(sayi=>Console.WriteLine(sayi));
        renklistesi.ForEach(renk=>Console.WriteLine(renk));

        //listeden eleman cıkarma 
        sayilistesi.Remove(3);
        renklistesi.Remove("sari");

        sayilistesi.ForEach(sayi=>Console.WriteLine(sayi));
        renklistesi.ForEach(renk=>Console.WriteLine(renk));
        sayilistesi.RemoveAt(0);//index e göre elemman çıkarma
        renklistesi.RemoveAt(1);

        sayilistesi.ForEach(sayi=>Console.WriteLine(sayi));//yazdırma
        renklistesi.ForEach(renk=>Console.WriteLine(renk));


        //liste içerisinde arama 
        if (sayilistesi.Contains(10))
        {
            Console.WriteLine("10 liste içerisinde bulundu");
        }
        //elemanı vererek index ulaşma
        Console.WriteLine(renklistesi.BinarySearch("Yeşil"));

        //diziyi list'e çevirme
        string[] hayvanlar={"kedi","köpek","kuş"};
        List<string> hayvanlarlistesi=new List<string>(hayvanlar);
        //listeyi temizleme
        hayvanlarlistesi.Clear();

        // list içerisinde nesne tutmak 
        List<kullanıcılar>kullanıcılistesi=new List<kullanıcılar>();
        kullanıcılar kullanıcı1=new kullanıcılar();
        kullanıcı1.Isim="ayşe";
        kullanıcı1.Soyisim="yılmaz";
        kullanıcı1.Yas=26;

        kullanıcılar kullanıcı2=new kullanıcılar();
        kullanıcı2.Isim="fatma";
        kullanıcı2.Soyisim="yılmaz";
        kullanıcı2.Yas=26;

        kullanıcılistesi.Add(kullanıcı1);
        kullanıcılistesi.Add(kullanıcı2);

        List<kullanıcılar>yeniliste=new List<kullanıcılar>();
        yeniliste.Add(new kullanıcılar(){
            Isim="deniz",
            Soyisim="Ekinci",
            Yas=24
            
        });
        foreach (var kullanıcı in kullanıcılistesi)
        {
            Console.WriteLine("kullanıcı adı:"+kullanıcı.Isim);
            Console.WriteLine("kullanıcı soyad:"+kullanıcı.Soyisim);
            Console.WriteLine("Kullanıcı yası:"+kullanıcı.Yas);
        }
        yeniliste.Clear();

    }
    public class kullanıcılar
    {       
        private string isim ; //CTRL+SHİFT+R
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
