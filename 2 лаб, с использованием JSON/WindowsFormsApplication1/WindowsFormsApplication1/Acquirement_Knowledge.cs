using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication1
{
    interface IAcquirement_Knowledge
    {
        void AddRule(string usl, string resul, string factn, IBase_Info Ibi);
        void UpDate(int index, string usl, string resul, string factn, IBase_Info Ibi);
        void DeletRule(int index, IBase_Info Ibi);
    }

    class Acquirement_Knowledge : IAcquirement_Knowledge
    {
        
        string razdel1 = "/";
        string razdel2 = "$";
        IBase_Info IBI;

       void IAcquirement_Knowledge.AddRule(string usl, string resul, string factn, IBase_Info Ibi)
        {
            IBI = Ibi;
            int num_str = IBI.B.Rule.Count;

            string[][] usloviya;
            string[][] resultat;
            string[] factname;
            SeparationDate(usl, resul, factn, num_str, out usloviya, out resultat, out factname);

            IBI.B.Rule.Add(new Rules()
            {
                Fact = usloviya[num_str],
                Result = resultat[num_str],
                newFactName = factname[num_str],
            });

            IBI.Serialized();
            IBI.Deserialized();
        }

        public void UpDate(int index, string usl, string resul, string factn, IBase_Info Ibi)
        {
            IBI = Ibi;
            int num_str = index;

            string[][] usloviya;
            string[][] resultat;
            string[] factname;
            SeparationDate(usl, resul, factn, num_str, out usloviya, out resultat, out factname);

            IBI.B.Rule[num_str].Fact = usloviya[num_str];
            IBI.B.Rule[num_str].Result = resultat[num_str];
            IBI.B.Rule[num_str].newFactName = factname[num_str];
            Ibi.Serialized();
            Ibi.Deserialized();
        }

        private static void SeparationDate(string usl, string resul, string factn, int num_str, out string[][] usloviya, out string[][] resultat, out string[] factname)
        {
            usloviya = new string[num_str + 1][];
            resultat = new string[num_str + 1][];
            factname = new string[num_str + 1];

            String[] uslov = usl.Split(',');
            usloviya[num_str] = new string[uslov.GetLength(0)];

            for (int j = 0; j < uslov.GetLength(0); j++)
            {
                // Убираем лишние пробелы.
                uslov[j] = uslov[j].Trim();
                usloviya[num_str][j] = uslov[j];
            }
            string[] res = resul.Split(',');
            resultat[num_str] = new string[res.GetLength(0)];
            for (int j = 0; j < res.GetLength(0); ++j)
            {
                res[j] = res[j].Trim();
                resultat[num_str][j] = res[j];
            }
            // Запысываем имя факта в factname.
            factname[num_str] = factn;
        }

        public void DeletRule(int index, IBase_Info Ibi)
        {
            IBI = Ibi;
            IBI.B.Rule.RemoveAt(index);
            Ibi.Serialized();
            Ibi.Deserialized();
        }
    }
}
