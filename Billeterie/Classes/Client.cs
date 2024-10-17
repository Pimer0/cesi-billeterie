using Billeterie.Interfaces;

namespace Billeterie.Classes;

public class Client : Iclient
{
    public int Age { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Adresse { get; set; }
    public string Telephone { get; set; }
    
    public List<Billet> Billets = new List<Billet>();
    
    public Client(int age, string nom, string prenom, string adresse, string telephone)
    {
        Age = age;
        Nom = nom;
        Prenom = prenom;
        Adresse = adresse;
        Telephone = telephone;
    }
    
    public void ReserverBillet(Evenement evenement, int numeroPlace, Billet.TypeBillet categorie)
    {
        if (evenement.nombrePlace > 0)
        {
            Billet billet = new Billet();
            billet.NumeroPlace = numeroPlace;
            billet.Categorie = categorie;
            billet.Evenement = evenement;
            billet.Client = this;
            Billets.Add(billet);
            evenement.Billets.Add(billet);
            evenement.nombrePlace--;
        }
        else
        {
            Console.WriteLine("Plus de place disponible pour cet événement");
        }
    }
}