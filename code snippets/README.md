### C#: Test Memory Usage
```c#
class Program
{
    static void Main(string[] args)
    {
        var list = new List<string>();
        string text = "";
        for (int i = 0; i < 1000000; i++)
        {
            text += "abc";
            list.Add(text);
            Console.WriteLine($"Iteration: {i}: { GetTotalMegaBytesOfMemoryUsed()} MB");
        }

        Console.ReadLine();
    }

    private static string GetTotalMegaBytesOfMemoryUsed()
    {
        var currentProcess = System.Diagnostics.Process.GetCurrentProcess();
        long totalBytesOfMemoryUsed = currentProcess.WorkingSet64 / 1024 / 1024;
        return totalBytesOfMemoryUsed.ToString("N0");
    }
}
```
