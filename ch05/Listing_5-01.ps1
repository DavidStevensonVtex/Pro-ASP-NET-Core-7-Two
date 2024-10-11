# Listing 5.1 Creating the example project

dotnet new globaljson --sdk-version 8.0.204 --output LanguageFeatures
dotnet new web --no-https --output LanguageFeatures --framework net8.0
dotnet new sln -o LanguageFeatures
dotnet sln LanguageFeatures add LanguageFeatures

# The template "global.json file" was created successfully.

# The template "ASP.NET Core Empty" was created successfully.

# Processing post-creation actions...
# Restoring C:\Users\drsgis\drs\Pro-ASP-NET-Core-7-Two\ch05\LanguageFeatures\LanguageFeatures.csproj:
#   Determining projects to restore...
#   Restored C:\Users\drsgis\drs\Pro-ASP-NET-Core-7-Two\ch05\LanguageFeatures\LanguageFeatures.csproj (in 82 ms).
# Restore succeeded.


# The template "Solution File" was created successfully.

# Project `LanguageFeatures.csproj` added to the solution.