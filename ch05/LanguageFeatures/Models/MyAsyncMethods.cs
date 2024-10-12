// Listing 5.53 The contents of MyAsyncMethods.cs file in the Models folder

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpTask = client.GetAsync("http//manning.com");
            return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) =>
            {
                return antecedent.Result.Content.Headers.ContentLength;
            });
        }
    }
}
