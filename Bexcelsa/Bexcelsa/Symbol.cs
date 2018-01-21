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
            public Int32 Volume { get; set; }
            public double Shares { get; set; }
            public Int32 AvgVol3Mon { get; set; }
            public Int32 MarketCap { get; set; }
        }
    }
}
