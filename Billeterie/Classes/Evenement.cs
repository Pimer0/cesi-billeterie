using Billeterie.Interfaces;

namespace Billeterie.Classes;

public class Evenement : Ievenement
{
    public string Nom { get; set; }
    public Lieu Lieu { get; set; }
    public DateTime Date { get; set; }
    public DateTime Heure { get; set; }
    public List<Billet> Billets = new List<Billet>();
    public int nombrePlace { get; set; }
    
    public Evenement(string nom, Lieu lieu, DateTime date, DateTime heure, int nombrePlace)
    {
        Nom = nom;
        Lieu = lieu;
        Date = date;
        Heure = heure;
        this.nombrePlace = nombrePlace;
    }
    
    public List<Billet> GetBillets()
    {
        return Billets;
    }

}