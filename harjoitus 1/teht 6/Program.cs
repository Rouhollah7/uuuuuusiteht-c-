using System;
class Program
{
    static void Main()
    {
        Console.Write("Syötä bonuspisteet (kokonaisluku):");

        if (int.TryParse(Console.ReadLine(), out int pisteet))
        {
            switch (pisteet)
            {
                case 1:
                case 2:
                case 3:
                    pisteet *= 10;
                    break;
                case 4:
                case 5:
                case 6:
                    pisteet *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    pisteet *= 1000;
                    break;
                default:
                    Console.WriteLine("Virheelliset pisteet. Anna pisteet välillä 0-9.");
                    return; // Lopetetaan ohjelma virheellisillä pisteillä
            }

            Console.WriteLine($"Kasvatetut bonuspisteet: {pisteet}");
        }
        else
        {
            Console.WriteLine("Virheellinen syöte. Anna kokonaisluku.");
        }
    }
}
