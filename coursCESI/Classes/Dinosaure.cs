namespace coursCESI.Classes;

public class Dinosaure
{
    // Attributs
    
    private int _age;
    private string _nom;
    private int _nombreDePatte;
    
    // pirvate bool _peutVoler;
    
    // Propriétés
    
    public bool PeutVoler { get; set; }
    public string regimeAlimentaire { get; set; } = "Carnivore";
    public double Poids { get; private set; }

    public int Age
    {
        get => _age;
        set => _age = value;
    }
    
    public string Nom
    {
        get => _nom;
        set => _nom = value;
    }
    
    public int NombreDePatte
    {
        get => _nombreDePatte;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Nombre de patte doit être supérieur à 0");
            }
            else
            {
                _nombreDePatte = value;
            }
        }
    }
    
    // Constructeur
    
    public Dinosaure()
    {
        _age = 10;
        _nom = "T-Rex";
        _nombreDePatte = 4;
    }

    public Dinosaure(int age, string nom, int nombreDePatte)
    {
        _age = age;
        _nom = nom;
        _nombreDePatte = nombreDePatte;
    }
    
    public Dinosaure(int age, string nom, int nombreDePatte, double poids)
    {
        _age = age;
        _nom = nom;
        _nombreDePatte = nombreDePatte;
        Poids = poids;
    }
    
    public Dinosaure(int age, string nom, int nombreDePatte, double poids, bool peutVoler)
    {
        _age = age;
        _nom = nom;
        _nombreDePatte = nombreDePatte;
        Poids = poids;
        PeutVoler = peutVoler;
    }
    
    // Méthodes  
    
    public void Crier()
    {
        Console.WriteLine("Roaaaaar");
    }
}