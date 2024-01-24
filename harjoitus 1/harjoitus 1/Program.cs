class Program
{
    static void Main()
    {
        Console.Write("Syötä ensimmäinen luku: ");
        int luku1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Syötä toinen luku: ");
        int luku2 = Convert.ToInt32(Console.ReadLine());

        if (luku1 > luku2)
        {
            int temp = luku1;
            luku1 = luku2;
            luku2 = temp;

            Console.WriteLine("Luvut suuruusjärjestyksessä: " + luku1 + ", " + luku2);
        }
        else
        {
            Console.WriteLine("Luvut ovat suuruusjärjestyksessä: " + luku1 + ", " + luku2);
        }
    }
}
