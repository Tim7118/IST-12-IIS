using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IWorkingMemory
    {
        /// <summary>
        ///  Реализует хранение означенных фактов.
        /// </summary>
        WorkMemory workMemory { get; }
        void AddFact(string val, string factName);
        void Start();
    }
}
