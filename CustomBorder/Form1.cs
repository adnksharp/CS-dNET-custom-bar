using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomBorder
{
	public partial class Form1 : Form
	{
		bool max = false, min = false, pos = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			button1.Text = "X";
			button2.Text = "O";
			button3.Text = "-";
			button4.Text = "V";
			button5.Text = "Form1";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			max = !max;
			if (max)
				WindowState = FormWindowState.Maximized;
			else
				WindowState = FormWindowState.Normal;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			min = !min;
			if (min) 
				Size = new Size(480, 48);
			else
				Size = new Size(480, 240);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			pos = !pos;
		}

		private void button5_MouseEnter(object sender, EventArgs e)
		{
			if (pos) locate();
		}

		private void button5_MouseMove(object sender, MouseEventArgs e)
		{
			if (pos) locate();
		}

		public void locate()
		{
			Location = new Point(int.Parse(Cursor.Position.X.ToString()) - 300, int.Parse(Cursor.Position.Y.ToString()) - 25);
		}
	}
}
