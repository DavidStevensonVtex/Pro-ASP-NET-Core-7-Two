# Listing 28.33 Sending a request

Invoke-RestMethod http://localhost:5000/controllers/form/body -Method POST `
    -Body (@{ Name="Soccer Boots" ; Price = 89.99 } | ConvertTo-Json) `
    -ContentType "application/json"

    # PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch28\WebApp> ..\Listing_28-33.ps1

    # productId  : 0
    # name       : Soccer Boots
    # price      : 89.99
    # categoryId : 0
    # category   : 
    # supplierId : 0