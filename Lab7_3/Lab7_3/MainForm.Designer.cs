/*
 * Сделано в SharpDevelop.
 * Пользователь: Oleg
 * Дата: 22.11.2017
 * Время: 20:28
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace Lab7_3
{
	partial class MainForm
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.button6 = new System.Windows.Forms.Button();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.button7 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"x+y",
			"x-y",
			"x^2+y^2",
			"x^2-y^2"});
			this.comboBox1.Location = new System.Drawing.Point(12, 13);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(122, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "Functions";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 41);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(101, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "x0,x1";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 68);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(101, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "y0,y1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 121);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Draw";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.draw_click);
			// 
			// pictureBox
			// 
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox.Location = new System.Drawing.Point(140, 13);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(750, 671);
			this.pictureBox.TabIndex = 4;
			this.pictureBox.TabStop = false;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 95);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(101, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "Step";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 150);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "Move";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 179);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(101, 23);
			this.button3.TabIndex = 13;
			this.button3.Text = "Turn";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 208);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(101, 23);
			this.button4.TabIndex = 17;
			this.button4.Text = "Scale";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click+= new System.EventHandler(this.button2_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 296);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(101, 23);
			this.button5.TabIndex = 18;
			this.button5.Text = "Scale around axis";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click+=new System.EventHandler(this.button9_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(13, 243);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 19;
			this.textBox4.Text = "Angle to turn around axis";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"OX",
			"OY",
			"OZ"});
			this.comboBox2.Location = new System.Drawing.Point(12, 269);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 20;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(9, 344);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(102, 17);
			this.radioButton1.TabIndex = 21;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "перспективная";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(17, 374);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 22;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(17, 401);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 23;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(17, 427);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 20);
			this.textBox7.TabIndex = 24;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(9, 453);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(109, 17);
			this.radioButton2.TabIndex = 25;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "изометрическая";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(9, 476);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(114, 17);
			this.radioButton3.TabIndex = 26;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "ортографическая";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(27, 526);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 27;
			this.button6.Text = "Отобразить";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
			"XY",
			"ZX",
			"YZ"});
			this.comboBox3.Location = new System.Drawing.Point(17, 499);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(96, 21);
			this.comboBox3.TabIndex = 28;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(27, 661);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 29;
			this.button7.Text = "Clear";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(902, 696);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Name = "MainForm";
			this.Text = "Lab7_3";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
