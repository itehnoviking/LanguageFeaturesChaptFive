namespace LanguageFeaturesChaptFive.Models
{
    public class Product
    {
        public string Name { get; set; }    
        public decimal? Price { get; set; }
        public Product Related { get; set; }

        public static Product[] GetProducts()
        {
            Product odnaKopeyka1844em = new Product
            {
                Name = "1 копейка серебром 1844 г. Е.М.",
                Price = 1600M
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
