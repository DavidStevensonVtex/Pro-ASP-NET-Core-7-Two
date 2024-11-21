# Listing 39.1 Re-creating the project database

dotnet ef database drop --force --context DataContext 
dotnet ef database drop --force --context IdentityContext
dotnet ef database update --context DataContext
dotnet ef database update --context IdentityContext