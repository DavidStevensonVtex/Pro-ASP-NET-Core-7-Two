﻿// Listing 7.18 The contents of the IStoreRepository.cs file in the SportsStore/Models folder

namespace SportsStore.Models
{
    public class IStoreRepository
    {
        IQueryable<Product> Products { get; set; }
    }
}
