    Console.Write("ole hyvä ja anna ikäsi: ");
    int ika = int.Parse(Console.ReadLine());
    if (ika < 15) 
{
    Console.Write("saat ajaa polkopyärää");
}
else if(ika <18)
{
    Console.Write("saat ajaa mopa");
}
    else
{
    Console.Write("saat ajaa autoa");
}