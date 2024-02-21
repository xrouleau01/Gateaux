namespace WebApplication3.Models
{
    public interface IGateauRep
    {
        IEnumerable<Gateau> lsGateaux { get; }

        Gateau ChercherGateau(int id);
    }
}
