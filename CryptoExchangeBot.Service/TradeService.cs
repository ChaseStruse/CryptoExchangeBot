using System;
using System.Collections.Generic;

namespace CryptoExchangeBot.Service
{
    public interface ITradeService
    {
        bool Buy(List<double> lastThreeMonthHighs, double currentPrice);
    }
    public class TradeService
    {
        public bool Buy(List<double> lastThreeMonthHighs, double currentPrice)
        {
            throw new NotImplementedException();
        }
    }
}
