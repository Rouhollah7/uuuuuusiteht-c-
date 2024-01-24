using System;
class Program
{
    static void Main()
    {
        Console.Write("Syötä viisi kokonaislukua:                                                                                              ");

        int suurin = int.MinValue;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Luku {i + 1}: ");

            if (int.TryParse(Console.ReadLine(), out int luku))
            {
                if (luku > suurin)
                {
                    suurin = luku;
                }
            }
            else
            {
                Console.Write("Virheellinen syöte. Anna kokonaisluku.");
                i--; 
            }
        }

        if (suurin != int.MinValue)
        {
            Console.WriteLine($"Suurin luku on: {suurin}");
        }
        else
        {
            Console.WriteLine("Et antanut kelvollisia lukuja.");
        }
    }
}
