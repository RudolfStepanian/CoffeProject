using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee.DataAccessLayer
{
    public class SPParam
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public SPParam(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}
