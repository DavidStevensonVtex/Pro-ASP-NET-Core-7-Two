// Listing 5.58 Using an asyncrounous executable in the MyAsyncMethods.cs file in the Models folder

using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Security.AccessControl;
using System;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpMessage = await client.GetAsync("http://manning.com");
            return httpMessage.Content.Headers.ContentLength;
        }

        //Error(active)  CS1061	'IAsyncEnumerable<long?>' does not contain a definition for 'GetAwaiter' and no accessible extension method 'GetAwaiter' accepting a first argument of type 'IAsyncEnumerable<long?>' could be found(are you missing a using directive or an assembly reference?)	LanguageFeatures D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch05\LanguageFeatures\Controllers\HomeController.cs	10	


        //public static async IAsyncEnumerable<long?> GetPageLengths(List<string> output, params string[] urls)
        //{
        //    HttpClient client = new HttpClient();
        //    foreach (string url in urls)
        //    {
        //        output.Add($"Started request for {url}");
        //        var httpMessage = await client.GetAsync($"http://{url}");
        //        output.Add($"Completed request for {url}");
        //        yield return httpMessage.Content.Headers.ContentLength;
        //    }
        //}
    }
}
