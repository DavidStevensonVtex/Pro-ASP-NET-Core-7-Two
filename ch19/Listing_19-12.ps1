# Listing 19.12 Updating an object

Invoke-RestMethod http://localhost:5000/api/products -Method PUT `
    -Body (@{ ProductId = 1;Name="Green Kayak"; Price=275; CategoryId=2; SupplierId=2 } | `
    ConvertTo-Json ) -ContentType "application/json"

