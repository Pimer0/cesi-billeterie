namespace Billeterie.Classes;

public class IHM
{
    public string Choix { get; set; }
    
    public void AfficherMenu()
    {
        Console.WriteLine("1. Afficher les billets");
        Console.WriteLine("2. Acheter un billet");
        Console.WriteLine("3. Afficher les billets achetés");
        Console.WriteLine("4. Creer un client");
        Console.WriteLine("5. Creer un événement");
        Console.WriteLine("6. Quitter");
    }
    
    public void AfficherBillets(List<Billet> billets)
    {
        foreach (Billet billet in billets)
        {
            Console.WriteLine("Billet n°" + billet.NumeroPlace + " - " + billet.Categorie + " - " + billet.Evenement.Nom + " - " + billet.Client.Nom + " " + billet.Client.Prenom);
        }
        try 
        {
            if (billets.Count == 0)
            {
                throw new NotFoundException();
            }
        }
        catch (NotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    public void AfficherBilletsAchetes(Client client)
    {
        foreach (Billet billet in client.Billets)
        {
            Console.WriteLine("Billet n°" + billet.NumeroPlace + " - " + billet.Categorie + " - " + billet.Evenement.Nom);
        }
    }
    
    public void AcheterBillet(Client client, List<Evenement> evenements)
    {
        Console.WriteLine("Choisissez un événement :");
        for (int i = 0; i < evenements.Count; i++)
        {
            Console.WriteLine(i + ". " + evenements[i].Nom);
        }
        int choixEvenement = Convert.ToInt32(Console.ReadLine());
        Evenement evenement = evenements[choixEvenement];
        
        Console.WriteLine("Choisissez une catégorie :");
        Console.WriteLine("0. Normal");
        Console.WriteLine("1. VIP");
        Console.WriteLine("2. Gold");
        int choixCategorie = Convert.ToInt32(Console.ReadLine());
        Billet.TypeBillet categorie = (Billet.TypeBillet)choixCategorie;
        
        Console.WriteLine("Choisissez un numéro de place :");
        int numeroPlace = Convert.ToInt32(Console.ReadLine());
        
        client.ReserverBillet(evenement, numeroPlace, categorie);
    }
    
    public void AjouterClient()
    {
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
        
        Client client = new Client(age, nom, prenom, adresse, telephone);
    }
    
    public void AjouterEvenement()
    {
        Console.WriteLine("Entrez le nom de l'événement :");
        string nom = Console.ReadLine();
        
        Console.WriteLine("Entrez le lieu de l'événement :");
        string lieu = Console.ReadLine();
        
        Console.WriteLine("Entrez la date de l'événement :");
        DateTime date = Convert.ToDateTime(Console.ReadLine());
        
        Console.WriteLine("Entrez l'heure de l'événement :");
        DateTime heure = Convert.ToDateTime(Console.ReadLine());
        
        Console.WriteLine("Entrez le nombre de places de l'événement :");
        int nombrePlace = Convert.ToInt32(Console.ReadLine());
        
        Lieu lieuObj = new Lieu(lieu, "France", 20);
        Evenement evenement = new Evenement(nom, lieuObj, date, heure, nombrePlace);
    }
    
}