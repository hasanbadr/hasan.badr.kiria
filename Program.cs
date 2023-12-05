namespace hasan.badr.kiria
{
    class Kirja
    {
        // Ominaisuudet (Properties)
        public string Nimi { get; set; }
        public string Kirjailija { get; set; }
        public int Sivumaara { get; set; }
        public bool Onkolainassa { get; private set; }

        // Konstruktori
        public Kirja(string nimi, string kirjailija, int sivumaara)
        {
            Nimi = nimi;
            Kirjailija = kirjailija;
            Sivumaara = sivumaara;
            Onkolainassa = false;
            Console.WriteLine($"Kirja {Nimi} luotu.");
        }

        // Metodit
        public void Lainaa()
        {
            if (!Onkolainassa)
            {
                Onkolainassa = true;
                Console.WriteLine($"Kirja {Nimi} on nyt lainassa.");
            }
            else
            {
                Console.WriteLine($"Kirja {Nimi} on jo lainassa.");
            }
        }

        public void Palauta()
        {
            if (Onkolainassa)
            {
                Onkolainassa = false;
                Console.WriteLine($"Kirja {Nimi} on palautettu.");
            }
            else
            {
                Console.WriteLine($"Kirja {Nimi} ei ole lainassa, ei tarvitse palauttaa.");
            }
        }
    }

    class Ohjelma
    {
        static void Main()
        {
            // Luodaan kirja-instansseja
            Kirja kirja1 = new Kirja("Kirja 1", "Kirjailija 1", 200);
            Kirja kirja2 = new Kirja("Kirja 2", "Kirjailija 2", 150);
            Kirja kirja3 = new Kirja("Kirja 3", "Kirjailija 3", 300);

            // Käytetään gettereitä ja settereitä
            kirja1.Nimi = "Päivitetty Kirja 1";
            Console.WriteLine($"Päivitetty nimi kirjalle 1: {kirja1.Nimi}");

            // Käytetään lainaamis- ja palauttamismetodeita
            kirja1.Lainaa();
            kirja2.Lainaa();
            kirja2.Palauta();
            kirja3.Lainaa();
            kirja3.Palauta();
        }
    }

}
