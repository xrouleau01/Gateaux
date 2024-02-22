namespace WebApplication3.Models
{
    public class MemGateauRep
    {
        public IEnumerable<Gateau> collectionGateau => new List<Gateau>()
        {
            new Gateau {Id = 0, Nom = "Volcan et dinausores", portions = 4, Ingredients = "farine, sucre, lait, oeufs, extrait de vanille", calories = 1000, urlImage = "/dino.jpg"},
            new Gateau {Id = 1, Nom = "Chat", portions = 5, Ingredients = "farine, sucre, pépites de chocolat, lait, oeufs", calories = 2000, urlImage = "/chat.jpg"},
            new Gateau {Id = 2, Nom = "Ciel", portions = 1, Ingredients = "farine, sucre, pépites de chocolat, lait, oeufs", calories = 36, urlImage = "/ciel.jpg"},
            new Gateau {Id = 3, Nom = "Rouge", portions = 10, Ingredients = "farine, sucre, pépites de chocolat, lait, oeufs", calories = 2900, urlImage = "/rouge.jpg"},
            new Gateau {Id = 4, Nom = "Barbie", portions = 7, Ingredients = "farine, sucre, pépites de chocolat, lait, oeufs", calories = 680, urlImage = "/barbie.jpg"},
            new Gateau {Id = 5, Nom = "Mathieu", portions = 3, Ingredients = "farine, sucre, pépites de chocolat, lait, oeufs", calories = 1230, urlImage = "/mathieu.jpg"},
            new Gateau {Id = 6, Nom = "Gazon", portions = 7, Ingredients = "farine, sucre, pépites de chocolat, lait, oeufs", calories = 680, urlImage = "/gazon.jpg"},
            new Gateau {Id = 7, Nom = "Choco", portions = 3, Ingredients = "farine, sucre, pépites de chocolat, lait, oeufs", calories = 1230, urlImage = "/choco.jpg"},
        };

        public Gateau ChercheGateau(int id)
        {
            return collectionGateau.FirstOrDefault(x => x.Id == id);
        }
    }
}
