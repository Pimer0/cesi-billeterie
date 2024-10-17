namespace Billeterie.Classes;

public class IHM
{
    public string Choix { get; set; }
    
    public void AfficherMenu()
    {
        Console.WriteLine("1. Afficher les billets");
        Console.WriteLine("2. Acheter un billet");
        Console.WriteLine("3. Afficher les billets achetés");
        Console.WriteLine("4. Quitter");
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
}