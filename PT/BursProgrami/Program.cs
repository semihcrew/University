class Program
{
    public static void Main()
    {
        double[] burs = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };
        int i = 0;
        foreach (double d in burs)
        {
            if (d < 500)
            {
                burs[i] += burs[i] * 0.1 + 50;
            }
            Console.WriteLine(burs[i]);
            i++;
        }
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }
}
