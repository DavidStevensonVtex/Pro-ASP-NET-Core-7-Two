# Listing 20.17 Requesting a PNG response

Invoke-WebRequest http://localhost:5000/api/content/object `
        -Headers @{Accept="img/png"}| `
    Select-Object @{n='Content-Type'; e={ $_.Headers."Content-Type" }}, Content 

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\WebApp> ..\Listing_20-17.ps1

# Content-Type                    Content
# ------------                    -------
# application/json; charset=utf-8 {"name":"Kayak","price":275.00,"categoryId":1,"supplierId":1}

# After implementing: Listing 20.18 Configuring content negotiaton in the Program.cs file in the WebApp folder

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\WebApp> ..\Listing_20-17.ps1
# Invoke-WebRequest: D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\Listing_20-17.ps1:3:1
# Line |
#    3 |  Invoke-WebRequest http://localhost:5000/api/content/object `
#      |  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
#      | Response status code does not indicate success: 406 (Not Acceptable).