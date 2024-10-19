namespace AS2425._3F.INF.Prof.Temperature;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prof;3F;19/10/24;Temperatrue");

        Console.WriteLine("1. -2..5");
        Console.WriteLine("2.  5..11");
        Console.WriteLine("3. 11..20");
        Console.WriteLine("4. 20..31");
        Console.WriteLine("5. 31..99");

        Console.WriteLine("Digita il tipo di temperatura");

        int tipoTemperatura = Convert.ToInt32(Console.ReadLine());
        string fasciaTemperatura = "";

        switch(tipoTemperatura)
        {
            case 1: fasciaTemperatura = "ghiaccio"; break;
            case 2: fasciaTemperatura = "freddo"; break;
            case 3: fasciaTemperatura = "tiepido"; break;
            case 4: fasciaTemperatura = "caldo"; break;
            case 5: fasciaTemperatura = "caldissimo"; break;
            default: fasciaTemperatura = "*** non gestita ***"; break;
        }

        Console.WriteLine($"La tipologia della temperatura è {fasciaTemperatura}");
    }
}
