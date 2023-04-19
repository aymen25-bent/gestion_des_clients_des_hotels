using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClient
{
    class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Courriel { get; set; }
        public string CarteCredit { get; set; }
        public int NumChambre { get; set; }

        public Client(string nom, string prenom, string courriel, string carteCredit, int numChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteCredit = carteCredit;
            NumChambre = numChambre;
        }
    }

    class Hotel
    {
        public ArrayList Clients { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }

        public Hotel(string nom, string adresse)
        {
            Nom = nom;
            Adresse = adresse;
            Clients = new ArrayList();
        }

        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("======================================================================= ");
            Console.WriteLine("Bienvenue A HOTEL");
            Console.WriteLine("======================================================================= ");
            // Exemple d'utilisation
            Hotel hotel = new Hotel("Le Parisien", "6261 Rue du bordeaux");
            Client client1 = new Client("aymen", "bentounsi", "aymen@gmail.com", "438-274-7801", 101);
            Client client2 = new Client("saber ", "ayoub", "ayoubh@gmail.com", "456-371-8293", 102);

            hotel.AjouterClient(client1);
            hotel.AjouterClient(client2);

            foreach (Client client in hotel.Clients)
            {
                Console.WriteLine("{0} {1} ({2}), chambre {3}", client.Prenom, client.Nom, client.Courriel, client.NumChambre);
            }
            onsole.WriteLine("======================================================================= ");
            Console.WriteLine("Appuyez sur n'importe quelle touche pour quitter.");
            Console.WriteLine("======================================================================= ");

            Console.ReadLine();
        } }
    }
