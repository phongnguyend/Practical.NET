/// <summary>
/// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#tuples-and-discards
/// </summary>

using System;
using System.IO;

namespace TuplesAndDiscards
{
    class Program
    {
        static void Main(string[] args)
        {
            var reportGenerator = new ReportGenerator();

            reportGenerator.GenerateMonthlyReportV1(DateTime.Now, out string fileName, out Stream data);
            Console.WriteLine(fileName);

            var rsV2 = reportGenerator.GenerateMonthlyReportV2(DateTime.Now);
            Console.WriteLine(rsV2[0].ToString());

            var rsV3 = reportGenerator.GenerateMonthlyReportV3(DateTime.Now);
            Console.WriteLine(rsV3.Item1);

            var rsV4 = reportGenerator.GenerateMonthlyReportV4(DateTime.Now);
            Console.WriteLine(rsV4.FileName);

            var rsV5 = reportGenerator.GenerateMonthlyReportV5(DateTime.Now);
            Console.WriteLine(rsV5.FileName);

            Console.ReadLine();
        }
    }
}
