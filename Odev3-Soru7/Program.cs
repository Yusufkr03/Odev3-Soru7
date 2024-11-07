// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

List<int> sayilar = new List<int>();
bool devam = true;
int say = 1;
int toplam = 0;
Console.WriteLine("Toplamak istediğiniz Pozitif sayılar giriniz");
Console.WriteLine("İşlemi sonlandırma istediğinizde 0 yazınız");
while (devam == true)
{

    Console.Write("{0}.Sayı:", say);
    int sayi = int.Parse(Console.ReadLine());
    if (sayi == 0)
    {
        devam = false;
    }
    else if (sayi > 0)
    {
        sayilar.Add(sayi);
        toplam = sayi + toplam;
        say++;
    }
    else
    {
        Console.WriteLine("Pozitif sayı giriniz");
    }
}

Console.WriteLine("----Girdiğiniz Sayılar----");
for (int i = 0; i < sayilar.Count; i++)
{
    Console.Write(sayilar[i] + ",");
}
Console.WriteLine();
Console.Write("Toplamları:"+toplam);
