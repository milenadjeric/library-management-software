namespace Client.UserControls
{
    partial class UCRazduzivanje
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMsgClan = new System.Windows.Forms.Label();
            this.btnSearchClan = new System.Windows.Forms.Button();
            this.txtSearchClan = new System.Windows.Forms.TextBox();
            this.lblBrClanskeKarte = new System.Windows.Forms.Label();
            this.btnAddKnjiga = new System.Windows.Forms.Button();
            this.lblSearchParam = new System.Windows.Forms.Label();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.dgvRazduzivanje = new System.Windows.Forms.DataGridView();
            this.lblRazduzivanje = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblClan = new System.Windows.Forms.Label();
            this.txtClan = new System.Windows.Forms.TextBox();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnZaduzi = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDateDo = new System.Windows.Forms.DateTimePicker();
            this.cmbKnjiga = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazduzivanje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(331, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 24);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Razduži knjige";
            // 
            // lblMsgClan
            // 
            this.lblMsgClan.AutoSize = true;
            this.lblMsgClan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgClan.Location = new System.Drawing.Point(63, 106);
            this.lblMsgClan.Name = "lblMsgClan";
            this.lblMsgClan.Size = new System.Drawing.Size(0, 13);
            this.lblMsgClan.TabIndex = 26;
            // 
            // btnSearchClan
            // 
            this.btnSearchClan.FlatAppearance.BorderSize = 3;
            this.btnSearchClan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchClan.Location = new System.Drawing.Point(305, 82);
            this.btnSearchClan.Name = "btnSearchClan";
            this.btnSearchClan.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClan.TabIndex = 25;
            this.btnSearchClan.Text = "Pretraži";
            this.btnSearchClan.UseVisualStyleBackColor = true;
            // 
            // txtSearchClan
            // 
            this.txtSearchClan.Location = new System.Drawing.Point(57, 83);
            this.txtSearchClan.Name = "txtSearchClan";
            this.txtSearchClan.Size = new System.Drawing.Size(228, 20);
            this.txtSearchClan.TabIndex = 24;
            // 
            // lblBrClanskeKarte
            // 
            this.lblBrClanskeKarte.AutoSize = true;
            this.lblBrClanskeKarte.Location = new System.Drawing.Point(22, 86);
            this.lblBrClanskeKarte.Name = "lblBrClanskeKarte";
            this.lblBrClanskeKarte.Size = new System.Drawing.Size(31, 13);
            this.lblBrClanskeKarte.TabIndex = 23;
            this.lblBrClanskeKarte.Text = "Clan:";
            // 
            // btnAddKnjiga
            // 
            this.btnAddKnjiga.Enabled = false;
            this.btnAddKnjiga.FlatAppearance.BorderSize = 3;
            this.btnAddKnjiga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddKnjiga.Location = new System.Drawing.Point(305, 140);
            this.btnAddKnjiga.Name = "btnAddKnjiga";
            this.btnAddKnjiga.Size = new System.Drawing.Size(75, 23);
            this.btnAddKnjiga.TabIndex = 33;
            this.btnAddKnjiga.Text = "Dodaj";
            this.btnAddKnjiga.UseVisualStyleBackColor = true;
            // 
            // lblSearchParam
            // 
            this.lblSearchParam.AutoSize = true;
            this.lblSearchParam.Location = new System.Drawing.Point(14, 145);
            this.lblSearchParam.Name = "lblSearchParam";
            this.lblSearchParam.Size = new System.Drawing.Size(39, 13);
            this.lblSearchParam.TabIndex = 31;
            this.lblSearchParam.Text = "Knjiga:";
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(421, 83);
            this.dgvSearch.MultiSelect = false;
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(350, 150);
            this.dgvSearch.TabIndex = 35;
            // 
            // dgvRazduzivanje
            // 
            this.dgvRazduzivanje.AllowUserToAddRows = false;
            this.dgvRazduzivanje.AllowUserToDeleteRows = false;
            this.dgvRazduzivanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRazduzivanje.Location = new System.Drawing.Point(19, 290);
            this.dgvRazduzivanje.MultiSelect = false;
            this.dgvRazduzivanje.Name = "dgvRazduzivanje";
            this.dgvRazduzivanje.ReadOnly = true;
            this.dgvRazduzivanje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRazduzivanje.Size = new System.Drawing.Size(340, 87);
            this.dgvRazduzivanje.TabIndex = 36;
            // 
            // lblRazduzivanje
            // 
            this.lblRazduzivanje.AutoSize = true;
            this.lblRazduzivanje.Location = new System.Drawing.Point(18, 264);
            this.lblRazduzivanje.Name = "lblRazduzivanje";
            this.lblRazduzivanje.Size = new System.Drawing.Size(108, 13);
            this.lblRazduzivanje.TabIndex = 37;
            this.lblRazduzivanje.Text = "Lista za razduzivanje:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMessage.Location = new System.Drawing.Point(304, 412);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(163, 13);
            this.lblMessage.TabIndex = 38;
            this.lblMessage.Text = "Odaberite knjige za razduzivanje.";
            // 
            // lblClan
            // 
            this.lblClan.AutoSize = true;
            this.lblClan.Location = new System.Drawing.Point(418, 264);
            this.lblClan.Name = "lblClan";
            this.lblClan.Size = new System.Drawing.Size(76, 13);
            this.lblClan.TabIndex = 40;
            this.lblClan.Text = "Odabrani clan:";
            // 
            // txtClan
            // 
            this.txtClan.Enabled = false;
            this.txtClan.Location = new System.Drawing.Point(421, 290);
            this.txtClan.Name = "txtClan";
            this.txtClan.Size = new System.Drawing.Size(202, 20);
            this.txtClan.TabIndex = 39;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.FlatAppearance.BorderSize = 3;
            this.btnIzbaci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzbaci.Location = new System.Drawing.Point(421, 354);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(75, 23);
            this.btnIzbaci.TabIndex = 41;
            this.btnIzbaci.Text = "Izbaci";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.FlatAppearance.BorderSize = 3;
            this.btnOdaberi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdaberi.Location = new System.Drawing.Point(305, 111);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberi.TabIndex = 42;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            // 
            // btnZaduzi
            // 
            this.btnZaduzi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.btnZaduzi.FlatAppearance.BorderSize = 3;
            this.btnZaduzi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZaduzi.Location = new System.Drawing.Point(696, 354);
            this.btnZaduzi.Name = "btnZaduzi";
            this.btnZaduzi.Size = new System.Drawing.Size(75, 23);
            this.btnZaduzi.TabIndex = 43;
            this.btnZaduzi.Text = "Razduzi";
            this.btnZaduzi.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(19, 178);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 13);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Datum razduzivanja:";
            // 
            // dtpDateDo
            // 
            this.dtpDateDo.Location = new System.Drawing.Point(20, 201);
            this.dtpDateDo.Name = "dtpDateDo";
            this.dtpDateDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDo.TabIndex = 44;
            // 
            // cmbKnjiga
            // 
            this.cmbKnjiga.Enabled = false;
            this.cmbKnjiga.FormattingEnabled = true;
            this.cmbKnjiga.Location = new System.Drawing.Point(57, 141);
            this.cmbKnjiga.Name = "cmbKnjiga";
            this.cmbKnjiga.Size = new System.Drawing.Size(228, 21);
            this.cmbKnjiga.TabIndex = 46;
            // 
            // UCRazduzivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbKnjiga);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDateDo);
            this.Controls.Add(this.btnZaduzi);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.lblClan);
            this.Controls.Add(this.txtClan);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblRazduzivanje);
            this.Controls.Add(this.dgvRazduzivanje);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnAddKnjiga);
            this.Controls.Add(this.lblSearchParam);
            this.Controls.Add(this.lblMsgClan);
            this.Controls.Add(this.btnSearchClan);
            this.Controls.Add(this.txtSearchClan);
            this.Controls.Add(this.lblBrClanskeKarte);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCRazduzivanje";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazduzivanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMsgClan;
        private System.Windows.Forms.Button btnSearchClan;
        private System.Windows.Forms.TextBox txtSearchClan;
        private System.Windows.Forms.Label lblBrClanskeKarte;
        private System.Windows.Forms.Button btnAddKnjiga;
        private System.Windows.Forms.Label lblSearchParam;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.DataGridView dgvRazduzivanje;
        private System.Windows.Forms.Label lblRazduzivanje;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.TextBox txtClan;
        private System.Windows.Forms.Button btnIzbaci;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnZaduzi;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDateDo;
        private System.Windows.Forms.ComboBox cmbKnjiga;

        public System.Windows.Forms.Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public System.Windows.Forms.Label LblMsgClan { get => lblMsgClan; set => lblMsgClan = value; }
        public System.Windows.Forms.Label LblBrClanskeKarte { get => lblBrClanskeKarte; set => lblBrClanskeKarte = value; }
        public System.Windows.Forms.Label LblSearchParam { get => lblSearchParam; set => lblSearchParam = value; }
        public System.Windows.Forms.Label LblRazduzivanje { get => lblRazduzivanje; set => lblRazduzivanje = value; }
        public System.Windows.Forms.Label LblMessage { get => lblMessage; set => lblMessage = value; }
        public System.Windows.Forms.Label LblClan { get => lblClan; set => lblClan = value; }
        public System.Windows.Forms.Label LblDate { get => lblDate; set => lblDate = value; }
        public System.Windows.Forms.Button BtnSearchClan { get => btnSearchClan; set => btnSearchClan = value; }
        public System.Windows.Forms.Button BtnAddKnjiga { get => btnAddKnjiga; set => btnAddKnjiga = value; }
        public System.Windows.Forms.Button BtnIzbaci { get => btnIzbaci; set => btnIzbaci = value; }
        public System.Windows.Forms.Button BtnOdaberi { get => btnOdaberi; set => btnOdaberi = value; }
        public System.Windows.Forms.Button BtnZaduzi { get => btnZaduzi; set => btnZaduzi = value; }
        public System.Windows.Forms.TextBox TxtSearchClan { get => txtSearchClan; set => txtSearchClan = value; }
        public System.Windows.Forms.TextBox TxtClan { get => txtClan; set => txtClan = value; }
        public System.Windows.Forms.DataGridView DgvSearch { get => dgvSearch; set => dgvSearch = value; }
        public System.Windows.Forms.DataGridView DgvRazduzivanje { get => dgvRazduzivanje; set => dgvRazduzivanje = value; }
        public System.Windows.Forms.DateTimePicker DtpDateDo { get => dtpDateDo; set => dtpDateDo = value; }
        public System.Windows.Forms.ComboBox CmbKnjiga { get => cmbKnjiga; set => cmbKnjiga = value; }

    }
}