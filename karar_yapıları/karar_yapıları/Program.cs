internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour; //o anki saati alabiliriz
        if (time>=6 &&time<11 )
        {
            Console.WriteLine("Günaydın.");
        }
        else if (time>=11 &&time<19)
        {
            Console.WriteLine("iyi günler");
        }
        else
        {
            Console.WriteLine("İyi geceler");
        }

        string sonuc =time <= 18 ? "iyigünler" : "iyi geceler";
        sonuc = time>6 && time<11 ? "günaydın" : time<=18 ? "iyi günler":"iyi geceler";
        Console.WriteLine(sonuc);
    }
}