/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 12/03/2014
 * Time: 04:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace usuarios
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void TabPage1Click(object sender, EventArgs e)
		{

		

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			menu m=new menu();
			m.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
