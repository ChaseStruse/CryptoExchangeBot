using System;
using System.Collections.Generic;
using System.Linq;

namespace CryptoExchangeBot.Service
{
    public interface ITradeService
    {
        bool DetermineBuyOrSell(List<double> lastThreeMonthHighs, double currentPrice);
    }
    public class TradeService : ITradeService
    {
        public bool DetermineBuyOrSell(List<double> lastThreeMonthHighs, double currentPrice)
        {
            var buy = false;
            var total = 0.0;

            lastThreeMonthHighs.Add(currentPrice);

            foreach(var high in lastThreeMonthHighs)
            {
                total += high;
            }

            var average = total / lastThreeMonthHighs.Count;

            if (average < currentPrice) buy = true;

            return buy;
        }
    }
}
