namespace WatchShop.Models.Services
{
    public interface IWatchService
    {
        void AddOrder(WatchOrder order);
        List<WatchOrder> GetOrders();
        void UpdateOrder(WatchOrder order);
        void DeleteOrder(int id);
        WatchOrder? FindOrder(int id);
    }
}
