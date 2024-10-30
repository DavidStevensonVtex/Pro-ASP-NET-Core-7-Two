# Listing 20.9 Sending an HTTP Path request

Invoke-RestMethod http://localhost:5000/api/suppliers/1 -Method PATCH `
    -ContentType "application/json" `
    -Body '[{ "op": "replace", "path": "City", "value": "Los Angeles" }]'

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\WebApp> ..\Listing_20-09.ps1

# supplierId name         city
# ---------- ----         ----
#          1 Splash Dudes Los Angeles