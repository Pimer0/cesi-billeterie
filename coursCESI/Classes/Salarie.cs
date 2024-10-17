namespace coursCESI.Classes;

public class Salarie
{
    static int _nombreDeSalarie = 0;
    static int _salaireTotal = 0;
    public int matricule { get; set; }
    public string service { get; set; }
    public string categorie { get; set; }
    public string Nom { get; set; }
    public int Salaire { get; set; }
    
    
    public Salarie(string nom, int salaire)
    {
        _nombreDeSalarie++;
        _salaireTotal += salaire;
        Nom = nom;
        Salaire = salaire;
    }
    
    public static int AfficherNombreDeSalarie()
    {
        Console.WriteLine("Nombre de salarié : ");
        return _nombreDeSalarie;
    }
    
    public static int AfficherSalaireTotal()
    {
        Console.WriteLine("Salaire total : ");
        return _salaireTotal;
    }
    
    public int AfficherSalaire()
    {
        Console.WriteLine("Salaire de " + Nom + " : " + Salaire);
        return Salaire;
    }
    
    public override string ToString()
    {
        
        return Nom + " " + Salaire;
    }
    
}