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

        public void UpdateStockQuantity(string productName, string sizeName, string colorName
            , int quantity, string changeStatus,string nowStatus)
        {
            if (changeStatus == nowStatus)
            {
                return;
            }
            var repo = new OrderRepository();
            if (changeStatus == "已出貨")
            {
                repo.UpdateStockQuantity(productName, sizeName, colorName, quantity);
            }
            else if (changeStatus == "未取貨" || changeStatus=="待出貨"||
                changeStatus=="退款中"&&nowStatus=="已完成") 
            {
                quantity = -quantity;
                repo.UpdateStockQuantity(productName , sizeName, colorName, quantity);
            }
            else
            {
                return;
            }
        }

        
        public void UpdateOrderStatus(int orderDetailId, string changeStatus,string nowStatus,
            string payment)
        {
            var repo = new OrderRepository();

            if(changeStatus == "待出貨")
            {
                if (nowStatus != "已出貨")
                {
                    throw new Exception("只有訂單狀態為:[已出貨],訂單可變更為:[待出貨}!");
                }
            }

            else if(changeStatus == "已出貨")
            {
                if(nowStatus != "待出貨")
                {
                    throw new Exception("只有訂單狀態為:[待出貨],訂單可變更為:[已出貨]!");
                }
            }

            else if(changeStatus == "已完成")
            {
                if(nowStatus != "已出貨")
                {
                    throw new Exception("只有訂單狀態為:[已出貨],訂單可變更為:[已完成}!");
                }
            }

            else if(changeStatus == "已取消")
            {
                if(nowStatus != "待出貨")
                {
                    throw new Exception("只有訂單狀態為:[待出貨],訂單可變更為:[已取消}!");
                }
            }

            else if(changeStatus == "退款中")
            {
                if (nowStatus != "已完成" && nowStatus!="已取消" && nowStatus != "未取貨")
                {
                    throw new Exception("只有訂單狀態為:[已完成]或[已取消],訂單可變更為:[退款中]!");
                }
                if(nowStatus == "已取消" && payment == "貨到付款"|| nowStatus == "未取貨" && payment == "貨到付款")
                {
                    throw new Exception("訂單狀態為:[貨到付款],無法將訂單改為[退款中]!");
                }
            }

            else if (changeStatus == "未取貨")
            {
                if (nowStatus != "已出貨")
                {
                    throw new Exception("只有訂單狀態為:[已出貨],訂單可變更為[未取貨]");
                }
            }

            else if(changeStatus == "已退款")
            {
                if(nowStatus!= "退款中")
                {
                    throw new Exception("只有訂單狀態為:[退款中],訂單可變更為:[已退款}!");
                }
            }
            else 
            { 
                throw new Exception("請輸入更改訂單狀態"); 
            }
            repo.UpdateOrderStatus(orderDetailId, changeStatus);

        }

        public void DeleteOrder(int orderItems,int orderId)
        {
            if (orderItems <= 0)
            {
                new OrderRepository().DeleteOrder(orderId);
            }
            else
            {
                throw new Exception("請先清空訂單商品內容!");
            }
        }
    }
}
