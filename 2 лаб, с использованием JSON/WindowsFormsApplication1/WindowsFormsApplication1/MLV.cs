using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface Imlv
    {
        int Search( IBase_Info Ibi, IWorking_memory Iwm);
    }

    class MLV : Imlv
    {
        IBase_Info IBI;
        IWorking_memory IWM;

        int Imlv.Search(IBase_Info Ibi, IWorking_memory Iwm)
        {
            IBI = Ibi;
            IWM = Iwm;
            int rule_number = -1;

            //последовательно проверяем все имеющиеся правила
            for( int i = 0; i < IBI.B.Rule.Count; ++i)
            {
                if(proverka_pravila(i))
                {
                    rule_number = i;
                }
            }
            return rule_number;               
        }

        public bool proverka_pravila(int numberRule)
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
                    if (IBI.B.Rule[numberRule].Fact[i] == IWM.workMemory.Fact[j].name)
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
