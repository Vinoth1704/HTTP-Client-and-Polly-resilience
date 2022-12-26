using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientServer
{
    class HttpClientServer
    {
        public static async Task run()
        {
            // Create the HTTP client
            var client = new HttpClient();

            // Make the GET request
            var response = await client.GetAsync("https://dummyjson.com/products/1");

            // Check the status code
            if (response.IsSuccessStatusCode)
            {
                // Read the response content
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Request failed with status code: {response.StatusCode}");
            }
        }
    }
}