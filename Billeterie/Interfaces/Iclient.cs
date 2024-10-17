using Billeterie.Classes;

namespace Billeterie.Interfaces;

public interface Iclient
{
    public void ReserverBillet(Evenement evenement, int numeroPlace, Billet.TypeBillet categorie);
}

