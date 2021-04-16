using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace CryptoExchangeBot.Service.Tests
{
    public class TradeServiceTests
    {
        private ITradeService _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new TradeService();
        }

        [Test]
        public void BuyReturnsTrue_WhenGiven_CryptosLastThreeMonthPrices()
        {
            var lastThreeMonthHighs = new List<double>()
            {
                .5,
                .6,
                .7,
                .8,
                1.2
            };

            var currentPrice = 1.35;

            var actual = _sut.Buy(lastThreeMonthHighs, currentPrice);

            actual.Should().Be(true);
        }
    }
}