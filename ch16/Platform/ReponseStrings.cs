// Listing 16.19 The contents of the ResponseStrings.cs file in the Platform folder

namespace Platform
{
	public class Responses
	{
        public static string DefaultResponse = @"
<!DOCTYPE html>
<html>
<head>
    <meta charset=""utf-8"" />
    <title>Error</title>
    <link href=""lib/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"" />
</head>
<body class=""text-center"">
    <h3 class=""p-2"">Something went wrong...</h3>
    <h6>You can go back to the <a href=""/"">home page</a> and try again.</h6>
</body>
</html>
";
	}
}
