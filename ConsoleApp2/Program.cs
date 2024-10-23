using kámen_nužky_papír;

string[] moznosti = { "1", "2", "3" };
Hra hra = new Hra();

Console.WriteLine("Hra kámen, nůžky, papír");
Console.WriteLine("-------------------------");

while (hra.SkoreHrac < 5 && hra.SkoreNepritele < 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Skóre - Hráč: " + hra.SkoreHrac + " | Počítač: " + hra.SkoreNepritele);
    Console.WriteLine("-------------------------");


    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("kolo hráče");
    Console.WriteLine("1-kámen");
    Console.WriteLine("2-nůžky");
    Console.WriteLine("3-papír");
    Console.WriteLine("----------------------------------");
    string zadanaHodnota = Console.ReadLine().ToLower();
    Console.Clear();

    if (!Array.Exists(moznosti, element => element.Equals(zadanaHodnota)))
    {
        Console.WriteLine("Neplatný výběr.");
        continue;
    }

    Random random = new Random();
    int volbaProtiHraceIndex = random.Next(moznosti.Length);
    string PC = moznosti[volbaProtiHraceIndex];


    Console.WriteLine("Počítač vybral: " + PC);
    Console.WriteLine("Vybral jste: " + zadanaHodnota);
    Console.WriteLine("------------------------------------");


    if (zadanaHodnota == PC)
    {
        Console.WriteLine("Remíza!");
    }
    else if (
        (zadanaHodnota == "1" && PC == "2") ||
        (zadanaHodnota == "2" && PC == "3") ||
        (zadanaHodnota == "3" && PC == "1")
        )
    {
        Console.WriteLine("Vyhráli jste!");
        hra.ZvysitSkoreHrace();
    }
    else
    {
        Console.WriteLine("Počítač vyhrál!");
        hra.ZvysitSkoreNepritele();
    }
    Console.WriteLine("-----------------");


}

Console.ForegroundColor = ConsoleColor.Yellow;
if (hra.SkoreHrac == 5)
{
    Console.WriteLine("Vyhráli jsi!!");
}
else
{
    Console.WriteLine("Proti hráč vyhrál !!!! jsi celelkem hovno ngl  ");
}