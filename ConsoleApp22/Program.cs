
static void Main(string[] args)
{
    int kisaKenar, uzunKenar, alan, cevre;
    Console.Write("Kısa Kenar : ");
    kisaKenar = Convert.ToInt32(Console.ReadLine());
    Console.Write("Uzun Kenar : ");
    uzunKenar = Convert.ToInt32(Console.ReadLine());

    alan = kisaKenar * uzunKenar;
    cevre = 2 * (kisaKenar + uzunKenar);
    Console.WriteLine("===============================");
    Console.WriteLine("Dikdörtgenin Alanı : " + alan);
    Console.WriteLine("Dikdörtgenin Çevresi : " + cevre);

    Console.ReadLine();
}

