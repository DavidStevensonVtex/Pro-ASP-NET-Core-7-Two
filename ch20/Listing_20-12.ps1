# Listing 20.12 Requesting an object reponse

Invoke-WebRequest http://localhost:5000/api/content/object | `
    Select-Object @{n='Content-Type'; e={ $_.Headers."Content-Type" }}, Content

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\WebApp> ..\Listing_20-12.ps1

# Content-Type                    Content
# ------------                    -------
# application/json; charset=utf-8 {"productId":1,"name":"Kayak","price":275.00,"categoryId":1,"supplierId":1}