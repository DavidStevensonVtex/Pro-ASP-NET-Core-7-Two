# Listing 20.23 Sending JSON data via HTTP POST

Invoke-RestMethod http://localhost:5000/api/content -Method POST `
    -Body (@{ Name="Swimming Goggles"; Price=12.75; CategoryId=1; SupplierId=1 } | `
    ConvertTo-Json ) -ContentType "application/json"

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\WebApp> ..\Listing_20-23.ps1
# JSON: Swimming Goggles