# Listing 15.14 Storing a user secret
# Note: Because this is a tutorial book, this isn't really a secret
# and can be displayed in this example command.

dotnet user-secrets set "WebService:Id" "MyAccount"
dotnet user-secrets set "WebService:Key" "MySecret123$"

# PS C:\Users\drsgis\drs\Pro-ASP-NET-Core-7-Two\ch15\Platform> ..\Listing_15-14.ps1    
# Successfully saved WebService:Id = MyAccount to the secret store.
# Successfully saved WebService:Key = MySecret123$ to the secret store.