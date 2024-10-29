# Listing 19.18 Sending a GET Request for a Product that doesn't exist

Invoke-WebRequest http://localhost:5000/api/products/1000 | `
    Select-Object StatusCode

    # StatusCode
    # ----------
    #        204