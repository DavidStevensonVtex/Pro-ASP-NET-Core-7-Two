﻿// Listing 35.33 Applying an attribute in the ToggleService.cs file inthe Services folder

using Advanced.Blazor;
using Microsoft.JSInterop;

namespace Advanced.Services {
    public class ToggleService {
        private List<MultiNavLink> components = new List<MultiNavLink>();
        private bool enabled = true;

        public void EnrolComponents(IEnumerable<MultiNavLink> comps) {
            components.AddRange(comps);
        }

        [JSInvokable]
        public bool ToggleComponents() {
            enabled = !enabled;
            components.ForEach(c => c.SetEnabled(enabled));
            return enabled;
        }
    }
}
