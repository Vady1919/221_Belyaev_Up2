using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221_Belyaev_Up2
{
    internal class DiscountCalculator
    {
        public static Dictionary<int, double> CalculateDiscounts(List<PartnerProducts> salesData)
        {
            var discounts = new Dictionary<int, double>();

            // Группируем данные по PartnerID и суммируем Quantity
            var partnerSales = salesData
                .GroupBy(sale => sale.PartnerID)
                .Select(group => new
                {
                    PartnerID = group.Key,
                    TotalQuantity = group.Sum(sale => sale.Quantity) // Сумма всех Quantity для партнера
                })
                .ToList();

            // Рассчитываем скидку для каждого партнера
            foreach (var partner in partnerSales)
            {
                double discount = 0;

                if (partner.TotalQuantity >= 10000 && partner.TotalQuantity < 50000)
                {
                    discount = 5; // 5%
                }
                else if (partner.TotalQuantity >= 50000 && partner.TotalQuantity < 300000)
                {
                    discount = 10; // 10%
                }
                else if (partner.TotalQuantity >= 300000)
                {
                    discount = 15; // 15%
                }

                discounts[partner.PartnerID] = discount;
            }

            return discounts;
        }
    }
}
