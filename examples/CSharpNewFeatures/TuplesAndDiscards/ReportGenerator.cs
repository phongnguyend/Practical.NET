using System;
using System.Collections.Generic;
using System.IO;

namespace TuplesAndDiscards
{
    public class ReportGenerator
    {
        public void GenerateMonthlyReportV1(DateTime month, out string fileName, out Stream data)
        {
            // TODO: generate file name and report data

            fileName = $"MonthlyReport_{month:yyyy_MM}.xlsx";
            data = new MemoryStream();
        }

        public List<object> GenerateMonthlyReportV2(DateTime month)
        {
            // TODO: generate file name and report data

            return new List<object>() { $"MonthlyReport_{month:yyyy_MM}.xlsx", new MemoryStream() };
        }

        public Tuple<string, Stream> GenerateMonthlyReportV3(DateTime month)
        {
            // TODO: generate file name and report data

            return new Tuple<string, Stream>($"MonthlyReport_{month:yyyy_MM}.xlsx", new MemoryStream());
        }

        public ReportOutput GenerateMonthlyReportV4(DateTime month)
        {
            // TODO: generate file name and report data

            return new ReportOutput
            {
                FileName = $"MonthlyReport_{month:yyyy_MM}.xlsx",
                Data = new MemoryStream()
            };
        }

        public (string FileName, Stream Data) GenerateMonthlyReportV5(DateTime month)
        {
            // TODO: generate file name and report data

            return (FileName: $"MonthlyReport_{month:yyyy_MM}.xlsx", Data: new MemoryStream());
        }
    }

    public class ReportOutput
    {
        public string FileName { get; set; }

        public Stream Data { get; set; }
    }
}
