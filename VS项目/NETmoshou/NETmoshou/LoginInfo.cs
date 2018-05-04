using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETmoshou
{
   public class LoginInfo
    {
        public string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
     
    }
   
}
