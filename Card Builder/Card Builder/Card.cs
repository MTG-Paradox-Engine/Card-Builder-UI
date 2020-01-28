using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Builder
{
    class Card
    {
        public string name = "";
        public string power = "1";
        public string Toughness = "1";
        public HashSet<string> Colors = new HashSet<string>();
        public HashSet<string> SuperType = new HashSet<string>();
        public HashSet<string> SubType = new HashSet<string>();
    }
}
