Console.Write("Anna luku väliltä 0-999: ");
int luku = Convert.ToInt32(Console.ReadLine());

if (luku < 0 || luku > 999)
{
    Console.WriteLine("Syötä luku väliltä 0-999.");
}
else
{
    int sadat = luku / 100;
    int kymmenetJaYkkoset = luku % 100;
    int ykkoset = kymmenetJaYkkoset % 10;

    if (luku == 0)
    {
        Console.WriteLine("Nolla");
    }
    else
    {
        MuunnaJaTulostaSadat(sadat);

        if (sadat > 0 && kymmenetJaYkkoset > 0)
        {
            Console.Write("ja ");
        }

        MuunnaJaTulostaKymmenetJaYkkoset(kymmenetJaYkkoset);

        if (kymmenetJaYkkoset >= 20)
        {
            MuunnaJaTulostaYkkoset(ykkoset);
        }

        Console.WriteLine();
    }
}

Console.ReadLine();


static void MuunnaJaTulostaSadat(int sadat)
{
    if (sadat > 0)
    {
        string[] sanat = { "", "Yksi", "Kaksi", "Kolme", "Neljä", "Viisi", "Kuusi", "Seitsemän", "Kahdeksan", "Yhdeksän" };
        Console.Write($"{sanat[sadat]}sata ");
    }
}

static void MuunnaJaTulostaKymmenetJaYkkoset(int kymmenetJaYkkoset)
{
    if (kymmenetJaYkkoset >= 20)
    {
        string[] kymmenetSanat = { "", "", "Kaksikymmentä", "Kolmekymmentä", "Neljäkymmentä", "Viisikymmentä", "Kuusikymmentä", "Seitsemänkymmentä", "Kahdeksankymmentä", "Yhdeksänkymmentä" };
        Console.Write($"{kymmenetSanat[kymmenetJaYkkoset / 10]}");
    }
    else if (kymmenetJaYkkoset >= 10)
    {
        string[] teinitSanat = { "Kymmenen", "Yksitoista", "Kaksitoista", "Kolmetoista", "Neljätoista", "Viisitoista", "Kuusitoista", "Seitsemäntoista", "Kahdeksantoista", "Yhdeksäntoista" };
        Console.Write($"{teinitSanat[kymmenetJaYkkoset - 10]}");
    }
}

static void MuunnaJaTulostaYkkoset(int ykkoset)
{
    string[] sanat = { "", "-yksi", "-kaksi", "-kolme", "-neljä", "-viisi", "-kuusi", "-seitsemän", "-kahdeksan", "-yhdeksän" };
    Console.Write($"{sanat[ykkoset]}");
}


