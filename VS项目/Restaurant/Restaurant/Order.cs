﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    //菜单类
    public class Order
    {
        public Client customer; //顾客
        public int id;          //餐桌号
        public string mealList; //已点菜单
    }
}
