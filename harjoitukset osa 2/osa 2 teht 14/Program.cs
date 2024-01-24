using System;

class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä ensimmäinen kokonaisluku: ");
        int luku1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Syötä toinen kokonaisluku: ");
        int luku2 = Convert.ToInt32(Console.ReadLine());

        TarkistaJaTulostaSuhde(luku1, luku2);
    }

    static void TarkistaJaTulostaSuhde(int luku1, int luku2)
    {
        if (luku1 > 0 && luku2 > 0)
        {
            Console.WriteLine("Molemmat ovat positiivisia.");
        }
        else if (luku1 < 0 && luku2 < 0)
        {
            Console.WriteLine("Molemmat ovat negatiivisia.");
        }
        else
        {
            Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen.");
        }
    }
}

