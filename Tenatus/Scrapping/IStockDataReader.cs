using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tenatus.Scrapping
{
    public interface IStockDataReader
    {
     Task<List<StockData>> WriteStocksValue();
     StockData ReadStockValue();
     void Dispose();
    }
}