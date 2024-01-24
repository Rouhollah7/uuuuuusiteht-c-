class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä lause: ");
        string lause = Console.ReadLine();
        string pisinSana = EtsiPisinSana(lause);

        if (!string.IsNullOrEmpty(pisinSana))
        {
            Console.WriteLine($"Pisin sana: {pisinSana}");
        }
        else
        {
            Console.WriteLine("Lauseessa ei ollut sanoja.");
        }
    }
    static string EtsiPisinSana(string lause)
    {
        string[] sanat = lause.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (sanat.Length > 0)
        {
            string pisinSana = sanat[0];

            foreach (string sana in sanat)
            {
                if (sana.Length > pisinSana.Length)
                {
                    pisinSana = sana;
                }
            }

            return pisinSana;
        }
        else
        {
            return string.Empty;
        }
    }
}
