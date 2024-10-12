// Listing 5.48 The contents of the IProductSelection.cs file in the Models folder

namespace LanguageFeatures.Models
{
    public interface IProductSelection
    {
        IEnumerable<Product>? Products { get; }
    }
}
