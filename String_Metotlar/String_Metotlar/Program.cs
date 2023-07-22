string deisken ="dersimiz c# hosgeldiniz";
string deisken2 ="dersimiz c#";
//.Length
Console.WriteLine(deisken.Length);
// toUpper =>hepsini büyültür    toLower=>hepsini küçültür
Console.WriteLine(deisken.ToUpper());
Console.WriteLine(deisken.ToLower());

//Concat
Console.WriteLine(string.Concat(deisken,"Merhaba","süleyman"));
// Compare CompareTo 
Console.WriteLine(deisken.CompareTo(deisken2));// 1. deişken ile 2. deişken karakter sayıları karşılastırır 0,1,-1
Console.WriteLine(String.Compare(deisken,deisken2,true));
Console.WriteLine(String.Compare(deisken,deisken2,false));

//Contains
Console.WriteLine(deisken.Contains(deisken2)); // deişken 1 içinde deişken 2 varsa true döner 
Console.WriteLine(deisken.EndsWith("hosgeldiniz")); //hoşgeldiniz ile bitiyormu
Console.WriteLine(deisken.StartsWith("merhaba")); //merhaba ile başlıyormu

//IndexOf
Console.WriteLine(deisken.IndexOf("cs")); //c nin index verir bulamazas -1 veerir

//İnsert
Console.WriteLine(deisken.Insert(0,"merhaba "));//0 indexden başlayarak merhaba ekler
//LastIndex
Console.WriteLine(deisken.LastIndexOf("i")); //i ile son indexi verir
//Padleft=>      PadRight
Console.WriteLine(deisken + deisken2.PadLeft(30)); // 30 karaktere tamamlayana kadar bosluk ekler 
//remove
Console.WriteLine(deisken.Remove(10));// 10 indexden başlayarak sonuna kadar siler
Console.WriteLine(deisken.Remove(5,3));// 5 den başlar 3 karakter siler 
Console.WriteLine(deisken.Remove(10));// 10 indexden başlayarak sonuna kadar siler

//replace
Console.WriteLine(deisken.Replace("c#","Csharp"));

//Split
Console.WriteLine(deisken.Split(' ')[1]);

//Substring 
Console.WriteLine(deisken.Substring(4));
Console.WriteLine(deisken.Substring(4,6));