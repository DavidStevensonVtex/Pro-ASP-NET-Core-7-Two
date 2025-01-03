﻿// Listing 32.7 The contents of the Location.cs file in the Models folder

namespace Advanced.Models
{
    public class Location
    {
        public long LocationId { get; set; }
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public IEnumerable<Person>? People;
    }
}
