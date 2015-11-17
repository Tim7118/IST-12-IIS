using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        IBase_Info ibi;
        Imlv IMLV;
        IWorking_memory IVM;
        IAcquirement_Knowledge IAK;

        int Number;

        public Form1()
        {
            InitializeComponent();
            ibi = new Base_Info();
            IMLV = new MLV();
            IVM = new Working_memory();
            IAK = new Acquirement_Knowledge();
        }

        private void workRule(int numRule)
        {
            richTextBoxMLV_component_explanations.Text = richTextBoxMLV_component_explanations.Text + "Сработало правило номер:  " + Convert.ToString(numRule) + Environment.NewLine;
        }

        private void cause(string[] Cause, int numRule)
        {
            string fact = Cause[0];
            for (int i = 1; i < Cause.Length; i++)
            {
                fact = fact + " " + Cause[i];
            }
            richTextBoxMLV_component_explanations.Text = richTextBoxMLV_component_explanations.Text + "Эти факты привели в срабатыванию правила №" + Convert.ToString(numRule) +" : "+ fact + Environment.NewLine;
        }

        private void Finish()
        {
            richTextBoxMLV_component_explanations.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Добавление нового правила.
            bool correctly = true;
            string fact = Fact.Text;
            string rule = Result.Text;
            string newfact = newFactName.Text;

            // Проверка корректности введенных значений.
            correctly = Revision(fact, rule, newfact);

            if (correctly == true)
            {
                IAK.AddRule(fact, rule, newfact, ibi);
                MessageBox.Show("Правило добавлено");
            }

            if (IVM.workMemory.Fact != null)
            {
                IVM.workMemory.Fact.Clear();
            }
            Fact.Text = "";
            Result.Text = "";
            newFactName.Text = "";
        }

        private bool Revision( string fact, string rule, string newfact)
        {
            bool correct = true;

            if ((fact == "") || (rule == "") || (newfact == ""))
            {
                MessageBox.Show("Не все поля заполнены");
                correct = false;
            }
            if (fact.IndexOf("=") == -1)
            {
                MessageBox.Show("В предпосылке нет знака равно");
                correct = false;
            }
            if ((fact.IndexOf("/") > 0) || (newfact.IndexOf("/") > 0) || (rule.IndexOf("/") > 0))
            {
                MessageBox.Show("Использовался запрещщенный символ");
                correct = false;
            }
            if ((fact.IndexOf("$") > 0) || (newfact.IndexOf("$") > 0) || (rule.IndexOf("$") > 0))
            {
                MessageBox.Show("Использовался запрещщенный символ");
                correct = false;
            }
            return correct;
        }

        private void программаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Начальная подготовка к МЛВ.
            panel_AddRule.Visible = false;
            panel_Rules.Visible = false;
            labelMLV_End.Visible = false;
            panel_ProgramMLV.Visible = true;
            labelMLV_Question.Visible = true;
            labelMLV_answer.Visible = true;
            buttonMLV_addAnswer.Visible = true;
            textBoxMLV_answer.Visible = true;
            
            ibi.Start();
            IVM.Start();
            // Поиск подходящего правила.
            int number = IMLV.Search(ibi,IVM) ;
            Number = number;
            if (number > -1)
            {
                workRule(number);
                cause(ibi.B.Rule[number].Fact, number);
                string result = "";
                for (int i = 0; i < ibi.B.Rule[number].Result.Length; i++)
                {
                    result = result + ibi.B.Rule[number].Result[i];
                }
                textBoxMLV_Result.Text = result;
            }
            else
            {
                MessageBox.Show("Правило не найдено");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Была нажата кнопка "добавить".
            panel_AddRule.Visible = true;
            panel_Rules.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Здесь реализован основной механизм МЛВ.
            string otv = textBoxMLV_answer.Text;
            otv = otv.ToLower();
            if(otv == "true"||otv== "false")
            {
                textBoxMLV_answer.Text = "";
                // Добавили в рабочую память новый означенный факт. 
                IVM.AddFact(otv, ibi.B.Rule[Number].newFactName);
                // Ищем по обновленной рабочей памяти подходящее правило в базе знаний.
                int number = IMLV.Search(ibi, IVM);
                // Если Number == -1 значит правило не было найдено.
                Number = number;               
                if (number > -1)
                {
                    // Компонент обьяснения показывает номер сработавшего правила.
                    workRule(number);
                    // К.О Поясняеет что привело к этому правилу
                    cause(ibi.B.Rule[number].Fact, number);

                    if (ibi.B.Rule[number].newFactName == "End")
                    {
                        textBoxMLV_answer.Visible = false;
                        labelMLV_Question.Visible = false;
                        buttonMLV_addAnswer.Visible = false;
                        labelMLV_End.Visible = true;
                        labelMLV_answer.Visible = false;
                   
                        IVM.workMemory.Fact.Clear();
                        Finish();
                    }
                    string result = "";
                    for (int i = 0; i < ibi.B.Rule[number].Result.Length; i++)
                    {
                        result = result + ibi.B.Rule[number].Result[i];
                    }
                    textBoxMLV_Result.Text = result;                   
                }
                else
                {
                    MessageBox.Show("Правила с такой предпосылкой не найдено");
                }
            }
            else
            {
                textBoxMLV_answer.Text = "";
                MessageBox.Show("Введите корректное значение (true/false)");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Изменение правила, подстановка значений.
            panel_UpDateRule.Visible = true;
            panel_AddRule.Visible = false;
            panel_ProgramMLV.Visible = false;
            panel_Rules.Visible = false;

            string result = ibi.B.Rule[listBoxRules_List.SelectedIndex].Fact[0];
            for (int i = 1; i < ibi.B.Rule[listBoxRules_List.SelectedIndex].Fact.Length; i++)
            {
                result = result + " , " + ibi.B.Rule[listBoxRules_List.SelectedIndex].Fact[i];
            }
            textBox3UpDate_Fact.Text = result;

            string fact = ibi.B.Rule[listBoxRules_List.SelectedIndex].Result[0];
            for (int i = 1; i < ibi.B.Rule[listBoxRules_List.SelectedIndex].Result.Length; i++)
            {
                fact = fact + " , " + ibi.B.Rule[listBoxRules_List.SelectedIndex].Result[i];
            }
            textBoxUpDate_Result.Text = fact;

            textBoxUpDate_NewName.Text = ibi.B.Rule[listBoxRules_List.SelectedIndex].newFactName;

            if(listBoxRules_List.SelectedIndex >= 0)
            {
                int ind = listBoxRules_List.SelectedIndex;
                MessageBox.Show("Изменить правило № " + Convert.ToString( ind));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Изменение правила.
            // Проверка введенных значений.
            bool correctly = Revision(textBox3UpDate_Fact.Text, textBoxUpDate_Result.Text, textBoxUpDate_NewName.Text);
            if (correctly == true)
            {
                IAK.UpDate(listBoxRules_List.SelectedIndex, textBox3UpDate_Fact.Text, textBoxUpDate_Result.Text, textBoxUpDate_NewName.Text, ibi);
                MessageBox.Show("Правило № " + Convert.ToString(listBoxRules_List.SelectedIndex) + " изменено");
                panel_UpDateRule.Visible = false;
            }
            textBox3UpDate_Fact.Text = "";
            textBoxUpDate_Result.Text = "";
            textBoxUpDate_NewName.Text = "";            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Удаление правила.
            if (listBoxRules_List.SelectedIndex >= 0)
            {
                int ind = listBoxRules_List.SelectedIndex;
                MessageBox.Show("Удалить правило № " + Convert.ToString(ind));
                IAK.DeletRule(listBoxRules_List.SelectedIndex, ibi);

                listBoxRules_List.Items.Clear();
                foreach (Rules item in ibi.B.Rule)
                {
                    string fact = "";
                    for (int i = 0; i < item.Fact.Length; i++)
                    {
                        fact = fact + item.Fact[i];
                    }

                    string result = "";
                    for (int i = 0; i < item.Result.Length; i++)
                    {
                        result = result + item.Result[i];
                    }
                    listBoxRules_List.Items.Add("Если " + fact + " То " + result + " Означить факт с именем " + item.newFactName);
                } 
            }
        }

        private void ПравилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Rules.Visible = true;
            panel_AddRule.Visible = false;
            panel_ProgramMLV.Visible = false;

            // Если правила обновлялись, стоит очистить списки.
            if (IVM.workMemory.Fact != null)
            {
                IVM.workMemory.Fact.Clear();
                ibi.B.Rule.Clear();
                listBoxRules_List.Items.Clear();
            }
            ibi.Start();
            IVM.Start();

            foreach (Rules item in ibi.B.Rule)
            {
                string fact = "";
                for (int i = 0; i < item.Fact.Length; i++)
                {
                    fact = fact + item.Fact[i];
                }

                string result = "";
                for (int i = 0; i < item.Result.Length; i++)
                {
                    result = result + item.Result[i];
                }
                listBoxRules_List.Items.Add("Если " + fact + " То " + result + " Означить факт с именем " + item.newFactName);
            }   
        }
    }
}

