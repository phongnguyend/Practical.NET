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
        //var currentProcess = System.Diagnostics.Process.GetCurrentProcess();
        //long totalBytesOfMemoryUsed = currentProcess.WorkingSet64 / 1024 / 1024;
        //return totalBytesOfMemoryUsed.ToString("N0");

        long totalBytesOfMemoryUsed = Environment.WorkingSet / 1024 / 1024;
        return totalBytesOfMemoryUsed.ToString("N0");
    }
}
```
### C#: Open file without locking
```c#
var stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
```

### C#: Generate Sql Statement To Delete Duplicated Records
```c#
private static string GenerateSqlStatementToDeleteDuplicatedRecords(string tableName, string[] duplicatedColumns, string[] orderByColumns, string id)
{
    string autoColumn = Guid.NewGuid().ToString();

    StringBuilder sqlBuilder = new StringBuilder();
    sqlBuilder.AppendLine("DELETE T");
    sqlBuilder.AppendLine("FROM");
    sqlBuilder.AppendLine("(");
    sqlBuilder.AppendLine($"SELECT [{id}], [{autoColumn}] = ROW_NUMBER() OVER (");
    sqlBuilder.AppendLine($"              PARTITION BY {string.Join(", ", duplicatedColumns.Select(x => $"[{x}]"))}");
    sqlBuilder.AppendLine($"              ORDER BY {string.Join(", ", orderByColumns.Select(x => $"[{x}]"))}");
    sqlBuilder.AppendLine("            )");
    sqlBuilder.AppendLine($"FROM [{tableName}]");
    sqlBuilder.AppendLine(") AS T");
    sqlBuilder.AppendLine($"WHERE [{autoColumn}] > 1");

    var sql = sqlBuilder.ToString();
    return sql;
}
```

### C#: Generate DateTime Formats
```c#
private static string[] GenerateDateTimeFormats()
{
    var dateFormats = new[] { "yyyy/MM/dd", "yyyy-MM-dd" };
    var timeFormats = new[] { "HH:mm:ss" };
    var offSetFormats = new[] { "z", "zz", "zzz" };

    var formats = new List<string> { };

    foreach (var dateFormat in dateFormats)
    {
        formats.Add(dateFormat);

        foreach (var timeFormat in timeFormats)
        {
            formats.Add(dateFormat + " " + timeFormat);

            foreach (var offSetFormat in offSetFormats)
            {
                formats.Add(dateFormat + " " + timeFormat + " " + offSetFormat);
            }
        }
    }

    return formats.ToArray();
}
```
