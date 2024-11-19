// Listing 36.12 Applying validation attributes in the Person.cs file in the Models folder

using System.ComponentModel.DataAnnotations;

namespace Advanced.Models
{
    public class Person
    {
        public long PersonId { get; set; }

        [Required(ErrorMessage = "A firstname is required")]
        [MinLength(3, ErrorMessage = "First names must be 3 or more characters")]
        public string Firstname { get; set; } = string.Empty;

        [Required(ErrorMessage = "A surname is required")]
        [MinLength(3, ErrorMessage = "Sur names must be 3 or more characters")]
        public string Surname { get; set; } = string.Empty;

        [Range(1, long.MaxValue, ErrorMessage = "A department must be selected")]
        public long DepartmentId { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "A location must be selected")]

        public long LocationId { get; set; }

        public Department? Department { get; set; }
        public Location? Location { get; set; }
    }
}
