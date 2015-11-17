namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьПравилоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_AddRule = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd_AddRule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newFactName = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Fact = new System.Windows.Forms.TextBox();
            this.panel_ProgramMLV = new System.Windows.Forms.Panel();
            this.labelMLV_help = new System.Windows.Forms.Label();
            this.richTextBoxMLV_component_explanations = new System.Windows.Forms.RichTextBox();
            this.labelMLV_End = new System.Windows.Forms.Label();
            this.buttonMLV_addAnswer = new System.Windows.Forms.Button();
            this.labelMLV_answer = new System.Windows.Forms.Label();
            this.textBoxMLV_answer = new System.Windows.Forms.TextBox();
            this.textBoxMLV_Result = new System.Windows.Forms.TextBox();
            this.labelMLV_Question = new System.Windows.Forms.Label();
            this.panel_Rules = new System.Windows.Forms.Panel();
            this.buttonRules_dalete = new System.Windows.Forms.Button();
            this.buttonRules_Update = new System.Windows.Forms.Button();
            this.buttonRules_add = new System.Windows.Forms.Button();
            this.listBoxRules_List = new System.Windows.Forms.ListBox();
            this.panel_UpDateRule = new System.Windows.Forms.Panel();
            this.buttonUpDate_makeChanges = new System.Windows.Forms.Button();
            this.textBoxUpDate_NewName = new System.Windows.Forms.TextBox();
            this.textBoxUpDate_Result = new System.Windows.Forms.TextBox();
            this.textBox3UpDate_Fact = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel_AddRule.SuspendLayout();
            this.panel_ProgramMLV.SuspendLayout();
            this.panel_Rules.SuspendLayout();
            this.panel_UpDateRule.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПравилоToolStripMenuItem,
            this.программаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьПравилоToolStripMenuItem
            // 
            this.добавитьПравилоToolStripMenuItem.Name = "добавитьПравилоToolStripMenuItem";
            this.добавитьПравилоToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.добавитьПравилоToolStripMenuItem.Text = "Правила";
            this.добавитьПравилоToolStripMenuItem.Click += new System.EventHandler(this.ПравилаToolStripMenuItem_Click);
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.программаToolStripMenuItem.Text = "программа";
            this.программаToolStripMenuItem.Click += new System.EventHandler(this.программаToolStripMenuItem_Click);
            // 
            // panel_AddRule
            // 
            this.panel_AddRule.AutoSize = true;
            this.panel_AddRule.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_AddRule.Controls.Add(this.label6);
            this.panel_AddRule.Controls.Add(this.buttonAdd_AddRule);
            this.panel_AddRule.Controls.Add(this.label3);
            this.panel_AddRule.Controls.Add(this.label2);
            this.panel_AddRule.Controls.Add(this.label1);
            this.panel_AddRule.Controls.Add(this.newFactName);
            this.panel_AddRule.Controls.Add(this.Result);
            this.panel_AddRule.Controls.Add(this.Fact);
            this.panel_AddRule.Location = new System.Drawing.Point(12, 215);
            this.panel_AddRule.Name = "panel_AddRule";
            this.panel_AddRule.Size = new System.Drawing.Size(254, 243);
            this.panel_AddRule.TabIndex = 1;
            this.panel_AddRule.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Добавление нового правила";
            // 
            // buttonAdd_AddRule
            // 
            this.buttonAdd_AddRule.Location = new System.Drawing.Point(42, 176);
            this.buttonAdd_AddRule.Name = "buttonAdd_AddRule";
            this.buttonAdd_AddRule.Size = new System.Drawing.Size(89, 39);
            this.buttonAdd_AddRule.TabIndex = 6;
            this.buttonAdd_AddRule.Text = "add";
            this.buttonAdd_AddRule.UseVisualStyleBackColor = true;
            this.buttonAdd_AddRule.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "newFactname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "fact1=value,fact2=value2";
            // 
            // newFactName
            // 
            this.newFactName.Location = new System.Drawing.Point(6, 143);
            this.newFactName.Name = "newFactName";
            this.newFactName.Size = new System.Drawing.Size(220, 20);
            this.newFactName.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(9, 96);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(217, 20);
            this.Result.TabIndex = 1;
            // 
            // Fact
            // 
            this.Fact.Location = new System.Drawing.Point(9, 48);
            this.Fact.Name = "Fact";
            this.Fact.Size = new System.Drawing.Size(217, 20);
            this.Fact.TabIndex = 0;
            // 
            // panel_ProgramMLV
            // 
            this.panel_ProgramMLV.Controls.Add(this.labelMLV_help);
            this.panel_ProgramMLV.Controls.Add(this.richTextBoxMLV_component_explanations);
            this.panel_ProgramMLV.Controls.Add(this.labelMLV_End);
            this.panel_ProgramMLV.Controls.Add(this.buttonMLV_addAnswer);
            this.panel_ProgramMLV.Controls.Add(this.labelMLV_answer);
            this.panel_ProgramMLV.Controls.Add(this.textBoxMLV_answer);
            this.panel_ProgramMLV.Controls.Add(this.textBoxMLV_Result);
            this.panel_ProgramMLV.Controls.Add(this.labelMLV_Question);
            this.panel_ProgramMLV.Location = new System.Drawing.Point(603, 27);
            this.panel_ProgramMLV.Name = "panel_ProgramMLV";
            this.panel_ProgramMLV.Size = new System.Drawing.Size(382, 435);
            this.panel_ProgramMLV.TabIndex = 2;
            this.panel_ProgramMLV.Visible = false;
            // 
            // labelMLV_help
            // 
            this.labelMLV_help.AutoSize = true;
            this.labelMLV_help.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelMLV_help.Location = new System.Drawing.Point(201, 64);
            this.labelMLV_help.Name = "labelMLV_help";
            this.labelMLV_help.Size = new System.Drawing.Size(58, 13);
            this.labelMLV_help.TabIndex = 7;
            this.labelMLV_help.Text = "(true/false)";
            // 
            // richTextBoxMLV_component_explanations
            // 
            this.richTextBoxMLV_component_explanations.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBoxMLV_component_explanations.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxMLV_component_explanations.Location = new System.Drawing.Point(11, 148);
            this.richTextBoxMLV_component_explanations.Name = "richTextBoxMLV_component_explanations";
            this.richTextBoxMLV_component_explanations.ReadOnly = true;
            this.richTextBoxMLV_component_explanations.Size = new System.Drawing.Size(355, 275);
            this.richTextBoxMLV_component_explanations.TabIndex = 6;
            this.richTextBoxMLV_component_explanations.Text = "";
            // 
            // labelMLV_End
            // 
            this.labelMLV_End.AutoSize = true;
            this.labelMLV_End.Location = new System.Drawing.Point(68, 9);
            this.labelMLV_End.Name = "labelMLV_End";
            this.labelMLV_End.Size = new System.Drawing.Size(77, 13);
            this.labelMLV_End.TabIndex = 5;
            this.labelMLV_End.Text = "Вам подходит";
            this.labelMLV_End.Visible = false;
            // 
            // buttonMLV_addAnswer
            // 
            this.buttonMLV_addAnswer.Location = new System.Drawing.Point(18, 102);
            this.buttonMLV_addAnswer.Name = "buttonMLV_addAnswer";
            this.buttonMLV_addAnswer.Size = new System.Drawing.Size(75, 30);
            this.buttonMLV_addAnswer.TabIndex = 4;
            this.buttonMLV_addAnswer.Text = "Ответить!";
            this.buttonMLV_addAnswer.UseVisualStyleBackColor = true;
            this.buttonMLV_addAnswer.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelMLV_answer
            // 
            this.labelMLV_answer.AutoSize = true;
            this.labelMLV_answer.Location = new System.Drawing.Point(15, 66);
            this.labelMLV_answer.Name = "labelMLV_answer";
            this.labelMLV_answer.Size = new System.Drawing.Size(37, 13);
            this.labelMLV_answer.TabIndex = 3;
            this.labelMLV_answer.Text = "Ответ";
            // 
            // textBoxMLV_answer
            // 
            this.textBoxMLV_answer.Location = new System.Drawing.Point(60, 61);
            this.textBoxMLV_answer.Name = "textBoxMLV_answer";
            this.textBoxMLV_answer.Size = new System.Drawing.Size(117, 20);
            this.textBoxMLV_answer.TabIndex = 2;
            // 
            // textBoxMLV_Result
            // 
            this.textBoxMLV_Result.Location = new System.Drawing.Point(11, 35);
            this.textBoxMLV_Result.Name = "textBoxMLV_Result";
            this.textBoxMLV_Result.Size = new System.Drawing.Size(281, 20);
            this.textBoxMLV_Result.TabIndex = 1;
            // 
            // labelMLV_Question
            // 
            this.labelMLV_Question.AutoSize = true;
            this.labelMLV_Question.Location = new System.Drawing.Point(8, 9);
            this.labelMLV_Question.Name = "labelMLV_Question";
            this.labelMLV_Question.Size = new System.Drawing.Size(44, 13);
            this.labelMLV_Question.TabIndex = 0;
            this.labelMLV_Question.Text = "Вопрос";
            // 
            // panel_Rules
            // 
            this.panel_Rules.Controls.Add(this.buttonRules_dalete);
            this.panel_Rules.Controls.Add(this.buttonRules_Update);
            this.panel_Rules.Controls.Add(this.buttonRules_add);
            this.panel_Rules.Controls.Add(this.listBoxRules_List);
            this.panel_Rules.Location = new System.Drawing.Point(0, 24);
            this.panel_Rules.Name = "panel_Rules";
            this.panel_Rules.Size = new System.Drawing.Size(587, 185);
            this.panel_Rules.TabIndex = 3;
            this.panel_Rules.Visible = false;
            // 
            // buttonRules_dalete
            // 
            this.buttonRules_dalete.Location = new System.Drawing.Point(498, 102);
            this.buttonRules_dalete.Name = "buttonRules_dalete";
            this.buttonRules_dalete.Size = new System.Drawing.Size(75, 30);
            this.buttonRules_dalete.TabIndex = 3;
            this.buttonRules_dalete.Text = "удалить";
            this.buttonRules_dalete.UseVisualStyleBackColor = true;
            this.buttonRules_dalete.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonRules_Update
            // 
            this.buttonRules_Update.Location = new System.Drawing.Point(498, 66);
            this.buttonRules_Update.Name = "buttonRules_Update";
            this.buttonRules_Update.Size = new System.Drawing.Size(75, 30);
            this.buttonRules_Update.TabIndex = 2;
            this.buttonRules_Update.Text = "изменить";
            this.buttonRules_Update.UseVisualStyleBackColor = true;
            this.buttonRules_Update.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonRules_add
            // 
            this.buttonRules_add.Location = new System.Drawing.Point(497, 32);
            this.buttonRules_add.Name = "buttonRules_add";
            this.buttonRules_add.Size = new System.Drawing.Size(75, 30);
            this.buttonRules_add.TabIndex = 1;
            this.buttonRules_add.Text = "добавить";
            this.buttonRules_add.UseVisualStyleBackColor = true;
            this.buttonRules_add.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxRules_List
            // 
            this.listBoxRules_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxRules_List.FormattingEnabled = true;
            this.listBoxRules_List.Location = new System.Drawing.Point(12, 12);
            this.listBoxRules_List.Name = "listBoxRules_List";
            this.listBoxRules_List.Size = new System.Drawing.Size(479, 160);
            this.listBoxRules_List.TabIndex = 0;
            // 
            // panel_UpDateRule
            // 
            this.panel_UpDateRule.Controls.Add(this.buttonUpDate_makeChanges);
            this.panel_UpDateRule.Controls.Add(this.textBoxUpDate_NewName);
            this.panel_UpDateRule.Controls.Add(this.textBoxUpDate_Result);
            this.panel_UpDateRule.Controls.Add(this.textBox3UpDate_Fact);
            this.panel_UpDateRule.Controls.Add(this.label11);
            this.panel_UpDateRule.Controls.Add(this.label10);
            this.panel_UpDateRule.Controls.Add(this.label9);
            this.panel_UpDateRule.Controls.Add(this.label8);
            this.panel_UpDateRule.Location = new System.Drawing.Point(301, 215);
            this.panel_UpDateRule.Name = "panel_UpDateRule";
            this.panel_UpDateRule.Size = new System.Drawing.Size(271, 243);
            this.panel_UpDateRule.TabIndex = 4;
            this.panel_UpDateRule.Visible = false;
            // 
            // buttonUpDate_makeChanges
            // 
            this.buttonUpDate_makeChanges.Location = new System.Drawing.Point(70, 176);
            this.buttonUpDate_makeChanges.Name = "buttonUpDate_makeChanges";
            this.buttonUpDate_makeChanges.Size = new System.Drawing.Size(95, 39);
            this.buttonUpDate_makeChanges.TabIndex = 7;
            this.buttonUpDate_makeChanges.Text = "Внести изменения";
            this.buttonUpDate_makeChanges.UseVisualStyleBackColor = true;
            this.buttonUpDate_makeChanges.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxUpDate_NewName
            // 
            this.textBoxUpDate_NewName.Location = new System.Drawing.Point(6, 143);
            this.textBoxUpDate_NewName.Name = "textBoxUpDate_NewName";
            this.textBoxUpDate_NewName.Size = new System.Drawing.Size(248, 20);
            this.textBoxUpDate_NewName.TabIndex = 6;
            // 
            // textBoxUpDate_Result
            // 
            this.textBoxUpDate_Result.Location = new System.Drawing.Point(7, 91);
            this.textBoxUpDate_Result.Name = "textBoxUpDate_Result";
            this.textBoxUpDate_Result.Size = new System.Drawing.Size(247, 20);
            this.textBoxUpDate_Result.TabIndex = 5;
            // 
            // textBox3UpDate_Fact
            // 
            this.textBox3UpDate_Fact.Location = new System.Drawing.Point(6, 47);
            this.textBox3UpDate_Fact.Name = "textBox3UpDate_Fact";
            this.textBox3UpDate_Fact.Size = new System.Drawing.Size(245, 20);
            this.textBox3UpDate_Fact.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "newFactName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Result";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "fact1=val1,fact2=val2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Изменить правило";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 474);
            this.Controls.Add(this.panel_UpDateRule);
            this.Controls.Add(this.panel_Rules);
            this.Controls.Add(this.panel_ProgramMLV);
            this.Controls.Add(this.panel_AddRule);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_AddRule.ResumeLayout(false);
            this.panel_AddRule.PerformLayout();
            this.panel_ProgramMLV.ResumeLayout(false);
            this.panel_ProgramMLV.PerformLayout();
            this.panel_Rules.ResumeLayout(false);
            this.panel_UpDateRule.ResumeLayout(false);
            this.panel_UpDateRule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьПравилоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.Panel panel_AddRule;
        private System.Windows.Forms.TextBox newFactName;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Fact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd_AddRule;
        private System.Windows.Forms.Panel panel_ProgramMLV;
        private System.Windows.Forms.Button buttonMLV_addAnswer;
        private System.Windows.Forms.Label labelMLV_answer;
        private System.Windows.Forms.TextBox textBoxMLV_answer;
        private System.Windows.Forms.TextBox textBoxMLV_Result;
        private System.Windows.Forms.Label labelMLV_Question;
        private System.Windows.Forms.Panel panel_Rules;
        private System.Windows.Forms.ListBox listBoxRules_List;
        private System.Windows.Forms.Button buttonRules_dalete;
        private System.Windows.Forms.Button buttonRules_Update;
        private System.Windows.Forms.Button buttonRules_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMLV_End;
        private System.Windows.Forms.Panel panel_UpDateRule;
        private System.Windows.Forms.TextBox textBoxUpDate_NewName;
        private System.Windows.Forms.TextBox textBoxUpDate_Result;
        private System.Windows.Forms.TextBox textBox3UpDate_Fact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUpDate_makeChanges;
        private System.Windows.Forms.RichTextBox richTextBoxMLV_component_explanations;
        private System.Windows.Forms.Label labelMLV_help;
    }
}

