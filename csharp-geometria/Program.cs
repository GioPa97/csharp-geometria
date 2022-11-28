/* Consegna:
Nel progetto csharp-geometria creare le seguenti classi :
Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, occupatevi di configurare le sue proprietà di base e altezza (come abbiamo fatto con le nostre auto questa mattina nel programma principale) e stampate a video il perimetro e l’area.
Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:
—— Rettangolo1 ——
base: 20 cm
altezza: 10 cm
Perimetro: 60 cm
Area: 200 cm2
BONUS: Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni, ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.
*/

using csharp_geometria;

Rettangolo nuovoRettangolo = new Rettangolo();
Console.WriteLine("Inserisci un nome per il rettangolo:");
nuovoRettangolo.nomeRettangolo = Console.ReadLine();
Console.WriteLine("Inserisci un numero per la base del rettangolo:");
int baseUtente = nuovoRettangolo.baseRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci un numero per l'altezza del rettangolo:");
int altezzaUtente = nuovoRettangolo.altezzaRettangolo = int.Parse(Console.ReadLine());
nuovoRettangolo.perimetro = nuovoRettangolo.calcolaPerimetro(baseUtente, altezzaUtente);
nuovoRettangolo.area = nuovoRettangolo.calcolaArea(baseUtente, altezzaUtente);
nuovoRettangolo.stampaRettangolo();

//-----------------------------------------------------------------------------------------------


Rettangolo nuovoRettangoloUno = new Rettangolo();
nuovoRettangoloUno.nomeRettangolo = "Anselmo";
nuovoRettangoloUno.baseRettangolo = 3;
nuovoRettangoloUno.altezzaRettangolo = 8;
nuovoRettangoloUno.perimetro = nuovoRettangoloUno.calcolaPerimetro(nuovoRettangoloUno.baseRettangolo, nuovoRettangoloUno.altezzaRettangolo);
nuovoRettangoloUno.area = nuovoRettangoloUno.calcolaArea(nuovoRettangoloUno.baseRettangolo, nuovoRettangoloUno.altezzaRettangolo);
nuovoRettangoloUno.stampaRettangolo();

//-----------------------------------------------------------------------------------------------

Rettangolo nuovoRettangoloDue = new Rettangolo();
nuovoRettangoloDue.nomeRettangolo = "Brigitta";
nuovoRettangoloDue.baseRettangolo = 4;
nuovoRettangoloDue.altezzaRettangolo = 11;
nuovoRettangoloDue.perimetro = nuovoRettangoloDue.calcolaPerimetro(nuovoRettangoloDue.baseRettangolo, nuovoRettangoloDue.altezzaRettangolo);
nuovoRettangoloDue.area = nuovoRettangoloDue.calcolaArea(nuovoRettangoloDue.baseRettangolo, nuovoRettangoloDue.altezzaRettangolo);
nuovoRettangoloDue.stampaRettangolo();



