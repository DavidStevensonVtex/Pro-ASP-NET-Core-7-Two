# Listing 18.1 Creating the project

dotnet new globaljson --sdk-version 8.0.400 --output WebApp
dotnet new web --no-https --output WebApp --framework net8.0
dotnet new sln -o WebApp
dotnet sln WebApp add WebApp

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch18> .\Listing_18-01.ps1
# The template "global.json file" was created successfully.

# The template "ASP.NET Core Empty" was created successfully.

# Processing post-creation actions...
# Restoring D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch18\WebApp\WebApp.csproj:
#   Determining projects to restore...
#   Restored D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch18\WebApp\WebApp.csproj (in 105 ms).
# Restore succeeded.


# The template "Solution File" was created successfully.

# Project `WebApp.csproj` added to the solution.