namespace AsyncAwaitSample;
class Program
{
    public static async Task Main()
    {
        // the await keyword ensures execution waits for this method call to complete
        await DelayAsync();
        Console.WriteLine("Program complete.");
    }

    public async static Task DelayAsync()
    {
        await Task.Delay(2000);
        Console.WriteLine("Delay complete.");
    }
}

