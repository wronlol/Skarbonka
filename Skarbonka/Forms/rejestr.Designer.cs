﻿namespace Skarbonka.Forms
{
    partial class rejestr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rejestr));
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpis1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDla1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator11 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label20 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Zarejestruj";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(198, 253);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(183, 67);
            this.bunifuFlatButton1.TabIndex = 71;
            this.bunifuFlatButton1.Text = "Zarejestruj";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(64, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Podaj hasło";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(64, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Podaj nazwę użytkownika";
            // 
            // txtOpis1
            // 
            this.txtOpis1.BackColor = System.Drawing.Color.White;
            this.txtOpis1.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtOpis1.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtOpis1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtOpis1.BorderThickness = 3;
            this.txtOpis1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpis1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOpis1.ForeColor = System.Drawing.Color.DarkGray;
            this.txtOpis1.isPassword = false;
            this.txtOpis1.Location = new System.Drawing.Point(52, 105);
            this.txtOpis1.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpis1.Name = "txtOpis1";
            this.txtOpis1.Size = new System.Drawing.Size(496, 44);
            this.txtOpis1.TabIndex = 67;
            this.txtOpis1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDla1
            // 
            this.txtDla1.BackColor = System.Drawing.Color.White;
            this.txtDla1.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDla1.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtDla1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDla1.BorderThickness = 3;
            this.txtDla1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDla1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDla1.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDla1.isPassword = false;
            this.txtDla1.Location = new System.Drawing.Point(53, 157);
            this.txtDla1.Margin = new System.Windows.Forms.Padding(4);
            this.txtDla1.Name = "txtDla1";
            this.txtDla1.Size = new System.Drawing.Size(496, 44);
            this.txtDla1.TabIndex = 66;
            this.txtDla1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator11
            // 
            this.bunifuSeparator11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator11.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator11.LineThickness = 1;
            this.bunifuSeparator11.Location = new System.Drawing.Point(47, 69);
            this.bunifuSeparator11.Name = "bunifuSeparator11";
            this.bunifuSeparator11.Size = new System.Drawing.Size(292, 26);
            this.bunifuSeparator11.TabIndex = 65;
            this.bunifuSeparator11.Transparency = 255;
            this.bunifuSeparator11.Vertical = false;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(47, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(215, 28);
            this.label20.TabIndex = 64;
            this.label20.Text = "Skarbonka - Rejestracja";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(509, 21);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 63;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // rejestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 379);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOpis1);
            this.Controls.Add(this.txtDla1);
            this.Controls.Add(this.bunifuSeparator11);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rejestr";
            this.Text = "rejestr";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOpis1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDla1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator11;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}