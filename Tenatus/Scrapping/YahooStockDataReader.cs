using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tenatus.Scrapping
{
    public class YahooStockDataReader : IStockDataReader
    {
        private readonly string _stock;
        private ChromeDriver _driver;

        public YahooStockDataReader(string stock)
        {
            _stock = stock;
            _driver = new ChromeDriver("C:\\Stocks\\Tenatus");
            _driver.Navigate().GoToUrl($"https://finance.yahoo.com/quote/{_stock}");
        }

        public Task<List<StockData>> WriteStocksValue()
        {
            var stocksData = new List<StockData>();
            var now = DateTime.Now;
            while (DateTime.Now < now.AddHours(2))
            {
                var stockVal = _driver.FindElementById("quote-header-info")
                    .FindElement(By.CssSelector("span[data-reactid='32']")).Text;

                stocksData.Add(new StockData() {Time = DateTime.Now, Value = stockVal});
                Console.WriteLine(stockVal);
                Thread.Sleep(1000);
            }

            var jsonStr = JsonConvert.SerializeObject(stocksData.ToArray());
            System.IO.File.WriteAllText($@"c:\Stocks\Tenatus\{_stock}-value.json", jsonStr);
            return Task.FromResult(stocksData);
        }

        public StockData ReadStockValue()
        {
            var stockVal = _driver.FindElementById("quote-header-info")
                .FindElement(By.CssSelector("span[data-reactid='32']")).Text;
            return new StockData() {Time = DateTime.Now, Value = stockVal};
        }

        public void Dispose()
        {
            _driver.Dispose();
        }
    }
}