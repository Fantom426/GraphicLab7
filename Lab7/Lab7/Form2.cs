using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lab7
{
	public partial class Form2 : Form
	{
		Bitmap bmp;
		Graphics g;
		Pen pen_facets = new Pen(Color.Green);
		int maxx = Int32.MinValue;
		int minx = Int32.MaxValue;
		int maxy = Int32.MinValue;
		int miny = Int32.MaxValue;
		int centerX;
		int centerY;
		public Form2(List<facet> pts)
		{
			foreach (facet f in pts){
				foreach (point3D p in f.points){
					if (p.X>maxx)
						maxx=(int)p.X;
					if (p.X<minx)
						minx=(int)p.X;
					if (p.Y>maxy)
						maxy=(int)p.Y;
					if (p.Y<miny)
						miny=(int)p.Y;
				}
			}
			
			InitializeComponent();
			bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
			centerX=pictureBox1.Width/2; centerY=pictureBox1.Height/2;
			pictureBox1.Image=bmp;
			g = Graphics.FromImage(bmp);
			
			foreach (facet f in pts)
				draw_facet(f);
			
			g.Dispose();
			pictureBox1.Update();
		}
		
		private void draw_facet(facet f)
		{
			int n = f.points.Count - 1;
			int x1 = (int)Math.Round(maxx - f.points[0].X+25); int x2 = (int)Math.Round(maxx-f.points[n].X+25);
			int y1 = (int)Math.Round(maxy-f.points[0].Y+25); int y2 = (int)Math.Round(maxy-f.points[n].Y+25);
			g.DrawLine(pen_facets, x1, y1, x2, y2);
			
			for (int i = 0; i < n; i++)
			{
			    x1 = (int)Math.Round(maxx-f.points[i].X+25); x2 = (int)Math.Round(maxx-f.points[i + 1].X+25);
			    y1 = (int)Math.Round(maxy-f.points[i].Y+25); y2 = (int)Math.Round(maxy-f.points[i + 1].Y+25);
			    g.DrawLine(pen_facets, x1, y1, x2, y2);
			}
		}
	}
}
