using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetTv
{

    //工厂类

    public class ChannelFactory
    {
        public static ChannelBase GreatChannel(string type)
        {
            ChannelBase channel = null;
            switch (type)
            {
                case"TypeA":
                    channel = new TypeAChannel();
                    break;
                case"TypeB":
                    channel = new TypeBChannel();
                    break;
            }
            return channel;
        }
    }
}
