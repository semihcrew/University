class Program
{
    public static void Main()
    {
        Console.WriteLine("Kaç adet sayı girmek istiyorsunuz?");
        int adet = int.Parse(Console.ReadLine());
        double toplam = 0;
        double ortalama = 0;
        for (int i = 0; i < adet; i++)
        {
            Console.WriteLine("Sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());
            toplam = toplam + sayi;
        }
        Console.WriteLine("Sayıların toplamı: " + toplam);
        ortalama = toplam / adet;
        Console.WriteLine("Sayıların ortalaması: " + ortalama);
    }
}
