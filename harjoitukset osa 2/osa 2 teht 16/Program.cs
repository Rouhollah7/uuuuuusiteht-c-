using System;

class Ohjelma
{
    static void Main()
    {
        TulostaParittomatLuvut();
    }

    static void TulostaParittomatLuvut()
    {
        for (int i = 1; i <= 99; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}

