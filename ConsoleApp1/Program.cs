using CsvHelper;
using CsvHelper.Configuration.Attributes;

using Microsoft.VisualBasic.FileIO;

using System;
using System.Globalization;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public class CurrencyInfo
        {
            [Index(0)]
            public string PaymentID { get; set; }
            [Index(1)]
            public string ProcessingCurrency { get; set; }
            [Index(2)]
            public string PayoutCurrency { get; set; }
            [Index(3)]
            public DateTime RequestedOn { get; set; }
            [Index(4)]
            public string ChannelName { get; set; }
            [Index(5)]
            public uint Reference { get; set; }
            [Index(6)]
            public string PaymentMethod { get; set; }
            [Index(7)]
            public string CardType{ get; set; }
            [Index(8)]
            public string CardCategory{ get; set; }
            [Index(9)]
            public string IssuerCountry{ get; set; }
            [Index(10)]
            public string MerchantCountry{ get; set; }
            [Index(11)]
            public string MID { get; set; }
            [Index(12)]
            public string ActionType{ get; set; }
            [Index(13)]
            public string ActionID{ get; set; }
            [Index(14)]
            public DateTime ProcessedOn{ get; set; }
            [Index(15)]
            public string ResponseCode{ get; set; }
            [Index(16)]
            public string ResponseDescription { get; set; }
            [Index(17)]
            public string BreakdownType { get; set; }
            [Index(18)]
            public DateTime BreakdownDate{ get; set; }
            [Index(19)]
            public decimal ProcessingCurrencyAmount { get; set; }
            [Index(20)]
            public decimal PayoutCurrencyAmount { get; set; }
            [Index(21)]
            public string Region { get; set; }
        }


        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\strug\source\repos\ConsoleApp1\test.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<CurrencyInfo>();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
