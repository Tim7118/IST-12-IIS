using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IMLV
    {
        /// <summary>
        /// Поиск подходящего правила , в соответствии с рабочей памятью.
        /// </summary>
        /// <param name="Ibi"></param>
        /// <param name="Iwm"></param>
        /// <returns></returns>
        int Search(IBaseInfo Ibi, IWorkingMemory Iwm);
    }
}
