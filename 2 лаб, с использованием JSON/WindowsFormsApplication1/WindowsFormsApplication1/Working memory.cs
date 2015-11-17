using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1


{
    interface IWorking_memory
    {
        RP workMemory { get; }
        void AddFact( string val, string factName);
        void Start();
    }

    class Working_memory : IWorking_memory
    {
        RP work_memory = new RP();

        public RP workMemory
        {
            get { return work_memory; }
        } 

        public void Start()
        {
            work_memory.Fact = new List<Facts>();
            // При начале работы МЛВ в рабочую память заносится первый факт.
            work_memory.Fact.Add(new Facts() 
            {
                name = "start" + "=" + "true",
                value = "true",
            });
        } 
       
        public void AddFact(string val, string factName)
        {
            // Убираем лишние пробелы
            factName = factName.Trim();
            val = val.Trim(); 
            // Добавление означенного факта в рабочую память
            work_memory.Fact.Add( new Facts()            
            {
                name = factName + "=" + val,
                value = val,
            });
        }
    }

    class RP
    {
        public List<Facts> Fact ;
    }

    class Facts
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}
