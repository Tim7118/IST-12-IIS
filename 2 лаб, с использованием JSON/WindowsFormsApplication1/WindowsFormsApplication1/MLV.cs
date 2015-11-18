using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Реализует поиск подходящего правила в базе знаний.
    /// </summary>
    class MLV : IMLV
    {
        IBaseInfo IBI;
        IWorkingMemory IWM;

        /// <summary>
        /// Поиск правила в базе знаний.
        /// </summary>
        /// <param name="Ibi"></param>
        /// <param name="Iwm"></param>
        /// <returns></returns>
        int IMLV.Search(IBaseInfo Ibi, IWorkingMemory Iwm)
        {
            IBI = Ibi;
            IWM = Iwm;
            int rule_number = -1;

            // Последовательно проверяем все имеющиеся правила.
            for( int i = 0; i < IBI.B.Rule.Count; ++i)
            {
                if(checkRule(i))
                {
                    rule_number = i;
                }
            }
            return rule_number;               
        }

        private bool checkRule(int numberRule)
        {
            // Правило считается выполненным, когда выполнены все его подусловия( предпосылки ).
            // Правило ЕСЛИ start=true,ForChild=true/Животное должно жить в клетке?(Cell будет считаться выполненным,
            // Если в элементе j списка IWM.workMemory.Fact[j].name будут строки  "start=true" , "ForChild=true".

            // Количество выполненных подусловий.
            int сoincidentally = 0; 
            int i = 0;

            for (i = 0; i < IBI.B.Rule[numberRule].Fact.Length; ++i)
            {
                int j = 0;
                while (j < IWM.workMemory.Fact.Count)
                {
                    // Сравнение предпосылок правила с рабочей памятью.
                    if (IBI.B.Rule[numberRule].Fact[i] == IWM.workMemory.Fact[j].Name)
                    {
                        сoincidentally++;
                        break;
                    }
                    j++;
                }
            }
            
            if (сoincidentally == i)
                // Если выполнены все подусловия данного правила, то правило выполнено, ф-я возвращает true.
                return true;
            else
                // Если не все, то правило не выполнено, возвращаем false.
                return false;
        }
    }
}
