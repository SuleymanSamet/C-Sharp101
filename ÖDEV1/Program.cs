// 1. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.Write("Girmek istediğiniz Sayı Adetini Giriniz: ");

int sayiAdeti = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[sayiAdeti];
for (int i=0; i<sayiAdeti; i++)
{
    Console.Write("Lütfen {0}. Sayısı Giriniz: ", i + 1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

Console.Write("Girmiş Olduğunuz Çift Sayılar: ");
int bolonebilenSayi = 0;
for (int i=0; i<sayiAdeti; i++)
{
    if (sayiDizisi[i]%2==0)
    {
        bolonebilenSayi++;
        Console.Write(sayiDizisi[i] + " ");
    }
}



// 2. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

Console.Write("Hangi Sayının Bölünmesini İstersiniz: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Kaç Adet Sayı Girmek İstersiniz: ");
int sayi = int.Parse(Console.ReadLine());
int[] sayiD= new int[sayi];
for (int i=0; i<sayi; i++)
{
    Console.WriteLine("Lütfen {0}. Sayısı Giriniz: ", i + 1);
    sayiD[i] = int.Parse(Console.ReadLine());
}

Console.Write("Girmiş Olduğunuz Bölünen sayılar: ");
int bolonen = 0;
for (int i=0; i<sayi; i++)
{
    if (sayiD[i] % m == 0 || sayiD[i] == m)
    {
        bolonen++;
        Console.Write(sayiD[i] + " ");
    }
}



// 3. Soru
//  kullanıcı pozitif bir sayı girsin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Console.Write("Kaç Adet Kelime Girmek İstersiniz: ");
int sayiAdet = int.Parse(Console.ReadLine());
String[] sayiDizi = new String[sayiAdet];
for (int i=0; i<sayiAdet; i++)
{
    Console.Write("Lütfen {0}. Kelimeyi Giriniz: ", i + 1);
    sayiDizi[i] = (Console.ReadLine());
}


Array.Reverse(sayiDizi);
Console.Write("Girmiş Olduğunuz Kelimeler: ");
for (int i=0; i<sayiAdet; i++)
{
        Console.Write(sayiDizi[i] + " ");
    
}




// 4. Soru
//  bir cümle yazması yazın. Cümledeki toplam kelime ve harf sayısını console'a yazdır.

Console.Write("Bir Cümle Yazınız: ");
String Dizisi = Console.ReadLine();

int harf = Dizisi.Length;
string[] bos = Dizisi.Split(' ');
int bosluksuzharf = harf - (bos.Length - 1);
Console.WriteLine("Toplam Kelime: " + bos.Length + " Toplam Harf: " + bosluksuzharf);