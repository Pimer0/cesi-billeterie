namespace coursCESI.Classes;

public class Commercial: Salarie
{
    public int ChiffreAffaire { get; set; }
    public int Commission { get; set; }

    public Commercial(string nom, int salaire, int chiffreAffaire, int commission) : base(nom, salaire)
    {
        ChiffreAffaire = chiffreAffaire;
        Commission = commission;
    }
    
    public int afficherSalaire()
    {
        return Salaire + (ChiffreAffaire * Commission / 100);
    }
    
    public override string ToString()
    {
        return Nom + " " + Salaire + " " + ChiffreAffaire + " " + Commission;
    }


}