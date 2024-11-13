# Listing 32.4 Installing a global tool package

dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef --version 8.0.11

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch32\Advanced> ..\Listing_32-04.ps1
# Tool 'dotnet-ef' (version '8.0.10') was successfully uninstalled.
# You can invoke the tool using the following command: dotnet-ef 
# Tool 'dotnet-ef' (version '8.0.11') was successfully installed.