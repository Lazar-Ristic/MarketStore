using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountCard[] discountCards = new DiscountCard[3];
            discountCards[0] = new BronzeCard("Lazar", 0);
            discountCards[1] = new SilverCard("Lazar", 600);
            discountCards[2] = new GoldCard("Lazar", 1500);
            Console.WriteLine("1. Bronze:");
            discountCards[0].outputValue(150);
            Console.WriteLine("2. Silver:");
            discountCards[1].outputValue(850);
            Console.WriteLine("3. Gold:");
            discountCards[2].outputValue(1300);
        }
    }
}
