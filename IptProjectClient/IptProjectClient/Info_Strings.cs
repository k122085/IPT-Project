using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IptProjectClient
{
    class Info_Strings
    {
        string _name;
        string _url;

        public string Project_Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Project_URL
        {
            get { return _url; }
            set { _url = value; }
        }
    }
}
