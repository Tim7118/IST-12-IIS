using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frame
{
    
    [Serializable()]
    public class Frame
    {
        public List<Slot> slots = new List<Slot>();
        public string NameFrame { get; set; }
    }

    public class Slot
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class GroopFrame
    {
        public List<Frame> GroopFrm = new List<Frame>();
    }

    
}
