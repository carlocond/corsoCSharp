using System;
using Microsoft.VisualBasic;


public class Operazioni
{

    public int Somma(int a, int b)
    {
            int somma = a + b;
            return somma;
        }
    public int Moltiplica(int a, int b) 
    {
            int prodotto = a * b;
            return prodotto;
        }


    public void StampaRisultato(string operazione, int risultato)
    {
        Console.WriteLine($"Il risultato della {operazione} è: {risultato}.");
        
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Inserisci il primo numero");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci il secondo numero");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Quale operazione vuoi effettuare? Somma(s) o Moltiplicazione(m)");
        string risposta = Console.ReadLine();

        switch (risposta)
        {
            case "s":
                Console.WriteLine(b);
                int somma = Somma(a, b);
                StampaRisultato($"Somma {somma}");
                break;

            case "m":
                int prodotto = Moltiplica(a, b);
                StampaRisultato($"Moltiplicazione {prodotto}");
                break;

            default:
                Console.WriteLine("Hai inserito un valore non valido, Scegli tra Somma e Moltiplicazione");
                break;
        }
       
    
    }
}
