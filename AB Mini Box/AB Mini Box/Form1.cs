/*
 * Created by XereX(codaaj)
 * SharpDevelop 5.1 -> C# NET FrameWork 4.5.2
 * Thanks forums :)
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AB_Mini_Box
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if (label1.Top > -2500)
            {
                label1.Top -= 1;
            }
		}
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		void Form1Load(object sender, EventArgs e)
		{
	
		}
	}
}
