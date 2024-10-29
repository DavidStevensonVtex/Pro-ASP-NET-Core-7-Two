# Listing 19.20 Sending a POST request

Invoke-RestMethod http://localhost:5000/api/products -Method POST `
    -Body (@{ Name="Boot Laces"; Price=19.99; CategoryId=2; SupplierId=2 } | `
    ConvertTo-Json ) -ContentType "application/json"

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch19\WebApp> ..\Listing_19-20.ps1

# productId  : 14
# name       : Boot Laces
# price      : 19.99
# categoryId : 2
# category   : 
# supplierId : 2
# supplier   : 