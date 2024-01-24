using System;

class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä sana: ");
        string syote = Console.ReadLine();

        string tulos = VaihdaKirjaimet(syote);

        Console.WriteLine($"Tulos: {tulos}");
    }
    static string VaihdaKirjaimet(string sana)
    {
        if (sana.Length >= 2)
        {
            char ensimmainenKirjain = sana[0];
            char viimeinenKirjain = sana[sana.Length - 1];

            string uusiSana = viimeinenKirjain + sana.Substring(1, sana.Length - 2) + ensimmainenKirjain;

            return uusiSana;
        }
        else
        {
            return sana;
        }
    }
}
