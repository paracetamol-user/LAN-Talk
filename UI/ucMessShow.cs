﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
	public partial class ucMessShow : UserControl
	{
		private string mess;
		private string idMess;
		private User user;
		private ucUserINChatBox ucParent;
		public ucMessShow()
		{
			InitializeComponent();
		}
		public ucMessShow(string mess , User user, ucUserINChatBox ucUserINChatBox)
		{
			InitializeComponent();
			this.user = user;
			this.label1.Text = mess;
			this.ScaleLabel();
			this.ucParent = ucUserINChatBox;
		}
		public void ChangeTheme()
        {
			this.label1.ForeColor = Form1.theme.TextColor;
			this.BackColor = Color.Transparent;
		}
		public void ScaleLabel()
		{
			Size lblTextSize() => TextRenderer.MeasureText(label1.Text, label1.Font);
			Size s = lblTextSize();
			while (true)
			{
				if (label1.Width < s.Width)
				{
					label1.Height = label1.Height +  (int)label1.Font.Size;
					s.Width = s.Width - label1.Width;
				}
				else break;
			}
		}
		public string GetText()
        {
			return this.label1.Text;
        }
		public void SetText(string s)
        {
			this.label1.Text = s;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
			if (Form1.chatBoxFocus != ucParent)
			{
				if (Form1.chatBoxFocus != null)
				{
					Form1.chatBoxFocus.BackColor = Color.Transparent;
					Form1.chatBoxFocus.DisableMenu();
				}
				Form1.chatBoxFocus = ucParent;
				this.ucParent.EnableMenu();
				this.ucParent.BackColor = Form1.theme.Menu;
			}
            else
            {
				return;
            }
		}
		public void DeleteMessage()
        {
			this.label1.Text = "Deleted message";
			this.label1.Font = new Font("Time New Roman",10,FontStyle.Underline);

        }
    }
}
