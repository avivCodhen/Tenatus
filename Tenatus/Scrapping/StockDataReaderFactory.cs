using System;

namespace Tenatus.Scrapping
{
    public static class StockDataReaderFactory
    {
        public static IStockDataReader GetStockDataReader(StockDataReaderType type, string stock)
        {
            switch (type)
            {
                case StockDataReaderType.Yahoo:
                    return new YahooStockDataReader(stock);
                default:
                    return new YahooStockDataReader(stock);
                
            }
        }
    }
}