using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.ExtMethods;
using Onique.EStore.SqlDataLayer.Repositoties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Services
{
    public class OrderService
    {
        public void CreateOrder(string memberName, string methodName, string address,
            string payment, string discountName)
        {
            if (!string.IsNullOrEmpty(memberName)
                && !string.IsNullOrEmpty(methodName)
                && !string.IsNullOrEmpty(address)
                && !string.IsNullOrEmpty(payment)
                && !string.IsNullOrEmpty(discountName))
            {
                var repo = new OrderRepository();
                repo.CreateOrder(memberName, methodName, address, payment, discountName);
            }
            else
            {
                throw new Exception("請正確填寫訂單資料!");
            }
        }

        public void CreateOrderDetail(int orderId, string product, int orderQuantity
            , string size, string color)
        {
            if (orderQuantity <= 0)
            {
                throw new Exception("訂單數量不可少於0");
            }
            var repo = new OrderRepository();
            repo.CreateOrderDetail(orderId,product, orderQuantity, size, color);
        }

        public void UpdateOrderProduct(int orderDetialId, int productId, int orderQuantity, string size, string color)
        {
            var repo = new OrderRepository();

            var dto = repo.GetProductStock(productId, size, color);

            if (dto == null)
            {
                throw new Exception("無法成功取得庫存數");
            }

            int stockQuantity = dto.StockQuantity;

            if (orderQuantity <= 0 || orderQuantity > stockQuantity)
            {
                throw new Exception("修改數量異常,請確認後重新輸入");
            }
            else
            {
                repo.UpdateOrderProduct(orderDetialId,orderQuantity,size,color);
            }
        }
    }
}
