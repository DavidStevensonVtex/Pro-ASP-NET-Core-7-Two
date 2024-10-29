# Listing 19.15 Saving a Product

Invoke-RestMethod http://localhost:5000/api/products -Method POST `
    -Body (@{ ProductId = 100; Name="Swim Buoy"; Price=19.99; CategoryId=1; SupplierId=1 } | `
    ConvertTo-Json ) -ContentType "application/json"

    # Invoke-RestMethod: D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch19\Listing_19-15.ps1:3:1
    # Line |
    #    3 |  Invoke-RestMethod http://localhost:5000/api/products -Method POST `
    #      |  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    #      | Microsoft.EntityFrameworkCore.DbUpdateException: An error occurred while saving the entity changes. See the inner exception for details.   
    #      | ---> Microsoft.Data.SqlClient.SqlException (0x80131904): Cannot insert explicit value for identity column in table 'Products' when
    #      | IDENTITY_INSERT is set to OFF.    