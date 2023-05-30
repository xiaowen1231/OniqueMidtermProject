using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Repositoties
{
    public class OrderDetailRepository
    {
        public List<OrderDetailDto> ShowOrderDetail(int id)
        {
            var db = new AppDbContext();

            var query = from od in db.OrderDetails
                        join o in db.Orders
                        on od.OrderId equals o.OrderId
                        join p in db.Products
                        on od.ProductId equals p.ProductId
                        join ps in db.ProductSizes
                        on od.SizeId equals ps.SizeId
                        join pc in db.ProductColors
                        on od.ColorId equals pc.ColorId
                        where od.OrderId == id
                        select new OrderDetailDto
                        {
                            ProductName = p.ProductName,
                            Price = p.Price,
                            OrderQuantity = od.OrderQuantity,
                            SizeName = ps.SizeName,
                            ColorName = pc.ColorName,
                        };

            return query.ToList();

        }
    }
}
