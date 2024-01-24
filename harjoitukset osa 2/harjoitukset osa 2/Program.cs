using System;

class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä ikäsi: ");
        int ika = Convert.ToInt32(Console.ReadLine());

        TulostaIkapalaute(ika);
    }

    static void TulostaIkapalaute(int ika)
    {
        int vertailuika = 19
            ;

        if (ika < vertailuika)
        {
            Console.WriteLine($"{ika} – näytät ikäistäsi nuoremmalta");
        }
        else if (ika > vertailuika)
        {
            Console.WriteLine($"{ika} – näytät ikäistäsi vanhemmalta");
        }
        else
        {
            Console.WriteLine($"{ika} – näytät ikäistäsi ikäiseltä");
        }
    }
}

    
