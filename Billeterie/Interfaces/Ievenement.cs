using Billeterie.Classes;

namespace Billeterie.Interfaces;

public interface Ievenement
{
    public List<Billet> GetBillets();
}