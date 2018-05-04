using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public enum MovieType
    {
        //喜剧
        Comedy,
        //战争
        War,
        //爱情
        Romance,
        //动作
        Action,
        //卡通
        Cartoon,
        //恐怖
        Thriller,
        //冒险
        Adventure

    }

    public class Movie
    {
        public string MovieName { get; set; }
        public string Poster { get; set; }
        public string Director { get; set; }
        public string Actor { get; set; }
        public MovieType MovieType { get; set; }
        public int Price { get; set; }

    }
}
