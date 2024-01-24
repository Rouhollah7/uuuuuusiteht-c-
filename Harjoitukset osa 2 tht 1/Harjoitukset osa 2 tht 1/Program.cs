Console.Write("teht1: ");
static void yhteenlasku(int a, int b)
{
    int summa = a + b;
    Console.WriteLine("lukujen {0} ja {1} summa on {2}", a, b, summa);
}
yhteenlasku(3, 5);

Console.Write("teht2: ");
static void fahrenheit(int a)
{
    double fah = a * 1.8 + 32;
    Console.WriteLine("celsiusaste {0} on Fahrenheteita {1} ", a, fah);
}
fahrenheit(10);

Console.WriteLine("teht3:");
static void pst(int a, int b)
{
    int summa, erotus, tulo;
    double osamaara;
    summa = a + b;
    erotus = a - b;
    tulo = a * b;
    osamaara = (double)a / b;
    Console.WriteLine("Lukujen {0} ja {1} \nsumma on {2} \nerotus on {3}\ntulo on {4} \nosamaara on {5}");
}

pst(8, 5); static void jakoj(int a, int b)
{
    Console.Write("teht4: ");
    int jakojaannos = a % b;
    Console.WriteLine("Lukujen {0} ja {1} jakojäänos on {2} ", a, b, jakojaannos);

}
jakoj(5, 2);
Console.Write("teht5: ");
static void tervehdys()
{
    Console.WriteLine("Anna etunimi");
    string etunimi = Console.ReadLine();
    Console.WriteLine("Hei {0}", etunimi);

}
tervehdys();
static void yhteenlasku2()
{
    Console.Write("anna yhteenlasku 1. numero:");
    int eka = int.Parse(Console.ReadLine());
    Console.Write("anna yhteenlasku 2. numero:");
    int toka = int.Parse(Console.ReadLine());
    int summa = eka + toka;
    Console.WriteLine("Lukje  {0} ja {1} summa on {2}", eka, toka, summa);

}
yhteenlasku2();
static void fahrenheit2()
{
    Console.Write("Anna celsiusarvo: ");
    double cel = double.Parse(Console.ReadLine());
    double fah = cel * 1.8 + 32;
    Console.WriteLine("{0} celsiusastetta on {1} fahrenheit astetta", cel, fah);


}
fahrenheit2();
static void pst2()
{
    Console.Write("Anna 1 luku :");
    int l1 = int.Parse(Console.ReadLine());
    Console.Write("Anna 2 luku :");
    int l2 = int.Parse(Console.ReadLine());
    int summa, erotus, tulo;
    double osamaara;
    summa = l1 + l2;
    erotus = l1 - l2;
    tulo = l1 * l2;
    osamaara = (double)l1 / l2;
    Console.WriteLine("Lukujen {0} ja {1} \nsumma on {2} \nerotus on {3}\ntulo on {4} \nosamaara on {5}", l1, l2, summa, erotus, tulo, osamaara);
}
pst2();
static void jakoj2()
{
    Console.Write("Anna jaettava: ");
    int jaettava = int.Parse(Console.ReadLine());
    Console.Write("Anna jaettava: ");
    int jakava = int.Parse(Console.ReadLine());
    double jakojaannos = (double)jaettava / jakava;
    Console.WriteLine("lukujen {0} ja {1} jakava on {2} ", jaettava, jakava, jakojaannos);

}
jakoj2();

Console.Write("Syötä kokonaisluku välillä 1 - 10: ");
if (int.TryParse(Console.ReadLine(), out int luku) && luku >= 1 && luku <= 10)
{
    TulostaKertotaulu(luku);
}
else
{
    Console.WriteLine("Virheellinen syöte. Anna kokonaisluku välillä 1 - 10.");
}
static void TulostaKertotaulu(int luku)
{
    for (int i = 1; i <= 10; i++)
    {
        int tulos = luku * i;
        Console.WriteLine($"{luku} x {i} = {tulos}");
    }
}