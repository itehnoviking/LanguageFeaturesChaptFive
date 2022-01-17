namespace LanguageFeaturesChaptFive.Models
{
    public class MyAsyncMethod
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();

            var httpMessage = await client.GetAsync("https://ru.ucoin.net");

            return httpMessage.Content.Headers.ContentLength;
        }

        public static async IAsyncEnumerable<long?> GetPageLength (List<string> output, params string[] urls)
        {
            List<long?> results = new List<long?>();
            HttpClient client = new HttpClient();
            foreach (var url in urls)
            {
                output.Add($"Stated request for {url}");
                var httpMessage = await client.GetAsync($"https://{url}");
                results.Add(httpMessage.Content.Headers.ContentLength);
                output.Add($"Completed request for {url}");
                yield return httpMessage.Content.Headers.ContentLength;
            }

            
        }
    }
}
