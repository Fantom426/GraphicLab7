/*
 * Сделано в SharpDevelop.
 * Пользователь: Oleg
 * Дата: 16.11.2017
 * Время: 1:33
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace Lab7
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.x_shift = new System.Windows.Forms.NumericUpDown();
			this.y_shift = new System.Windows.Forms.NumericUpDown();
			this.z_shift = new System.Windows.Forms.NumericUpDown();
			this.x_scale = new System.Windows.Forms.NumericUpDown();
			this.y_scale = new System.Windows.Forms.NumericUpDown();
			this.z_scale = new System.Windows.Forms.NumericUpDown();
			this.x_rotate = new System.Windows.Forms.NumericUpDown();
			this.y_rotate = new System.Windows.Forms.NumericUpDown();
			this.z_rotate = new System.Windows.Forms.NumericUpDown();
			this.axis_angle = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.center = new System.Windows.Forms.RadioButton();
			this.isometric = new System.Windows.Forms.RadioButton();
			this.orthographic = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.x_shift)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.y_shift)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.z_shift)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.x_scale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.y_scale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.z_scale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.x_rotate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.y_rotate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.z_rotate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axis_angle)).BeginInit();
			this.SuspendLayout();
			// 
         // pictureBox
         // 
         this.pictureBox.BackColor = System.Drawing.Color.White;
         this.pictureBox.Location = new System.Drawing.Point(150, 12);
         this.pictureBox.Name = "pictureBox";
         this.pictureBox.Size = new System.Drawing.Size(902, 637);
         this.pictureBox.TabIndex = 0;
         this.pictureBox.TabStop = false;
         this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(29, 23);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(14, 13);
         this.label1.Text = "X";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(29, 47);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(14, 13);
         this.label2.Text = "Y";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(29, 73);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(14, 13);
         this.label3.Text = "Z";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(29, 138);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(14, 13);
         this.label4.Text = "X";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(29, 165);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(14, 13);
         this.label5.Text = "Y";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(29, 191);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(14, 13);
         this.label6.Text = "Z";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(29, 252);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(20, 13);
         this.label7.Text = "0X";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(29, 277);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(20, 13);
         this.label8.Text = "0Y";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(29, 303);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(20, 13);
         this.label9.Text = "0Z";
         // 
         // x_shift
         // 
         this.x_shift.Location = new System.Drawing.Point(49, 21);
         this.x_shift.Minimum = new decimal(new int[] {
         100,
         0,
         0,
         -2147483648});
         this.x_shift.Name = "x_shift";
         this.x_shift.Size = new System.Drawing.Size(84, 20);
         this.x_shift.TabIndex = 1;
         // 
         // y_shift
         // 
         this.y_shift.Location = new System.Drawing.Point(49, 45);
         this.y_shift.Minimum = new decimal(new int[] {
         100,
         0,
         0,
         -2147483648});
         this.y_shift.Name = "y_shift";
         this.y_shift.Size = new System.Drawing.Size(84, 20);
         this.y_shift.TabIndex = 2;
         // 
         // z_shift
         // 
         this.z_shift.Location = new System.Drawing.Point(49, 71);
         this.z_shift.Minimum = new decimal(new int[] {
         100,
         0,
         0,
         -2147483648});
         this.z_shift.Name = "z_shift";
         this.z_shift.Size = new System.Drawing.Size(84, 20);
         this.z_shift.TabIndex = 3;
         // 
         // x_scale
         // 
         this.x_scale.DecimalPlaces = 1;
         this.x_scale.Increment = new decimal(new int[] {
         1,
         0,
         0,
         65536});
         this.x_scale.Location = new System.Drawing.Point(49, 136);
         this.x_scale.Maximum = new decimal(new int[] {
         10,
         0,
         0,
         0});
         this.x_scale.Minimum = new decimal(new int[] {
         1,
         0,
         0,
         65536});
         this.x_scale.Name = "x_scale";
         this.x_scale.Size = new System.Drawing.Size(84, 20);
         this.x_scale.TabIndex = 5;
         this.x_scale.Value = new decimal(new int[] {
         1,
         0,
         0,
         0});
         // 
         // y_scale
         // 
         this.y_scale.DecimalPlaces = 1;
         this.y_scale.Increment = new decimal(new int[] {
         1,
         0,
         0,
         65536});
         this.y_scale.Location = new System.Drawing.Point(49, 163);
         this.y_scale.Maximum = new decimal(new int[] {
         10,
         0,
         0,
         0});
         this.y_scale.Minimum = new decimal(new int[] {
         1,
         0,
         0,
         65536});
         this.y_scale.Name = "y_scale";
         this.y_scale.Size = new System.Drawing.Size(84, 20);
         this.y_scale.TabIndex = 6;
         this.y_scale.Value = new decimal(new int[] {
         1,
         0,
         0,
         0});
         // 
         // z_scale
         // 
         this.z_scale.DecimalPlaces = 1;
         this.z_scale.Increment = new decimal(new int[] {
         1,
         0,
         0,
         65536});
         this.z_scale.Location = new System.Drawing.Point(49, 189);
         this.z_scale.Maximum = new decimal(new int[] {
         10,
         0,
         0,
         0});
         this.z_scale.Minimum = new decimal(new int[] {
         1,
         0,
         0,
         65536});
         this.z_scale.Name = "z_scale";
         this.z_scale.Size = new System.Drawing.Size(84, 20);
         this.z_scale.TabIndex = 7;
         this.z_scale.Value = new decimal(new int[] {
         1,
         0,
         0,
         0});
         // 
         // x_rotate
         // 
         this.x_rotate.Location = new System.Drawing.Point(55, 250);
         this.x_rotate.Maximum = new decimal(new int[] {
         360,
         0,
         0,
         0});
         this.x_rotate.Minimum = new decimal(new int[] {
         360,
         0,
         0,
         -2147483648});
         this.x_rotate.Name = "x_rotate";
         this.x_rotate.Size = new System.Drawing.Size(82, 20);
         this.x_rotate.TabIndex = 9;
         // 
         // y_rotate
         // 
         this.y_rotate.Location = new System.Drawing.Point(55, 275);
         this.y_rotate.Maximum = new decimal(new int[] {
         360,
         0,
         0,
         0});
         this.y_rotate.Minimum = new decimal(new int[] {
         360,
         0,
         0,
         -2147483648});
         this.y_rotate.Name = "y_rotate";
         this.y_rotate.Size = new System.Drawing.Size(82, 20);
         this.y_rotate.TabIndex = 10;
         // 
         // z_rotate
         // 
         this.z_rotate.Location = new System.Drawing.Point(55, 301);
         this.z_rotate.Maximum = new decimal(new int[] {
         360,
         0,
         0,
         0});
         this.z_rotate.Minimum = new decimal(new int[] {
         360,
         0,
         0,
         -2147483648});
         this.z_rotate.Name = "z_rotate";
         this.z_rotate.Size = new System.Drawing.Size(82, 20);
         this.z_rotate.TabIndex = 11;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(69, 353);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(55, 13);
         this.label10.Text = "Отразить";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(49, 97);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 4;
         this.button1.Text = "Перенести";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(32, 215);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(107, 23);
         this.button2.TabIndex = 8;
         this.button2.Text = "Масштабировать";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(55, 327);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 12;
         this.button3.Text = "Повернуть";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(55, 369);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(75, 23);
         this.button4.TabIndex = 13;
         this.button4.Text = "X";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // button5
         // 
         this.button5.Location = new System.Drawing.Point(55, 398);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(75, 23);
         this.button5.TabIndex = 14;
         this.button5.Text = "Y";
         this.button5.UseVisualStyleBackColor = true;
         this.button5.Click += new System.EventHandler(this.button5_Click);
         // 
         // button6
         // 
         this.button6.Location = new System.Drawing.Point(55, 427);
         this.button6.Name = "button6";
         this.button6.Size = new System.Drawing.Size(75, 23);
         this.button6.TabIndex = 15;
         this.button6.Text = "Z";
         this.button6.UseVisualStyleBackColor = true;
         this.button6.Click += new System.EventHandler(this.button6_Click);
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(12, 463);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(111, 13);
         this.label11.Text = "Поворот вокруг оси:";
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(11, 488);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(32, 13);
         this.label12.Text = "Угол";
         // 
         // axis_angle
         // 
         this.axis_angle.Location = new System.Drawing.Point(49, 486);
         this.axis_angle.Maximum = new decimal(new int[] {
         360,
         0,
         0,
         0});
         this.axis_angle.Minimum = new decimal(new int[] {
         360,
         0,
         0,
         -2147483648});
         this.axis_angle.Name = "axis_angle";
         this.axis_angle.Size = new System.Drawing.Size(70, 20);
         this.axis_angle.TabIndex = 16;
         // 
         // button7
         // 
         this.button7.Location = new System.Drawing.Point(14, 512);
         this.button7.Name = "button7";
         this.button7.Size = new System.Drawing.Size(131, 23);
         this.button7.TabIndex = 17;
         this.button7.Text = "Выбрать ось";
         this.button7.UseVisualStyleBackColor = true;
         this.button7.Click += new System.EventHandler(this.button7_Click);
         // 
         // button8
         // 
         this.button8.Location = new System.Drawing.Point(15, 541);
         this.button8.Name = "button8";
         this.button8.Size = new System.Drawing.Size(131, 23);
         this.button8.TabIndex = 18;
         this.button8.Text = "Удалить ось";
         this.button8.UseVisualStyleBackColor = true;
         this.button8.Click += new System.EventHandler(this.button8_Click);
         // 
         // button9
         // 
         this.button9.Location = new System.Drawing.Point(15, 570);
         this.button9.Name = "button9";
         this.button9.Size = new System.Drawing.Size(131, 23);
         this.button9.TabIndex = 19;
         this.button9.Text = "Повернуть вокруг оси";
         this.button9.UseVisualStyleBackColor = true;
         this.button9.Click += new System.EventHandler(this.button9_Click);
         // 
         // button10
         // 
         this.button10.Location = new System.Drawing.Point(44, 626);
         this.button10.Name = "button10";
         this.button10.Size = new System.Drawing.Size(75, 23);
         this.button10.TabIndex = 21;
         this.button10.Text = "Очистить";
         this.button10.UseVisualStyleBackColor = true;
         this.button10.Click += new System.EventHandler(this.button10_Click);
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(1060, 15);
         this.label13.Name = "label13";
         this.label13.Text = "Проекции";
			// 
			// center
			// 
			this.center.Location = new System.Drawing.Point(1060, this.label13.Location.Y+15);
			this.center.Name = "center";
			this.center.TabStop = true;
			this.center.Text = "перспективная";
			this.center.UseVisualStyleBackColor = true;
			this.center.AutoSize=true;
			this.center.TabIndex=22;
			//
			//	X
			//
			this.label14.Location = new System.Drawing.Point(1065,this.center.Location.Y+25);
			this.label14.Text = "X";
			this.label14.AutoSize = true;
			//
			//	Y
			//
			this.label15.Location = new System.Drawing.Point(1065,this.label14.Location.Y+20);
			this.label15.Text = "Y";
			this.label15.AutoSize = true;
			//
			//	Z
			//
			this.label16.Location = new System.Drawing.Point(1065,label15.Location.Y+20);
			this.label16.Text = "Z";
			this.label16.AutoSize = true;
			//
			//	textbox1
			//
			this.textBox1.Location = new System.Drawing.Point(1085,this.center.Location.Y+20);
			this.textBox1.TabIndex=23;
			//
			//	textbox2
			//
			this.textBox2.Location = new System.Drawing.Point(1085,this.textBox1.Location.Y+20);
			this.textBox2.TabIndex=24;
			//
			//	textbox3
			//
			this.textBox3.Location = new System.Drawing.Point(1085,this.textBox2.Location.Y+20);
			this.textBox3.TabIndex=25;
			// 
			// isometric
			// 
			this.isometric.Location = new System.Drawing.Point(1060, this.textBox3.Location.Y+20);
			this.isometric.Name = "isometric";
			this.isometric.TabStop = true;
			this.isometric.Text = "изометриеческая";
			this.isometric.UseVisualStyleBackColor = true;
			this.isometric.AutoSize = true;
			this.isometric.TabIndex = 26;
			// 
			//	orthographic
			// 
			this.orthographic.Location = new System.Drawing.Point(1060, this.isometric.Location.Y+20);
			this.orthographic.Name = "orthographic";
			this.orthographic.TabStop = true;
			this.orthographic.Text = "Ортографическая";
			this.orthographic.UseVisualStyleBackColor = true;
			this.orthographic.AutoSize = true;
			this.orthographic.TabIndex = 27;
			// 
         // comboBox2
         // 
         this.comboBox2.FormattingEnabled = true;
         this.comboBox2.Items.AddRange(new object[] {
         "xy",
         "zx",
         "yz"});
         this.comboBox2.Location = new System.Drawing.Point(1070, this.orthographic.Location.Y+20);
         this.comboBox2.Name = "comboBox2";
         this.comboBox2.Size = new System.Drawing.Size(121, 21);
         this.comboBox2.Text = "Выберите плоскость";
         this.comboBox2.TabIndex=28;
         // 
         // button11
         // 
         this.button11.Location = new System.Drawing.Point(1070, this.comboBox2.Location.Y+25);
         this.button11.Name = "button11";
         this.button11.AutoSize=true;
         this.button11.TabIndex = 29;
         this.button11.Text = "Отобразить";
         this.button11.UseVisualStyleBackColor = true;
         this.button11.Click += new System.EventHandler(this.button11_Click);
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Items.AddRange(new object[] {
         "Тетраэдр",
         "Гексаэдр",
         "Октаэдр",
         "Икосаэдр"});
         this.comboBox1.Location = new System.Drawing.Point(25, 599);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(121, 21);
         this.comboBox1.TabIndex = 20;
         this.comboBox1.Text = "Выберите фигуру";
         this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
         // 
		// comboBox3
		// 
		this.comboBox3.FormattingEnabled = true;
		this.comboBox3.Items.AddRange(new object[] {
		"x+y",
		"x-y",
		"x^2+y^2",
		"x^2-y^2"});
		this.comboBox3.Location = new System.Drawing.Point(1065, this.button11.Location.Y+40);
		this.comboBox3.Name = "comboBox3";
		this.comboBox3.Size = new System.Drawing.Size(122, 21);
		this.comboBox3.TabIndex = 30;
		this.comboBox3.Text = "Functions";
		// 
		// textBox4
		// 
		this.textBox4.Location = new System.Drawing.Point(1070, this.comboBox3.Location.Y+25);
		this.textBox4.Name = "textBox4";
		this.textBox4.Size = new System.Drawing.Size(101, 20);
		this.textBox4.Text = "x0,x1";
		this.textBox4.TabIndex=31;
		// 
		// textBox5
		// 
		this.textBox5.Location = new System.Drawing.Point(1070, this.textBox4.Location.Y+25);
		this.textBox5.Name = "textBox5";
		this.textBox5.Size = new System.Drawing.Size(101, 20);
		this.textBox5.Text = "y0,y1";
		this.textBox5.TabIndex=32;
		// 
		// textBox6
		// 
		this.textBox6.Location = new System.Drawing.Point(1070, this.textBox5.Location.Y+25);
		this.textBox6.Name = "textBox6";
		this.textBox6.Size = new System.Drawing.Size(101, 20);
		this.textBox6.Text = "1";
		this.textBox6.TabIndex=33;
		// 
		// button12
		// 
		this.button12.Location = new System.Drawing.Point(1080, this.textBox6.Location.Y+25);
		this.button12.Name = "button12";
		this.button12.Size = new System.Drawing.Size(101, 23);
		this.button12.TabIndex = 34;
		this.button12.Text = "Draw";
		this.button12.UseVisualStyleBackColor = true;
		this.button12.Click += new System.EventHandler(this.draw_click);
		// 
        // button13
         // 
         this.button13.Location = new System.Drawing.Point(1090, this.button12.Location.Y+50);
         this.button13.Name = "button13";
         this.button13.AutoSize=true;
         this.button13.Text = "Load";
         this.button13.UseVisualStyleBackColor = true;
         this.button13.Click += new System.EventHandler(but13_click);
         this.button13.TabIndex=35;
         // 
		// textBox7
		// 
		this.textBox7.Location = new System.Drawing.Point(1070, this.button13.Location.Y+40);
		this.textBox7.Name = "textBox7";
		this.textBox7.Size = new System.Drawing.Size(101, 20);
		this.textBox7.Text = "step";
		this.textBox7.TabIndex=36;
         // 
         // button14
         // 
         this.button14.Location = new System.Drawing.Point(1090, this.textBox7.Location.Y+25);
         this.button14.Name = "button14";
         this.button14.AutoSize=true;
         this.button14.Text = "Make Figure";
         this.button14.TabIndex=37;
         this.button14.UseVisualStyleBackColor = true;
         this.button14.Click += new System.EventHandler(but14_click);
		// 
		// button15
		// 
		this.button15.Location = new System.Drawing.Point(1090, 630);
		this.button15.Name = "button15";
		this.button15.AutoSize = true;
		this.button15.Text = "Save";
		this.button15.TabIndex = 38;
		this.button15.UseVisualStyleBackColor = true;
		this.button15.Click += new System.EventHandler(Button15_Click);
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1200, 654);
         this.Controls.Add(this.button15);
         this.Controls.Add(this.textBox7);
         this.Controls.Add(this.button14);
         this.Controls.Add(this.button13);
         this.Controls.Add(this.textBox6);
         this.Controls.Add(this.textBox5);
         this.Controls.Add(this.textBox4);
         this.Controls.Add(this.button12);
         this.Controls.Add(this.comboBox3);
         this.Controls.Add(this.comboBox2);
         this.Controls.Add(this.label14);
         this.Controls.Add(this.label15);
         this.Controls.Add(this.label16);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.isometric);
         this.Controls.Add(this.orthographic);
         this.Controls.Add(this.comboBox1);
         this.Controls.Add(this.button11);
         this.Controls.Add(this.button10);
         this.Controls.Add(this.button9);
         this.Controls.Add(this.button8);
         this.Controls.Add(this.button7);
         this.Controls.Add(this.axis_angle);
         this.Controls.Add(this.label13);
         this.Controls.Add(this.label12);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.button6);
         this.Controls.Add(this.button5);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.z_rotate);
         this.Controls.Add(this.y_rotate);
         this.Controls.Add(this.x_rotate);
         this.Controls.Add(this.z_scale);
         this.Controls.Add(this.y_scale);
         this.Controls.Add(this.x_scale);
         this.Controls.Add(this.z_shift);
         this.Controls.Add(this.y_shift);
         this.Controls.Add(this.x_shift);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.center);
         this.Controls.Add(this.pictureBox);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.x_shift)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.y_shift)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.z_shift)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.x_scale)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.y_scale)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.z_scale)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.x_rotate)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.y_rotate)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.z_rotate)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.axis_angle)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();
		}
		
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;	
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown x_shift;
		private System.Windows.Forms.NumericUpDown y_shift;
		private System.Windows.Forms.NumericUpDown z_shift;
		private System.Windows.Forms.NumericUpDown x_scale;
		private System.Windows.Forms.NumericUpDown y_scale;
		private System.Windows.Forms.NumericUpDown z_scale;
		private System.Windows.Forms.NumericUpDown x_rotate;
		private System.Windows.Forms.NumericUpDown y_rotate;
		private System.Windows.Forms.NumericUpDown z_rotate;
		private System.Windows.Forms.NumericUpDown axis_angle;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.RadioButton center;
		private System.Windows.Forms.RadioButton isometric;
		private System.Windows.Forms.RadioButton orthographic;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
	}
}
