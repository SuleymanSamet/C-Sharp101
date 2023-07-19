internal class Program
{
    private static void Main(string[] args)
    {
        //  try
        // {//hata alması muhtemel kod bloğu buraya girilir
        //    Console.WriteLine("Bir sayı giriniz:");
        //    int sayi=Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("girmiş oldunuz sayı : "+sayi);
        // }
        // catch(Exception ex)//yakalanan hata ne yapılıcaksa o yazılır
        // {
        //     Console.WriteLine("Bir Hata Oluştu: "+ ex.Message.ToString());
        // }
        // finally//her zaman çalışan kod blogu 
        // {
        //     Console.WriteLine("İşlem tamamlandı.");
        // }
        
       try //try
       {
        //int a=int.Parse("test");
        int a=int.Parse("-200000000000");
       }
       catch (ArgumentNullException ex)
       {
        Console.WriteLine("boş değer girdiniz.");
        Console.WriteLine(ex);
       }
       catch (FormatException ex)
       {
        Console.WriteLine("veri tipi uygun değil.");
        Console.WriteLine(ex);
       }
       catch (OverflowException ex)
       {
        Console.WriteLine("bu sayı çok küçük yada çok büyük olabilir.");
        Console.WriteLine(ex);
       }
       finally{
        Console.WriteLine("İŞLEM BAŞARIYLA TAMAMLANMISTIR.");
       }
       
    }
}