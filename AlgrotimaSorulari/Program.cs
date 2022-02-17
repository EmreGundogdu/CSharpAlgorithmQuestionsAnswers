//İki sayının toplamını veren uygulamayı yazalım
#region 1. Çözüm
//int sayi1 = 10;
//int sayi2 = 20;
//int sonuc = sayi1 + sayi2;
//Console.WriteLine(sonuc);

//int sayi3 = 10, sayi4 = 20;
//int sonuc2 = sayi3 + sayi4;
//Console.WriteLine(sonuc2);

//Console.WriteLine(sayi1 + sayi2);
#endregion
#region 2. Çözüm
//Console.WriteLine("Lütfen sayi1 değerini giriniz.");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Lütfen sayi2 değerini giriniz");
//int sayi2 = int.Parse(Console.ReadLine());
//Console.WriteLine(sayi1 + sayi2);
#endregion
#region 3. Çözüm
//try
//{
//    Console.WriteLine("Lütfen sayi1 değerini giriniz.");
//    int sayi1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Lütfen sayi2 değerini giriniz");
//    int sayi2 = int.Parse(Console.ReadLine());
//    Console.WriteLine(sayi1 + sayi2);
//}
//catch
//{
//    Console.WriteLine("Lütfen doğru bir sayı değeri giriniz");
//}

#endregion
//Kullanıcın girdiği iki sayının karelerinin toplamını veren uygulamayı yazalım
#region 1. Çözüm
//Console.WriteLine("Lütfen birinci sayıyı giriniz");
//int sayi1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Lütfen ikinci sayıyı giriniz");
//int sayi2 = int.Parse(Console.ReadLine());
//int sonuc = sayi1 * sayi1 + sayi2 * sayi2;
//Console.WriteLine(sonuc);
#endregion
#region 2. Çözüm
//Console.WriteLine("Lütfen birinci sayıyı giriniz");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Lütfen ikinci sayıyı giriniz");
//int sayi2 = Convert.ToInt32(Console.ReadLine());

//Math.Pow(2, 2);    2nin 2. kuvveti
//double sonuc = Math.Pow(sayi1, 2) + Math.Pow(sayi2, 2);
//Console.WriteLine(sonuc);
#endregion
#region 3. Çözüm
//Console.WriteLine("Lütfen birinci ve ikinci sayıları giriniz");
////double sonuc = Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2);
//Console.WriteLine(Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2));
#endregion
//1 'den 10'a kadar olan sayıların kütlerinin toplamını bulan uygulamayı yazalım
#region 1. Çözüm
//double toplam = 0;
//for (int i = 1; i <= 10; i++)
//{
//    //toplam += i * i * i;
//    toplam += Math.Pow(i, 3);
//}
//Console.WriteLine(toplam);
#endregion
#region 2. Çözüm
int sayac = 1;
double toplam = 0;
while (sayac <= 10)
{
    toplam += Math.Pow(sayac, 3);
    sayac++;
    //if (sayac == 10)
    //    break;
}
#endregion