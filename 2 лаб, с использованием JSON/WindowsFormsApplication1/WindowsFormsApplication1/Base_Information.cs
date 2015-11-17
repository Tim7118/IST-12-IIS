using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1

{
    interface IBase_Info
    {
        // Выражения между ЕСЛИ и ТО , т.е. условия выполнения правила.
        string[][] Usloviya {get;}
        // Выражения после ТО , т.е. результат выполнения правила.
        string[][] Resultat {get;}
        // Имя факта.
        string[] Factname {get;} 
        BZ B {get;}
        void Start();
        //void Download();
        //void Fill();
        void Serialized();
        void Deserialized();
    }

    class Base_Info : IBase_Info
    {
        string[][] usloviya; 
        string[][] resultat;
        string[] factname;
        int num_str = 0;
        string razdel1= "/";
        string razdel2= "$";
        public BZ b = new BZ();

        public Base_Info()
        {
            b.Rule = new List<Rules>();
        }

        public BZ B
        {
            get { return b; }         
        }

        public string[][] Usloviya
        {
            get { return usloviya; }
        }

        public string[][] Resultat
        {
            get { return resultat; }
        }

        public string[] Factname
        {
            get { return factname; }
        }

        public void Start()
        {
            //// Загружаем бз в массивы строк.
            //Download();
            //// Заполняем b.
            //Fill();
            //// Переводим b в json и сохраняем.
            //Serialized();
            // Извлекаем из json в b.
            
            Deserialized();
        }

        public void Download()
        {
            // Эта функция нужна только тогда, когда в проекте новая база знаний.
            // Копируем строки из файла в строковый массив.
            string[] buffer = File.ReadAllLines(@"База_знаний2.txt", Encoding.GetEncoding(1251));
            // Считаем количество правил.
            num_str = 0;
            for (int i = 0; i < buffer.GetLength(0); ++i)
            {
                if (buffer[i] != "")
                    num_str++;
            }

            // Выделяем память под массив условий, результатов и имен фактов.
            usloviya = new string[num_str][];
            resultat = new string[num_str][];
            factname = new string[num_str];

            for (int i = 0; i < num_str; ++i)
            {
                // Если строчка из файла не пустая, начинаем ее обрабатывать.
                if (buffer[i] != "")
                {
                    // Находим начало  razdel1.
                    int t2 = buffer[i].IndexOf(razdel1);
                    // Копируем часть строки -предпосылку в переменную  tmp.  
                    // Начинаем копировать c 0 т.к перед предпосылкой ничего нет.
                    // Второй аргумент - длина копируемой посдтроки - t2.
                    String tmp = buffer[i].Substring(0, t2 );
                    // Разбираем условие, разделяем на подстроки по символу ','.
                    String[] usl = tmp.Split(',');
                    // Выделяем память для строки массива условий.
                    usloviya[i] = new string[usl.GetLength(0)];
                    for (int j = 0; j < usl.GetLength(0); ++j)
                    {
                        // Убираем лишние пробелы.
                        usl[j] = usl[j].Trim();
                        // Записываем в массив.
                        usloviya[i][j] = usl[j];
                    }
                    // Теперь обрабатываем результат выражения (часть строки после первого"razdel1" разделителя).
                    // Начинаем копировать c индекса t2+1 потому что t2 - это индекс начала вопроса, само слово razdel длиной 1 символ.

                    // Находим начало razdel2
                    int t3 = buffer[i].IndexOf(razdel2); 
                    tmp = buffer[i].Substring(t2 + 1, t3 - t2 -1);

                    string[] res = tmp.Split(',');
                    resultat[i] = new string[res.GetLength(0)];
                    for (int j = 0; j < res.GetLength(0); ++j)
                    {  
                        res[j] = res[j].Trim();
                        resultat[i][j] = res[j];
                    }

                    tmp = buffer[i].Substring(t3 + 1, buffer[i].Length - t3 -1).Trim();
                    // Запысываем имя факта в factname.
                    factname[i] = tmp; 
                }
            }
        }

        public void Fill( )
        {
            // Эта функция нужна только тогда, когда в проекте новая база знаний.
            b.Rule = new List<Rules>();
            for(int i = 0; i < num_str; i++)
            {
                b.Rule.Add(new Rules()
                {
                    Fact = usloviya[i],
                    Result = resultat[i],
                    newFactName = factname[i],
                });
            }
        }

        public void Serialized()
        {
            string serialized = JsonConvert.SerializeObject(b);
            string path = @"JSON.txt";
            System.IO.File.WriteAllText(path, serialized);
        }

        public void Deserialized()
        {
            string path = @"JSON.txt";
            string json = System.IO.File.ReadAllText(path);
            try
            {
                b = JsonConvert.DeserializeObject<BZ>(json);
            }
            catch (Exception ex)
            {
                // нужно видимо что то предпринять
            }
        }
    }

    class BZ
    {
       public  List<Rules> Rule; 
    }

    class Rules
    {
        public string[] Fact { get; set; }
        public string[] Result { get; set; }
        public string newFactName { get; set; }
    }

   
}

