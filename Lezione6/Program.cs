using System;

public class Operazioni
{
    // Metodo per sommare due numeri
    public int Somma(int a, int b)
    {
        int somma = a + b;
        return somma;
    }

    // Metodo per moltiplicare due numeri
    public int Moltiplica(int a, int b)
    {
        int prodotto = a * b;
        return prodotto;
    }

    // Metodo per stampare il risultato dell'operazione
    public void StampaRisultato(string operazione, int risultato)
    {
        Console.WriteLine($"Il risultato della {operazione} è: {risultato}.");
    }

    // Metodo Main - punto di ingresso del programma
    public static void Main(string[] args)
    {
        Operazioni op = new Operazioni(); // Creo un oggetto della classe Operazioni

        Console.WriteLine("Inserisci il primo numero:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci il secondo numero:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Quale operazione vuoi effettuare? Somma(s) o Moltiplicazione(m)");
        string risposta = Console.ReadLine();

        switch (risposta.ToLower()) // per accettare anche lettere maiuscole
        {
            case "s":
                int somma = op.Somma(a, b);
                op.StampaRisultato("somma", somma);
                break;

            case "m":
                int prodotto = op.Moltiplica(a, b);
                op.StampaRisultato("moltiplicazione", prodotto);
                break;

            default:
                Console.WriteLine("Hai inserito un valore non valido. Scegli tra 's' per somma o 'm' per moltiplicazione.");
                break;
        }
    }
}

