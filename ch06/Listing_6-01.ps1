# Listing 6.1 Creating the example project

dotnet new globaljson --sdk-version 8.0.400 --output Testing/SimpleApp
dotnet new web --no-https --output Testing/SimpleApp --framework net8.0
dotnet new sln -o Testing

dotnet sln Testing add Testing/SimpleApp

# The template "global.json file" was created successfully.

# The template "ASP.NET Core Empty" was created successfully.

# Processing post-creation actions...
# Restoring D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch06\Testing\SimpleApp\SimpleApp.csproj:
#   Determining projects to restore...
#   Restored D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch06\Testing\SimpleApp\SimpleApp.csproj (in 158 ms).
# Restore succeeded.


# The template "Solution File" was created successfully.

# Project `SimpleApp\SimpleApp.csproj` added to the solution.