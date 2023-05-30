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
        public List<OrderDetailDto> GetOrderProductList(int id)
        {
            var db = new AppDbContext();

            var query = from od in db.OrderDetails.AsNoTracking()
                        join o in db.Orders.AsNoTracking()
                        on od.OrderId equals o.OrderId
                        join p in db.Products.AsNoTracking()
                        on od.ProductId equals p.ProductId
                        join ps in db.ProductSizes.AsNoTracking()
                        on od.SizeId equals ps.SizeId
                        join pc in db.ProductColors.AsNoTracking()
                        on od.ColorId equals pc.ColorId
                        where od.OrderId == id
                        select new OrderDetailDto
                        {
                            OrderDetailId = od.OrderDetailId,
                            ProductName = p.ProductName,
                            Price = p.Price,
                            OrderQuantity = od.OrderQuantity,
                            SizeName = ps.SizeName,
                            ColorName = pc.ColorName,
                        };

            return query.ToList();

        }

        public OrderDetailProductDto GetProduct(int orderDetailId)
        {
            var db = new AppDbContext();
            var query = from od in db.OrderDetails.AsNoTracking()
                        join p in db.Products.AsNoTracking()
                        on od.ProductId equals p.ProductId
                        join pc in db.ProductColors.AsNoTracking()
                        on od.ColorId equals pc.ColorId
                        join ps in db.ProductSizes.AsNoTracking()
                        on od.SizeId equals ps.SizeId
                        where od.OrderDetailId == orderDetailId
                        select new OrderDetailProductDto
                        {
                            OrderDetailId = od.OrderDetailId,
                            OrderId = od.OrderId,
                            ProductName = p.ProductName,
                            ColorName = pc.ColorName,
                            SizeName = ps.SizeName,
                            OrderQuantity = od.OrderQuantity,
                            ProductDescription = p.Description,
                            Price= p.Price,
                            StockQuantity =
                           (from psd in db.ProductStockDetails
                            where od.ProductId == psd.ProductId &&
                            od.SizeId == psd.SizeId &&
                            od.ColorId == psd.ColorId
                            select psd.Quantity).FirstOrDefault(),
                            PhotoPath =
                            (from psd in db.ProductStockDetails
                             join pp in db.ProductPhotos
                             on psd.ProductPhotoId equals pp.ProductPhotoId
                             where od.ProductId == psd.ProductId &&
                             od.SizeId == psd.SizeId &&
                             od.ColorId == psd.ColorId
                             select pp.ProductPhotoPath).FirstOrDefault()
                        };

            OrderDetailProductDto dto = query.FirstOrDefault();

            return dto;
        }
    }
}
