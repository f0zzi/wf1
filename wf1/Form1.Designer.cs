namespace wf1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOil = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMoneyOil = new System.Windows.Forms.TextBox();
            this.tbQuantityOil = new System.Windows.Forms.TextBox();
            this.tbPriceOil = new System.Windows.Forms.TextBox();
            this.cbOil = new System.Windows.Forms.ComboBox();
            this.SumOil = new System.Windows.Forms.GroupBox();
            this.lbSumOil = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbSwitch = new System.Windows.Forms.GroupBox();
            this.rbMoney = new System.Windows.Forms.RadioButton();
            this.rbQuantity = new System.Windows.Forms.RadioButton();
            this.gbFood = new System.Windows.Forms.GroupBox();
            this.tbCola = new System.Windows.Forms.TextBox();
            this.tbFri = new System.Windows.Forms.TextBox();
            this.tbBurger = new System.Windows.Forms.TextBox();
            this.tbHotdog = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SumFood = new System.Windows.Forms.GroupBox();
            this.lbSumFood = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbSumTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbOil.SuspendLayout();
            this.SumOil.SuspendLayout();
            this.gbSwitch.SuspendLayout();
            this.gbFood.SuspendLayout();
            this.SumFood.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOil
            // 
            this.gbOil.Controls.Add(this.label5);
            this.gbOil.Controls.Add(this.label4);
            this.gbOil.Controls.Add(this.label3);
            this.gbOil.Controls.Add(this.label2);
            this.gbOil.Controls.Add(this.label1);
            this.gbOil.Controls.Add(this.tbMoneyOil);
            this.gbOil.Controls.Add(this.tbQuantityOil);
            this.gbOil.Controls.Add(this.tbPriceOil);
            this.gbOil.Controls.Add(this.cbOil);
            this.gbOil.Controls.Add(this.SumOil);
            this.gbOil.Controls.Add(this.gbSwitch);
            this.gbOil.Location = new System.Drawing.Point(21, 20);
            this.gbOil.Name = "gbOil";
            this.gbOil.Size = new System.Drawing.Size(233, 262);
            this.gbOil.TabIndex = 0;
            this.gbOil.TabStop = false;
            this.gbOil.Text = "Автозаправка";
            this.gbOil.TextChanged += new System.EventHandler(this.TbQuantityOil_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "грн.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "л.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "грн.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ціна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Бензин";
            // 
            // tbMoneyOil
            // 
            this.tbMoneyOil.Location = new System.Drawing.Point(111, 149);
            this.tbMoneyOil.Name = "tbMoneyOil";
            this.tbMoneyOil.Size = new System.Drawing.Size(82, 22);
            this.tbMoneyOil.TabIndex = 5;
            this.tbMoneyOil.TextChanged += new System.EventHandler(this.TbQuantityOil_TextChanged);
            this.tbMoneyOil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox8_KeyPress);
            // 
            // tbQuantityOil
            // 
            this.tbQuantityOil.Location = new System.Drawing.Point(111, 119);
            this.tbQuantityOil.Name = "tbQuantityOil";
            this.tbQuantityOil.Size = new System.Drawing.Size(82, 22);
            this.tbQuantityOil.TabIndex = 4;
            this.tbQuantityOil.TextChanged += new System.EventHandler(this.TbQuantityOil_TextChanged);
            this.tbQuantityOil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox8_KeyPress);
            // 
            // tbPriceOil
            // 
            this.tbPriceOil.Enabled = false;
            this.tbPriceOil.Location = new System.Drawing.Point(75, 69);
            this.tbPriceOil.Name = "tbPriceOil";
            this.tbPriceOil.Size = new System.Drawing.Size(118, 22);
            this.tbPriceOil.TabIndex = 3;
            // 
            // cbOil
            // 
            this.cbOil.FormattingEnabled = true;
            this.cbOil.Items.AddRange(new object[] {
            "A-76",
            "A-92",
            "A-95"});
            this.cbOil.Location = new System.Drawing.Point(75, 29);
            this.cbOil.Name = "cbOil";
            this.cbOil.Size = new System.Drawing.Size(118, 24);
            this.cbOil.TabIndex = 2;
            this.cbOil.SelectedIndexChanged += new System.EventHandler(this.CbOil_SelectedIndexChanged);
            // 
            // SumOil
            // 
            this.SumOil.Controls.Add(this.lbSumOil);
            this.SumOil.Controls.Add(this.label8);
            this.SumOil.Location = new System.Drawing.Point(7, 186);
            this.SumOil.Name = "SumOil";
            this.SumOil.Size = new System.Drawing.Size(220, 68);
            this.SumOil.TabIndex = 1;
            this.SumOil.TabStop = false;
            this.SumOil.Text = "До сплати";
            // 
            // lbSumOil
            // 
            this.lbSumOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSumOil.Location = new System.Drawing.Point(7, 26);
            this.lbSumOil.Name = "lbSumOil";
            this.lbSumOil.Size = new System.Drawing.Size(175, 31);
            this.lbSumOil.TabIndex = 11;
            this.lbSumOil.Text = "label11";
            this.lbSumOil.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "грн.";
            // 
            // gbSwitch
            // 
            this.gbSwitch.Controls.Add(this.rbMoney);
            this.gbSwitch.Controls.Add(this.rbQuantity);
            this.gbSwitch.Location = new System.Drawing.Point(7, 104);
            this.gbSwitch.Name = "gbSwitch";
            this.gbSwitch.Size = new System.Drawing.Size(97, 76);
            this.gbSwitch.TabIndex = 0;
            this.gbSwitch.TabStop = false;
            // 
            // rbMoney
            // 
            this.rbMoney.AutoSize = true;
            this.rbMoney.Location = new System.Drawing.Point(7, 45);
            this.rbMoney.Name = "rbMoney";
            this.rbMoney.Size = new System.Drawing.Size(62, 21);
            this.rbMoney.TabIndex = 1;
            this.rbMoney.TabStop = true;
            this.rbMoney.Text = "Сума";
            this.rbMoney.UseVisualStyleBackColor = true;
            // 
            // rbQuantity
            // 
            this.rbQuantity.AutoSize = true;
            this.rbQuantity.Location = new System.Drawing.Point(7, 15);
            this.rbQuantity.Name = "rbQuantity";
            this.rbQuantity.Size = new System.Drawing.Size(87, 21);
            this.rbQuantity.TabIndex = 0;
            this.rbQuantity.TabStop = true;
            this.rbQuantity.Text = "Кількість";
            this.rbQuantity.UseVisualStyleBackColor = true;
            this.rbQuantity.CheckedChanged += new System.EventHandler(this.RbQuantity_CheckedChanged);
            // 
            // gbFood
            // 
            this.gbFood.Controls.Add(this.tbCola);
            this.gbFood.Controls.Add(this.tbFri);
            this.gbFood.Controls.Add(this.tbBurger);
            this.gbFood.Controls.Add(this.tbHotdog);
            this.gbFood.Controls.Add(this.textBox7);
            this.gbFood.Controls.Add(this.textBox6);
            this.gbFood.Controls.Add(this.textBox5);
            this.gbFood.Controls.Add(this.textBox4);
            this.gbFood.Controls.Add(this.label7);
            this.gbFood.Controls.Add(this.label6);
            this.gbFood.Controls.Add(this.checkBox4);
            this.gbFood.Controls.Add(this.checkBox3);
            this.gbFood.Controls.Add(this.checkBox2);
            this.gbFood.Controls.Add(this.checkBox1);
            this.gbFood.Controls.Add(this.SumFood);
            this.gbFood.Location = new System.Drawing.Point(274, 20);
            this.gbFood.Name = "gbFood";
            this.gbFood.Size = new System.Drawing.Size(284, 262);
            this.gbFood.TabIndex = 1;
            this.gbFood.TabStop = false;
            this.gbFood.Text = "Міні-кафе";
            // 
            // tbCola
            // 
            this.tbCola.Enabled = false;
            this.tbCola.Location = new System.Drawing.Point(204, 149);
            this.tbCola.Name = "tbCola";
            this.tbCola.Size = new System.Drawing.Size(73, 22);
            this.tbCola.TabIndex = 14;
            this.tbCola.Tag = "Cola";
            this.tbCola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox8_KeyPress);
            // 
            // tbFri
            // 
            this.tbFri.Enabled = false;
            this.tbFri.Location = new System.Drawing.Point(204, 116);
            this.tbFri.Name = "tbFri";
            this.tbFri.Size = new System.Drawing.Size(74, 22);
            this.tbFri.TabIndex = 13;
            this.tbFri.Tag = "Fri";
            this.tbFri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox8_KeyPress);
            // 
            // tbBurger
            // 
            this.tbBurger.CausesValidation = false;
            this.tbBurger.Enabled = false;
            this.tbBurger.Location = new System.Drawing.Point(204, 84);
            this.tbBurger.Name = "tbBurger";
            this.tbBurger.Size = new System.Drawing.Size(74, 22);
            this.tbBurger.TabIndex = 12;
            this.tbBurger.Tag = "Burger";
            this.tbBurger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox8_KeyPress);
            // 
            // tbHotdog
            // 
            this.tbHotdog.Enabled = false;
            this.tbHotdog.Location = new System.Drawing.Point(204, 51);
            this.tbHotdog.Name = "tbHotdog";
            this.tbHotdog.Size = new System.Drawing.Size(74, 22);
            this.tbHotdog.TabIndex = 11;
            this.tbHotdog.Tag = "Hotdog";
            this.tbHotdog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox8_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(131, 149);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(57, 22);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "4,40";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(131, 116);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(57, 22);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "7,20";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 84);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(57, 22);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "5,40";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 51);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(57, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "4,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Кількість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ціна";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 149);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(98, 21);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Tag = "4";
            this.checkBox4.Text = "Кока-кола";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 116);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(121, 21);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Tag = "3";
            this.checkBox3.Text = "Картопля-фрі";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 84);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 21);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Tag = "2";
            this.checkBox2.Text = "Гамбургер";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Tag = "1";
            this.checkBox1.Text = "Хот-дог";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // SumFood
            // 
            this.SumFood.Controls.Add(this.lbSumFood);
            this.SumFood.Controls.Add(this.label9);
            this.SumFood.Location = new System.Drawing.Point(7, 186);
            this.SumFood.Name = "SumFood";
            this.SumFood.Size = new System.Drawing.Size(271, 68);
            this.SumFood.TabIndex = 0;
            this.SumFood.TabStop = false;
            this.SumFood.Text = "Досплати";
            // 
            // lbSumFood
            // 
            this.lbSumFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSumFood.Location = new System.Drawing.Point(6, 26);
            this.lbSumFood.Name = "lbSumFood";
            this.lbSumFood.Size = new System.Drawing.Size(227, 31);
            this.lbSumFood.TabIndex = 11;
            this.lbSumFood.Text = "label11";
            this.lbSumFood.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "грн.";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbSumTotal);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(21, 288);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(537, 100);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ВСЬОГО до сплати";
            // 
            // lbSumTotal
            // 
            this.lbSumTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSumTotal.Location = new System.Drawing.Point(325, 48);
            this.lbSumTotal.Name = "lbSumTotal";
            this.lbSumTotal.Size = new System.Drawing.Size(168, 39);
            this.lbSumTotal.TabIndex = 11;
            this.lbSumTotal.Text = "label11";
            this.lbSumTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "грн.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "X-звіт";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Прорахувати";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 402);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.gbFood);
            this.Controls.Add(this.gbOil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbOil.ResumeLayout(false);
            this.gbOil.PerformLayout();
            this.SumOil.ResumeLayout(false);
            this.SumOil.PerformLayout();
            this.gbSwitch.ResumeLayout(false);
            this.gbSwitch.PerformLayout();
            this.gbFood.ResumeLayout(false);
            this.gbFood.PerformLayout();
            this.SumFood.ResumeLayout(false);
            this.SumFood.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOil;
        private System.Windows.Forms.GroupBox SumOil;
        private System.Windows.Forms.GroupBox gbSwitch;
        private System.Windows.Forms.RadioButton rbMoney;
        private System.Windows.Forms.RadioButton rbQuantity;
        private System.Windows.Forms.GroupBox gbFood;
        private System.Windows.Forms.GroupBox SumFood;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMoneyOil;
        private System.Windows.Forms.TextBox tbQuantityOil;
        private System.Windows.Forms.TextBox tbPriceOil;
        private System.Windows.Forms.ComboBox cbOil;
        private System.Windows.Forms.TextBox tbCola;
        private System.Windows.Forms.TextBox tbFri;
        private System.Windows.Forms.TextBox tbBurger;
        private System.Windows.Forms.TextBox tbHotdog;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbSumOil;
        private System.Windows.Forms.Label lbSumFood;
        private System.Windows.Forms.Label lbSumTotal;
    }
}

