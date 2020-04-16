using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Alpaca.Markets;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Serilog;
using Tenatus.Scrapping;
using Tenatus.Trading;
using Tenatus.Trading.TradingProviders;

namespace Tenatus
{
    class Program
    {
        private const string filePath = "c:\\Stocks\\Tenatus\\";
        private const string symbol = "fb";

        static async Task Main(string[] args)
        {
            try
            {
                var stocks = new[] {"qqq", "msft", "fb", "aapl"};
                var task = new List<Task>();
                var alpacaClient = TradingClientFactory.GetTradingClient(TradingClientType.Alpaca);
                foreach (var stock in stocks)
                {
                    var trader = new Trader(StockDataReaderFactory.GetStockDataReader(StockDataReaderType.Yahoo, stock),
                        alpacaClient, stock);

                    task.Add(Task.Run(() => trader.HandleOrders()));
                }

                await Task.WhenAll(task.ToArray());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            /*var stocks = new[] {"qqq", "msft", "fb", "aapl"};
            var task = new List<Task>();
            foreach (var stock in stocks)
            {
                task.Add(Task.Run(() => ScrapperFactory.GetScrapper(ScrapperType.Yahoo, stock).ReadStocksValue()));
            }

            await Task.WhenAll(task.ToArray());*/

            /*var watch = System.Diagnostics.Stopwatch.StartNew();

            Console.WriteLine($"Profit is  {Test()}");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"time: { elapsedMs}");*/
        }

        private static decimal Test()
        {
            var values =
                JsonConvert.DeserializeObject<List<StockData>>(
                    File.ReadAllText("c:\\Stocks\\Tenatus\\stocks.json"));

            var buyPrice = new decimal(0.0);
            var sellPrice = new decimal(0.0);
            var sellValue = new decimal(1.0001);
            var temp = new decimal(0.0);
            var profit = new decimal(1);
            var buyValue = new decimal(0.99);

            var trend = false;
            while (sellValue <= (decimal) 1.01)
            {
                buyValue = (decimal) 0.99;
                while (buyValue <= 1)
                {
                    for (var i = 1; i < values.Count; i++)
                    {
                        var value = Convert.ToDecimal(values[i].Value);
                        var prevValue = Convert.ToDecimal(values[i - 1].Value);

                        trend = value > prevValue;

                        if (!trend)
                        {
                            temp = new[] {temp, value, prevValue}.Max();
                            if (buyPrice == 0 && value / temp <= buyValue)
                                buyPrice = value;
                        }
                        else
                        {
                            temp = 0;
                            if (buyPrice != 0 && value / buyPrice >= sellValue)
                            {
                                profit *= (value / buyPrice);
                                buyPrice = 0;
                            }
                        }
                    }

                    WriteToCsv(sellValue, buyValue, profit);
                    buyValue += (decimal) 0.0001;
                    profit = 1;
                }

                sellValue += (decimal) 0.0001;
            }

            return profit;
        }

        private static void WriteToCsv(decimal sellValue, decimal buyValue, decimal profit)
        {
            var csv = new StringBuilder();

            var newLine = $"{sellValue},{buyValue},{profit}";
            csv.AppendLine(newLine);

            File.AppendAllText(filePath, csv.ToString());
        }
    }
}