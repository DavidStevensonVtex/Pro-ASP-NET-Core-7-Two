# Listing 19.26 Testing validation

Invoke-WebRequest http://localhost:5000/api/products -Method POST `
    -Body (@{ Name="Boot Laces"; } | `
    ConvertTo-Json ) -ContentType "application/json"

    # PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch19\WebApp> ..\Listing_19-26.ps1
    # Invoke-WebRequest: D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch19\Listing_19-26.ps1:3:1
    # Line |
    #    3 |  Invoke-WebRequest http://localhost:5000/api/products -Method POST `
    #      |  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    #      |  {   "Price": [     "The field Price must be between 1 and 1000."   ],   "CategoryId": [     "The field CategoryId must be between 1 and      
    #      | 9.223372036854776E\u002B18."   ],   "SupplierId": [     "The field SupplierId must be between 1 and 9.223372036854776E\u002B18."   ] } 