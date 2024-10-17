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
            continuer = false;
            break;
        default:
            Console.WriteLine("Choix invalide, veuillez réessayer.");
            break;
    }
}