using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IAcquirementKnowledge
    {
        void AddRule(string usl, string resul, string factn, IBaseInfo Ibi);
        void UpDate(int index, string usl, string resul, string factn, IBaseInfo Ibi);
        void DeletRule(int index, IBaseInfo Ibi);
    }
}
