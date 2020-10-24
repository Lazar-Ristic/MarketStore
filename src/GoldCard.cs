using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class GoldCard : DiscountCard
    {
        public GoldCard(string ownerName, double turnover) : base(ownerName, turnover, 0.02) { }
        public override double getDiscountRate()
        {
            return base.getDiscountRate() + Math.Min(0.1, turnover / 10000);
        }
    }
}
