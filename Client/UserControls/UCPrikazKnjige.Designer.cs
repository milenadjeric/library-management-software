namespace Client.UserControls
{
    partial class UCPrikazKnjige
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPovez = new System.Windows.Forms.Label();
            this.lblGodinaIzdavanja = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtGodinaIzdavanja = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblBrojPrimeraka = new System.Windows.Forms.Label();
            this.cmbPovez = new System.Windows.Forms.ComboBox();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.btnAddAutor = new System.Windows.Forms.Button();
            this.cmbIzdavac = new System.Windows.Forms.ComboBox();
            this.btnAddIzdavac = new System.Windows.Forms.Button();
            this.nudBrPrimeraka = new System.Windows.Forms.NumericUpDown();
            this.lblMsgISBN = new System.Windows.Forms.Label();
            this.lblMsgNaziv = new System.Windows.Forms.Label();
            this.lblMsgAutor = new System.Windows.Forms.Label();
            this.lblMsgZanr = new System.Windows.Forms.Label();
            this.lblMsgIzdavac = new System.Windows.Forms.Label();
            this.lblMsgGodinaIzdavanja = new System.Windows.Forms.Label();
            this.lblMsgPovez = new System.Windows.Forms.Label();
            this.lblMsgBrPrimeraka = new System.Windows.Forms.Label();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.lblBrStrana = new System.Windows.Forms.Label();
            this.txtBrStrana = new System.Windows.Forms.TextBox();
            this.lblMsgBrStrana = new System.Windows.Forms.Label();
            this.lblBrDostupnih = new System.Windows.Forms.Label();
            this.txtDostupne = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrPrimeraka)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(34, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 29);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Obriši knjigu";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMessage.Location = new System.Drawing.Point(264, 374);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(152, 13);
            this.lblMessage.TabIndex = 41;
            this.lblMessage.Text = "Unesite podatke o novoj knjizi.";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(657, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 37);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(657, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 37);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(312, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 24);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Dodaj novu knjigu";
            // 
            // lblPovez
            // 
            this.lblPovez.AutoSize = true;
            this.lblPovez.Location = new System.Drawing.Point(46, 282);
            this.lblPovez.Name = "lblPovez";
            this.lblPovez.Size = new System.Drawing.Size(40, 13);
            this.lblPovez.TabIndex = 37;
            this.lblPovez.Text = "Povez:";
            // 
            // lblGodinaIzdavanja
            // 
            this.lblGodinaIzdavanja.AutoSize = true;
            this.lblGodinaIzdavanja.Location = new System.Drawing.Point(46, 240);
            this.lblGodinaIzdavanja.Name = "lblGodinaIzdavanja";
            this.lblGodinaIzdavanja.Size = new System.Drawing.Size(92, 13);
            this.lblGodinaIzdavanja.TabIndex = 36;
            this.lblGodinaIzdavanja.Text = "Godina izdavanja:";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Location = new System.Drawing.Point(520, 76);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(32, 13);
            this.lblZanr.TabIndex = 35;
            this.lblZanr.Text = "Žanr:";
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Location = new System.Drawing.Point(46, 198);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(48, 13);
            this.lblIzdavac.TabIndex = 34;
            this.lblIzdavac.Text = "Izdavač:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(46, 157);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 33;
            this.lblAutor.Text = "Autor:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(46, 118);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 32;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtGodinaIzdavanja
            // 
            this.txtGodinaIzdavanja.Location = new System.Drawing.Point(153, 237);
            this.txtGodinaIzdavanja.Name = "txtGodinaIzdavanja";
            this.txtGodinaIzdavanja.Size = new System.Drawing.Size(228, 20);
            this.txtGodinaIzdavanja.TabIndex = 30;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(153, 115);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(228, 20);
            this.txtNaziv.TabIndex = 26;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(153, 76);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(228, 20);
            this.txtISBN.TabIndex = 25;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(46, 79);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 24;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblBrojPrimeraka
            // 
            this.lblBrojPrimeraka.AutoSize = true;
            this.lblBrojPrimeraka.Location = new System.Drawing.Point(46, 316);
            this.lblBrojPrimeraka.Name = "lblBrojPrimeraka";
            this.lblBrojPrimeraka.Size = new System.Drawing.Size(77, 13);
            this.lblBrojPrimeraka.TabIndex = 48;
            this.lblBrojPrimeraka.Text = "Broj primeraka:";
            // 
            // cmbPovez
            // 
            this.cmbPovez.FormattingEnabled = true;
            this.cmbPovez.Location = new System.Drawing.Point(153, 274);
            this.cmbPovez.Name = "cmbPovez";
            this.cmbPovez.Size = new System.Drawing.Size(228, 21);
            this.cmbPovez.TabIndex = 50;
            // 
            // cmbAutor
            // 
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(153, 154);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(228, 21);
            this.cmbAutor.TabIndex = 51;
            // 
            // btnAddAutor
            // 
            this.btnAddAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAutor.Location = new System.Drawing.Point(387, 152);
            this.btnAddAutor.Name = "btnAddAutor";
            this.btnAddAutor.Size = new System.Drawing.Size(51, 23);
            this.btnAddAutor.TabIndex = 52;
            this.btnAddAutor.Text = "Dodaj";
            this.btnAddAutor.UseVisualStyleBackColor = true;
            // 
            // cmbIzdavac
            // 
            this.cmbIzdavac.FormattingEnabled = true;
            this.cmbIzdavac.Location = new System.Drawing.Point(153, 195);
            this.cmbIzdavac.Name = "cmbIzdavac";
            this.cmbIzdavac.Size = new System.Drawing.Size(228, 21);
            this.cmbIzdavac.TabIndex = 54;
            // 
            // btnAddIzdavac
            // 
            this.btnAddIzdavac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddIzdavac.Location = new System.Drawing.Point(387, 193);
            this.btnAddIzdavac.Name = "btnAddIzdavac";
            this.btnAddIzdavac.Size = new System.Drawing.Size(51, 23);
            this.btnAddIzdavac.TabIndex = 55;
            this.btnAddIzdavac.Text = "Dodaj";
            this.btnAddIzdavac.UseVisualStyleBackColor = true;
            // 
            // nudBrPrimeraka
            // 
            this.nudBrPrimeraka.Location = new System.Drawing.Point(153, 314);
            this.nudBrPrimeraka.Name = "nudBrPrimeraka";
            this.nudBrPrimeraka.Size = new System.Drawing.Size(120, 20);
            this.nudBrPrimeraka.TabIndex = 56;
            // 
            // lblMsgISBN
            // 
            this.lblMsgISBN.AutoSize = true;
            this.lblMsgISBN.Location = new System.Drawing.Point(159, 97);
            this.lblMsgISBN.Name = "lblMsgISBN";
            this.lblMsgISBN.Size = new System.Drawing.Size(0, 13);
            this.lblMsgISBN.TabIndex = 57;
            // 
            // lblMsgNaziv
            // 
            this.lblMsgNaziv.AutoSize = true;
            this.lblMsgNaziv.Location = new System.Drawing.Point(160, 138);
            this.lblMsgNaziv.Name = "lblMsgNaziv";
            this.lblMsgNaziv.Size = new System.Drawing.Size(0, 13);
            this.lblMsgNaziv.TabIndex = 58;
            // 
            // lblMsgAutor
            // 
            this.lblMsgAutor.AutoSize = true;
            this.lblMsgAutor.Location = new System.Drawing.Point(160, 178);
            this.lblMsgAutor.Name = "lblMsgAutor";
            this.lblMsgAutor.Size = new System.Drawing.Size(0, 13);
            this.lblMsgAutor.TabIndex = 59;
            // 
            // lblMsgZanr
            // 
            this.lblMsgZanr.AutoSize = true;
            this.lblMsgZanr.Location = new System.Drawing.Point(568, 95);
            this.lblMsgZanr.Name = "lblMsgZanr";
            this.lblMsgZanr.Size = new System.Drawing.Size(0, 13);
            this.lblMsgZanr.TabIndex = 60;
            // 
            // lblMsgIzdavac
            // 
            this.lblMsgIzdavac.AutoSize = true;
            this.lblMsgIzdavac.Location = new System.Drawing.Point(160, 219);
            this.lblMsgIzdavac.Name = "lblMsgIzdavac";
            this.lblMsgIzdavac.Size = new System.Drawing.Size(0, 13);
            this.lblMsgIzdavac.TabIndex = 61;
            // 
            // lblMsgGodinaIzdavanja
            // 
            this.lblMsgGodinaIzdavanja.AutoSize = true;
            this.lblMsgGodinaIzdavanja.Location = new System.Drawing.Point(160, 258);
            this.lblMsgGodinaIzdavanja.Name = "lblMsgGodinaIzdavanja";
            this.lblMsgGodinaIzdavanja.Size = new System.Drawing.Size(0, 13);
            this.lblMsgGodinaIzdavanja.TabIndex = 62;
            // 
            // lblMsgPovez
            // 
            this.lblMsgPovez.AutoSize = true;
            this.lblMsgPovez.Location = new System.Drawing.Point(160, 298);
            this.lblMsgPovez.Name = "lblMsgPovez";
            this.lblMsgPovez.Size = new System.Drawing.Size(0, 13);
            this.lblMsgPovez.TabIndex = 63;
            // 
            // lblMsgBrPrimeraka
            // 
            this.lblMsgBrPrimeraka.AutoSize = true;
            this.lblMsgBrPrimeraka.Location = new System.Drawing.Point(161, 336);
            this.lblMsgBrPrimeraka.Name = "lblMsgBrPrimeraka";
            this.lblMsgBrPrimeraka.Size = new System.Drawing.Size(0, 13);
            this.lblMsgBrPrimeraka.TabIndex = 64;
            // 
            // cmbZanr
            // 
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(558, 71);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(164, 21);
            this.cmbZanr.TabIndex = 65;
            // 
            // lblBrStrana
            // 
            this.lblBrStrana.AutoSize = true;
            this.lblBrStrana.Location = new System.Drawing.Point(492, 114);
            this.lblBrStrana.Name = "lblBrStrana";
            this.lblBrStrana.Size = new System.Drawing.Size(60, 13);
            this.lblBrStrana.TabIndex = 66;
            this.lblBrStrana.Text = "Broj strana:";
            // 
            // txtBrStrana
            // 
            this.txtBrStrana.Location = new System.Drawing.Point(558, 111);
            this.txtBrStrana.Name = "txtBrStrana";
            this.txtBrStrana.Size = new System.Drawing.Size(164, 20);
            this.txtBrStrana.TabIndex = 67;
            // 
            // lblMsgBrStrana
            // 
            this.lblMsgBrStrana.AutoSize = true;
            this.lblMsgBrStrana.Location = new System.Drawing.Point(568, 134);
            this.lblMsgBrStrana.Name = "lblMsgBrStrana";
            this.lblMsgBrStrana.Size = new System.Drawing.Size(0, 13);
            this.lblMsgBrStrana.TabIndex = 68;
            // 
            // lblBrDostupnih
            // 
            this.lblBrDostupnih.AutoSize = true;
            this.lblBrDostupnih.Location = new System.Drawing.Point(475, 154);
            this.lblBrDostupnih.Name = "lblBrDostupnih";
            this.lblBrDostupnih.Size = new System.Drawing.Size(77, 13);
            this.lblBrDostupnih.TabIndex = 69;
            this.lblBrDostupnih.Text = "Broj dostupnih:";
            // 
            // txtDostupne
            // 
            this.txtDostupne.Enabled = false;
            this.txtDostupne.Location = new System.Drawing.Point(558, 150);
            this.txtDostupne.Name = "txtDostupne";
            this.txtDostupne.Size = new System.Drawing.Size(164, 20);
            this.txtDostupne.TabIndex = 70;
            // 
            // UCPrikazKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.txtDostupne);
            this.Controls.Add(this.lblBrDostupnih);
            this.Controls.Add(this.lblMsgBrStrana);
            this.Controls.Add(this.txtBrStrana);
            this.Controls.Add(this.lblBrStrana);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.lblMsgBrPrimeraka);
            this.Controls.Add(this.lblMsgPovez);
            this.Controls.Add(this.lblMsgGodinaIzdavanja);
            this.Controls.Add(this.lblMsgIzdavac);
            this.Controls.Add(this.lblMsgZanr);
            this.Controls.Add(this.lblMsgAutor);
            this.Controls.Add(this.lblMsgNaziv);
            this.Controls.Add(this.lblMsgISBN);
            this.Controls.Add(this.nudBrPrimeraka);
            this.Controls.Add(this.btnAddIzdavac);
            this.Controls.Add(this.cmbIzdavac);
            this.Controls.Add(this.btnAddAutor);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.cmbPovez);
            this.Controls.Add(this.lblBrojPrimeraka);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPovez);
            this.Controls.Add(this.lblGodinaIzdavanja);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.lblIzdavac);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtGodinaIzdavanja);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBN);
            this.Name = "UCPrikazKnjige";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrPrimeraka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPovez;
        private System.Windows.Forms.Label lblGodinaIzdavanja;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtGodinaIzdavanja;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblBrojPrimeraka;
        private System.Windows.Forms.ComboBox cmbPovez;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.Button btnAddAutor;
        private System.Windows.Forms.ComboBox cmbIzdavac;
        private System.Windows.Forms.Button btnAddIzdavac;
        private System.Windows.Forms.NumericUpDown nudBrPrimeraka;
        private System.Windows.Forms.Label lblMsgISBN;
        private System.Windows.Forms.Label lblMsgNaziv;
        private System.Windows.Forms.Label lblMsgAutor;
        private System.Windows.Forms.Label lblMsgZanr;
        private System.Windows.Forms.Label lblMsgIzdavac;
        private System.Windows.Forms.Label lblMsgGodinaIzdavanja;
        private System.Windows.Forms.Label lblMsgPovez;
        private System.Windows.Forms.Label lblMsgBrPrimeraka;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.Label lblBrStrana;
        private System.Windows.Forms.TextBox txtBrStrana;
        private System.Windows.Forms.Label lblMsgBrStrana;
        private System.Windows.Forms.Label lblBrDostupnih;
        private System.Windows.Forms.TextBox txtDostupne;

        public System.Windows.Forms.Button BtnDelete { get => btnDelete; set => btnDelete = value; }
        public System.Windows.Forms.Button BtnCancel { get => btnCancel; set => btnCancel = value; }
        public System.Windows.Forms.Button BtnSave { get => btnSave; set => btnSave = value; }
        public System.Windows.Forms.Button BtnAddAutor { get => btnAddAutor; set => btnAddAutor = value; }
        public System.Windows.Forms.Button BtnAddIzdavac { get => btnAddIzdavac; set => btnAddIzdavac = value; }
        public System.Windows.Forms.Label LblMessage { get => lblMessage; set => lblMessage = value; }
        public System.Windows.Forms.Label LblBrStrana { get => lblBrStrana; set => lblBrStrana = value; }
        public System.Windows.Forms.Label LblMsgBrStrana { get => lblMsgBrStrana; set => lblMsgBrStrana = value; }
        public System.Windows.Forms.Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public System.Windows.Forms.Label LblPovez { get => lblPovez; set => lblPovez = value; }
        public System.Windows.Forms.Label LblGodinaIzdavanja { get => lblGodinaIzdavanja; set => lblGodinaIzdavanja = value; }
        public System.Windows.Forms.Label LblZanr { get => lblZanr; set => lblZanr = value; }
        public System.Windows.Forms.Label LblIzdavac { get => lblIzdavac; set => lblIzdavac = value; }
        public System.Windows.Forms.Label LblAutor { get => lblAutor; set => lblAutor = value; }
        public System.Windows.Forms.Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public System.Windows.Forms.Label LblISBN { get => lblISBN; set => lblISBN = value; }
        public System.Windows.Forms.Label LblBrojPrimeraka { get => lblBrojPrimeraka; set => lblBrojPrimeraka = value; }
        public System.Windows.Forms.Label LblMsgISBN { get => lblMsgISBN; set => lblMsgISBN = value; }
        public System.Windows.Forms.Label LblMsgNaziv { get => lblMsgNaziv; set => lblMsgNaziv = value; }
        public System.Windows.Forms.Label LblMsgAutor { get => lblMsgAutor; set => lblMsgAutor = value; }
        public System.Windows.Forms.Label LblMsgZanr { get => lblMsgZanr; set => lblMsgZanr = value; }
        public System.Windows.Forms.Label LblMsgIzdavac { get => lblMsgIzdavac; set => lblMsgIzdavac = value; }
        public System.Windows.Forms.Label LblMsgGodinaIzdavanja { get => lblMsgGodinaIzdavanja; set => lblMsgGodinaIzdavanja = value; }
        public System.Windows.Forms.Label LblMsgPovez { get => lblMsgPovez; set => lblMsgPovez = value; }
        public System.Windows.Forms.Label LblMsgBrPrimeraka { get => lblMsgBrPrimeraka; set => lblMsgBrPrimeraka = value; }
        public System.Windows.Forms.Label LblBrDostupnih { get => lblBrDostupnih; set => lblBrDostupnih = value; }
        public System.Windows.Forms.TextBox TxtGodinaIzdavanja { get => txtGodinaIzdavanja; set => txtGodinaIzdavanja = value; }
        public System.Windows.Forms.TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public System.Windows.Forms.TextBox TxtISBN { get => txtISBN; set => txtISBN = value; }
        public System.Windows.Forms.TextBox TxtBrStrana { get => txtBrStrana; set => txtBrStrana = value; }
        public System.Windows.Forms.TextBox TxtDostupne { get => txtDostupne; set => txtDostupne = value; }
        public System.Windows.Forms.ComboBox CmbPovez { get => cmbPovez; set => cmbPovez = value; }
        public System.Windows.Forms.ComboBox CmbAutor { get => cmbAutor; set => cmbAutor = value; }
        public System.Windows.Forms.ComboBox CmbIzdavac { get => cmbIzdavac; set => cmbIzdavac = value; }
        public System.Windows.Forms.NumericUpDown NudBrPrimeraka { get => nudBrPrimeraka; set => nudBrPrimeraka = value; }
        public System.Windows.Forms.ComboBox CmbZanr { get => cmbZanr; set => cmbZanr = value; }


    }
}