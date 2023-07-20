//dizi tanımlama
string[] renkler= new string[5];
string[] hayvanlar={"kedi","köpek","balık","ayı"};
int[] dizi;
dizi= new int[5];

// dizilere değer atama ve erişim
renkler[0]="mavi";
dizi[3]=10;
Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

// döngülerle dizi

//klavyeden girilen n tane sayı ortalamasını alan program 
Console.Write("lütfen dizinin elaman sayısını giriniz :");
int diziuzunlugu=int.Parse(Console.ReadLine());
int[] sayıdizisi=new int[diziuzunlugu];

for (int i = 0; i < diziuzunlugu; i++)
{
    Console.WriteLine("Lütfen {0},sayısı giriniz :",i+1);
    sayıdizisi[i]=int.Parse(Console.ReadLine());
}
int toplam=0;
foreach (var sayi in sayıdizisi)
{
 toplam+=sayi ;  
}
Console.WriteLine("ortalama :" +toplam/diziuzunlugu);