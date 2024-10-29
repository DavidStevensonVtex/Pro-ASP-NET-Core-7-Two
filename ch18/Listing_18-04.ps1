# Listing 18.4 Installing a global tool package

dotnet tool uninstall --global dotnet-ef 
dotnet tool install --global dotnet-ef --version 8.0.10

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch18\WebApp> ..\Listing_18-04.ps1
# Tool 'dotnet-ef' (version '8.0.10') was successfully uninstalled.
# You can invoke the tool using the following command: dotnet-ef 
# Tool 'dotnet-ef' (version '8.0.10') was successfully installed.