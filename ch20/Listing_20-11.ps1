# Listing 20.11 Requesting a string response

Invoke-WebRequest http://localhost:5000/api/content/string | `
    Select-Object @{n='Content-Type'; e={ $_.Headers."Content-Type" }}, Content

    # PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\WebApp> ..\Listing_20-11.ps1

    # Content-Type              Content
    # ------------              -------
    # text/plain; charset=utf-8 This is a string response 