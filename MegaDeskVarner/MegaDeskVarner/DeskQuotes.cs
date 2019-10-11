using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskVarner
{
    class DeskQuotes
    {
        // Desk, rush days, customer name, and quote date.
        public string date { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int rushDays { get; set; }
        public int priceQuote { get; set; }
        public Desk desk { get; set; }


        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000; 
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_AREA = 1; 
        private const int RUSH_THRESHOLD = 2000;
    }

 
}
