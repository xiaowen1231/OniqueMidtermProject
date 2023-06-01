﻿using Onique.EStore.SqlDataLayer.EFModels;
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
            var db = new AppDbContext();
            var repo = new OrderRepository();
            repo.CreateOrderDetail(orderId,product, orderQuantity, size, color);
        }
    }
}
