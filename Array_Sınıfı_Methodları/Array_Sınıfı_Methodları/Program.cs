//sort
int[] sayiDizisi={23,12,86,72,3,11,17,4};
Console.WriteLine("*******Sırasız oluşturulan dizi*********");
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("*******Sıralı dizi*********");
Array.Sort(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//clear 
Console.WriteLine("*******Array Clear*********");
Array.Clear(sayiDizisi,2,2); // 2 indexden başlayarak 2 tane elamana 0 değeri atadı
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
//reverse
Console.WriteLine("***********tersine çevirme işlevi************");
Array.Reverse(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
//indexOf verilen elaman dizi içinde varsa indexsini döner
Console.WriteLine("***********IndexOf sayı index bulma************");
Console.WriteLine(Array.IndexOf(sayiDizisi,23));

//Ressize
Console.WriteLine("***********ressize ile boyutlandırma************");
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8]=99; 
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}