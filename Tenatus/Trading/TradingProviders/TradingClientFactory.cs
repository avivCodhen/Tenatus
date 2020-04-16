using System;

namespace Tenatus.Trading.TradingProviders
{
    public class TradingClientFactory
    {
        public static ITradingClient GetTradingClient(TradingClientType type)
        {
            switch (type)
            {
                case TradingClientType.Alpaca:
                    return new AlpacaClient();
                case TradingClientType.InteractiveBrokers:
                    throw new NotImplementedException();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}