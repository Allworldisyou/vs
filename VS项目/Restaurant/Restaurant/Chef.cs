using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    //厨师类
    public class Chef
    {
        private Order order;
        //获得菜单
        public void GetOrder(Order order)
        {
            this.order = order;
        }
        //厨师做菜
        public void Cook()
        {
            Console.WriteLine("厨师烹制：{0}",order.mealList);
            Console.WriteLine("制作完成");
        }
        //提醒饭菜制作完毕
        public void SendAlert(Waitress waitress)
        {
            Console.WriteLine("厨师提醒服务员取菜！");
            waitress.GetOrder(order);
        }
    }
}
