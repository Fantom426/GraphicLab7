using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab7
{
	public delegate double Functions(double x, double y);
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Form1 : Form
	{
		double plus(double x, double y){
			return x+y;
		}
		double minus(double x, double y){
			return x-y;
		}
		double sum_squares(double x, double y){
			return x*x+y*y;
		}
		double minus_squares(double x, double y){
			return x*x-y*y;
		}
		
		Bitmap bmp;
		Graphics g;
		Pen pen_facets = new Pen(Color.Green);
		Pen pen_lines = new Pen(Color.Gray);
		int centerX, centerY;
		bool is_axis = false;
		point3D axis_P1, axis_P2;
		List<facet> facets = new List<facet>();
		List<point3D> points = new List<point3D>();
		double[,] center_matr = new double[4,4];
		double[,] isometric_matr = new double[4,4];
		double[,] ortographic_matr = new double[4,4];
		List<List<point3D>> pts_rotate = new List<List<point3D>>();
		int clcs=0;
	
		public Form1()
		{	
			InitializeComponent();
			bmp = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
			pictureBox.Image = bmp; centerX = pictureBox.Width / 2; centerY = pictureBox.Height / 2;
			this.center_matr[3,3]=1;
			this.isometric_matr[3,3]=1;
			this.ortographic_matr[3,3]=1;
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			g = Graphics.FromImage(bmp);
		}
		
		private void initialize_points()
		{
			points.Clear();
			foreach (facet sh in facets)
			    for (int i = 0; i < sh.points.Count; i++)
			        if (!points.Contains(sh.points[i]))
			            points.Add(sh.points[i]);
		}
		
		private void draw_point(point3D p)
		{
			g.FillEllipse(new SolidBrush(Color.Gray), (int)Math.Round(p.X + centerX - 6), 
																	(int)Math.Round(-p.Y + centerY - 6), 12, 12);
		}
		
		private void draw_point_rotate(point3D p)
		{
			g.FillEllipse(new SolidBrush(Color.Green), (int)Math.Round(p.X + centerX - 3), 
																	(int)Math.Round(-p.Y + centerY - 3), 6, 6);
		}
		
		private void draw_facet(facet f)
		{
			int n = f.points.Count - 1;
			int x1 = (int)Math.Round(f.points[0].X + centerX); int x2 = (int)Math.Round(f.points[n].X + centerX);
			int y1 = (int)Math.Round(-f.points[0].Y + centerY); int y2 = (int)Math.Round(-f.points[n].Y + centerY);
			g.DrawLine(pen_facets, x1, y1, x2, y2);
			
			for (int i = 0; i < n; i++)
			{
			    x1 = (int)Math.Round(f.points[i].X + centerX); x2 = (int)Math.Round(f.points[i + 1].X + centerX);
			    y1 = (int)Math.Round(-f.points[i].Y + centerY); y2 = (int)Math.Round(-f.points[i + 1].Y + centerY);
			    g.DrawLine(pen_facets, x1, y1, x2, y2);
			}
		}
		
		private void redraw_image()
		{
			g.Clear(Color.White);
			foreach (facet f in facets)
			    draw_facet(f);
			if (axis_P1 != null && axis_P2 != null)
			{
			    draw_point(axis_P1);
			    draw_point(axis_P2);
			    g.DrawLine(pen_lines, (int)Math.Round(axis_P1.X + centerX), (int)Math.Round(-axis_P1.Y + centerY), (int)Math.Round(axis_P2.X + centerX), (int)Math.Round(-axis_P2.Y + centerY));
			}
			pictureBox.Image = bmp;
		}
		
		private void add_points_to_tetrahedron(int size)
		{
			double h = Math.Sqrt(3) * size;
			
			var p1 = new point3D(-size, -h / 2, 0);
			var p2 = new point3D(0, -h / 2, -h);
			var p3 = new point3D(size, -h / 2, 0);
			var p4 = new point3D(0, h / 2, 0);
			
			var f1 = new facet();
			f1.add(p1); f1.add(p2); f1.add(p3);
			facets.Add(f1);
			var f2 = new facet();
			f2.add(p1); f2.add(p4); f2.add(p2);
			facets.Add(f2);
			var f3 = new facet();
			f3.add(p4); f3.add(p2); f3.add(p3);
			facets.Add(f3);
			var f4 = new facet();
			f4.add(p1); f4.add(p4); f4.add(p3);
			facets.Add(f4);
		}
		
		private void add_points_to_ikosaedr(int size)
		{
			var p1 = new point3D(-size * 1 / 2, size, 0);
			var p2 = new point3D(size * 1 / 2, size, 0);
			var p3 = new point3D(0, size * 1 / 2, size);
			var p4 = new point3D(0, -size * 1 / 2, size);
			var p5 = new point3D(-size * 1 / 2, -size, 0);
			var p6 = new point3D(size * 1 / 2, -size, 0);
			var p7 = new point3D(-size, 0, size * 1 / 2);
			var p8 = new point3D(-size, 0, -size * 1 / 2);
			var p9 = new point3D(size, 0, size * 1 / 2);
			var p10 = new point3D(size, 0, -size * 1 / 2);
			var p11 = new point3D(0, size * 1 / 2, -size);
			var p12 = new point3D(0, -size * 1 / 2, -size);
			
			var f1 = new facet();
			f1.add(p1); f1.add(p2); f1.add(p3);
			facets.Add(f1);
			var f2 = new facet();
			f2.add(p1); f2.add(p3); f2.add(p7);
			facets.Add(f2);
			var f3 = new facet();
			f3.add(p1); f3.add(p8); f3.add(p11);
			facets.Add(f3);
			var f4 = new facet();
			f4.add(p1); f4.add(p2); f4.add(p11);
			facets.Add(f4);
			var f5 = new facet();
			f5.add(p1); f5.add(p7); f5.add(p8);
			facets.Add(f5);
			var f6 = new facet();
			f6.add(p2); f6.add(p3); f6.add(p9);
			facets.Add(f6);
			var f7 = new facet();
			f7.add(p2); f7.add(p9); f7.add(p10);
			facets.Add(f7);
			var f8 = new facet();
			f8.add(p2); f8.add(p10); f8.add(p11);
			facets.Add(f8);
			var f9 = new facet();
			f9.add(p3); f9.add(p4); f9.add(p7);
			facets.Add(f9);
			var f10 = new facet();
			f10.add(p3); f10.add(p4); f10.add(p9);
			facets.Add(f10);
			var f11 = new facet();
			f11.add(p4); f11.add(p5); f11.add(p7);
			facets.Add(f11);
			var f12 = new facet();
			f12.add(p4); f12.add(p5); f12.add(p6);
			facets.Add(f12);
			var f13 = new facet();
			f13.add(p4); f13.add(p6); f13.add(p9);
			facets.Add(f13);
			var f14 = new facet();
			f14.add(p5); f14.add(p7); f14.add(p8);
			facets.Add(f14);
			var f15 = new facet();
			f15.add(p5); f15.add(p8); f15.add(p12);
			facets.Add(f15);
			var f16 = new facet();
			f16.add(p5); f16.add(p6); f16.add(p12);
			facets.Add(f16);
			var f17 = new facet();
			f17.add(p6); f17.add(p9); f17.add(p10);
			facets.Add(f17);
			var f18 = new facet();
			f18.add(p6); f18.add(p10); f18.add(p12);
			facets.Add(f18);
			var f19 = new facet();
			f19.add(p8); f19.add(p11); f19.add(p12);
			facets.Add(f19);
			var f20 = new facet();
			f20.add(p10); f20.add(p11); f20.add(p12);
			facets.Add(f20);
		}
		
		private void add_points_to_cube(int size)
		{
			var p1 = new point3D(-size, -size, -size);
			var p2 = new point3D(-size, size, -size);
			var p3 = new point3D(size, size, -size);
			var p4 = new point3D(size, -size, -size);
			var p5 = new point3D(-size, -size, size);
			var p6 = new point3D(-size, size, size);
			var p7 = new point3D(size, size, size);
			var p8 = new point3D(size, -size, size);
			
			var f1 = new facet();
			f1.add(p1); f1.add(p2); f1.add(p3); f1.add(p4);
			facets.Add(f1);
			var f2 = new facet();
			f2.add(p1); f2.add(p2); f2.add(p6); f2.add(p5);
			facets.Add(f2);
			var f3 = new facet();
			f3.add(p5); f3.add(p6); f3.add(p7); f3.add(p8);
			facets.Add(f3);
			var f4 = new facet();
			f4.add(p4); f4.add(p3); f4.add(p7); f4.add(p8);
			facets.Add(f4);
			var f5 = new facet();
			f5.add(p2); f5.add(p6); f5.add(p7); f5.add(p3);
			facets.Add(f5);
			var f6 = new facet();
			f6.add(p1); f6.add(p5); f6.add(p8); f6.add(p4);
			facets.Add(f6);
		}
		
		private void add_points_to_octahedron(int size)
		{
			double a = Math.Sqrt(3) * size;
			double p = (a + a + (size / 2)) / 2;
			double h = 2 * Math.Sqrt(p * (p - (size / 2)) * (p - a) * (p - a)) / (size / 2);
			
			var p1 = new point3D(0, -h, 0);
			var p2 = new point3D(-size, 0, -size);
			var p3 = new point3D(0, h, 0);
			var p4 = new point3D(size, 0, -size);
			var p5 = new point3D(-size, 0, size);
			var p6 = new point3D(size, 0, size);
			
			var f1 = new facet();
			f1.add(p2); f1.add(p3); f1.add(p4);
			facets.Add(f1);
			var f2 = new facet();
			f2.add(p2); f2.add(p1); f2.add(p4);
			facets.Add(f2);
			var f3 = new facet();
			f3.add(p2); f3.add(p3); f3.add(p5);
			facets.Add(f3);
			var f4 = new facet();
			f4.add(p2); f4.add(p1); f4.add(p5);
			facets.Add(f4);
			var f5 = new facet();
			f5.add(p4); f5.add(p3); f5.add(p6);
			facets.Add(f5);
			var f6 = new facet();
			f6.add(p4); f6.add(p1); f6.add(p6);
			facets.Add(f6);
			var f7 = new facet();
			f7.add(p5); f7.add(p3); f7.add(p6);
			facets.Add(f7);
			var f8 = new facet();
			f8.add(p5); f8.add(p1); f8.add(p6);
			facets.Add(f8);
		}
		
		private void displacement(int kx, int ky, int kz)
		{
			foreach (point3D p in points)
			{
			    p.X += kx;
			    p.Y += ky;
			    p.Z += kz;
			}
		}
		
		private void rotate(double xAngle, double yAngle, double zAngle)
		{
			foreach (point3D p in points)
			{
			    rotate_0X(p, xAngle);
			    rotate_0Y(p, yAngle);
			    rotate_0Z(p, zAngle);
			}
		}
		
		private void rotate_0X(point3D p, double angle)
		{
			double y = p.Y;
			double z = p.Z;
			p.Y = y * Math.Cos(angle) + z * Math.Sin(angle);
			p.Z = y * -Math.Sin(angle) + z * Math.Cos(angle);
		}
		
		private void rotate_0Y(point3D p, double angle)
		{
			double x = p.X;
			double z = p.Z;
			p.X = x * Math.Cos(angle) + z * -Math.Sin(angle);
			p.Z = x * Math.Sin(angle) + z * Math.Cos(angle);
		}
		
		private void rotate_0Z(point3D p, double angle)
		{
			double x = p.X;
			double y = p.Y;
			p.X = x * Math.Cos(angle) + y * Math.Sin(angle);
			p.Y = x * -Math.Sin(angle) + y * Math.Cos(angle);
		}
		
		private point3D center_point()
		{
			double sumX = 0, sumY = 0, sumZ = 0;
			int count = 0;
			for (int i = 0; i < facets.Count; i++)
			    for (int j = 0; j < facets[i].points.Count; j++)
			    {
			        sumX += facets[i].points[j].X;
			        sumY += facets[i].points[j].Y;
			        sumZ += facets[i].points[j].Z;
			        ++count;
			    }
			return new point3D(sumX / count, sumY / count, sumZ / count);
		}
		
		private void scaling(double xScale, double yScale, double zScale)
		{
			point3D center_P = center_point();
			foreach (point3D p in points)
			{
			    p.X -= center_P.X;
			    p.Y -= center_P.Y;
			    p.Z -= center_P.Z;
			
			    p.X *= xScale;
			    p.Y *= yScale;
			    p.Z *= zScale;
			
			    p.X += center_P.X;
			    p.Y += center_P.Y;
			    p.Z += center_P.Z;
			}
		}
		
		private void reflection(int ind)
		{
			switch (ind) {
				case 1:
					foreach (point3D p in points)
						p.Z = -p.Z;
					break;
				case 2:
					foreach (point3D p in points)
						p.Y = -p.Y;
					break;
				case 3:
					foreach (point3D p in points)
						p.X = -p.X;
					break;
			}
			}
			
		private point3D normalize_vector(point3D pt1, point3D pt2){
			double x = pt2.X - pt1.X;
			double y = pt2.Y - pt1.Y;
			double z = pt2.Z - pt1.Z;
			double length = Math.Sqrt(x * x + y * y + z * z);
			return new point3D(x / length, y / length, z / length);
		}
		
		private void button1_Click(object sender, EventArgs e)  // перенос
		{
			int kx = (int)x_shift.Value, ky = (int)y_shift.Value, kz = (int)z_shift.Value;
			displacement(kx, ky, kz);
			redraw_image();
		}
		
		private void button2_Click(object sender, EventArgs e)  // масштабирование
		{
			scaling((double)x_scale.Value, (double)y_scale.Value, (double)z_scale.Value);
			redraw_image();
		}
		
		private void button3_Click(object sender, EventArgs e)  // поворот
		{
			double x_angle = ((double)x_rotate.Value * Math.PI) / 180;
			double y_angle = ((double)y_rotate.Value * Math.PI) / 180;
			double z_angle = ((double)z_rotate.Value * Math.PI) / 180;
			rotate(x_angle, y_angle, z_angle);
			redraw_image();
		}
		
		private void button4_Click(object sender, EventArgs e)
		{
			reflection(3);
			redraw_image();
		}
		
		private void button5_Click(object sender, EventArgs e)
		{
			reflection(2);
			redraw_image();
		}
		
		private void button6_Click(object sender, EventArgs e)
		{
			reflection(1);
			redraw_image();
		}
		
		private void button7_Click(object sender, EventArgs e)  // выбираем точки для поворота вокруг оси
		{
			if (axis_P1 != null)
			{
			    axis_P1 = axis_P2 = null;
			    redraw_image();
			}
			is_axis = true;
		}
		
		private void button8_Click(object sender, EventArgs e)
		{
			axis_P1 = axis_P2 = null;
			redraw_image();
		}
		
		private void button9_Click(object sender, EventArgs e)  // поворот вокруг оси
		{
			if (axis_P1 == null || axis_P2 == null)
			{
			    MessageBox.Show("Выберите ось!", "Ошибка", MessageBoxButtons.OK);
			    return;
			}
			double axisAngle = ((double)axis_angle.Value * Math.PI) / 180;
			axis_rotate(axis_P1, axis_P2, axisAngle);
			redraw_image();
		}
		
		private void button10_Click(object sender, EventArgs e)
		{
			axis_P1=axis_P2=null;
			points.Clear();
			facets.Clear();
			pts_rotate.Clear();
			g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox.Size.Width, pictureBox.Size.Height);
			pictureBox.Invalidate();
		}
		
		private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			facets.Clear();
			switch (comboBox1.SelectedItem.ToString()) {
				case "Тетраэдр":
					add_points_to_tetrahedron(100);
					break;
				case "Октаэдр":
					add_points_to_octahedron(100);
					break;
				case "Гексаэдр":
					add_points_to_cube(100);
					break;
				case "Икосаэдр":
					add_points_to_ikosaedr(200);
					break;
			}
			
			initialize_points();
			redraw_image();
		}
		
		private void pictureBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (!is_axis || e.Button != System.Windows.Forms.MouseButtons.Left)
			    return;
			if (axis_P1 == null){
				pts_rotate.Add(new List<point3D>());
			    axis_P1 = new point3D((e.X - centerX), (-e.Y + centerY), 0);
			    draw_point(axis_P1);
			}
			else if (axis_P2 == null){
			    axis_P2 = new point3D((e.X - centerX), (-e.Y + centerY), 0);
			    draw_point(axis_P2);
			    g.DrawLine(pen_lines, (int)Math.Round(axis_P1.X + centerX), (int)Math.Round(-axis_P1.Y + centerY), 
			    							  (int)Math.Round(axis_P2.X + centerX), (int)Math.Round(-axis_P2.Y + centerY));
			}
			else{
				if (clcs==0) return;
				point3D pt = new point3D((e.X - centerX), (-e.Y + centerY), 0);
				pts_rotate[0].Add(pt);
				draw_point_rotate(pt);
			}
			pictureBox.Image = bmp;
		}
		
		private void axis_rotate(point3D pt1, point3D pt2, double angle)
		{
			point3D c = normalize_vector(pt1, pt2);
			double x = c.X, y = c.Y, z = c.Z;
			double d = Math.Sqrt(y * y + z * z);
			double alpha = -Math.Asin(y / d);
			double beta = Math.Asin(x);
			
			foreach (point3D p in points)
			{
			    // перенос первой точки вектора в начало координат
			    p.X -= pt1.X;
			    p.Y -= pt1.Y;
			    p.Z -= pt1.Z;
			
			    //повороты - ось вращения совпадает с осью z, для этого вращаем сначала вокруг оси x, затем вокруг y
			    rotate_0X(p, alpha);
			    rotate_0Y(p, beta);
			    rotate_0Z(p, angle);
			    rotate_0Y(p, -beta);
			    rotate_0X(p, -alpha);
			
			    p.X += pt1.X;
			    p.Y += pt1.Y;
			    p.Z += pt1.Z;
			}
		}
		
		private void rotate_0X_new(ref point3D p, double angle)
		{
			double y = p.Y;
			double z = p.Z;
			p.Y = y * Math.Cos(angle) + z * Math.Sin(angle);
			p.Z = y * -Math.Sin(angle) + z * Math.Cos(angle);
		}
		
		private void rotate_0Y_new(ref point3D p, double angle)
		{
			double x = p.X;
			double z = p.Z;
			p.X = x * Math.Cos(angle) + z * -Math.Sin(angle);
			p.Z = x * Math.Sin(angle) + z * Math.Cos(angle);
		}
		
		private void rotate_0Z_new(ref point3D p, double angle)
		{
			double x = p.X;
			double y = p.Y;
			p.X = x * Math.Cos(angle) + y * Math.Sin(angle);
			p.Y = x * -Math.Sin(angle) + y * Math.Cos(angle);
		}
		
		private point3D axis_rotate_point(point3D pt1, point3D pt2, point3D p, double angle){
			point3D c = normalize_vector(pt1, pt2);
			
			double x = c.X, y = c.Y, z = c.Z;
			double d = Math.Sqrt(y * y + z * z);
			double alpha = -Math.Asin(y / d);
			double beta = Math.Asin(x);
			point3D new_p = new point3D(p.X,p.Y,p.Z);
			new_p.X -= pt1.X;
			new_p.Y -= pt1.Y;
			new_p.Z -= pt1.Z;
			
			rotate_0X_new(ref new_p, alpha);
			rotate_0Y_new(ref new_p, beta);
			rotate_0Z_new(ref new_p, angle);
			rotate_0Y_new(ref new_p, -beta);
			rotate_0X_new(ref new_p, -alpha);
			
			new_p.X += pt1.X;
			new_p.Y += pt1.Y;
			new_p.Z += pt1.Z;
			
			return new_p;
		}
		
		private void button11_Click(object sender, EventArgs e)
		{
			var new_f = new List<facet>();
			if (this.center.Checked){
				center_matr[0,3]=0;
				center_matr[1,3]=0;
				center_matr[2,3]=0;
				double xx = Int32.Parse(textBox1.Text);
				if (xx != 0)
					center_matr[0,3]=-1/xx;
				double yy = Int32.Parse(textBox2.Text);
				if (yy != 0)
					center_matr[1,3]=-1/yy;
				double zz = Int32.Parse(textBox3.Text);
				if (zz != 0)
					center_matr[2,3]=-1/zz;
				center_matr[0,0]=1;
				center_matr[1,1]=1;
				foreach (facet f in facets){
					var ff=new facet();
					foreach (point3D pt in f.points) {
						double x = pt.X*center_matr[0,0]+pt.Y*center_matr[1,0]+pt.Z*center_matr[2,0]+center_matr[3,0];
						double y = pt.X*center_matr[0,1]+pt.Y*center_matr[1,1]+pt.Z*center_matr[2,1]+center_matr[3,1];
						double d = pt.X*center_matr[0,3]+pt.Y*center_matr[1,3]+pt.Z*center_matr[2,3]+center_matr[3,3];
						double t = 1 / d;					
						x*=t; y*=t;
						ff.add(new point3D(x,y,0));
					}
					new_f.Add(ff);
				}
				
			}
			else if (isometric.Checked){
				const double rad = 120 * Math.PI / 180D;
				double sin = Math.Sin(rad);
				double cos = Math.Cos(rad);
				isometric_matr[0,0]=cos;
				isometric_matr[0,1]=sin*sin;
				isometric_matr[1,1]=cos;
				isometric_matr[2,0]=sin;
				isometric_matr[2,1]=-sin*cos;
				isometric_matr[3,3]=1;
				
				foreach (facet f in facets){
					var ff=new facet();
					foreach (point3D pt in f.points) {
						double x = pt.X*isometric_matr[0,0]+pt.Y*isometric_matr[1,0]+pt.Z*isometric_matr[2,0]+isometric_matr[3,0];
						double y = pt.X*isometric_matr[0,1]+pt.Y*isometric_matr[1,1]+pt.Z*isometric_matr[2,1]+isometric_matr[3,1];
						
						ff.add(new point3D(x,y,0));
					}
					new_f.Add(ff);
				}
			}
			else if (orthographic.Checked){
				ortographic_matr[3,3]=1;
				switch (comboBox2.SelectedItem.ToString()) {
					case "xy":
						ortographic_matr[0, 0] = 1;
						ortographic_matr[1, 1] = 1;
						break;
					case "zx":
						ortographic_matr[0, 0] = 1;
						ortographic_matr[2, 2] = 1;
						break;
					case "yz":
						ortographic_matr[1, 1] = 1;
						ortographic_matr[2, 2] = 1;
						break;
				}
				foreach (facet f in facets){
					var ff=new facet();
					foreach (point3D pt in f.points) {
						double x = pt.X*ortographic_matr[0,0]+pt.Y*ortographic_matr[1,0]+pt.Z*ortographic_matr[2,0]+ortographic_matr[3,0];
						double y = pt.X*ortographic_matr[0,1]+pt.Y*ortographic_matr[1,1]+pt.Z*ortographic_matr[2,1]+ortographic_matr[3,1];
						double z = pt.X*ortographic_matr[0,2]+pt.Y*ortographic_matr[1,2]+pt.Z*ortographic_matr[2,2]+ortographic_matr[3,2];
						
						if (z == 0)
							ff.add(new point3D(x,y,0));
						else if (y == 0)
							ff.add(new point3D(x, z, 0));
						else if (x == 0)
							ff.add(new point3D(y, z, 0));
						
					}
					new_f.Add(ff);
				}
			}
			for(int i = 0; i < 4; i++)
				for(int g = 0; g < 4; g++)
					ortographic_matr[i,g]=0;
			var fff = new Form2(new_f);
				fff.Show();    
		}
		
		void draw_click(object sender, System.EventArgs e){
			Functions f = plus;
			switch (comboBox3.SelectedIndex){
				case 0:
					break;
				case 1:
					f=minus;
					break;
				case 2:
					f=sum_squares;
					break;
				case 3:
					f=minus_squares;
					break;
			}
			var ss = textBox4.Text.Split(',');
			int x0 = Int32.Parse(ss[0]); int x1 = Int32.Parse(ss[1]);
			ss = textBox5.Text.Split(',');
			int y0 = Int32.Parse(ss[0]); int y1 = Int32.Parse(ss[1]);
			int step = Int32.Parse(textBox6.Text);
			
			int i = x0;
			int g = y0;
			
			int ky = (y1-y0)/step+1;
			int kx = (x1-x0)/step+1;
			
			while (i<=x1){
				g=y0;
				while (g<=y1) {
					points.Add(new point3D(i,g,f(i,g)));
					g+=step;
				}
				i+=step;
			}
			
			for(int q = 0; q<ky-1; q++){
				for (int w = 0; w < kx-1; w++) {
					var fac = new facet();
					fac.add(points[ky*q+w]);
					fac.add(points[ky*q+w+1]);
					fac.add(points[ky*(q+1)+w+1]);
					fac.add(points[ky*(q+1)+w]);
					facets.Add(fac);
				}
			}
			initialize_points();
			redraw_image();
		}
		
		void but13_click(object sender, System.EventArgs e){
			OpenFileDialog load_points = new OpenFileDialog();
			load_points.ShowDialog();
			if (!load_points.CheckFileExists){
				MessageBox.Show("Choose File");
				return;
			}
			
			string[] lines = File.ReadAllLines(load_points.FileName);
			var size_lines = lines.Length;
			for (int i = 0; i < size_lines; i++){
				string[] pts = lines[i].Split(';');
				var pts_count = pts.Length;
				var f = new facet();
				for (int g = 0; g < pts_count; g++) {
					string s = pts[g].TrimStart(' ');
					string[] xyz = s.Split(' ');
					var x = Double.Parse(xyz[0]);
					var y = Double.Parse(xyz[1]);
					var z = Double.Parse(xyz[2]);
					f.add(new point3D(x,y,z));
				}
				facets.Add(f);
			}
			initialize_points();
			redraw_image();
		}
		
		void but14_click(object sender, System.EventArgs e){
			clcs++;
			if (clcs<2) return;
			clcs=0;
			double steps = Int32.Parse(textBox7.Text);
			double angle = ((360.0/steps)* Math.PI) / 180D;

			for (int i = 0; i < steps; i++) {
				pts_rotate.Add(new List<point3D>());
				int sz = pts_rotate[i].Count;
				for (int g = 0; g < sz; g++)
					pts_rotate[i+1].Add(axis_rotate_point(axis_P1,axis_P2,pts_rotate[i][g], angle));
			}

			for (int i = 0; i < pts_rotate.Count-1; i++) {
				for (int g = 0; g < pts_rotate[i].Count-1; g++) {
					var fac = new facet();
					fac.add(pts_rotate[i][g]);
					fac.add(pts_rotate[i][g+1]);
					fac.add(pts_rotate[i+1][g+1]);
					fac.add(pts_rotate[i+1][g]);
					facets.Add(fac);
				}
			}
			axis_P1=axis_P2=null;
			initialize_points();
			redraw_image();
		}

		private void Button15_Click(object sender, System.EventArgs e)
		{
			int sz = facets.Count;
			List<string> res = new List<string>();
			for (int i = 0; i < sz; i++)
			{
				var f = facets[i];
				int c_pts = f.points.Count;
				string s = "";
				for (int g = 0; g < c_pts - 1; g++)
				{
					var pt = f.points[g];
					s += pt.X.ToString() + " " + pt.Y.ToString() + " " + pt.Z.ToString();
					s += "; ";
				}
				s += f.points[c_pts - 1].X.ToString() + " " + f.points[c_pts - 1].Y.ToString() +" "+ f.points[c_pts - 1].Z.ToString();
				res.Add(s);
			}
			File.WriteAllLines("saved_figure.txt", res.ToArray());
		}
	}

    public class point3D
    {
        public double X, Y, Z;

        public point3D()
        {
            this.X = this.Y = this.Z = 0;
        }

        public point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }

    public class facet
    {
        public List<point3D> points;

        public facet()
        {
            points = new List<point3D>();
        }

        public void add(point3D p)
        {
            points.Add(p);
        }
        public bool is_visible()
        {
            point3D p1 = points[0];
            point3D p2 = points[1];
            point3D p3 = points[2];
            double aX = p2.X - p1.X;
            double aY = p2.Y - p1.Y;
            double aZ = p2.Z - p1.Z;
            double bX = p3.X - p2.X;
            double bY = p3.Y - p2.Y;
            double bZ = p3.Z - p2.Z;

            var n = new point3D(aY * bZ - aZ * bY, aZ * bX - aX * bZ, aX * bY - aY * bX);
            return (aX * bY - aY * bX <= 0);
        }
	}
}
