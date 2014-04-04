using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APNSPushTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void btnPush_Click(object sender, EventArgs e)
		{
			try
			{
				// 第１引数：p12ファイルのフルパス　第２引数：ファイルのパスワード
				ApnsInterface.Apns apns = new ApnsInterface.Apns(@"D:\xxxxx\xxxxx.p12", "password");
				apns.PushServer = "gateway.push.apple.com";
				apns.Push(this.txtDeviceToken.Text, txtMessage.Text, int.Parse(this.cmbCount.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	}
}
