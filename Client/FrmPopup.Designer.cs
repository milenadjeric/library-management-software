namespace Client
{
    partial class FrmPopup
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
            this.lblMsgPrezime = new System.Windows.Forms.Label();
            this.lblMsgIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMsgPrezime
            // 
            this.lblMsgPrezime.AutoSize = true;
            this.lblMsgPrezime.Location = new System.Drawing.Point(99, 107);
            this.lblMsgPrezime.Name = "lblMsgPrezime";
            this.lblMsgPrezime.Size = new System.Drawing.Size(0, 13);
            this.lblMsgPrezime.TabIndex = 64;
            // 
            // lblMsgIme
            // 
            this.lblMsgIme.AutoSize = true;
            this.lblMsgIme.Location = new System.Drawing.Point(98, 66);
            this.lblMsgIme.Name = "lblMsgIme";
            this.lblMsgIme.Size = new System.Drawing.Size(0, 13);
            this.lblMsgIme.TabIndex = 63;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(28, 87);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 62;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(92, 84);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(228, 20);
            this.txtPrezime.TabIndex = 61;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(92, 45);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(228, 20);
            this.txtIme.TabIndex = 60;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(28, 48);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 59;
            this.lblIme.Text = "Ime:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.LightPink;
            this.btnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDodaj.FlatAppearance.BorderSize = 3;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Location = new System.Drawing.Point(161, 130);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 65;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // FrmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(407, 191);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblMsgPrezime);
            this.Controls.Add(this.lblMsgIme);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPopup";
            this.Text = "Dodaj autora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsgPrezime;
        private System.Windows.Forms.Label lblMsgIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnDodaj;

        public System.Windows.Forms.Label LblMsgPrezime { get => lblMsgPrezime; set => lblMsgPrezime = value; }
        public System.Windows.Forms.Label LblMsgIme { get => lblMsgIme; set => lblMsgIme = value; }
        public System.Windows.Forms.Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public System.Windows.Forms.Label LblIme { get => lblIme; set => lblIme = value; }
        public System.Windows.Forms.TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public System.Windows.Forms.TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public System.Windows.Forms.Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
    }
}