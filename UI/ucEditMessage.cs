﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Network;

namespace UI
{
	public partial class ucEditMessage : UserControl
	{
		private ucUserINChatBox pnparent;
		private ucMessShow ucmessshow;
		public ucEditMessage()
		{
			InitializeComponent();
		}
		public ucEditMessage(ucUserINChatBox ucUserINChatBox , ucMessShow ucMessShow)
		{
			InitializeComponent();
			this.pnparent = ucUserINChatBox;
			this.ucmessshow = ucMessShow;
			this.lbCancel.ForeColor = FrmMain.theme.TxtForeColor;
			this.lbSave.ForeColor = FrmMain.theme.TxtForeColor;
			this.textBox1.BackColor = FrmMain.theme.BackColor;
			this.textBox1.ForeColor = FrmMain.theme.TxtForeColor;
			this.textBox1.Text = ucMessShow.GetText();
			this.Visible = true;
		}
		private void lbCancel_Click(object sender, EventArgs e)
		{
			ucmessshow.Visible = true;
			pnparent._RemoveEditControls(this);
			pnparent.isTurnOnEdit = false;
		}
		private async void lbSave_Click(object sender, EventArgs e)
		{
			byte[] tempbuff = Encoding.UTF8.GetBytes("EDITMESSAGE%" + pnparent.ID + "%" + pnparent.IDParent + "%" + textBox1.Text);
			SmallPackage package = new SmallPackage(0, 1024, "M", tempbuff, "0");
			FrmMain.server.GetStream().WriteAsync(package.Packing(), 0, package.Packing().Length);
			ucmessshow.Visible = true;
			ucmessshow.SetText(textBox1.Text);
			pnparent._RemoveEditControls(this);
			pnparent.isTurnOnEdit = false;

			
		}
	}
}
