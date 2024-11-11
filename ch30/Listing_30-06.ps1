# Listing 30.6 Regenerating the development certificates

dotnet dev-certs https --clean 
dotnet dev-certs https --trust 

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch30\WebApp> ..\Listing_30-06.ps1
# Cleaning HTTPS development certificates from the machine. A prompt might get displayed to confirm the removal of some of the certificates.
# There was an error trying to clean HTTPS development certificates on this machine.
# The operation was canceled by the user.
# Trusting the HTTPS development certificate was requested. A confirmation prompt will be displayed if the certificate was not previously trusted. Click yes on the prompt to trust the certificate.
# Successfully trusted the existing HTTPS certificate.