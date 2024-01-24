Console.Write("Syötä ensimmäinen kokonaisluku:");
int luku1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Syötä toinen kokonaisluku:");
int luku2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Syötä kolmas kokonaisluku:");
int luku3 = Convert.ToInt32(Console.ReadLine());

int suurinLuku = EtsiSuurin(luku1, luku2, luku3);

Console.WriteLine("Suurin luku on: " + suurinLuku);


    static int EtsiSuurin(int a, int b, int c)
{
    int suurin = a;

    if (b > suurin)
    {
        suurin = b;
    }

    if (c > suurin)
    {
        suurin = c;
    }

    return suurin;
}

