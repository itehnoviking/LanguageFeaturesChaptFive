using System.Collections;

namespace LanguageFeaturesChaptFive.Models
{
    public class ShoppingCart : IProductSelection
    {
        private List<Product> products = new List<Product>();

        public ShoppingCart(params Product[] prods)
        {
            products.AddRange(prods);
        }
        public IEnumerable<Product> Products { get => products; }
    }
}
