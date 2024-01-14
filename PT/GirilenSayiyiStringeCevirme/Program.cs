class Program
{
    static void Main()
    {
        string sayiString = " ";
        string[] birler = { "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
        string[] onlar = { "on ", "yirmi ", "otuz ", "kırk ", "elli ", "altmış ", "yetmiş ", "seksen ", "doksan " };
        string[] yüzler = { "yüz ", "iki yüz ", "üç yüz ", "dört yüz ", "beş yüz ", "altı yüz ", "yedi yüz ", "sekiz yüz ", "dokuz yüz " };
        Console.WriteLine("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());
        if ((sayi / 100) >= 1)
        {
            sayiString = yüzler[(sayi / 100) - 1];
            sayi = sayi % 100;
        }
        if ((sayi / 100) < 0)
        {
            sayiString = "eksi " + yüzler[Math.Abs(sayi / 100) - 1];
            sayi = Math.Abs(sayi % 100);
        }
        if ((sayi / 10) >= 1)
        {
            sayiString = sayiString + onlar[(sayi / 10) - 1];
        }
        if ((sayi % 10) >= 1)
        {
            sayiString = sayiString + birler[(sayi % 10) - 1];
        }
        if (sayi == 0)
        {
            sayiString = "sıfır";
        }
        Console.WriteLine(sayiString);
        Console.ReadLine();
    }
}
