using System;
class Program
{
    static void Main()
    {
        Console.Write("Valitse syötettävä tyyppi (1: kokonaisluku, 2: double-luku, 3: merkkijono):");

        if (int.TryParse(Console.ReadLine(), out int valinta))
        {
            switch (valinta)
            {
                case 1:
                    SyotaKokonaisluku();
                    break;
                case 2:
                    SyotaDoubleLuku();
                    break;
                case 3:
                    SyotaMerkkijono();
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Virheellinen syöte. Anna kokonaisluku.");
        }
    }

    static void SyotaKokonaisluku()
    {
        Console.Write("Syötä kokonaisluku: ");
        if (int.TryParse(Console.ReadLine(), out int luku))
        {
            luku++;
            Console.WriteLine($"Luku kasvatettuna yhdellä: {luku}");
        }
        else
        {
            Console.WriteLine("Virheellinen syöte. Anna kokonaisluku.");
        }
    }

    static void SyotaDoubleLuku()
    {
        Console.Write("Syötä double-luku: ");
        if (double.TryParse(Console.ReadLine(), out double luku))
        {
            luku++;
            Console.WriteLine($"Luku kasvatettuna yhdellä: {luku}");
        }
        else
        {
            Console.WriteLine("Virheellinen syöte. Anna double-luku.");
        }
    }

    static void SyotaMerkkijono()
    {
        Console.Write("Syötä merkkijono: ");
        string merkkijono = Console.ReadLine();
        merkkijono += "*";
        Console.WriteLine($"Merkkijono lisättynä *-merkillä: {merkkijono}");
    }
}

