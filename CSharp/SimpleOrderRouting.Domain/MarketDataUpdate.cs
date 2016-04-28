namespace SimpleOrderRouting.Domain
{
    using SimpleOrderRouting.Domain.Order;

    public class MarketDataUpdate
    {
        public MarketDataUpdate(IMarket market, decimal price, int quantity)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Market = market;
        }

        public IMarket Market { get; private set; }

        public InstrumentIdentifier InstrumentIdentifier { get; private set; }

        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
    }
}