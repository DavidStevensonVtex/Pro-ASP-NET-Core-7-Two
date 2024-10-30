# Listing 20.24 Sending XML Data via HTTP POST

$content = Get-Content -Path "../ProductBindingTarget.xml"

Invoke-RestMethod http://localhost:5000/api/content -Method POST `
        -Body $content -ContentType "application/xml"

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch20\WebApp> ..\Listing_20-24.ps1
# XML: Kayak