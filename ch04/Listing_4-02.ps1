# Listing 4.2 Creating a new project

dotnet new globaljson --sdk-version 8.0.204 --output MySolution/MyProject
dotnet new web --no-https --output MySolution/MyProject --framework net8.0
dotnet new sln -o MySolution
dotnet sln MySolution add MySolution/MyProject