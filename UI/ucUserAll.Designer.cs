﻿namespace UI
{
    partial class ucUserAll
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUserAll));
            this.pnLine = new System.Windows.Forms.Panel();
            this.pnContain = new System.Windows.Forms.Panel();
            this.pnContainId = new System.Windows.Forms.Panel();
            this.lbId = new System.Windows.Forms.Label();
            this.pnContrainName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picChat = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.pnContainPicture = new System.Windows.Forms.Panel();
            this.gunaPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnContain.SuspendLayout();
            this.pnContainId.SuspendLayout();
            this.pnContrainName.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.pnContainPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.Transparent;
            this.pnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLine.ForeColor = System.Drawing.Color.Black;
            this.pnLine.Location = new System.Drawing.Point(11, 0);
            this.pnLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(360, 1);
            this.pnLine.TabIndex = 0;
            this.pnLine.Click += new System.EventHandler(this.ucUserAll_Click);
            // 
            // pnContain
            // 
            this.pnContain.BackColor = System.Drawing.Color.Transparent;
            this.pnContain.Controls.Add(this.pnContainId);
            this.pnContain.Controls.Add(this.pnContrainName);
            this.pnContain.Controls.Add(this.panel2);
            this.pnContain.Controls.Add(this.panel1);
            this.pnContain.Controls.Add(this.pnContainPicture);
            this.pnContain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContain.Location = new System.Drawing.Point(11, 1);
            this.pnContain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContain.Name = "pnContain";
            this.pnContain.Padding = new System.Windows.Forms.Padding(11, 7, 20, 7);
            this.pnContain.Size = new System.Drawing.Size(360, 68);
            this.pnContain.TabIndex = 1;
            this.pnContain.Click += new System.EventHandler(this.ucUserAll_Click);
            // 
            // pnContainId
            // 
            this.pnContainId.BackColor = System.Drawing.Color.Transparent;
            this.pnContainId.Controls.Add(this.lbId);
            this.pnContainId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnContainId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainId.Location = new System.Drawing.Point(70, 37);
            this.pnContainId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainId.Name = "pnContainId";
            this.pnContainId.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.pnContainId.Size = new System.Drawing.Size(208, 25);
            this.pnContainId.TabIndex = 6;
            this.pnContainId.Click += new System.EventHandler(this.ucUserAll_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.Transparent;
            this.lbId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.DimGray;
            this.lbId.Location = new System.Drawing.Point(5, 2);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(53, 20);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "label2";
            this.lbId.Click += new System.EventHandler(this.ucUserAll_Click);
            // 
            // pnContrainName
            // 
            this.pnContrainName.BackColor = System.Drawing.Color.Transparent;
            this.pnContrainName.Controls.Add(this.lbName);
            this.pnContrainName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnContrainName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContrainName.Location = new System.Drawing.Point(70, 7);
            this.pnContrainName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContrainName.Name = "pnContrainName";
            this.pnContrainName.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.pnContrainName.Size = new System.Drawing.Size(208, 30);
            this.pnContrainName.TabIndex = 5;
            this.pnContrainName.Click += new System.EventHandler(this.ucUserAll_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(5, 2);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 26);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            this.lbName.Click += new System.EventHandler(this.ucUserAll_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.picChat);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(278, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.panel2.Size = new System.Drawing.Size(34, 54);
            this.panel2.TabIndex = 4;
            this.panel2.Click += new System.EventHandler(this.ucUserAll_Click);
            // 
            // picChat
            // 
            this.picChat.BackColor = System.Drawing.Color.Transparent;
            this.picChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picChat.Image = ((System.Drawing.Image)(resources.GetObject("picChat.Image")));
            this.picChat.Location = new System.Drawing.Point(0, 0);
            this.picChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picChat.Name = "picChat";
            this.picChat.Size = new System.Drawing.Size(23, 54);
            this.picChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChat.TabIndex = 0;
            this.picChat.TabStop = false;
            this.picChat.Click += new System.EventHandler(this.ucUserAll_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picMenu);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(312, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(28, 54);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.ucUserAll_Click);
            // 
            // picMenu
            // 
            this.picMenu.BackColor = System.Drawing.Color.Transparent;
            this.picMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(11, 0);
            this.picMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(17, 54);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // pnContainPicture
            // 
            this.pnContainPicture.BackColor = System.Drawing.Color.Transparent;
            this.pnContainPicture.Controls.Add(this.gunaPic);
            this.pnContainPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnContainPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContainPicture.Location = new System.Drawing.Point(11, 7);
            this.pnContainPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainPicture.Name = "pnContainPicture";
            this.pnContainPicture.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainPicture.Size = new System.Drawing.Size(59, 54);
            this.pnContainPicture.TabIndex = 0;
            this.pnContainPicture.Click += new System.EventHandler(this.ucUserAll_Click);
            // 
            // gunaPic
            // 
            this.gunaPic.BackColor = System.Drawing.Color.Transparent;
            this.gunaPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPic.Image = ((System.Drawing.Image)(resources.GetObject("gunaPic.Image")));
            this.gunaPic.Location = new System.Drawing.Point(3, 2);
            this.gunaPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPic.Name = "gunaPic";
            this.gunaPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gunaPic.ShadowDecoration.Parent = this.gunaPic;
            this.gunaPic.Size = new System.Drawing.Size(53, 50);
            this.gunaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPic.TabIndex = 0;
            this.gunaPic.TabStop = false;
            this.gunaPic.Click += new System.EventHandler(this.ucUserAll_Click);
            // 
            // ucUserAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnContain);
            this.Controls.Add(this.pnLine);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucUserAll";
            this.Padding = new System.Windows.Forms.Padding(11, 0, 29, 0);
            this.Size = new System.Drawing.Size(400, 69);
            this.Click += new System.EventHandler(this.ucUserAll_Click);
            this.pnContain.ResumeLayout(false);
            this.pnContainId.ResumeLayout(false);
            this.pnContainId.PerformLayout();
            this.pnContrainName.ResumeLayout(false);
            this.pnContrainName.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChat)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.pnContainPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.Panel pnContain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Panel pnContainPicture;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gunaPic;
        private System.Windows.Forms.Panel pnContainId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel pnContrainName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picChat;
    }
}
