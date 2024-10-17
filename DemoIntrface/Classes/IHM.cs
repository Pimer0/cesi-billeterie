namespace DemoIntrface.Classes;

public class IHM
{
    public int choix { get; set; }
    
    public void AfficherMenu()
    {
        Console.WriteLine("1. Créer un rectangle");
        Console.WriteLine("2. Créer un triangle");
        Console.WriteLine("3. Créer un carré");
        Console.WriteLine("4. Quitter");
    }
    
    public void AfficherChoix()
    {
        Console.Write("Votre choix : ");
        choix = Convert.ToInt32(Console.ReadLine());
        
    }
    
    public void AfficherRectangle()
    {
        Console.WriteLine("Saisir les coordonnées du point d'origine du rectangle");
        Console.Write("Abscisse : ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ordonnée : ");
        int y = Convert.ToInt32(Console.ReadLine());
        Point origine = new Point(x, y);
        Console.Write("Longueur : ");
        double longueur = Convert.ToDouble(Console.ReadLine());
        Console.Write("Largeur : ");
        double largeur = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(origine, longueur, largeur);
        Console.WriteLine($"Rectangle créé : {rectangle}");
    }
    
    public void AfficherTriangle()
    {
        Console.WriteLine("Saisir les coordonnées du point d'origine du triangle");
        Console.Write("Abscisse : ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ordonnée : ");
        int y = Convert.ToInt32(Console.ReadLine());
        Point origine = new Point(x, y);
        Console.Write("Côté 1 : ");
        double cote1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Côté 2 : ");
        double cote2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Côté 3 : ");
        double cote3 = Convert.ToDouble(Console.ReadLine());
        Triangle triangle = new Triangle(origine, cote1, cote2, cote3);
        Console.WriteLine($"Triangle créé : {triangle}");
    }
    
    public void AfficherCarre()
    {
        Console.WriteLine("Saisir les coordonnées du point d'origine du carré");
        Console.Write("Abscisse : ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ordonnée : ");
        int y = Convert.ToInt32(Console.ReadLine());
        Point origine = new Point(x, y);
        Console.Write("Côté : ");
        double cote = Convert.ToDouble(Console.ReadLine());
        Carre carre = new Carre(origine, cote);
        Console.WriteLine($"Carré créé : {carre}");
    }
    
    
}