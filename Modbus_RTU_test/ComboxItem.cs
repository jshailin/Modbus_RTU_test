using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus_RTU_test
{
    public partial class ComboxItem
    {
        public string  Text { get; set; }
        public string Value { get; set; }

        public ComboxItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
