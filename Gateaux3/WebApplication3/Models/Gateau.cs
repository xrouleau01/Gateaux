namespace WebApplication3.Models
{
    public class Gateau
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int portions { get; set; }
        public string Ingredients { get; set; }
        public int calories { get; set; }
        public string urlImage { get; set; }
    }
}
