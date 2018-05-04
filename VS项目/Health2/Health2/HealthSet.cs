
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health2
{
    public class HealthSet
    {
         public HealthSet()
        {
            items = new Dictionary<string, HealthCheckItem>();
        }
         public HealthSet(string name, Dictionary<string, HealthCheckItem> items)
        {
            this.Name = name;
            this.items = items;
        }

        
        // 套餐名称
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        // 检查项目
        private Dictionary<string, HealthCheckItem> items;
        public Dictionary<string, HealthCheckItem> Items
        {
            get { return items; }
            set { items = value; }
        }
  
        // 套餐价格
        private int price;
        public int Price
        {
            get { return price; }
        }
       
        // 套餐计算方法
        public void CalcPrice()
        {
            int totalPrice = 0;
            foreach (HealthCheckItem item in items.Values)
            {
                totalPrice += item.Price;
            }
            this.price = totalPrice;
        }

    }
}
