using System;

namespace Bexcelsa
{
    partial class Program
    {
        public class Symbol
        {
            public string SymbolName { get; set; }
            public double LastPrice { get; set; }
            public double Change { get; set; }
            public double PercentChange { get; set; }
            public string Currency { get; set; }
            public DateTime MarketTime { get; set; }
            // todo: convert Volume from string to Int32
            public string Volume { get; set; }
            public double Shares { get; set; }
            // todo: convert AvgVol3Mon from string to Int32
            public string AvgVol3Mon { get; set; }
            // todo: convert MarketCap from string to Int32
            public string MarketCap { get; set; }
        }
    }
}
