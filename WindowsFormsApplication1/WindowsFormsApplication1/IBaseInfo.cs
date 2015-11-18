using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Реализует интерфейс базы знаний.
    /// </summary>
    interface IBaseInfo
    {
        // Выражения между ЕСЛИ и ТО , т.е. условия выполнения правила.
        string[][] Usloviya { get; }
        // Выражения после ТО , т.е. результат выполнения правила.
        string[][] Resultat { get; }
        // Имя факта.
        string[] Factname { get; }
        BZ B { get; }
        void Start();
        void Serialized();
        void Deserialized();
    }
}
