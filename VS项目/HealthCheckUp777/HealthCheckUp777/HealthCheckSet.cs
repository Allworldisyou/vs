using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheckUp777
{
    //体检套餐类
    public class HealthCheckSet
    {
        //采用泛型集合List保存所有的体检项目
        public List<HealthCheckItem> AllLItems = new List<HealthCheckItem>();



        //采用泛型集合List保存套餐中的体检项目
        public List<string> items = new List<string>();


        //套餐价格计算方法
        //public void CalcPrice()
        //{
        //    int totalPraice = 0;
        //    foreach (HealthCheckItem item in this.items)
        //    {
        //        totalPraice += item.Price;
        //    }
            
        //}
       
   
      

    }
}
