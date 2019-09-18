using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_list_handmade
{
    class Product
    {
        public string patch;
        public string name;
        public string fullName;
        public Product(string patch, string name,string fullName)
        {
            this.patch = patch;
            this.name = name;
            this.fullName = fullName;
        }
    }
}
