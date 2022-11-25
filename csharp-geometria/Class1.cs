using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    public class Rettangolo
    {
        // CARATTERISTICHE / PROPRIETA' che voglio tracciare (di un rettangolo

        public int baseRettangolo;
        public int altezzaRettangolo;




        // METODI con cui potrò interagire dal programma principale 
        // Posso creare dei metodi per questa classe con i quali il mio programma principale

        public int calcolaAreaint(int baseRettangolo, int altezzaRettangolo)
        {
            int area = baseRettangolo * altezzaRettangolo;
                return area;

        }

        public int calcolcaPerimetro(int baseRettangolo, int altezzaRettangolo)
        {
            int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetro;
        }



        public void StampaRettangolo()
        {
            Console.WriteLine("Base: \t" + baseRettangolo);
            Console.WriteLine("Altezza: \t" + altezzaRettangolo);


        }


    }
}