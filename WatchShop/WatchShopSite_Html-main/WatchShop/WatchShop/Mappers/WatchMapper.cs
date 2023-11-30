using Data.Entities;
using WatchShop.Models;

namespace WatchShop.Mappers
{
    public static class WatchMapper
    {
        public static WatchOrder GetModel(OrderDetails orderEntity)
        {
            if (Enum.TryParse<Watches>(orderEntity.Watch, out Watches watchType))
            {
                return new WatchOrder()
                {
                    Id = orderEntity.Id,
                    Watch = watchType,
                    FirstName = orderEntity.FirstName,
                    Surname = orderEntity.Surname,
                    City = orderEntity.City,
                    StreetAddress = orderEntity.Street,
                    ZipCode = orderEntity.ZipCode,
                    Phone = orderEntity.Phone
                };
            }
            else
            {
                throw new ArgumentException($"Invalid watchEntity.Name: {orderEntity.Watch}");
            }
        }

        public static OrderDetails GetEntity(WatchOrder model)
        {
            return new OrderDetails()
            {
                Id=model.Id,
                FirstName =model.FirstName,
                Surname =model.Surname,
                City =model.City,
                Street = model.StreetAddress,
                ZipCode = model.ZipCode,
                Phone = model.Phone,
                Watch = model.Watch.ToString()
            };
        }

        
    }
}
