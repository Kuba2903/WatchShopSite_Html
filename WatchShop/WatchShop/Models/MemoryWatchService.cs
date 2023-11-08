namespace WatchShop.Models
{
    public class MemoryWatchService : IWatchService
    {
        static Dictionary<int,WatchOrder> orders = new Dictionary<int,WatchOrder>();
        public void AddOrder(WatchOrder order)
        {
            int id = orders.Keys.Count != 0 ? orders.Keys.Max() : 0;
            order.Id = id + 1;
            orders.Add(order.Id, order);
        }

        public void DeleteOrder(int id) => orders.Remove(id);

        public WatchOrder? FindOrder(int id) => orders[id];

        public List<WatchOrder> GetOrders() => orders.Values.ToList();

        public void UpdateOrder(WatchOrder order) => orders[order.Id] = order;
    }
}
