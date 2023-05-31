using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Repositoties
{
    public class OrderRepository
    {
        public List<OrderDto> Search(int? orderId, string orderStatus)
        {
            AppDbContext db = new AppDbContext();

            var orders = from o in db.Orders.AsNoTracking()
                         join m in db.Members.AsNoTracking()
                         on o.MemberId equals m.MemberId
                         join sm in db.ShippingMethods.AsNoTracking()
                         on o.MethodId equals sm.MethodId
                         join os in db.OrderStatus.AsNoTracking()
                         on o.OrderStatusId equals os.StatusId
                         join p in db.PaymentMethods.AsNoTracking()
                         on o.PaymentMethodId equals p.PaymentMethodId
                         join d in db.Discounts.AsNoTracking()
                         on o.DiscountId equals d.DiscountId
                         select new OrderDto
                         {
                             Id = o.OrderId,
                             MemberName = m.Name,
                             ShippingMethod = sm.MethodName,
                             Address = o.ShippingAddress,
                             OrderStatus = os.StatusName,
                             OrderDate = o.OrderDate,
                             ShippingDate = o.ShippingDate,
                             CompletionDate = o.CompletionDate,
                             PaymentMethod = p.PaymentMethodName,
                             Discount = d.DiscountName,
                         };

            if (orderId.HasValue)
            {
                orders=orders.Where(x => x.Id == orderId);
            }
            if (!string.IsNullOrEmpty(orderStatus)) 
            {
                orders = orders.Where(s => s.OrderStatus == orderStatus);
            }

            return orders.ToList();
        }

        public List<string> AllStatus()
        {
            var db = new AppDbContext();

            var query = db.OrderStatus.AsNoTracking()
                .Select(x => x.StatusName.ToString());

            return query.ToList();
        }

        public void CreateOrder(int memberId, string methodName, string address, 
            string payment , string discountName)
        {
            var db = new AppDbContext();

            int methodId = db.ShippingMethods.AsNoTracking()
                .Where(s => s.MethodName == methodName)
                .Select(m => m.MethodId)
                .FirstOrDefault();

            int paymentId = db.PaymentMethods.AsNoTracking()
                .Where(p => p.PaymentMethodName == payment)
                .Select(p => p.PaymentMethodId)
                .FirstOrDefault();

            int discountId = db.Discounts.AsNoTracking()
                .Where(d => d.DiscountName == discountName)
                .Select(d => d.DiscountId)
                .FirstOrDefault();

            var order = new Order()
            {
                MemberId = memberId,
                MethodId = methodId,
                ShippingAddress = address,
                OrderStatusId = 1,
                OrderDate = DateTime.Now,
                PaymentMethodId = paymentId,
                DiscountId = discountId
            };

            db.Orders.Add(order);
            db.SaveChanges();
        }

        public List<SelectMemberDto> GetMemberOfSelect(string name)
        {
            var db = new AppDbContext();
            var query = from m in db.Members
                        join a in db.Areas
                        on m.Areas equals a.AreaId
                        join c in db.Citys
                        on m.Citys equals c.CityId
                        select new SelectMemberDto
                        {
                            Id = m.MemberId,
                            Name = m.Name,
                            Phone = m.Phone,
                            Address = c.CityName + a.AreaName + m.Address,
                            Photo = m.PhotoPath
                        };
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(d => d.Name.Contains(name));
            }
            return query.ToList();
        }
    }
}
