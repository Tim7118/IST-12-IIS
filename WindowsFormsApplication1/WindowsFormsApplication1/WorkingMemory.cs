using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Реализует работу с рабочей памятью.
    /// </summary>
    class WorkingMemory : IWorkingMemory
    {
        WorkMemory work_memory = new WorkMemory();

        public WorkMemory workMemory
        {
            get { return work_memory; }
        } 
        /// <summary>
        /// В начале работы прграммы заносит в рабочую память начальный факт.
        /// </summary>
        public void Start()
        {
            work_memory.Fact = new List<Facts>();
            // При начале работы МЛВ в рабочую память заносится первый факт.
            work_memory.Fact.Add(new Facts() 
            {
                Name = "start" + "=" + "true",
                Value = "true",
            });
        } 
       
        /// <summary>
        /// Добавляет означенный факт в рабочую  память.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="factName"></param>
        public void AddFact(string val, string factName)
        {
            // Убираем лишние пробелы
            factName = factName.Trim();
            val = val.Trim(); 
            // Добавление означенного факта в рабочую память
            work_memory.Fact.Add( new Facts()            
            {
                Name = factName + "=" + val,
                Value = val,
            });
        }
    }
    /// <summary>
    /// Хранит рабочую память.
    /// </summary>
    class WorkMemory
    {
        public List<Facts> Fact ;
    }
    /// <summary>
    /// Структура рабочей памяти.
    /// </summary>
    class Facts
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
