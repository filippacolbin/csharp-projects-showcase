using System;
using System.Collections.Generic;
using System.IO;

namespace SaljareConsoleApplication
{
    //Klass som innehåller variabler som innehåller säljarens information
    class Saljare
    {
        public string Namn;
        public string Personnummer;
        public string Distrikt;
        public int AntalSaldaArtiklar;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Lista som sparar alla säljare
            List<Saljare> saljareLista = LasInSaljare();

            //Sorta säljare efter antal sålda artiklar
            SorteraSaljare(saljareLista);

            //Spara resultatet och skriv ut det
            SkrivUtSpara(saljareLista);

            Console.WriteLine("\nTryck på valfri tangent för att avsluta");
            Console.ReadKey();
        }

        //Metod för att läsa in säljare
        static List<Saljare> LasInSaljare()
        {
            List<Saljare> lista = new List<Saljare>();

            //While-loop som kontrollerar inmatningen av antal säljare
            int antal = 0;
            bool sant = false;

            while (!sant)
            {
                Console.Write("Hur många säljare vill du registera? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out antal) && antal > 0)
                {
                    sant = true;
                }
                else
                {
                    Console.WriteLine("Skriv ett giltigt antal säljare!");

                }
            }

            //For-loop som går igenom listan säljare
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Säljare " + (i + 1) + ":");

                //Saljare sparas i variablen salj
                Saljare salj = new Saljare();

                Console.Write("Namn: ");
                salj.Namn = Console.ReadLine();

                Console.Write("Personnummer: ");
                salj.Personnummer = Console.ReadLine();

                Console.Write("Distrikt: ");
                salj.Distrikt = Console.ReadLine();

                //While-loop som kontrollerar antalet sålda artiklar 
                int artiklar;
                while (true)
                {
                    Console.Write("Antal sålda artiklar: ");
                    string artiklarna = Console.ReadLine();

                    if (int.TryParse(artiklarna, out artiklar) && artiklar >= 0)
                    {
                        salj.AntalSaldaArtiklar = artiklar;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Skriv ett giltigt heltal!");
                    }
                }
                lista.Add(salj);
            }

            return lista;
        }

        //Metod för att sorta säljare efter antal sålda artiklar
        //Metoden använder en bubbel-sortering 
        static void SorteraSaljare(List<Saljare> lista)
        {
            //Yttre For-loop som körs tills alla säljare ligger i rätt ordning 
            for (int i = 0; i < lista.Count - 1; i++)
            {
                //Inre For-loop som jämför två i taget och betyder plats om nödvändigt
                for (int j = 0; j < lista.Count - 1 - i; j++)
                {
                    //If-sats som kollar om säljaren på plats j har sålt fler än nästa säljare
                    if (lista[j].AntalSaldaArtiklar > lista[j + 1].AntalSaldaArtiklar)
                    {
                        //Temporär variabel skapas för att göra platsbytet för säljarna 
                        Saljare temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
        }

        //Metod för att spara och skriva ut resultatet 
        static void SkrivUtSpara(List<Saljare> lista)
        {
            //Skapar filen 
            StreamWriter fil = new StreamWriter("saljresultat.txt");

            //Skriver ut rubrikerna för både konsolen och filen
            Console.WriteLine();
            Console.WriteLine("Namn\tPersonnummer\tDistrikt\tAntal");
            fil.WriteLine("Namn\tPersonnummer\tDistrikt\tAntal");

            //Räknare för säljnivå
            int niva1 = 0;
            int niva2 = 0;
            int niva3 = 0;
            int niva4 = 0;

            //For-loop som går igenom alla säljare
            for (int i = 0; i < lista.Count; i++)
            {
                Saljare salj = lista[i];
                string rad = salj.Namn + "\t" + salj.Personnummer + "\t" + salj.Distrikt + "\t" + salj.AntalSaldaArtiklar;

                //Skriver ut till konsolen och filen
                Console.WriteLine(rad);
                fil.WriteLine(rad);

                //If-sats som raknar säljnivåerna
                if (salj.AntalSaldaArtiklar < 50)
                {
                    niva1++;

                    // Skriver ut antalet säljare på nivå 1 antingen
                    // listan är slut eller nästa säljare inte längre är under 50 artiklar.
                    if (i == lista.Count - 1 || lista[i + 1].AntalSaldaArtiklar >= 50)
                    {
                        Console.WriteLine(niva1 + " säljare har nått nivå 1: under 50 artiklar");
                        fil.WriteLine(niva1 + " säljare har nått nivå 1: under 50 artiklar");
                        Console.WriteLine();
                        fil.WriteLine();

                    }
                }
                else if (salj.AntalSaldaArtiklar < 100)
                {
                    niva2++;

                    if (i == lista.Count - 1 || lista[i + 1].AntalSaldaArtiklar >= 100)
                    {
                        Console.WriteLine(niva2 + " säljare har nått nivå 2: 50-99 artiklar");
                        fil.WriteLine(niva2 + " säljare har nått nivå 2: 50-99 artiklar");
                        Console.WriteLine();
                        fil.WriteLine();
                    }
                }
                else if (salj.AntalSaldaArtiklar < 200)
                {
                    niva3++;

                    if (i == lista.Count - 1 || lista[i + 1].AntalSaldaArtiklar >= 200)
                    {
                        Console.WriteLine(niva3 + " säljare har nått nivå 3: 100-199 artiklar");
                        fil.WriteLine(niva3 + " säljare har nått nivå 3: 100-199 artiklar");
                        Console.WriteLine();
                        fil.WriteLine();
                    }
                }
                else
                {
                    niva4++;

                    //If-sats som körs när listan är slut 
                    if (i == lista.Count - 1)
                    {
                        Console.WriteLine(niva4 + " säljare har nått nivå 4: över 199 artiklar");
                        fil.WriteLine(niva4 + " säljare har nått nivå 4: över 199 artiklar");
                        Console.WriteLine();
                        fil.WriteLine();


                    }
                }
            }
            fil.Close();
            Console.WriteLine("\nResultatet har sparats i filen \"saljresultat.txt\".");
        }
    }
}