namespace Billeterie.Classes;

public class Lieu : Adresse
{
    public int Capacite { get; set; }
    
    public Lieu(string rue, string ville, int capacite)
    {
        Rue = rue;
        Ville = ville;
        Capacite = capacite;
    }
}