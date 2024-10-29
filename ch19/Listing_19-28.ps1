# Listing 19.28 Sending a GET request

Invoke-WebRequest http://localhost:5000/api/products/1 | Select-Object Content 

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch19\WebApp> ..\Listing_19-28.ps1

# Content
# -------
# {"productId":1,"name":"Green Kayak","price":275.00,"categoryId":2,"category":null,"supplierId":2,"supplier":null} 