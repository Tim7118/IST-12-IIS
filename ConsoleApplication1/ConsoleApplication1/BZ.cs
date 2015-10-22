using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BZ
    {
        public Rule[] Rules { get; set; }
    }

    class Rule
    {
        public string Fact { get; set; }
        public string Result { get; set; }
        public string newFactName { get; set; }

    }

    class RP
    {
        public Facts[] Fact { get; set; }
    }

    class Facts
    {
        public string name { get; set; }
        public string value { get; set; }
    } 


}
