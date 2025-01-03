﻿// Listing 5.51 Adding a feature in the IProductSelection.cs file in the Models folder

namespace LanguageFeatures.Models
{
    public interface IProductSelection
    {
        IEnumerable<Product>? Products { get; }
        IEnumerable<string>? Names => Products?.Select(p => p.Name);
    }
}
