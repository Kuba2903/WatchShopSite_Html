namespace WatchShop.Models
{
    public interface IWatchService
    {
        void AddOrder(WatchOrder order);
        List<WatchOrder> GetOrders();
    }
}
