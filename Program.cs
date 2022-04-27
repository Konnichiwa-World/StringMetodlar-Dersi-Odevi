using System;
namespace String_Metodlar
{ class Program
    {static void Main(string[] args)
        {   System.Console.WriteLine("Ad Soyad giriniz:");
            string x =(Console.ReadLine());

            System.Console.WriteLine("Yazdığınız yazının uzunluğu:" + (x.Length));
            System.Console.WriteLine(String.Concat(x,"Süpersin!"));
            System.Console.WriteLine("Sanırım isminde ya A harfi yok, ya da sırası:" + (x.IndexOf("A")));
            System.Console.WriteLine(x.Insert(0,"BAY/BAYAN"));
            System.Console.WriteLine("Bakalim, ismindeki son a nerede:" + x.LastIndexOf("a"));
            System.Console.WriteLine("İsminin 5. hanesinden sonrasına elveda de:" + (x.Remove(5)));
            System.Console.WriteLine("2.den sonra 4 basamak gidecek:" + (x.Remove(2,4)));
            System.Console.WriteLine("İsmindeki A'ların yerine E koyalım bakalım:" + x.Replace("A","E"));
            System.Console.WriteLine("Bakalım soyadsız nasılsın:" + (x.Split(' ')[1]));
            System.Console.WriteLine("Bakalım son 2 hanen nasıl? Umarım ismin adam değildir :D :" + (x.Substring(2)));
            System.Console.WriteLine("Son sihirbazlık:" + (x.Substring(3,3)));
        }
    }
}
