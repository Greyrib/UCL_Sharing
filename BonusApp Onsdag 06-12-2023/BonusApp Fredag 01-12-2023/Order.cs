using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp_Fredag_01_12_2023
{
    public delegate double BonusProvider (double amount);
    public class Order
    {
        public BonusProvider Bonus;
        public List<Product> products = new List<Product>();

        public void AddProduct (Product p)
        {
            products.Add(p);
        }

        public double GetValueOfProducts ()
        {
            double totalvalue = 0;
            foreach (Product p in products)
            {
                totalvalue += p.Value;
            }
            return totalvalue;
        }

        public double GetBonus ()
        {
            double bonus = 0;
            bonus = Bonus(GetValueOfProducts());
            return bonus;
        }

        public double GetTotalPrice ()
        {
            double total = 0;
            total = GetValueOfProducts() - GetBonus();
            return total;
        }
    }
}
