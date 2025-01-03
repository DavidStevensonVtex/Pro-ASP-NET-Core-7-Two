﻿// Listing 38.4 The IdentityContext.cs file in the Models folder of the Advanced Project

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Advanced.Models {
    public class IdentityContext : IdentityDbContext<IdentityUser> {

        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options) { }
    }
}
