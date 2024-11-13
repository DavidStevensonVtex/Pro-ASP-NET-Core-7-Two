# Listing 32.1 Creating the project

dotnet new globaljson --sdk-version 8.0.400 --output Advanced 
dotnet new web --no-https --output Advanced --framework net8.0
dotnet new sln -o Advanced 
dotnet sln Advanced add Advanced

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch32> .\Listing_32-01.ps1
# The template "global.json file" was created successfully.

# The template "ASP.NET Core Empty" was created successfully.

# Processing post-creation actions...
# Restoring D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch32\Advanced\Advanced.csproj:
#   Determining projects to restore...
#   Restored D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch32\Advanced\Advanced.csproj (in 156 ms).
# Restore succeeded.


# The template "Solution File" was created successfully.

# Project `Advanced.csproj` added to the solution.