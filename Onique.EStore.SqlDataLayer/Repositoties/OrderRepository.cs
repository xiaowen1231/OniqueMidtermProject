﻿using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.ExtMethods;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Cryptography;
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
                orders = orders.Where(x => x.Id == orderId);
            }
            if (!string.IsNullOrEmpty(orderStatus))
            {
                orders = orders.Where(s => s.OrderStatus == orderStatus);
            }

            orders=orders.OrderByDescending(o => o.OrderDate).ThenByDescending(x=>x.OrderStatus);

            return orders.ToList();
        }


        public void CreateOrder(string memberName, string methodName, string address,
            string payment, string discountName)
        {
            var db = new AppDbContext();

            int memberId = db.GetId<Member>(m => m.Name == memberName, m => m.MemberId);

            int methodId = db.GetId<ShippingMethod>(s => s.MethodName == methodName
            , m => m.MethodId);

            int paymentId = db.GetId<PaymentMethod>(p => p.PaymentMethodName == payment
            , p => p.PaymentMethodId);

            int discountId = db.GetId<Discount>(d => d.DiscountName == discountName
            , d => d.DiscountId);

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

        public List<string> GetAllItems<T>(Expression<Func<T, string>> selector) where T : class
        {

            var db = new AppDbContext();
            var query = db.Set<T>().Select(selector);
            return query.ToList();
        }

        public List<SelectProductDto> ProductList(string name, string category)
        {
            var db = new AppDbContext();
            var query = from p in db.Products
                        join c in db.Categories
                        on p.ProductCategoryId equals c.CategoryId
                        select new SelectProductDto
                        {
                            Id = p.ProductId,
                            Name = p.ProductName,
                            Price = p.Price,
                            category = c.CategoryName
                        };
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(x => x.Name.Contains(name));
            }
            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(x => x.category.Contains(category));
            }

            return query.ToList();
        }

        public string GetProductName(int id)
        {
            var db = new AppDbContext();
            var query = db.Products.AsNoTracking()
                .Where(p => p.ProductId == id)
                .Select(p => p.ProductName)
                .FirstOrDefault();

            return query.ToString();
        }
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

        public OrderDetailProductDto GetOrderProductDetail(int orderDetailId)
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
                            ProductId = p.ProductId,
                            OrderId = od.OrderId,
                            ProductName = p.ProductName,
                            ColorName = pc.ColorName,
                            SizeName = ps.SizeName,
                            OrderQuantity = od.OrderQuantity,
                            ProductDescription = p.Description,
                            Price = p.Price,
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

        public List<string> GetProductSize(string productName)
        {
            var db = new AppDbContext();
            int productId = db.GetId<Product>(p => p.ProductName == productName, p => p.ProductId);
            var query = from p in db.Products
                        join psd in db.ProductStockDetails on p.ProductId equals psd.ProductId
                        join ps in db.ProductSizes on psd.SizeId equals ps.SizeId
                        where p.ProductId == productId
                        group ps.SizeName by ps.SizeName into g
                        select g.Key;

            return query.ToList();
        }
        public List<string> GetProductColor(string productName)
        {
            var db = new AppDbContext();
            int productId = db.GetId<Product>(p => p.ProductName == productName, p => p.ProductId);
            var query = from p in db.Products
                        join psd in db.ProductStockDetails on p.ProductId equals psd.ProductId
                        join pc in db.ProductColors on psd.ColorId equals pc.ColorId
                        where p.ProductId == productId
                        group pc.ColorName by pc.ColorName into g
                        select g.Key;

            return query.ToList();
        }

        public OrderDetailProductDto GetProductStock(int id, string size, string color)
        {
            var db = new AppDbContext();
            int sizeId = db.GetId<ProductSize>
                (s => s.SizeName == size, s => s.SizeId);

            int colorId = db.GetId<ProductColor>
                (c => c.ColorName == color, s => s.ColorId);

            var query = from psd in db.ProductStockDetails
                        where psd.ProductId == id
                        && psd.SizeId == sizeId
                        && psd.ColorId == colorId
                        select new OrderDetailProductDto
                        {
                            StockQuantity = psd.Quantity,
                            ProductPhotoId = psd.ProductId,
                        };
           var dto = query.FirstOrDefault();
            if (dto.ProductPhotoId == null)
            {
                dto.PhotoPath = null;
            }
            else
            {
                dto.PhotoPath = (from psd in db.ProductStockDetails
                             join pp in db.ProductPhotos
                             on psd.ProductPhotoId equals pp.ProductPhotoId
                             where psd.ProductId == id
                             && psd.SizeId == sizeId
                             && psd.ColorId == colorId
                             select pp.ProductPhotoPath).FirstOrDefault();
            }
            return dto;
        }

        public void CreateOrderDetail(int orderId, string product, int orderQuantity
            , string size, string color)
        {
            try
            {
                var db = new AppDbContext();

                int productId = db.GetId<Product>(p => p.ProductName == product, p => p.ProductId);

                int sizeId = db.GetId<ProductSize>(p => p.SizeName == size, p => p.SizeId);

                int colorId = db.GetId<ProductColor>(p => p.ColorName == color, p => p.ColorId);

                var orderDetail = new OrderDetail
                {

                    OrderId = orderId,
                    ProductId = productId,
                    OrderQuantity = orderQuantity,
                    SizeId = sizeId,
                    ColorId = colorId
                };

                db.OrderDetails.Add(orderDetail);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateOrderProduct(int orderDetailId,int orderQuantity
            ,string size,string color) 
        {
            var db = new AppDbContext();

            int sizeId = db.GetId<ProductSize>(s=>s.SizeName == size, s => s.SizeId);
            int colorId = db.GetId<ProductColor>(c=>c.ColorName == color,c=> c.ColorId);

            var orderDetail = db.OrderDetails.Where(od=>od.OrderDetailId==orderDetailId).FirstOrDefault();

            orderDetail.OrderQuantity = orderQuantity;
            orderDetail.SizeId = sizeId;
            orderDetail.ColorId = colorId;

            db.SaveChanges();
        }

        public void UpdateStockQuantity(string productName,string sizeName,string colorName
            ,int quantity)
        {
            var db = new AppDbContext();

            int productId = db.GetId<Product>(p => p.ProductName == productName, p => p.ProductId);
            int sizeId = db.GetId<ProductSize>(p => p.SizeName == sizeName, p => p.SizeId); 
            int colorId = db.GetId<ProductColor>(p => p.ColorName == colorName, p => p.ColorId);

            var productStockDetail = db.ProductStockDetails
                .Where(psd => psd.ProductId == productId
                && psd.SizeId == sizeId
                && psd.ColorId == colorId)
                .FirstOrDefault();

            int originalStock = productStockDetail.Quantity;
            
            productStockDetail.Quantity = originalStock-quantity;
            if(productStockDetail.Quantity < 0)
            {
                throw new Exception("庫存不足!");
            }
            db.SaveChanges();

        }

        public void UpdateOrderStatus(int orderDetailId,string changeStatus) 
        {
            var db = new AppDbContext();
            int statusId = db.GetId<OrderStatu>(os => os.StatusName == changeStatus, os => os.StatusId);
            DateTime changeTime = DateTime.Now;

            var orders = db.Orders.Find(orderDetailId);

            switch (changeStatus)
            {
                case "待出貨":
                    orders.ShippingDate = null; break;
                case "已出貨":
                    orders.ShippingDate = changeTime; break;
                case "已完成":
                    orders.CompletionDate = changeTime; break;
                default: break;
            }

            orders.OrderStatusId = statusId;

            db.SaveChanges();
        }
        
        public void DeleteOrderDetail(int orderDetailId)
        {
            var db = new AppDbContext();
            var orderDetail = db.OrderDetails.Find(orderDetailId);

            if(orderDetail == null)
            {
                throw new Exception("找不到要刪除的訂單商品!");
            }

            db.OrderDetails.Remove(orderDetail);

            db.SaveChanges();

        }

        public void DeleteOrder(int orderId)
        {
            var db = new AppDbContext();
            var order = db.Orders.Find(orderId);
            db.Orders.Remove(order);
            db.SaveChanges();
        }
    }
}
