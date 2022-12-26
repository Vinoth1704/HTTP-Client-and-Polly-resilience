using Polly;
using System;
using System.Net.Http;

namespace ClientServer
{
    class PollyResilience
    {
        public static void Polly()
        {
            // Create a retry policy that retries the operation if it fails due to a transient error
            var retryPolicy = Policy
                .Handle<HttpRequestException>()
                .Retry(3, (exception, retryCount) => {
                    // Log the exception and retry count
                    Console.WriteLine($"Exception: {exception.Message}. Retry count: {retryCount}");
                });

            // Execute the policy
            retryPolicy.Execute(() => {
                // Perform the operation here
                MakeHttpRequest();
            });
        }

        static void MakeHttpRequest()
        {
            // Simulate a transient error by throwing an exception
            throw new HttpRequestException("Transient error");
        }
    }
}