# Listing 20.13 Requesting XML data

Invoke-WebRequest http://localhost:5000/api/content/object `
        -Headers @{Accept="application/xml"}| `
    Select-Object @{n='Content-Type'; e={ $_.Headers."Content-Type" }}, Content

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\WebApp> ..\Listing_20-13.ps1

# Content-Type                    Content
# ------------                    -------
# application/json; charset=utf-8 {"productId":1,"name":"Kayak","price":275.00,"categoryId":1,"supplierId":1}