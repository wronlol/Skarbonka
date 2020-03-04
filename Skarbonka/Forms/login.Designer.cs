namespace Skarbonka.Forms
{
    partial class login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZaloguj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtLog = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHas = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator11 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label20 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblWrong = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(55, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasło";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(55, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa użytkownika";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnZaloguj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZaloguj.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnZaloguj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZaloguj.BorderRadius = 0;
            this.btnZaloguj.ButtonText = "Zaloguj";
            this.btnZaloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZaloguj.DisabledColor = System.Drawing.Color.Gray;
            this.btnZaloguj.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaloguj.Iconcolor = System.Drawing.Color.Transparent;
            this.btnZaloguj.Iconimage = null;
            this.btnZaloguj.Iconimage_right = null;
            this.btnZaloguj.Iconimage_right_Selected = null;
            this.btnZaloguj.Iconimage_Selected = null;
            this.btnZaloguj.IconMarginLeft = 0;
            this.btnZaloguj.IconMarginRight = 0;
            this.btnZaloguj.IconRightVisible = false;
            this.btnZaloguj.IconRightZoom = 0D;
            this.btnZaloguj.IconVisible = false;
            this.btnZaloguj.IconZoom = 90D;
            this.btnZaloguj.IsTab = false;
            this.btnZaloguj.Location = new System.Drawing.Point(357, 249);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.btnZaloguj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnZaloguj.OnHoverTextColor = System.Drawing.Color.White;
            this.btnZaloguj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnZaloguj.selected = false;
            this.btnZaloguj.Size = new System.Drawing.Size(183, 48);
            this.btnZaloguj.TabIndex = 6;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZaloguj.Textcolor = System.Drawing.Color.White;
            this.btnZaloguj.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtLog.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtLog.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtLog.BorderThickness = 3;
            this.txtLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLog.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLog.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLog.isPassword = false;
            this.txtLog.Location = new System.Drawing.Point(45, 99);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(496, 44);
            this.txtLog.TabIndex = 2;
            this.txtLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLog.OnValueChanged += new System.EventHandler(this.txtOpis1_OnValueChanged);
            // 
            // txtHas
            // 
            this.txtHas.BackColor = System.Drawing.Color.White;
            this.txtHas.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtHas.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtHas.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtHas.BorderThickness = 3;
            this.txtHas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHas.ForeColor = System.Drawing.Color.DarkGray;
            this.txtHas.isPassword = true;
            this.txtHas.Location = new System.Drawing.Point(45, 151);
            this.txtHas.Margin = new System.Windows.Forms.Padding(4);
            this.txtHas.Name = "txtHas";
            this.txtHas.Size = new System.Drawing.Size(496, 44);
            this.txtHas.TabIndex = 4;
            this.txtHas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHas.OnValueChanged += new System.EventHandler(this.txtDla1_OnValueChanged);
            // 
            // bunifuSeparator11
            // 
            this.bunifuSeparator11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator11.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator11.LineThickness = 1;
            this.bunifuSeparator11.Location = new System.Drawing.Point(38, 63);
            this.bunifuSeparator11.Name = "bunifuSeparator11";
            this.bunifuSeparator11.Size = new System.Drawing.Size(481, 26);
            this.bunifuSeparator11.TabIndex = 0;
            this.bunifuSeparator11.TabStop = false;
            this.bunifuSeparator11.Transparency = 255;
            this.bunifuSeparator11.Vertical = false;
            this.bunifuSeparator11.Load += new System.EventHandler(this.bunifuSeparator11_Load);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(38, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(218, 28);
            this.label20.TabIndex = 1;
            this.label20.Text = "Skarbonka - Logowanie";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(500, 15);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 50;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Rejestracja";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(45, 249);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(183, 48);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Rejestracja";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWrong.ForeColor = System.Drawing.Color.Salmon;
            this.lblWrong.Location = new System.Drawing.Point(228, 210);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(0, 19);
            this.lblWrong.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "label3";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 368);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZaloguj);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtHas);
            this.Controls.Add(this.bunifuSeparator11);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnZaloguj;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLog;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHas;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator11;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWrong;
        private System.Windows.Forms.Label label3;
    }
}