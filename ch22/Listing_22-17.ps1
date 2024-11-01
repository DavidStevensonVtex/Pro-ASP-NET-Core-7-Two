# Listing 22.17 Sending an HTTP request

Invoke-WebRequest http://localhost:5000/home/list | Select-Object -expand content

