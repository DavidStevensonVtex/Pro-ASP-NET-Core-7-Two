# Listing 19.4 Sending a POST request

Invoke-RestMethod http://localhost:5000/api/products -Method POST `
    -Body (@{ Name="Swimming Goggles"; Price=12.75; CategoryId=1; SupplierId=1 } | `
    ConvertTo-Json ) -ContentType "application/json"

