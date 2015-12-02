using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frame
{
    /// <summary>
    /// Класс, реализующий структуру фрейма.
    /// </summary>
    public class Frame
    {
        public List<Slot> slots = new List<Slot>();
        public string NameFrame { get; set; }
    }

    /// <summary>
    /// Класс, реализующий структуру слота.
    /// </summary>
    public class Slot
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    /// <summary>
    /// Класс, реализующий работу со всей базой знаний.
    /// </summary>
    public class GroopFrame
    {
        public List<Frame> GroopFrm = new List<Frame>();
    }

    
}
