using System;

namespace MarketStore
{
    public abstract class DiscountCard
    {
        protected string ownerName;
        protected double turnover;
        protected double discountRate;

        protected DiscountCard(string ownerName, double turnover, double discountRate)
        {
            this.ownerName = ownerName;
            this.turnover = turnover;
            this.discountRate = discountRate;
        }

        public double getDiscount(double valueOfPurchace)
        {
            return getDiscountRate() * valueOfPurchace;
        }

        public virtual double getDiscountRate()
        {
            return discountRate;
        }

        public double getTotal(double valueOfPurchace)
        {
            return valueOfPurchace - getDiscount(valueOfPurchace);
        }

        public void outputValue(double valueOfPurchace)
        {
            Console.WriteLine("a. turnover $" + string.Format("{0:F2}", turnover) + ", purchase value: $" + string.Format("{0:F2}", valueOfPurchace) + ";");
            Console.WriteLine("b. Output: ");
            Console.WriteLine("\t- Purchase Value: $" + string.Format("{0:F2}", valueOfPurchace));
            Console.WriteLine("\t- Discount rate: " + string.Format("{0:F1}", getDiscountRate() * 100) + "%");
            Console.WriteLine("\t- Discount: $" + string.Format("{0:F2}", getDiscount(valueOfPurchace)));
            Console.WriteLine("\t- Total: $" + string.Format("{0:F2}", getTotal(valueOfPurchace)));
            Console.WriteLine();
        }

    }
}
