# Listing 7.1 Creating the SportsStore project

dotnet new globaljson --sdk-version 8.0.400 --output SportsSln/SportsStore 
dotnet new web --no-https --output SportsSln/SportsStore --framework net8.0
dotnet new sln -o SportsSln

dotnet sln SportsSln add SportsSln/SportsStore

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch07> .\Listing_7-01.ps1
# The template "global.json file" was created successfully.

# The template "ASP.NET Core Empty" was created successfully.

# Processing post-creation actions...
# Restoring D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch07\SportsSln\SportsStore\SportsStore.csproj:
#   Determining projects to restore...
#   Restored D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch07\SportsSln\SportsStore\SportsStore.csproj (in 137 ms).
# Restore succeeded.


# The template "Solution File" was created successfully.

# Project `SportsStore\SportsStore.csproj` added to the solution.