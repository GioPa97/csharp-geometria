namespace csharp_geometria
{
    public class Rettangolo
    {
        // CARATTERISTICHE / PROPRIETA' che voglio tracciare (di un rettangolo

        public int baseRettangolo = 20;
        public int altezzaRettangolo = 10;
        public string nomeRettangolo;
        public int perimetro;
        public int area;
        public string colore = "bianco";


        //costruttore rettangolo
        public Rettangolo()
        {
           
        }
        public Rettangolo(string nomeRettangolo, int baseRettangolo, int altezzaRettangolo)
        {
            this.nomeRettangolo = nomeRettangolo;
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        public Rettangolo(string colore, string nomeRettangolo, int baseRettangolo, int altezzaRettangolo)
        {
            this.colore = colore;
            this.nomeRettangolo = nomeRettangolo;
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }



        // METODI con cui potrò interagire dal programma principale 
        // Posso creare dei metodi per questa classe con i quali il mio programma principale

        public int calcolaArea(int baseRettangolo, int altezzaRettangolo)
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area;

        }

        public void cambiacolore(string colore)
        {
            this.colore = colore;
        

        }

        public int calcolaPerimetro(int baseRettangolo, int altezzaRettangolo)
        {
            int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetro;

        }

        public void stampaRettangolo()
        {
            Console.WriteLine($"---Informazioni Rettangolo {this.nomeRettangolo}---");
            Console.WriteLine($"Altezza: {this.altezzaRettangolo}");
            Console.WriteLine($"Base: {this.baseRettangolo}");
            Console.WriteLine(this.colore);
            Console.WriteLine(this.perimetro);
            Console.WriteLine(this.area);
            Console.WriteLine("------------------------------------");
        }





    }
}