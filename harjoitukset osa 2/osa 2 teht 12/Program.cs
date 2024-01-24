using System;

class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä suurempi kokonaisluku: ");

        if (int.TryParse(Console.ReadLine(), out int suurempiLuku))
        {
            TulostaToistuvaSekvenssi(suurempiLuku);
        }
        else
        {
            Console.WriteLine("Virheellinen syöte. Syötä kelvollinen kokonaisluku.");
        }
    }
    static void TulostaToistuvaSekvenssi(int luku)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                Console.Write($"{luku} ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                Console.Write($"{luku} ");
            }
            Console.WriteLine();
        }
    }
}
