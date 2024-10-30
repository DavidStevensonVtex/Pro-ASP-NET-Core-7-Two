# Listing 20.13 Requesting XML data

Invoke-WebRequest http://localhost:5000/api/content/object `
        -Headers @{Accept="application/xml"}| `
    Select-Object @{n='Content-Type'; e={ $_.Headers."Content-Type" }}, Content 

Invoke-WebRequest http://localhost:5000/api/content/object `
        -Headers @{Accept="application/xml"}| `
    Select-Object Content | foreach { $_.Content } | `
    Out-File -Path "./product.xml" -Width 50000

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\WebApp> ..\Listing_20-13.ps1

# Content-Type                    Content
# ------------                    -------
# application/json; charset=utf-8 {"productId":1,"name":"Kayak","price":275.00,"categoryId":1,"supplierId":1}

# After implementing: Listing 20.14 Enabling XML formatting in the Program.cs file in the WebApp folder

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\WebApp> ..\Listing_20-13.ps1

# Content-Type                   Content
# ------------                   -------
# application/xml; charset=utf-8 <Product xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/WebA…
