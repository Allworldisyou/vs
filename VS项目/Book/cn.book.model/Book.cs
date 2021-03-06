﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        /// <summary>
        /// Id
        /// </summary>
        private int Id;

        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }


        /// <summary>
        /// 名字
        /// </summary>
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 作者
        /// </summary>
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        /// <summary>
        /// 时间
        /// </summary>
        private DateTime time;

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }


        /// <summary>
        /// 类型
        /// </summary>
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
