// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
byte b = 5; // 1 byte
sbyte c = 6;//1 byte

short s = 5;//2byte
ushort us = 5;//2byte

Int16 i16=3;//2 byte
int i =2;//4 byte
Int32 i32=2;//4 byte
Int64 i64=2;//8 byte

uint ui=2;//4 byte
long l=4;//8 byte
ulong ul=4;//8 byte

float f=5;//4 byte
double d=5;//8 byte
decimal de=5;//16 byte

char ch ='2';//2 byte
string st="sade"; //sınırsız 16,42

Boolean b1=true;
Boolean b2=false;

DateTime dt =DateTime.Now;      //tarih ve saat tutmak için kullanıyoruz 
Console.WriteLine(dt); 

object o1="x";
object o2='y' ;
object o3=3.3;
object o4=4;

//String ifadeler
string str1=string.Empty;
str1="Süleyman Samet Yumuşak";
string ad="Süleyman ";
string soyad="Yumuşak";
string tamad=ad+" "+soyad;

//integer tanımlama 
int in1=5;
int in2=3;
int int3=in1*in2;

//boolean tanımlama
bool bo1=10<2;

//değişken dönüşüm
string str20="20";
int int20=20;
string yenisayi=str20+int20.ToString(); //string olarak toplama yaptı 
Console.WriteLine(yenisayi);

int int21=int20+Convert.ToInt32(str20) ;
int int22=int20 ;
int tplm=int21+int22;
Console.WriteLine(tplm);

int22=int20+int.Parse(str20);
//date time
string datetime=DateTime.Now.ToString("dd,MM,yyyy"); //bugunun tarihi bana gün ay yıl olarak araları noktalı getir
Console.WriteLine(datetime);

//saat
string hour=DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);