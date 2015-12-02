using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frame
{
    public partial class Form1 : Form
    {
        string nameOfProcedure = "СarpetFunction";
        GroopFrame Frames = new GroopFrame();
        List<string> nameOfFrames = new List<string>();
        forXML ForXML = new forXML();
        public Form1()
        {
            InitializeComponent();
        }
        int numOfPrint = 0;
        int query = 0;
        int butclick = 0;
        int numOfParam = 1;
        ComboBox[] cb1;
        ComboBox[] cb2;
        Label[] lofn;
        Label[] lofv;
        TextBox[] tb;

        private void button1_Click(object sender, EventArgs e)
        {
            cb1 = new ComboBox[numOfParam+1];
            if (butclick < numOfParam)
            {
                int w = 12 + butclick * 120;
                int y = 150;
                int z = 50;
                butclick++;
                Point p1 = new Point(w, z);
                cb1[butclick] = new ComboBox();
                cb1[butclick].Location = p1;
                cb1[butclick].Width = 100;
                cb1[butclick].Height = 21;
                cb1[butclick].DataSource = nameOfFrames;
                cb1[butclick].SelectedIndexChanged += (cb, args) => SelectFrame(w,z,y,cb1);
                this.Controls.Add(cb1[butclick]);
                var i= this.Controls.Count;
            }
            else MessageBox.Show("Не больше "+numOfParam+" параметра");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckIdiot(tb[1].Text))
            {
                numOfPrint = 0;
                int index = FindIndexFrame(Convert.ToString(cb1[1].SelectedValue));
                WriteFrame(index);
                string ako = Frames.GroopFrm[index].slots[0].Value;
                while (ako != Frames.GroopFrm[0].slots[0].Value)
                {
                    int res = FindAKO(index);
                    ako = Frames.GroopFrm[res].slots[0].Value;
                    WriteFrame(res);
                    index = res;
                }
                query += 300;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Извлекаем из xml список фреймов.
            Frames = ForXML.LoadXml(Frames) as GroopFrame;
            for (int i=0;i<Frames.GroopFrm.Count;i++)
            {
                nameOfFrames.Add(Frames.GroopFrm[i].NameFrame);
            }
        }

        void SelectFrame(int w, int z, int y, ComboBox[] cb1)
        {
            for (int i = 0; i < nameOfFrames.Count; i++)
            {
                if (cb1[butclick].SelectedValue == nameOfFrames[i])
                {
                    cb2 = new ComboBox[numOfParam + 1];
                    Point p3 = new Point(w, z + z);
                    cb2[butclick] = new ComboBox();
                    cb2[butclick].Location = p3;
                    cb2[butclick].Width = 100;
                    cb2[butclick].Height = 21;
                    for (int j = 0; j < Frames.GroopFrm[i].slots.Count; j++)
                    {
                        cb2[butclick].Items.Add(Frames.GroopFrm[i].slots[j].Name);
                    }
                    cb2[butclick].SelectedIndexChanged += (cb, args) => SelectSlot(w, z, y);
                    this.Controls.Add(cb2[butclick]);
                }
            }
        }

        void SelectSlot(int w, int z,int y)
        {
            tb = new TextBox[numOfParam + 1];
            Point p2 = new Point(w, y);
            tb[butclick] = new TextBox();
            tb[butclick].Location = p2;
            tb[butclick].Width = 100;
            tb[butclick].Height = 21;
            this.Controls.Add(tb[butclick]);
            button2.Visible = true;
            button1.Visible = false;
        }

        int FindAKO(int ind)
        {
            int res = -1;
            // AKO родителя.
            string s = Frames.GroopFrm[ind].slots[0].Value;
            for (int j = 0; j < Frames.GroopFrm.Count;j++ )
            {
                if (Frames.GroopFrm[j].NameFrame == s)
                {
                    res = j;
                }
            }
                return res;
        }

        void WriteFrame(int ind)
        {
            int numbOfSlots = Frames.GroopFrm[ind].slots.Count;
            lofn = new Label[numbOfSlots];
            lofv = new Label[numbOfSlots];
            Point p;
            // Имя слота.
            for (int j = 0; j < numbOfSlots; j++)
            {
                int xx = 300+query;
                int yy = (j+1) * 25+numOfPrint;
                p = new Point(xx, yy);
                lofn[j] = new Label();
                lofn[j].Location = p;
                lofn[j].Width = 100;
                lofn[j].Height = 15;
                lofn[j].BackColor = Color.White;
                lofn[j].Text = Frames.GroopFrm[ind].slots[j].Name;
                this.Controls.Add(lofn[j]);
            }
            // Значение слота.
            for (int j = 0; j < numbOfSlots; j++)
            {
                int xx = 400+query;
                int yy = (1+j) * 25 + numOfPrint;
                p = new Point(xx, yy);
                lofv[j] = new Label();
                lofv[j].Location = p;
                lofv[j].Width = 100;
                lofv[j].Height = 15;
                lofv[j].BackColor = Color.White;
                switch (Frames.GroopFrm[ind].slots[j].Value)
                {
                    case "СarpetFunction":
                        {
                            СarpetFunction();
                        }
                        break;
                    default:
                        {
                            lofv[j].Text = Frames.GroopFrm[ind].slots[j].Value;
                        }
                        break;
                }
                this.Controls.Add(lofv[j]);
                //if (Frames.GroopFrm[ind].slots[j].Value == nameOfProcedure)
                //{
                //    СarpetFunction();
                //}
                //else
                //{
                //    lofv[j].Text = Frames.GroopFrm[ind].slots[j].Value;
                //}
            }
            numOfPrint += 150;
        }

        int FindIndexFrame(string s)
        {
            for (int i = 0; i < nameOfFrames.Count; i++)
            {
                if (s == nameOfFrames[i])
                {
                    return i;
                }
            }
            return -1;
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    Point p;
        //    int index = FindIndexFrame(Convert.ToString(cb1[1].SelectedValue));
        //    lofv = new Label[Frames.GroopFrm[index].slots.Count];
        //    lofn = new Label[Frames.GroopFrm[index].slots.Count];
        //    //Point p;
        //    // Имя слота.
        //    for (int j = 0; j < Frames.GroopFrm[index].slots.Count; j++)
        //    {
        //        int xx = 300 + query;
        //        int yy = (j + 1) * 25 + numOfPrint;
        //        p = new Point(xx, yy);
        //        lofn[j] = new Label();
        //        lofn[j].Location = p;
        //        lofn[j].Width = 100;
        //        lofn[j].Height = 15;
        //        lofn[j].BackColor = Color.White;
        //        lofn[j].Text = Frames.GroopFrm[index].slots[j].Name;
        //        this.Controls.Add(lofn[j]);
        //    }
        //    // Значение слота.
        //    for (int j = 0; j < Frames.GroopFrm[index].slots.Count; j++)
        //    {
        //        int xx = 400 + query;
        //        int yy = (1 + j) * 25 + numOfPrint;
        //        p = new Point(xx, yy);
        //        lofv[j] = new Label();
        //        lofv[j].Location = p;
        //        lofv[j].Width = 100;
        //        lofv[j].Height = 15;
        //        lofv[j].BackColor = Color.White;
        //        lofv[j].Text = Frames.GroopFrm[index].slots[j].Value;
        //        this.Controls.Add(lofv[j]);
        //    }
        //    string ako = Frames.GroopFrm[index].slots[0].Value;
        //    int ind = FindIndexFrame(ako);
        //    lofv[Frames.GroopFrm[index].slots.Count-1].Text = Convert.ToString(Convert.ToInt32(Frames.GroopFrm[ind].slots[1].Value) / 2);
        //    WriteFrame(index);
        //}

        void СarpetFunction()
        {
            Point p;
            int index = FindIndexFrame(Convert.ToString(cb1[1].SelectedValue));
            lofv = new Label[Frames.GroopFrm[index].slots.Count];
            lofn = new Label[Frames.GroopFrm[index].slots.Count];
            //Point p;
            // Имя слота.
            for (int j = 0; j < Frames.GroopFrm[index].slots.Count; j++)
            {
                int xx = 300 + query;
                int yy = (j + 1) * 25 + numOfPrint;
                p = new Point(xx, yy);
                lofn[j] = new Label();
                lofn[j].Location = p;
                lofn[j].Width = 100;
                lofn[j].Height = 15;
                lofn[j].BackColor = Color.White;
                lofn[j].Text = Frames.GroopFrm[index].slots[j].Name;
                this.Controls.Add(lofn[j]);
            }
            // Значение слота.
            for (int j = 0; j < Frames.GroopFrm[index].slots.Count; j++)
            {
                int xx = 400 + query;
                int yy = (1 + j) * 25 + numOfPrint;
                p = new Point(xx, yy);
                lofv[j] = new Label();
                lofv[j].Location = p;
                lofv[j].Width = 100;
                lofv[j].Height = 15;
                lofv[j].BackColor = Color.White;
                lofv[j].Text = Frames.GroopFrm[index].slots[j].Value;
                this.Controls.Add(lofv[j]);
            }
            string ako = Frames.GroopFrm[index].slots[0].Value;
            int ind = FindIndexFrame(ako);
            if (tb[1].Text != "")
            {
                lofv[Frames.GroopFrm[index].slots.Count - 1].Text = Convert.ToString(Convert.ToInt32(tb[1].Text) / 2);
            }
            else
            {
                lofv[Frames.GroopFrm[index].slots.Count - 1].Text = Convert.ToString(Convert.ToInt32(Frames.GroopFrm[ind].slots[1].Value) / 2);
            }
            //lofv[Frames.GroopFrm[index].slots.Count - 1].Text = Convert.ToString(Convert.ToInt32(Frames.GroopFrm[ind].slots[1].Value) / 2);
            //WriteFrame(index);
        }

        bool CheckIdiot(string s)
        {
            bool result = false;
            try
            {
                Convert.ToInt32(s);
            }
            catch
            {
                if (s == "")
                {
                    return result;
                }
                else
                {
                    result = true;
                    MessageBox.Show("Введите число");
                }
            }
            
            return result;
        }
    }
}
