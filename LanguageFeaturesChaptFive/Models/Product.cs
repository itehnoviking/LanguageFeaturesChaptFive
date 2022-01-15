namespace LanguageFeaturesChaptFive.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }
        public string Name { get; set; }
        public string Category { get; set; } = "Российская Империя до 1917";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }

        public static Product[] GetProducts()
        {
            Product odnaKopeyka1844em = new Product
            {
                Name = "1 копейка серебром 1844 г. Е.М.",
                Category = "Николай I (1825 - 1855 г.г.)",
                Price = 1100M
            };

            Product denga1950 = new Product(false)
            {
                Name = "Денга 1750 г.",
                Price = 150M
            };

            Product polushka1736 = new Product
            {
                Name = "Полушка 1736 г.",
                Price = 180M
            };

            Product polushka1735 = new Product
            {
                Name = "Полушка 1735 г.",
                Price = 170M
            };

            polushka1735.Related = polushka1736;
            polushka1736.Related = polushka1735;

            return new Product[] { odnaKopeyka1844em, polushka1736, polushka1735, null };
        }
    }
}
