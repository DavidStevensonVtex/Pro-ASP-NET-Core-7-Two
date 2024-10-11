# Listing 4.16 Installing the LibMap tool package

dotnet tool uninstall --global Microsoft.Web.LibraryManager.Cli 
dotnet tool install --global Microsoft.Web.LibraryManager.Cli --version 2.1.175

# A tool with the package Id 'microsoft.web.librarymanager.cli' could not be found. 

# Tools are uninstalled using their package Id which may be different
# from the tool name you use when calling the tool. You can find the tool names
# and the corresponding package Ids for installed tools using the command
# 'dotnet tool list'.
# You can invoke the tool using the following command: libman
# Tool 'microsoft.web.librarymanager.cli' (version '2.1.175') was successfully installed.