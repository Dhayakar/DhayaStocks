using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStocks.Model
{
    public class CompanyEStock
    {
        public int CompanyStockId { get; set; }
        public int CompanyId { get; set; }
        public decimal StockPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
