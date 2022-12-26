using System;
using ClientServer;
class Program
{
    public static async Task Main()
    {
        // await HttpClientServer.run();
        PollyResilience.Polly();
    }
}