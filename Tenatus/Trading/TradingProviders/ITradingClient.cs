using System.Threading.Tasks;

namespace Tenatus.Trading.TradingProviders
{
    public interface ITradingClient
    {
        Task<bool> Buy(string stock, int quantity, decimal price);
        Task<bool> Sell(string stock, int quantity, decimal price);
        Task<Order> LastOrderStatusOrDefault(string stock);
        Task<Position> GetCurrentPositionOrDefault(string stock);
    }
}