# Listing 7.2 Creating the unit test project 

dotnet new xunit -o SportsSln/SportsStore.Tests --framework net8.0
dotnet sln SportsSln add SportsSln/SportsStore.Tests
dotnet add SportsSln/SportsStore.Tests reference SportsSln/SportsStore

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch07> .\Listing_7-02.ps1
# The template "xUnit Test Project" was created successfully.

# Processing post-creation actions...
# Restoring D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch07\SportsSln\SportsStore.Tests\SportsStore.Tests.csproj:
#   Determining projects to restore...
#   Restored D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch07\SportsSln\SportsStore.Tests\SportsStore.Tests.csproj (in 651 ms).
# Restore succeeded.


# Project `SportsStore.Tests\SportsStore.Tests.csproj` added to the solution.
# Reference `..\SportsStore\SportsStore.csproj` added to the project.