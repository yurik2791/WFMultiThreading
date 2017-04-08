using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFMultiThreading
{
	public partial class Form1 : Form
	{
		string pathNF = @"D:\new.log";
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_start_Click(object sender, EventArgs e)
		{
			var path = @"D:\dismc.log";
			var lines = File.ReadAllLines(path);

			new Thread(() =>
			{
				foreach (var line in lines)
				{
					foreach (char letter in line)
					{
						new Thread(() =>
						{
							rtb.BeginInvoke(new MethodInvoker(() =>
								{
									rtb.AppendText(letter.ToString());
									Thread.Sleep(500);
								}));
						}).Start();
					}
				}
			}).Start();

		}


		private void btn_second_Click(object sender, EventArgs e)
		{
			new Thread(() =>
			{
				var buffer = Encoding.UTF8.GetBytes(txtBox.Text);
				rtb.BeginInvoke(new MethodInvoker(() =>
				{
					rtb.AppendText(Encoding.UTF8.GetString(buffer));
					//Thread.Sleep(500);
				}));
			}).Start();
		}
	}
}
