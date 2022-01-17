namespace LanguageFeaturesChaptFive.Models
{
    public interface IProductSelection
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<string> Names => Products.Select(p => p.Name);
        
    }
}
