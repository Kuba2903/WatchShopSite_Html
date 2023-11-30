using Data;
using WatchShop.Mappers;

namespace WatchShop.Models.Services
{
    public class EFWatchService : IWatchService
    {
        private readonly AppDbContext _context;

        public EFWatchService(AppDbContext context)
        {
            _context = context;
        }
        public void AddOrder(WatchOrder order)
        {
            var obj = _context.OrderDetails.Add(WatchMapper.GetEntity(order));
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var obj = _context.OrderDetails.Find(id);

            if (obj is not null)
            {
                _context.OrderDetails.Remove(obj);
                _context.SaveChanges();
            }
        }

        public WatchOrder? FindOrder(int id) => WatchMapper.GetModel(_context.OrderDetails.Find(id));


        public List<WatchOrder> GetOrders() => _context.OrderDetails.Select(x => WatchMapper.GetModel(x)).ToList();

        public void UpdateOrder(WatchOrder order)
        {
            _context.OrderDetails.Update(WatchMapper.GetEntity(order));
            _context.SaveChanges();
        }
    }
}
