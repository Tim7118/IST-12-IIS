using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ConsoleApplication1
{
    class Program
    {
        BZ bd;
        int count;
        RP rab_memory = new RP(); 
        private void serialized()
        {
            BZ myCollection = new BZ();
            myCollection.Rules = new Rule[29];

            myCollection.Rules[0] = new Rule()
            {
                Fact = "start = true",
                Result = "животное для ребенка?",
                newFactName = "ForChild",
            };
            myCollection.Rules[1] = new Rule()
            {
                //ЕСЛИ ForChild = true ТО животное должно жить в клетке? (Cell)
                Fact = "ForChild = true",
                Result = "животное должно жить в клетке?",
                newFactName = "Cell",
            };
            myCollection.Rules[2] = new Rule()
            {
                //ЕСЛИ ForChild = false ТО животное для конкретной цели? (Target)
                Fact = "ForChild = false",
                Result = "",
                newFactName = "",
            };
            myCollection.Rules[3] = new Rule()
            {
                //3.	ЕСЛИ Cell = true ТО животное должно иметь шерсть? (Woll)
                Fact = "Cell = true",
                Result = "животное должно иметь шерсть?",
                newFactName = "Woll",
            };
            myCollection.Rules[4] = new Rule()
            {
                //4.	ЕСЛИ Cell = false ТО животное должно быть большим? (Big)
                Fact = "Cell = false",
                Result = "животное должно быть большим?",
                newFactName = "Big",
            };
            myCollection.Rules[5] = new Rule()
            {
                //5.	ЕСЛИ Target = true ТО Животное нужно для охоты(Hunting)
                Fact = "Target = true",
                Result = "Животное нужно для охоты?",
                newFactName = "Hunting",
            };
            myCollection.Rules[6] = new Rule()
            {
                //6.	ЕСЛИ Target = false ТО животное должно быть экзотичным?(Exotica)
                Fact = "Target = false",
                Result = "животное должно быть экзотичным?",
                newFactName = "Exotica",
            };
            myCollection.Rules[7] = new Rule()
            {
                //7.	ЕСЛИ Woll= true ТО срок жизни больше 5 лет?( lifetime)
                Fact = "Woll = true",
                Result = "срок жизни больше 5 лет?",
                newFactName = "lifetime",
            };
            myCollection.Rules[8] = new Rule()
            {
                //8.	ЕСЛИ lifetime = true ТО кролик(End = true)
                Fact = "lifetime = true",
                Result = "Кролик",
                newFactName = "End = true",
            };

            myCollection.Rules[9] = new Rule()
            {
                //9.	ЕСЛИ lifetime = false ТО дегу(End = true)
                Fact = "lifetime = false",
                Result = "Дегу",
                newFactName = "End = true",
            };
            myCollection.Rules[10] = new Rule()
            {
                //10.	ЕСЛИ Woll = false ТО животное должно жить в воде?(InWater)
                Fact = "Woll = false",
                Result = "животное должно жить в воде?",
                newFactName = "InWater",
            };
            myCollection.Rules[11] = new Rule()
            {
                //11.	ЕСЛИ Big = true ТО Собака(End = true)
                Fact = "Big = true",
                Result = "Собака",
                newFactName = "End = true",
            };
            myCollection.Rules[12] = new Rule()
            {
                //12.	ЕСЛИ Big = false ТО Кошка(End = true)
                Fact = "Big = false",
                Result = "Кошка",
                newFactName = "End = true",
            };
            myCollection.Rules[13] = new Rule()
            {
                //13.	ЕСЛИ Hunting = true  ТО Борзая(End = true)
                Fact = "Hunting = true",
                Result = "Борзая",
                newFactName = "End = true",
            };
            myCollection.Rules[14] = new Rule()
            {
                //14.	ЕСЛИ Hunting = false ТО Собака-поводырь(End = true)
                Fact = "Hunting = false",
                Result = "Собака-поводырь",
                newFactName = "End = true",
            };
            myCollection.Rules[15] = new Rule()
            {
                //15.	ЕСЛИ Exotica= true ТО есть опыт обращения с такими животными?(Experience)
                Fact = "Exotica = true",
                Result = "есть опыт обращения с такими животными(экзотическими)?",
                newFactName = "Experience",
            };
            myCollection.Rules[16] = new Rule()
            {
                //16.	ЕСЛИ Exotica = false ТО Частный дом?(Home)
                Fact = "Exotica = false",
                Result = "Частный дом?",
                newFactName = "Home",
            };
            myCollection.Rules[17] = new Rule()
            {
                ///17.	ЕСЛИ InWater = true ТО золотая рыбка(End = true)
                Fact = "InWater = true",
                Result = "золотая рыбка",
                newFactName = "End = true",
            };
            myCollection.Rules[18] = new Rule()
            {
                //18.	ЕСЛИ InWater = false ТО хотите птицу?(Bird)
                Fact = "InWater = false",
                Result = "хотите птицу?",
                newFactName = "Bird",
            };
            myCollection.Rules[19] = new Rule()
            {
                //19.	ЕСЛИ Experience = true ТО максимальная цена больше 500$ ?(Price)
                Fact = "Experience = true",
                Result = "максимальная цена больше 500$ ?",
                newFactName = "Price",
            };
            myCollection.Rules[20] = new Rule()
            {
                //20.	ЕСЛИ Price = true ТО Кобра(End = true)
                Fact = "Price = true",
                Result = "Кобра",
                newFactName = "End = true",
            };
            myCollection.Rules[21] = new Rule()
            {
                //21.	ЕСЛИ Price = false ТО тарантул(End = true)
                Fact = "Price = false",
                Result = "тарантул",
                newFactName = "End = true",
            };
            myCollection.Rules[22] = new Rule()
            {
                //22.	ЕСЛИ Experience = false ТО дом вместительный?(BigHome)
                Fact = "Experience = false",
                Result = "дом вместительный?",
                newFactName = "BigHome",
            };
            myCollection.Rules[23] = new Rule()
            {
                //23.	ЕСЛИ Home = true ТО Конь(End = true)
                Fact = "Home = true",
                Result = "Конь",
                newFactName = "End = true",
            };
            myCollection.Rules[24] = new Rule()
            {
                //24.	ЕСЛИ Home = false ТО Лори(End = true)
                Fact = "Home = false",
                Result = "Лори",
                newFactName = "End = true",
            };
            myCollection.Rules[25] = new Rule()
            {
                //25.	ЕСЛИ Bird = true ТО попугай, канарейка (End = true)
                Fact = "Bird = true",
                Result = "попугай, канарейка",
                newFactName = "End = true",
            };
            myCollection.Rules[26] = new Rule()
            {
                //26.	ЕСЛИ Bird = false ТО черепаха(End = true)
                Fact = "Bird = false",
                Result = "черепаха",
                newFactName = "End = true",
            };
            myCollection.Rules[27] = new Rule()
            {
                //27.	ЕСЛИ BigHome  = true ТО слон(End = true)
                Fact = "BigHome = true",
                Result = "слон",
                newFactName = "End = true",
            };
            myCollection.Rules[28] = new Rule()
            {
                //28.	ЕСЛИ BigHome = false ТО тушканчик(End = true)
                Fact = "BigHome = false",
                Result = "тушканчик",
                newFactName = "End = true",
            };
            string serialized = JsonConvert.SerializeObject(myCollection);
            string path = @"JSON.txt";
            System.IO.File.WriteAllText(path, serialized);
        }

        private void deserialized()
        {
            string path = @"JSON.txt";
            string json = System.IO.File.ReadAllText(path);
            try
            {
                bd = JsonConvert.DeserializeObject<BZ>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("К сожалению произошла ошибка." + Environment.NewLine + ex.Message);
            }
        }
        private void MLV()
        {
        
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.serialized();
            p.deserialized();
            p.MLV();
        }

    }
}
