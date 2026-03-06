using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
    internal class ColorData
    {
        public string Name { get; set; }
        public string HexCode { get; set; }

        public ColorData(string name, string hexCode)
        {
            Name = name;
            HexCode = hexCode;
        }
    }
}
