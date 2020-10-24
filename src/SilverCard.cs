using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class SilverCard : DiscountCard
    {
        public SilverCard(string ownerName, double turnover) : base(ownerName, turnover, 0.02) { }
        public override double getDiscountRate()
        {
            if (turnover > 300)
                return 0.035;
            return base.getDiscountRate();
        }
    }
}
