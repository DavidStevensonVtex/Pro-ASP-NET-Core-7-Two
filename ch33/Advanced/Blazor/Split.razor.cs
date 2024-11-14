// Listing 33.22 The contents of the Split.razor.cs file in the Balzor folder

using Advanced.Models;
using Microsoft.AspNetCore.Components;

namespace Advanced.Blazor {

    public partial class Split {

        [Inject]
        public DataContext? Context { get; set; }

        public IEnumerable<string> Names =>
            Context?.People.Select(p => p.Firstname)
                ?? Enumerable.Empty<string>();
    }
}
