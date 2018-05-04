using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{

    //影院类
    public class Cinema
    {
        //座位集合属性
        public Dictionary<string, Seat> Seats = new Dictionary<string, Seat>();

        public Schedule Schedule;//放映计划
        //已售出电影票集合
        public List<Ticket> SoldTickets = new List<Ticket>();

        //保存售票情况
        public void Save()
        {
        }
        //读取售票情况
        public void Load()
        {
        }
    }
}
