using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7_3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public delegate double Functions(double x, double y);
	
	
	public partial class MainForm : Form
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
		point3D axis_P1, axis_P2;
		private System.Collections.Generic.List<Lab7_3.facet> facets;
		private System.Collections.Generic.List<Lab7_3.point3D> points;
		double[,] center_matr = new double[4,4];
		double[,] isometric_matr = new double[4,4];
		double[,] ortographic_matr = new double[4,4];
		private System.Collections.Generic.List<Lab7_3.point3D> axises;
	
		public MainForm()
		{	
			facets = new List<facet>();
			points = new List<point3D>();
			axises = new List<point3D>();
			InitializeComponent();
			bmp = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
			pictureBox.Image = bmp; centerX = pictureBox.Width / 2; centerY = pictureBox.Height / 2;
			this.center_matr[3,3]=1;
			this.isometric_matr[3,3]=1;
			this.ortographic_matr[3,3]=1;
			axises.Add(new point3D(0,0,300));
			axises.Add(new point3D(0,300,0));
			axises.Add(new point3D(300,0,0));
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
			g.FillEllipse(new SolidBrush(Color.Gray), (int)Math.Round(p.X + centerX - 6), (int)Math.Round(-p.Y + centerY - 6), 12, 12);
			//g.FillEllipse(new SolidBrush(Color.Gray), (int)Math.Round(axises[0].X + centerX - 6), (int)Math.Round(-axises[0].Y + centerY - 6), 12, 12);
			//g.FillEllipse(new SolidBrush(Color.Gray), (int)Math.Round(axises[1].X + centerX - 6), (int)Math.Round(-axises[1].Y + centerY - 6), 12, 12);
			//g.FillEllipse(new SolidBrush(Color.Gray), (int)Math.Round(axises[2].X + centerX - 6), (int)Math.Round(-axises[2].Y + centerY - 6), 12, 12);
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
			draw_axises();
			pictureBox.Image = bmp;
		}
		
		private void draw_axises(){
			for (int i = 0; i < 3; i++)
			{
			    int x1 = centerX; int x2 = (int)Math.Round(axises[i].X + centerX);
			    int y1 = centerY; int y2 = (int)Math.Round(-axises[i].Y + centerY);
			    g.DrawLine(new Pen(Color.Blue,3), x1, y1, x2, y2);
			}
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
			
		private point3D normalize_vector(point3D pt1, point3D pt2)
			{
			double x = pt2.X - pt1.X;
			double y = pt2.Y - pt1.Y;
			double z = pt2.Z - pt1.Z;
			double length = Math.Sqrt(x * x + y * y + z * z);
			return new point3D(x / length, y / length, z / length);
		}
		
		private void button1_Click(object sender, EventArgs e)  // перенос
		{
			int kx = 0, ky = 0, kz = 0;
			var f = new Move_form();
			f.ShowDialog();
			kx=Int32.Parse(f.textBox1.Text);
			ky=Int32.Parse(f.textBox2.Text);
			kz=Int32.Parse(f.textBox3.Text);
			
			displacement(kx, ky, kz);
			redraw_image();
		}
		
		private void button2_Click(object sender, EventArgs e)  // масштабирование
		{
			double kx = 0, ky = 0, kz = 0;
			var f = new Scale_form();
			f.ShowDialog();
			kx=Double.Parse(f.textBox1.Text);
			ky=Double.Parse(f.textBox2.Text);
			kz=Double.Parse(f.textBox3.Text);
			
			scaling(kx, ky, kz);
			redraw_image();
		}
		
		private void button3_Click(object sender, EventArgs e)  // поворот
		{
			double kx = 0, ky = 0, kz = 0;
			var f = new Turn_form();
			f.ShowDialog();
			if (f.DialogResult!=DialogResult.Abort){
				kx=Double.Parse(f.textBox1.Text);
				ky=Double.Parse(f.textBox2.Text);
				kz=Double.Parse(f.textBox3.Text);
			}
			double x_angle = (kx * Math.PI) / 180D;
			double y_angle = (ky * Math.PI) / 180D;
			double z_angle = (kz * Math.PI) / 180D;
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
		
		private void button9_Click(object sender, EventArgs e)  // поворот вокруг оси
		{
			
			double axisAngle = (Double.Parse(textBox4.Text) * Math.PI) / 180D;
			switch (comboBox2.SelectedItem.ToString()){
				case "OX":
					axis_P1=new point3D(0,0,0);
					axis_P2=new point3D(500,0,0);
					break;
				case "OY":
					axis_P1=new point3D(0,0,0);
					axis_P2=new point3D(0,500,0);
					break;
				case "OZ":
					axis_P1=new point3D(0,0,0);
					axis_P2=new point3D(0,0,500);
					break;
			}
			axis_rotate(axis_P1, axis_P2, axisAngle);
			redraw_image();
		}
		
		private void button10_Click(object sender, EventArgs e)
		{
			points.Clear();
			facets.Clear();
			g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox.Size.Width, pictureBox.Size.Height);
			pictureBox.Invalidate();
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
		
		void draw_click(object sender, System.EventArgs e){
			Functions f = plus;
			switch (comboBox1.SelectedIndex){
				case 0:
					f=plus;
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
			var ss = textBox1.Text.Split(',');
			int x0 = Int32.Parse(ss[0]); int x1 = Int32.Parse(ss[1]);
			ss = textBox2.Text.Split(',');
			int y0 = Int32.Parse(ss[0]); int y1 = Int32.Parse(ss[1]);
			int step = Int32.Parse(textBox3.Text);
			
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
					//facets.Add(fac);
					
					//fac.points.Clear();
					
					//fac.add(points[ky*q+w+1]);
					//fac.add(points[(ky+1)*q+w]);
					facets.Add(fac);
					//MessageBox.Show(fac.points.Count.ToString());
					//MessageBox.Show((ky*q+w).ToString()+" "+(ky*q+w+1).ToString()+Environment.NewLine+
					//                (ky*(q+1)+w).ToString()+" "+(ky*(1+q)+w+1).ToString());
				}
			}
			redraw_image();
		}
		
		void Button6Click(object sender, System.EventArgs e)
		{
			var new_f = new List<facet>();
			if (this.radioButton1.Checked){
				center_matr[0,3]=0;
				center_matr[1,3]=0;
				center_matr[2,3]=0;
				center_matr[0,0]=1;
				center_matr[1,1]=1;
				//center_matr[2,2]=1;
//				double xx = Double.Parse(textBox5.Text);
//				if (xx != 0)
//					center_matr[0,3]=-1/xx;
//				double yy = Double.Parse(textBox6.Text);
//				if (yy != 0)
//					center_matr[1,3]=-1/yy;
				double zz = Double.Parse(textBox7.Text);
				if (zz != 0)
					center_matr[2,3]=-1/zz;
				
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
			else if (this.radioButton2.Checked){
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
			else if (this.radioButton3.Checked){
				ortographic_matr[3,3]=1;
				switch (comboBox3.SelectedItem.ToString()) {
					case "XY":
						ortographic_matr[0, 0] = 1;
						ortographic_matr[1, 1] = 1;
						break;
					case "ZX":
						ortographic_matr[0, 0] = 1;
						ortographic_matr[2, 2] = 1;
						break;
					case "YZ":
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
						
						if (z==0)
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
		void Button7Click(object sender, System.EventArgs e)
		{
			g.Clear(Color.White);
			facets.Clear();
			points.Clear();
			pictureBox.Invalidate();
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
