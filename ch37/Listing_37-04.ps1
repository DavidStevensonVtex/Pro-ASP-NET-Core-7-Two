# Listing 37.4 Preparing the project for Blazor

dotnet new classlib -o ../DataModel -f net8.0
Move-Item -Path @("Models/Person.cs", "Models/Location.cs", "Models/Department.cs") ../DataModel

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch37\Advanced> ..\Listing_37-04.ps1
# The template "Class Library" was created successfully.

# Processing post-creation actions...
# Restoring D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch37\DataModel\DataModel.csproj:
#   Determining projects to restore...
#   Restored D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch37\DataModel\DataModel.csproj (in 87 ms).
# Restore succeeded.