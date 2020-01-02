namespace Skarbonka.Forms
{
    partial class formdodajPrzychod
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formdodajPrzychod));
            this.txtKod = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnZamknij = new Bunifu.Framework.UI.BunifuImageButton();
            this.label20 = new System.Windows.Forms.Label();
            this.bunifuSeparator11 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtKonto = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtKategoria = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtOd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtOpis = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtIlosc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnDodajPrzychod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.closeForm = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnZamknij)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKod
            // 
            this.txtKod.BackColor = System.Drawing.Color.White;
            this.txtKod.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtKod.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtKod.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtKod.BorderThickness = 3;
            this.txtKod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKod.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKod.ForeColor = System.Drawing.Color.DarkGray;
            this.txtKod.isPassword = false;
            this.txtKod.Location = new System.Drawing.Point(17, 248);
            this.txtKod.Margin = new System.Windows.Forms.Padding(4);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(234, 44);
            this.txtKod.TabIndex = 0;
            this.txtKod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnZamknij
            // 
            this.btnZamknij.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZamknij.Image = ((System.Drawing.Image)(resources.GetObject("btnZamknij.Image")));
            this.btnZamknij.ImageActive = null;
            this.btnZamknij.Location = new System.Drawing.Point(474, 12);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(40, 40);
            this.btnZamknij.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZamknij.TabIndex = 1;
            this.btnZamknij.TabStop = false;
            this.btnZamknij.Zoom = 10;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(12, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 28);
            this.label20.TabIndex = 25;
            this.label20.Text = "Dodaj przychód";
            // 
            // bunifuSeparator11
            // 
            this.bunifuSeparator11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator11.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator11.LineThickness = 1;
            this.bunifuSeparator11.Location = new System.Drawing.Point(12, 60);
            this.bunifuSeparator11.Name = "bunifuSeparator11";
            this.bunifuSeparator11.Size = new System.Drawing.Size(502, 26);
            this.bunifuSeparator11.TabIndex = 26;
            this.bunifuSeparator11.Transparency = 255;
            this.bunifuSeparator11.Vertical = false;
            this.bunifuSeparator11.Load += new System.EventHandler(this.bunifuSeparator11_Load);
            // 
            // txtKonto
            // 
            this.txtKonto.BackColor = System.Drawing.Color.Transparent;
            this.txtKonto.BorderRadius = 3;
            this.txtKonto.ForeColor = System.Drawing.Color.DimGray;
            this.txtKonto.Items = new string[] {
        "Gotówka",
        "Bank"};
            this.txtKonto.Location = new System.Drawing.Point(19, 197);
            this.txtKonto.Name = "txtKonto";
            this.txtKonto.NomalColor = System.Drawing.Color.White;
            this.txtKonto.onHoverColor = System.Drawing.Color.Silver;
            this.txtKonto.selectedIndex = 0;
            this.txtKonto.Size = new System.Drawing.Size(232, 42);
            this.txtKonto.TabIndex = 27;
            // 
            // txtKategoria
            // 
            this.txtKategoria.BackColor = System.Drawing.Color.Transparent;
            this.txtKategoria.BorderRadius = 3;
            this.txtKategoria.ForeColor = System.Drawing.Color.DimGray;
            this.txtKategoria.Items = new string[] {
        "Wypłata",
        "Przelew"};
            this.txtKategoria.Location = new System.Drawing.Point(261, 199);
            this.txtKategoria.Name = "txtKategoria";
            this.txtKategoria.NomalColor = System.Drawing.Color.White;
            this.txtKategoria.onHoverColor = System.Drawing.Color.Silver;
            this.txtKategoria.selectedIndex = 0;
            this.txtKategoria.Size = new System.Drawing.Size(253, 42);
            this.txtKategoria.TabIndex = 28;
            // 
            // txtOd
            // 
            this.txtOd.BackColor = System.Drawing.Color.White;
            this.txtOd.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtOd.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtOd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtOd.BorderThickness = 3;
            this.txtOd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOd.ForeColor = System.Drawing.Color.DarkGray;
            this.txtOd.isPassword = false;
            this.txtOd.Location = new System.Drawing.Point(19, 148);
            this.txtOd.Margin = new System.Windows.Forms.Padding(4);
            this.txtOd.Name = "txtOd";
            this.txtOd.Size = new System.Drawing.Size(496, 44);
            this.txtOd.TabIndex = 29;
            this.txtOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOpis
            // 
            this.txtOpis.BackColor = System.Drawing.Color.White;
            this.txtOpis.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtOpis.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtOpis.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtOpis.BorderThickness = 3;
            this.txtOpis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpis.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOpis.ForeColor = System.Drawing.Color.DarkGray;
            this.txtOpis.isPassword = false;
            this.txtOpis.Location = new System.Drawing.Point(19, 96);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(496, 44);
            this.txtOpis.TabIndex = 30;
            this.txtOpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOpis.OnValueChanged += new System.EventHandler(this.txtOpis_OnValueChanged);
            // 
            // txtIlosc
            // 
            this.txtIlosc.BackColor = System.Drawing.Color.White;
            this.txtIlosc.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtIlosc.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtIlosc.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtIlosc.BorderThickness = 3;
            this.txtIlosc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIlosc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIlosc.ForeColor = System.Drawing.Color.DarkGray;
            this.txtIlosc.isPassword = false;
            this.txtIlosc.Location = new System.Drawing.Point(261, 248);
            this.txtIlosc.Margin = new System.Windows.Forms.Padding(4);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(254, 44);
            this.txtIlosc.TabIndex = 31;
            this.txtIlosc.Text = "123";
            this.txtIlosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIlosc.OnValueChanged += new System.EventHandler(this.txtIlosc_OnValueChanged);
            // 
            // btnDodajPrzychod
            // 
            this.btnDodajPrzychod.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDodajPrzychod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajPrzychod.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDodajPrzychod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajPrzychod.BorderRadius = 0;
            this.btnDodajPrzychod.ButtonText = "Dodaj transakcję";
            this.btnDodajPrzychod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajPrzychod.DisabledColor = System.Drawing.Color.Gray;
            this.btnDodajPrzychod.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPrzychod.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDodajPrzychod.Iconimage = null;
            this.btnDodajPrzychod.Iconimage_right = null;
            this.btnDodajPrzychod.Iconimage_right_Selected = null;
            this.btnDodajPrzychod.Iconimage_Selected = null;
            this.btnDodajPrzychod.IconMarginLeft = 0;
            this.btnDodajPrzychod.IconMarginRight = 0;
            this.btnDodajPrzychod.IconRightVisible = false;
            this.btnDodajPrzychod.IconRightZoom = 0D;
            this.btnDodajPrzychod.IconVisible = false;
            this.btnDodajPrzychod.IconZoom = 90D;
            this.btnDodajPrzychod.IsTab = false;
            this.btnDodajPrzychod.Location = new System.Drawing.Point(261, 323);
            this.btnDodajPrzychod.Name = "btnDodajPrzychod";
            this.btnDodajPrzychod.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.btnDodajPrzychod.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDodajPrzychod.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDodajPrzychod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDodajPrzychod.selected = false;
            this.btnDodajPrzychod.Size = new System.Drawing.Size(254, 48);
            this.btnDodajPrzychod.TabIndex = 32;
            this.btnDodajPrzychod.Text = "Dodaj transakcję";
            this.btnDodajPrzychod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDodajPrzychod.Textcolor = System.Drawing.Color.White;
            this.btnDodajPrzychod.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnDodajPrzychod.Click += new System.EventHandler(this.btnDodajPrzychod_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // closeForm
            // 
            this.closeForm.Interval = 3000;
            this.closeForm.Tick += new System.EventHandler(this.closeForm_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(30, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Opis płatności";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(30, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Płatność od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(30, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID Transakcji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(271, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ilość";
            // 
            // formdodajPrzychod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(526, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajPrzychod);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtOd);
            this.Controls.Add(this.txtKategoria);
            this.Controls.Add(this.txtKonto);
            this.Controls.Add(this.bunifuSeparator11);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.txtKod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formdodajPrzychod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formdodajPrzychod";
            this.Load += new System.EventHandler(this.formdodajPrzychod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnZamknij)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtKod;
        private Bunifu.Framework.UI.BunifuImageButton btnZamknij;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator11;
        private Bunifu.Framework.UI.BunifuDropdown txtKonto;
        private Bunifu.Framework.UI.BunifuDropdown txtKategoria;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOpis;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIlosc;
        private Bunifu.Framework.UI.BunifuFlatButton btnDodajPrzychod;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer closeForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}