# Listing 20.16 Requesting XML data with a fallback

Invoke-WebRequest http://localhost:5000/api/content/object `
        -Headers @{Accept="application/xml,*/*;q=0.8"}| `
    Select-Object @{n='Content-Type'; e={ $_.Headers."Content-Type" }}, Content 

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\WebApp> ..\Listing_20-16.ps1

# Content-Type                    Content
# ------------                    -------
# application/json; charset=utf-8 {"name":"Kayak","price":275.00,"categoryId":1,"supplierId":1}