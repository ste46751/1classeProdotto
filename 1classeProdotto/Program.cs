using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _1classeProdotto
{
    internal class Program
    {
        //crezione classe prodotto con attributi: nome e prezzo
        public class prodotto
        {
            protected string nome;
            protected int prezzo;

            //costruttore senza parametri
            public prodotto()
            {
                nome = "Farro";
                prezzo = 10;
            }

            public void stampa()
            {
                Console.WriteLine($"Il prezzo di {nome} è {prezzo} ");
            }
        }

        //crezione classe prodotto con attributi: nome2 e prezzo2
        public class prodotto2
        {
            protected string nome2;
            protected int prezzo2;

            //costruttore con parametri
            public prodotto2(string n,int p)
            {
                nome2 = n;
                prezzo2 = p;
            }
            //funzione che stampa l'output
            public void stampa()
            {
                Console.WriteLine($"Il prezzo di {nome2} è {prezzo2} ");
            }
        }

        static void Main(string[] args)
        {
            //output del costruttore senza parametri
            prodotto p = new prodotto();
            p.stampa();

            //output del costruttore senza parametri
            Console.WriteLine($"Inserisci il nome del prodotto");
            string nom=Console.ReadLine();
            Console.WriteLine($"Inserisci il prezzo del prodotto");
            int prez= int.Parse(Console.ReadLine());
            prodotto2 p2 = new prodotto2(nom,prez);
            p2.stampa();

            Console.ReadLine();
        }
    }
}
