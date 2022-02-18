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
//int sayac = 1;
//double toplam = 0;
//while (sayac <= 10)
//{
//    toplam += Math.Pow(sayac, 3);
//    //if (sayac == 10)
//    //    break;
//    sayac++;
//}
#endregion
#region 3. Çözüm
//double toplam = 0;
//int sayac = 1;
//do
//{
//    toplam += Math.Pow(sayac, 3);
//    //if (sayac == 10) break;
//    sayac++;
//} while (sayac <= 10);
#endregion
#region 4. Çözüm
//int sayac = 10;
//double toplamSonuc = 0;
//string sonuc = "";
//while (sayac <= 10)
//{
//    toplamSonuc += Math.Pow(sayac, 3);
//    if (sayac != 10)
//        sonuc += $"{sayac} küp'ü + ";
//    else
//        sonuc += $"{sayac} küp'ü + {toplamSonuc}";
//    sayac++;
//}
//Console.WriteLine(sonuc);
#endregion
//Doğum tarihi girilen kisinin yaşını hesaplayan uygulamayı yazalım
#region 1. Çözüm
//Console.WriteLine("Lütfen doğum tarihini yazınız");
//DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());
//TimeSpan sonuc = DateTime.Now - dogumTarihi;
//Console.WriteLine(sonuc.Days / 365);
#endregion
#region 2. Çözüm
//Console.WriteLine("Lütfen doğum tarihini girin");
//DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
//DateTime bugun = DateTime.Now;
//int yas = bugun.Year - dogumTarihi.Year;
//if (dogumTarihi > bugun.AddYears(-yas))
//    yas--;
//Console.WriteLine(yas);
#endregion
#region 3. Çözüm
//Console.WriteLine("Lütfen doğum tarihi giriniz");
//DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
//int gun = (DateTime.Now - dogumTarihi).Days;
//int yas = gun / 365;
//int kalan = gun % 365;
//Console.WriteLine($"Yaş : {yas} | {yas + 1} yaşınıza kalan gün sayısı : {365 + (yas * 1 / 4) - kalan}");
#endregion
//Girilen sayının faktöriyelini hesaplayan uygulamayı yazalım
#region 1. Çözüm
//Console.WriteLine("Lütfen bir sayı girin");
//int deger = int.Parse(Console.ReadLine());
//int sonuc = 1;
//for (int i = deger; i > 0; i--)
//{
//    sonuc *= i;
//}
//Console.WriteLine(sonuc);
#endregion
#region 2. Çözüm
//Console.WriteLine("Lütfen bir sayı girin");
//int sayi = int.Parse(Console.ReadLine());
//int sonuc = 1;
//while (sayi > 0)
//{
//    sonuc *= sayi;
//    sayi--;
//}
//Console.WriteLine(sonuc);
#endregion
#region 3. Çözüm
Console.WriteLine("Lütfen bir sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());
int sonuc = 1;
do
{
    sonuc *= sayi;
    sayi--;
    if (sayi == 0) break;
} while (true);
#endregion