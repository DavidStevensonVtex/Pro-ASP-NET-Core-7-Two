﻿// Listing 31.3 Changing validation in the Product.cs file in the Models folder

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using WebApp.Validation;

namespace WebApp.Models
{
    //[PhraseAndPrice(Phrase = "Small", Price = "100")]
    public class Product
    {
        public long ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public required string Name { get; set; }

        [Range(1, 999999, ErrorMessage = "Please enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        [Validation.PrimaryKey(ContextType = typeof(DataContext), DataType = typeof(Category))]
        //[Remote("CategoryKey", "Validation", ErrorMessage = "Enter an existing key" )]
        public long CategoryId {  get ; set; }
        public Category? Category {  get; set; }

        [Validation.PrimaryKey(ContextType = typeof(DataContext), DataType = typeof(Supplier))]
        //[Remote("SupplierKey", "Validation", ErrorMessage = "Enter an existing key")]
        public long SupplierId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Supplier? Supplier { get; set; }
    }
}
