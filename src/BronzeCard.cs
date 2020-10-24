namespace MarketStore
{
    class BronzeCard : DiscountCard
    {
        public BronzeCard(string ownerName, double turnover) : base(ownerName, turnover, 0) { }

        public override double getDiscountRate()
        {
            if (turnover > 300)
                return 0.025;
            if (turnover > 100)
                return 0.001;
            return base.getDiscountRate();
        }
    }
}
