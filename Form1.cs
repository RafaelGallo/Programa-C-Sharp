using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto__Hello_World_em_linguas_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Em Portugues
			MessageBox.Show("Oi Mundo");

		}

		private void button2_Click(object sender, EventArgs e)
		{
			//Em ingles
			MessageBox.Show("Hello World");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//Em Italiano
			MessageBox.Show("Ciao mondo");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			//Em Russo
			MessageBox.Show("Привет мир");

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
	}
}
