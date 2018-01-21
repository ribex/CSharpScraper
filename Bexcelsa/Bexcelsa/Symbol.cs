using System;

namespace Bexcelsa
{
    partial class Program
    {
        public class Symbol
        {
            public string SymbolName { get; set; }
            public string LastPrice { get; set; }
            // todo: convert Change from string to double
            public string Change { get; set; }
            // todo: convert PercentChange from string to double
            public string PercentChange { get; set; }
            public string Currency { get; set; }
            // todo: convert DateTime from string to DateTime
            public string MarketTime { get; set; }
            // todo: convert Volume from string to Int32
            public string Volume { get; set; }
            // todo: convert Shares from string to double
            public string Shares { get; set; }
            // todo: convert AvgVol3Mon from string to Int32
            public string AvgVol3Mon { get; set; }
            // todo: convert MarketCap from string to Int32
            public string MarketCap { get; set; }
        }
    }
}
