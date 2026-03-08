namespace Client.UserControls
{
    partial class UCZaduzivanje
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlClan = new System.Windows.Forms.Panel();
            this.pnlKnjige = new System.Windows.Forms.Panel();
            this.dgvZaduzenje = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtClan = new System.Windows.Forms.TextBox();
            this.lblClan = new System.Windows.Forms.Label();
            this.dtpDateOd = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(337, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 24);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Zaduži knjige";
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderSize = 3;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Location = new System.Drawing.Point(722, 354);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 29;
            this.btnRemove.Text = "Izbaci knjigu";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // pnlClan
            // 
            this.pnlClan.AutoScroll = true;
            this.pnlClan.Location = new System.Drawing.Point(5, 57);
            this.pnlClan.Name = "pnlClan";
            this.pnlClan.Size = new System.Drawing.Size(387, 278);
            this.pnlClan.TabIndex = 30;
            // 
            // pnlKnjige
            // 
            this.pnlKnjige.AutoScroll = true;
            this.pnlKnjige.Location = new System.Drawing.Point(413, 57);
            this.pnlKnjige.Name = "pnlKnjige";
            this.pnlKnjige.Size = new System.Drawing.Size(387, 278);
            this.pnlKnjige.TabIndex = 31;
            // 
            // dgvZaduzenje
            // 
            this.dgvZaduzenje.AllowUserToAddRows = false;
            this.dgvZaduzenje.AllowUserToDeleteRows = false;
            this.dgvZaduzenje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaduzenje.Location = new System.Drawing.Point(231, 342);
            this.dgvZaduzenje.MultiSelect = false;
            this.dgvZaduzenje.Name = "dgvZaduzenje";
            this.dgvZaduzenje.ReadOnly = true;
            this.dgvZaduzenje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaduzenje.Size = new System.Drawing.Size(460, 84);
            this.dgvZaduzenje.TabIndex = 32;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(722, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtClan
            // 
            this.txtClan.Enabled = false;
            this.txtClan.Location = new System.Drawing.Point(8, 357);
            this.txtClan.Name = "txtClan";
            this.txtClan.Size = new System.Drawing.Size(202, 20);
            this.txtClan.TabIndex = 34;
            // 
            // lblClan
            // 
            this.lblClan.AutoSize = true;
            this.lblClan.Location = new System.Drawing.Point(23, 341);
            this.lblClan.Name = "lblClan";
            this.lblClan.Size = new System.Drawing.Size(76, 13);
            this.lblClan.TabIndex = 35;
            this.lblClan.Text = "Odabrani clan:";
            // 
            // dtpDateOd
            // 
            this.dtpDateOd.Location = new System.Drawing.Point(8, 400);
            this.dtpDateOd.Name = "dtpDateOd";
            this.dtpDateOd.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOd.TabIndex = 36;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 382);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 13);
            this.lblDate.TabIndex = 37;
            this.lblDate.Text = "Datum zaduzivanja:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMessage.Location = new System.Drawing.Point(338, 429);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(240, 13);
            this.lblMessage.TabIndex = 38;
            this.lblMessage.Text = "Odaberite člana, knjige i datum novog zaduženja.";
            // 
            // UCZaduzivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dgvZaduzenje);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDateOd);
            this.Controls.Add(this.lblClan);
            this.Controls.Add(this.txtClan);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlKnjige);
            this.Controls.Add(this.pnlClan);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCZaduzivanje";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlClan;
        private System.Windows.Forms.Panel pnlKnjige;
        private System.Windows.Forms.DataGridView dgvZaduzenje;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtClan;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.DateTimePicker dtpDateOd;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMessage;

        public System.Windows.Forms.Panel PnlKnjige { get => pnlKnjige; set => pnlKnjige = value; }
        public System.Windows.Forms.Panel PnlClan { get => pnlClan; set => pnlClan = value; }
        public System.Windows.Forms.Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public System.Windows.Forms.Label LblClan { get => lblClan; set => lblClan = value; }
        public System.Windows.Forms.Label LblDate { get => lblDate; set => lblDate = value; }
        public System.Windows.Forms.Label LblMessage { get => lblMessage; set => lblMessage = value; }
        public System.Windows.Forms.Button BtnRemove { get => btnRemove; set => btnRemove = value; }
        public System.Windows.Forms.Button BtnSave { get => btnSave; set => btnSave = value; }
        public System.Windows.Forms.DataGridView DgvZaduzenje { get => dgvZaduzenje; set => dgvZaduzenje = value; }
        public System.Windows.Forms.DateTimePicker DtpDateOd { get => dtpDateOd; set => dtpDateOd = value; }
        public System.Windows.Forms.TextBox TxtClan { get => txtClan; set => txtClan = value; }

    }
}