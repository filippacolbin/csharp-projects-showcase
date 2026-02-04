/*Filippa Colbin, filippa.colbin@hotmail.se, (colfil-4)
*L0002B
*Inlämningsuppgift 3
*/

namespace PersonApp
{
    public class Person
    {
        public string Fornamn { get; set; }
        public string Efternamn { get; set; }
        public string Personnummer { get; set; }

        //Konstruktor
        public Person(string fornamn, string efternamn, string personnummer)
        {
            Fornamn = fornamn;
            Efternamn = efternamn;
            Personnummer = personnummer;
        }

        //Kontrollera att personnummer är giltigt enligt 21-algoritmen
        public bool KontrolleraPersonnummer()
        {
            string personnr = Personnummer;

            //Kontrollera att det är 10 tecken och att det bara är siffror
            if (personnr.Length != 10 || !long.TryParse(personnr, out _))
            {
                return false;
            }

            int summa = 0;
           

            //For-loop som går igenom varje siffra i personnumret 
            for (int i = 0; i < personnr.Length; i++)
            {
                int siffra = int.Parse(personnr[i].ToString());
                int produkt;

                //If-sats där varje siffra multipliceras med 2,
                if (i % 2 == 0)
                {
                    produkt = siffra * 2;
                }
                else
                {
                    produkt = siffra * 1;
                }

                //If-sats som resultatet är tvåsiffrigt, lägg då ihop siffrorna
                if (produkt >= 10)
                {
                    int tiotal = produkt / 10;
                    int ental = produkt % 10;
                    produkt = tiotal + ental;
                }

                //Lägger till i totalsumman
                summa += produkt;
            }

            //If-sats om summan är delbar med 10
            if (summa % 10 == 0)
                return true;
            else
                return false;
        }

        public string KollaKon()
        {
            string personnr = Personnummer;

            //If-sats som kollar att personnummret är 10 tecken långt 
            //Om det inte är 10 tecken returneras "okänt"
            if (personnr.Length != 10)
                return "Okänt";

            //Näst sista siffran (index 8) avgör kön
            int Kon = int.Parse(personnr[8].ToString());

            if (Kon % 2 == 0)
                return "Kvinna";
            else
                return "Man";
        }
    }
}