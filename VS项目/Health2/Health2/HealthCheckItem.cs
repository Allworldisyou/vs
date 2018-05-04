using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health2
{
    
     // 体检项目类
     // 保存一个体检项目包括项目名、描述、单价
   
    public class HealthCheckItem
    { 
        
        public HealthCheckItem()
        {
        }
  
        public HealthCheckItem(string name, int price, string description)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
       
       
        // 项目名称
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

       
        // 项目描述
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        // 项目价格
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
