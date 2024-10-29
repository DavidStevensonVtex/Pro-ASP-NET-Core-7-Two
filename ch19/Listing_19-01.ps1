# Listing 19.1 Dropping the database

dotnet ef database drop --force

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch19\WebApp> ..\Listing_19-01.ps1
# Build started...
# Build succeeded.
# warn: Microsoft.EntityFrameworkCore.Model.Validation[10400]
#       Sensitive data logging is enabled. Log entries and exception messages may include sensitive application data; this mode should only be enabled 
# during development.
# Dropping database 'Products_Core_7' on server 'localhost\SQL_2022'.
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (28ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       SELECT 1
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (57ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
#       IF SERVERPROPERTY('EngineEdition') <> 5
#       BEGIN
#           ALTER DATABASE [Products_Core_7] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
#       END;
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (50ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
#       DROP DATABASE [Products_Core_7];
# Successfully dropped database 'Products_Core_7'.