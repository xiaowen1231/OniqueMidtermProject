using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Repositoties
{
    public class DiscountRepository
    {
        public decimal CalculateDiscount(string discountName, decimal price)
        {
            var db = new AppDbContext();
            DiscountDto dto = db.Discounts.AsNoTracking().Where(x => x.DiscountName == discountName)
                .Select(x => new DiscountDto
                {
                    DiscountId = x.DiscountId,
                    DiscountName = x.DiscountName,
                    DiscountMethod = x.DiscountMethod,
                }).FirstOrDefault();

            if (dto == null)
            {
                return 0;
            }

            decimal discountAmount = 0;

            switch (dto.DiscountName)
            {
                case "八折優惠":
                    discountAmount = (price * dto.DiscountMethod) + 60; break;
                case "折抵運費":
                    discountAmount = (price + dto.DiscountMethod) + 60; break;
                case "滿兩千折五十":
                    discountAmount = (price + dto.DiscountMethod) + 60; break;
                case "夏季特賣":
                    discountAmount = (price * dto.DiscountMethod) + 60; break;
                case "未使用折扣":
                    discountAmount = price; break;
                default:
                    break;
            }

            return discountAmount;
        }
    }
}
