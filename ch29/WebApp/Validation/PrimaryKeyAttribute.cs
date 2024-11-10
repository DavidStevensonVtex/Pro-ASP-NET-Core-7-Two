// Listing 29.17 The contents of the PrimaryKeyAttribute.cs file in the Validation folder

using System.ComponentModel.DataAnnotations;

namespace WebApp.Validation
{
    public class PrimaryKeyAttribute : ValidationAttribute
    {
        public Type? ContextType { get; set; }

        public Type? DataType { get; set; }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (ContextType != null && DataType != null)
            {
                DbContext? context = validationContext.GetRequiredService(ContextType) as DbContext;
                if (context != null && context.Find(DataType, value) == null)
                {
                    return new ValidationResult(ErrorMessage ?? "Enter an existing key value");
                }
            }

            return ValidationResult.Success;
        }
    }
}
