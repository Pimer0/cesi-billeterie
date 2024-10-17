// See https://aka.ms/new-console-template for more information

using Billeterie.Classes;

List<Evenement> evenements = new List<Evenement>{
    new Evenement("Concert", new Lieu("Paris", "France", 20), new DateTime(2022, 12, 25), new DateTime(2022, 12, 25, 20, 0, 0), 100),
    new Evenement("Match", new Lieu("Lyon", "France", 35), new DateTime(2022, 12, 25), new DateTime(2022, 12, 25, 20, 0, 0), 100)
};

List<Client> clients = new List<Client>{
    new Client(20, "Dupont", "Jean", "1 rue de la paix", "0606060606"),
    new Client(25, "Durand", "Pierre", "2 rue de la paix", "0606060607")
};

List<Billet> billets = new List<Billet>{
    new Billet(1, Billet.TypeBillet.Normal, evenements[0], clients[0]),
    new Billet(2, Billet.TypeBillet.VIP, evenements[1], clients[1])
};

IHM ihm = new IHM();

bool continuer = true;
while (continuer)
{
    ihm.AfficherMenu();
    string choix = Console.ReadLine();
    switch (choix)
    {
        case "1":
            ihm.AfficherBillets(billets);
            break;
        case "2":
            Console.WriteLine("Choisissez un client :");
            for (int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine($"{i}. {clients[i].Nom} {clients[i].Prenom}");
            }
            int choixClient = Convert.ToInt32(Console.ReadLine());
            ihm.AcheterBillet(clients[choixClient], evenements);
            break;
        case "3":
            Console.WriteLine("Choisissez un client :");
            for (int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine($"{i}. {clients[i].Nom} {clients[i].Prenom}");
            }
            choixClient = Convert.ToInt32(Console.ReadLine());
            ihm.AfficherBilletsAchetes(clients[choixClient]);
            break;
        case "4":
            Console.WriteLine("Entrez l'âge du client :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le nom du client :");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez le prénom du client :");
            string prenom = Console.ReadLine();
            Console.WriteLine("Entrez l'adresse du client :");
            string adresse = Console.ReadLine();
            Console.WriteLine("Entrez le téléphone du client :");
            string telephone = Console.ReadLine();
            clients.Add(new Client(age, nom, prenom, adresse, telephone));
            break;
        case "5":
            Console.WriteLine("Entrez le nom de l'événement :");
            string nomEvent = Console.ReadLine();
            Console.WriteLine("Entrez le lieu de l'événement :");
            string lieu = Console.ReadLine();
            Console.WriteLine("Entrez la date de l'événement :");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Entrez l'heure de l'événement :");
            DateTime heure = Convert.ToDateTime(Console.ReadLine());
            evenements.Add(new Evenement(nomEvent, new Lieu(lieu, "France", 20), date, heure, 100));
            break;
        case "6":
            continuer = false;
            break;
        default:
            Console.WriteLine("Choix invalide, veuillez réessayer.");
            break;
    }
}