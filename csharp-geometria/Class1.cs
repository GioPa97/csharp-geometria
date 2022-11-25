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



        // METODI con cui potrò interagire dal programma principale 
        // Posso creare dei metodi per questa classe con i quali il mio programma principale

        public int calcolaArea(int baseRettangolo, int altezzaRettangolo)
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area;

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
            calcolaPerimetro(this.baseRettangolo, this.altezzaRettangolo);
            calcolaArea(this.baseRettangolo, this.altezzaRettangolo);
            Console.WriteLine(this.perimetro);
            Console.WriteLine(this.area);
            Console.WriteLine("---------------------------------------------------");
        }





    }
}