namespace Billeterie.Classes;

public class Billet
{
    public int NumeroPlace { get; set; }
    public enum TypeBillet
    {
        Normal,
        VIP,
        Gold
    }
    public TypeBillet Categorie { get; set; }
    public Evenement Evenement { get; set; }
    public Client Client { get; set; }
    
    public Billet(int numeroPlace, TypeBillet categorie, Evenement evenement, Client client)
    {
        NumeroPlace = numeroPlace;
        Categorie = categorie;
        Evenement = evenement;
        Client = client;
    }

    public Billet()
    {
        throw new NotImplementedException();
    }
}