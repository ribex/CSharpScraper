using System.Collections.Generic;

namespace Bexcelsa
{
    public class Portfolio
    {
        public Portfolio()
        {
            
        }

        // primary key
        public int PortfolioId { get; set; }
        public string Name { get; set; }

        // navigation property
        public virtual List<Symbol> Symbols { get; set; }
    }
}