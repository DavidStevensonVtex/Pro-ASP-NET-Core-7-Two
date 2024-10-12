# Listing 6.8 Creating the unit test project

dotnet new xunit -o SimpleApp.Tests --framework net8.0
dotnet sln add SimpleApp.Tests
dotnet add SimpleApp.Tests reference SimpleApp 

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch06\Testing> ..\Listing_6-08.ps1   
# The template "xUnit Test Project" was created successfully.

# Processing post-creation actions...
# Restoring D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch06\Testing\SimpleApp.Tests\SimpleApp.Tests.csproj:
#   Determining projects to restore...
#   Restored D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch06\Testing\SimpleApp.Tests\SimpleApp.Tests.csproj (in 4.11 sec).
# Restore succeeded.


# Project `SimpleApp.Tests\SimpleApp.Tests.csproj` added to the solution.
# Reference `..\SimpleApp\SimpleApp.csproj` added to the project.