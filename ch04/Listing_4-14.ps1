# Listing 4.14 Installing a tool package

dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef --version 8.0.10

# pwd

# Path
# ----
# C:\Users\drsgis\drs\Pro-ASP-NET-Core-7-Two\ch04\MySolution\MyProject

# PS C:\Users\drsgis\drs\Pro-ASP-NET-Core-7-Two\ch04\MySolution\MyProject> ../../Listing_4-14.ps1
# A tool with the package Id 'dotnet-ef' could not be found. 

# Tools are uninstalled using their package Id which may be different
# from the tool name you use when calling the tool. You can find the tool names
# and the corresponding package Ids for installed tools using the command
# 'dotnet tool list'.
# You can invoke the tool using the following command: dotnet-ef
# Tool 'dotnet-ef' (version '8.0.10') was successfully installed.