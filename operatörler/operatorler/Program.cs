// atama ve işlemli atama
Console.WriteLine("*************ATAMA VE İŞLEMLİ ATAMA*********");
int x =3;
int y=3;
y =y+2;
Console.WriteLine(y);
y +=2;//işlemli atama
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);
x*=2;
Console.WriteLine(x);

//mantıksal operatörler
// ||,&&,!
Console.WriteLine("************MANTIKSAL OPERATÖRLER**********");
bool isSucces =true ;
bool isComplated =false;
if(isSucces && isComplated)
Console.WriteLine("başarılı");
if (isSucces || isComplated) //veya
Console.WriteLine("başarili");
if(isSucces && !isComplated)
Console.WriteLine("doğru");

//ilişkisel operatorler
//<,>,<=,>=,==,!=
Console.WriteLine("******İLİŞKİSEL OPERATORLER*********");
int a =3;
int b=4;
bool sonuc=a<b;
Console.WriteLine(sonuc);
sonuc=a>b;
Console.WriteLine(sonuc);
sonuc = a>= b;
Console.WriteLine(sonuc);
sonuc=a<=b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);
sonuc=a!=b;
Console.WriteLine(sonuc);
//ARİTMETİK OPERATORLER
Console.WriteLine("************ARİTMETİK OPERATÖRLER**********");
// *,/,+,-
int sayi1=10;
int sayi2=5;
int sonuc1=sayi1/sayi2;
Console.WriteLine(sonuc1);
sonuc1=sayi1*sayi2;
Console.WriteLine(sonuc1);
sonuc1=sayi1+sayi2;
Console.WriteLine(sonuc1);
sonuc1=sayi1-sayi2;
Console.WriteLine(sonuc1);
sonuc1=sayi1 ++;
// % mod alma
int sonuc2=20%3;
Console.WriteLine(sonuc2);