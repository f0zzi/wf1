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
            this.components = new System.ComponentModel.Container();
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
            this.tbPriceCola = new System.Windows.Forms.TextBox();
            this.tbPriceFri = new System.Windows.Forms.TextBox();
            this.tbPriceBurger = new System.Windows.Forms.TextBox();
            this.tbPriceHotdog = new System.Windows.Forms.TextBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.gbOil.Location = new System.Drawing.Point(24, 25);
            this.gbOil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOil.Name = "gbOil";
            this.gbOil.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOil.Size = new System.Drawing.Size(262, 328);
            this.gbOil.TabIndex = 0;
            this.gbOil.TabStop = false;
            this.gbOil.Text = "Автозаправка";
            this.gbOil.TextChanged += new System.EventHandler(this.TbQuantityOil_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "грн.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "л.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "грн.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ціна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Бензин";
            // 
            // tbMoneyOil
            // 
            this.tbMoneyOil.Location = new System.Drawing.Point(125, 186);
            this.tbMoneyOil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMoneyOil.MaxLength = 6;
            this.tbMoneyOil.Name = "tbMoneyOil";
            this.tbMoneyOil.Size = new System.Drawing.Size(92, 26);
            this.tbMoneyOil.TabIndex = 5;
            this.tbMoneyOil.TextChanged += new System.EventHandler(this.TbQuantityOil_TextChanged);
            this.tbMoneyOil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox8_KeyPress);
            // 
            // tbQuantityOil
            // 
            this.tbQuantityOil.Location = new System.Drawing.Point(125, 149);
            this.tbQuantityOil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbQuantityOil.MaxLength = 5;
            this.tbQuantityOil.Name = "tbQuantityOil";
            this.tbQuantityOil.Size = new System.Drawing.Size(92, 26);
            this.tbQuantityOil.TabIndex = 4;
            this.tbQuantityOil.TextChanged += new System.EventHandler(this.TbQuantityOil_TextChanged);
            this.tbQuantityOil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox8_KeyPress);
            // 
            // tbPriceOil
            // 
            this.tbPriceOil.Enabled = false;
            this.tbPriceOil.Location = new System.Drawing.Point(84, 86);
            this.tbPriceOil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPriceOil.Name = "tbPriceOil";
            this.tbPriceOil.Size = new System.Drawing.Size(132, 26);
            this.tbPriceOil.TabIndex = 3;
            // 
            // cbOil
            // 
            this.cbOil.FormattingEnabled = true;
            this.cbOil.Items.AddRange(new object[] {
            "A-76",
            "A-92",
            "A-95"});
            this.cbOil.Location = new System.Drawing.Point(84, 36);
            this.cbOil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbOil.Name = "cbOil";
            this.cbOil.Size = new System.Drawing.Size(132, 28);
            this.cbOil.TabIndex = 2;
            this.cbOil.SelectedIndexChanged += new System.EventHandler(this.CbOil_SelectedIndexChanged);
            // 
            // SumOil
            // 
            this.SumOil.Controls.Add(this.lbSumOil);
            this.SumOil.Controls.Add(this.label8);
            this.SumOil.Location = new System.Drawing.Point(8, 232);
            this.SumOil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SumOil.Name = "SumOil";
            this.SumOil.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SumOil.Size = new System.Drawing.Size(248, 85);
            this.SumOil.TabIndex = 1;
            this.SumOil.TabStop = false;
            this.SumOil.Text = "До сплати";
            // 
            // lbSumOil
            // 
            this.lbSumOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSumOil.Location = new System.Drawing.Point(8, 32);
            this.lbSumOil.Name = "lbSumOil";
            this.lbSumOil.Size = new System.Drawing.Size(197, 39);
            this.lbSumOil.TabIndex = 11;
            this.lbSumOil.Text = "label11";
            this.lbSumOil.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "грн.";
            // 
            // gbSwitch
            // 
            this.gbSwitch.Controls.Add(this.rbMoney);
            this.gbSwitch.Controls.Add(this.rbQuantity);
            this.gbSwitch.Location = new System.Drawing.Point(8, 130);
            this.gbSwitch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSwitch.Name = "gbSwitch";
            this.gbSwitch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSwitch.Size = new System.Drawing.Size(109, 95);
            this.gbSwitch.TabIndex = 0;
            this.gbSwitch.TabStop = false;
            // 
            // rbMoney
            // 
            this.rbMoney.AutoSize = true;
            this.rbMoney.Location = new System.Drawing.Point(8, 56);
            this.rbMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMoney.Name = "rbMoney";
            this.rbMoney.Size = new System.Drawing.Size(65, 24);
            this.rbMoney.TabIndex = 1;
            this.rbMoney.TabStop = true;
            this.rbMoney.Text = "Сума";
            this.rbMoney.UseVisualStyleBackColor = true;
            // 
            // rbQuantity
            // 
            this.rbQuantity.AutoSize = true;
            this.rbQuantity.Location = new System.Drawing.Point(8, 19);
            this.rbQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbQuantity.Name = "rbQuantity";
            this.rbQuantity.Size = new System.Drawing.Size(96, 24);
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
            this.gbFood.Controls.Add(this.tbPriceCola);
            this.gbFood.Controls.Add(this.tbPriceFri);
            this.gbFood.Controls.Add(this.tbPriceBurger);
            this.gbFood.Controls.Add(this.tbPriceHotdog);
            this.gbFood.Controls.Add(this.label7);
            this.gbFood.Controls.Add(this.label6);
            this.gbFood.Controls.Add(this.checkBox4);
            this.gbFood.Controls.Add(this.checkBox3);
            this.gbFood.Controls.Add(this.checkBox2);
            this.gbFood.Controls.Add(this.checkBox1);
            this.gbFood.Controls.Add(this.SumFood);
            this.gbFood.Location = new System.Drawing.Point(308, 25);
            this.gbFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFood.Name = "gbFood";
            this.gbFood.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFood.Size = new System.Drawing.Size(320, 328);
            this.gbFood.TabIndex = 1;
            this.gbFood.TabStop = false;
            this.gbFood.Text = "Міні-кафе";
            // 
            // tbCola
            // 
            this.tbCola.Enabled = false;
            this.tbCola.Location = new System.Drawing.Point(230, 186);
            this.tbCola.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCola.MaxLength = 5;
            this.tbCola.Name = "tbCola";
            this.tbCola.Size = new System.Drawing.Size(82, 26);
            this.tbCola.TabIndex = 14;
            this.tbCola.Tag = "Cola";
            this.tbCola.EnabledChanged += new System.EventHandler(this.TbFood_TextChanged_1);
            this.tbCola.TextChanged += new System.EventHandler(this.TbFood_TextChanged_1);
            this.tbCola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFood_KeyPress);
            // 
            // tbFri
            // 
            this.tbFri.Enabled = false;
            this.tbFri.Location = new System.Drawing.Point(230, 145);
            this.tbFri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFri.MaxLength = 5;
            this.tbFri.Name = "tbFri";
            this.tbFri.Size = new System.Drawing.Size(83, 26);
            this.tbFri.TabIndex = 13;
            this.tbFri.Tag = "Fri";
            this.tbFri.EnabledChanged += new System.EventHandler(this.TbFood_TextChanged_1);
            this.tbFri.TextChanged += new System.EventHandler(this.TbFood_TextChanged_1);
            this.tbFri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFood_KeyPress);
            // 
            // tbBurger
            // 
            this.tbBurger.CausesValidation = false;
            this.tbBurger.Enabled = false;
            this.tbBurger.Location = new System.Drawing.Point(230, 105);
            this.tbBurger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBurger.MaxLength = 5;
            this.tbBurger.Name = "tbBurger";
            this.tbBurger.Size = new System.Drawing.Size(83, 26);
            this.tbBurger.TabIndex = 12;
            this.tbBurger.Tag = "Burger";
            this.tbBurger.EnabledChanged += new System.EventHandler(this.TbFood_TextChanged_1);
            this.tbBurger.TextChanged += new System.EventHandler(this.TbFood_TextChanged_1);
            this.tbBurger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFood_KeyPress);
            // 
            // tbHotdog
            // 
            this.tbHotdog.Enabled = false;
            this.tbHotdog.Location = new System.Drawing.Point(230, 64);
            this.tbHotdog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHotdog.MaxLength = 5;
            this.tbHotdog.Name = "tbHotdog";
            this.tbHotdog.Size = new System.Drawing.Size(83, 26);
            this.tbHotdog.TabIndex = 11;
            this.tbHotdog.Tag = "Hotdog";
            this.tbHotdog.EnabledChanged += new System.EventHandler(this.TbFood_TextChanged_1);
            this.tbHotdog.TextChanged += new System.EventHandler(this.TbFood_TextChanged_1);
            this.tbHotdog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFood_KeyPress);
            // 
            // tbPriceCola
            // 
            this.tbPriceCola.Location = new System.Drawing.Point(147, 186);
            this.tbPriceCola.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPriceCola.Name = "tbPriceCola";
            this.tbPriceCola.ReadOnly = true;
            this.tbPriceCola.Size = new System.Drawing.Size(64, 26);
            this.tbPriceCola.TabIndex = 10;
            this.tbPriceCola.Text = "4,40";
            // 
            // tbPriceFri
            // 
            this.tbPriceFri.Location = new System.Drawing.Point(147, 145);
            this.tbPriceFri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPriceFri.Name = "tbPriceFri";
            this.tbPriceFri.ReadOnly = true;
            this.tbPriceFri.Size = new System.Drawing.Size(64, 26);
            this.tbPriceFri.TabIndex = 9;
            this.tbPriceFri.Text = "7,20";
            // 
            // tbPriceBurger
            // 
            this.tbPriceBurger.Location = new System.Drawing.Point(147, 105);
            this.tbPriceBurger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPriceBurger.Name = "tbPriceBurger";
            this.tbPriceBurger.ReadOnly = true;
            this.tbPriceBurger.Size = new System.Drawing.Size(64, 26);
            this.tbPriceBurger.TabIndex = 8;
            this.tbPriceBurger.Text = "5,40";
            // 
            // tbPriceHotdog
            // 
            this.tbPriceHotdog.Location = new System.Drawing.Point(147, 64);
            this.tbPriceHotdog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPriceHotdog.Name = "tbPriceHotdog";
            this.tbPriceHotdog.ReadOnly = true;
            this.tbPriceHotdog.Size = new System.Drawing.Size(64, 26);
            this.tbPriceHotdog.TabIndex = 7;
            this.tbPriceHotdog.Text = "4,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Кількість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ціна";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(8, 186);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(105, 24);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Tag = "4";
            this.checkBox4.Text = "Кока-кола";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(8, 145);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(134, 24);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Tag = "3";
            this.checkBox3.Text = "Картопля-фрі";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 105);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(107, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Tag = "2";
            this.checkBox2.Text = "Гамбургер";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 65);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 24);
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
            this.SumFood.Location = new System.Drawing.Point(8, 232);
            this.SumFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SumFood.Name = "SumFood";
            this.SumFood.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SumFood.Size = new System.Drawing.Size(305, 85);
            this.SumFood.TabIndex = 0;
            this.SumFood.TabStop = false;
            this.SumFood.Text = "Досплати";
            // 
            // lbSumFood
            // 
            this.lbSumFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSumFood.Location = new System.Drawing.Point(7, 32);
            this.lbSumFood.Name = "lbSumFood";
            this.lbSumFood.Size = new System.Drawing.Size(255, 39);
            this.lbSumFood.TabIndex = 11;
            this.lbSumFood.Text = "label11";
            this.lbSumFood.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "грн.";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbSumTotal);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(24, 360);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(604, 125);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ВСЬОГО до сплати";
            // 
            // lbSumTotal
            // 
            this.lbSumTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSumTotal.Location = new System.Drawing.Point(366, 60);
            this.lbSumTotal.Name = "lbSumTotal";
            this.lbSumTotal.Size = new System.Drawing.Size(189, 49);
            this.lbSumTotal.TabIndex = 11;
            this.lbSumTotal.Text = "label11";
            this.lbSumTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(554, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "грн.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "X-звіт";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Прорахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 502);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.gbFood);
            this.Controls.Add(this.gbOil);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox tbPriceCola;
        private System.Windows.Forms.TextBox tbPriceFri;
        private System.Windows.Forms.TextBox tbPriceBurger;
        private System.Windows.Forms.TextBox tbPriceHotdog;
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
        private System.Windows.Forms.Timer timer1;
    }
}

