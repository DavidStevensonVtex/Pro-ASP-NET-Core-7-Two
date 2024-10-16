# Listing 12.1 Creating the project

dotnet new globaljson --sdk-version 8.0.204 --output Platform
dotnet new web --no-https --output Platform --framework net8.0
dotnet new sln -o Platform
dotnet sln Platform add Platform

# The template "global.json file" was created successfully.

# The template "ASP.NET Core Empty" was created successfully.

# Processing post-creation actions...
# Restoring C:\Users\drsgis\drs\Pro-ASP-NET-Core-7-Two\ch12\Platform\Platform.csproj:
#   Determining projects to restore...
#   Restored C:\Users\drsgis\drs\Pro-ASP-NET-Core-7-Two\ch12\Platform\Platform.csproj (in 80 ms).
# Restore succeeded.


# The template "Solution File" was created successfully.

# Project `Platform.csproj` added to the solution.