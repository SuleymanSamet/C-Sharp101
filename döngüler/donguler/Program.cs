// birden fazla çalışmasını sağlamak için for loop kullanılır
//ekrandan girilen sayıya kadar olan tek sayıların çıktısı.
/* tek sayı
Console.Write("LÜTFEN BİR SAYI GİRİN:");
int sayi=int.Parse(Console.ReadLine());
for (int i = 1; i < sayi; i++)
{
    if (i % 2==1)
    {
        Console.WriteLine(i);
    }
}*/
/*
//çift sayı
Console.Write("Bir Sayı Giriniz :");
int sonuc=int.Parse(Console.ReadLine());
for (int i = 0; i < sonuc; i++)
{
    if (i % 2 ==0)
    {
        Console.WriteLine(i);
    }
}
//1 ile 1000 arasındaki tek ile çift sayıların toplamı yazdırma
int tektoplam=0;
int cifttoplam=0;
for (int i = 1; i <= 1000; i++)
{
    if (i%2==1)
    {
        tektoplam+=i;
        
    }
    else
    {
        cifttoplam+=i;
    }
}
Console.WriteLine("tek sayılar:" + tektoplam);
Console.WriteLine("çift sayılar:" + cifttoplam);
*/
//break continue
for (int i = 1; i < 10; i++)
{
    if (i==4)
    {
        break;
    }
    Console.WriteLine(i);
}
for (int i = 1; i < 10; i++)
{
    if (i==4)
    {
        continue;
    }
    Console.WriteLine(i);
}