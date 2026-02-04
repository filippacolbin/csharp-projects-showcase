using System;

//Filippa Colbin (colfil-4)

namespace VaxelRaknare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frågar om priset
            Console.Write("Ange pris: ");
            int pris = int.Parse(Console.ReadLine());

            //Betalat belopp
            Console.Write("Betalt: ");
            int betalt = int.Parse(Console.ReadLine());

            //If-sats som kontrollerar att kunden har betalat tillräckligt
            if (betalt < pris)
            {
                Console.WriteLine("För lite betalt. Betala minst: " + pris);
            }

            //Beräka växel
            int vaxel = betalt - pris;

            //Om kunden har betalt exakt belopp
            if (vaxel == 0)
            {
                Console.WriteLine("Ingen växel tillbaka. Tack för ditt köp");
                Console.WriteLine("Tryck Enter för att avsluta...");
                Console.ReadLine();
                return;
            }

            //Lista på sedlar och mynt
            int[] valorer = { 500, 200, 100, 50, 20, 10, 5, 1 };
            string[] namn = { "femhundralapp", "tvåhundralapp", "hundralapp", "femtiolapp", "tjuga", "tiokrona", "femkrona", "enkrona" };

            Console.WriteLine("Växel tillbaka: " + vaxel + " kr");

            //For-loop som loopar igenom varje valör 
            for (int i = 0; i < valorer.Length; i++)
            {
                int antal = vaxel / valorer[i]; //Antal valör
                vaxel %= valorer[i]; //kolla upp detta
                {
                    string text;

                    if (antal == 1)
                    {
                        text = "1 " + namn[i];
                    }
                    else
                    {
                        if (namn[i] == "tjuga")
                            text = antal + " tjugor";
                        else if (namn[i] == "tiokrona")
                            text = antal + " tiokronor";
                        else if (namn[i] == "femkrona")
                            text = antal + " femkronor";
                        else if (namn[i] == "enkrona")
                            text = antal + " enkronor";
                        else
                            text = antal + " " + namn[i] + "ar";
                    }
                    //Skriv ut resultatet i konsolen
                    Console.WriteLine(text);
                }
            }
            Console.WriteLine("Tryck Enter för att avsluta...");
            Console.ReadLine();
        }
    }
}
