namespace Client.UserControls
{
    partial class UCMainClan
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblClan = new System.Windows.Forms.Label();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.lblClanText = new System.Windows.Forms.Label();
            this.lblTextZaduzenja = new System.Windows.Forms.Label();
            this.dgvZaduzenja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenja)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(221, 135);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(329, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(132, 141);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(83, 15);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Naslov knjige:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(326, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 26);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Dobrodošli!";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(578, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 26);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblClan
            // 
            this.lblClan.AutoSize = true;
            this.lblClan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClan.Location = new System.Drawing.Point(159, 241);
            this.lblClan.Name = "lblClan";
            this.lblClan.Size = new System.Drawing.Size(0, 15);
            this.lblClan.TabIndex = 5;
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSearchText.Location = new System.Drawing.Point(229, 109);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(98, 15);
            this.lblSearchText.TabIndex = 8;
            this.lblSearchText.Text = "Pretražite knjige:";
            // 
            // lblClanText
            // 
            this.lblClanText.AutoSize = true;
            this.lblClanText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClanText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblClanText.Location = new System.Drawing.Point(197, 210);
            this.lblClanText.Name = "lblClanText";
            this.lblClanText.Size = new System.Drawing.Size(54, 15);
            this.lblClanText.TabIndex = 9;
            this.lblClanText.Text = "Korisnik:";
            // 
            // lblTextZaduzenja
            // 
            this.lblTextZaduzenja.AutoSize = true;
            this.lblTextZaduzenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextZaduzenja.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTextZaduzenja.Location = new System.Drawing.Point(430, 210);
            this.lblTextZaduzenja.Name = "lblTextZaduzenja";
            this.lblTextZaduzenja.Size = new System.Drawing.Size(117, 15);
            this.lblTextZaduzenja.TabIndex = 10;
            this.lblTextZaduzenja.Text = "Aktuelna zaduženja:";
            // 
            // dgvZaduzenja
            // 
            this.dgvZaduzenja.AllowUserToAddRows = false;
            this.dgvZaduzenja.AllowUserToDeleteRows = false;
            this.dgvZaduzenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaduzenja.Location = new System.Drawing.Point(404, 241);
            this.dgvZaduzenja.Name = "dgvZaduzenja";
            this.dgvZaduzenja.ReadOnly = true;
            this.dgvZaduzenja.Size = new System.Drawing.Size(319, 150);
            this.dgvZaduzenja.TabIndex = 11;
            // 
            // UCMainClan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvZaduzenja);
            this.Controls.Add(this.lblTextZaduzenja);
            this.Controls.Add(this.lblClanText);
            this.Controls.Add(this.lblSearchText);
            this.Controls.Add(this.lblClan);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "UCMainClan";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaduzenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.Label lblClanText;
        private System.Windows.Forms.Label lblTextZaduzenja;
        private System.Windows.Forms.DataGridView dgvZaduzenja;

        public System.Windows.Forms.Label LblSearch { get => lblSearch; set => lblSearch = value; }
        public System.Windows.Forms.Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public System.Windows.Forms.Label LblClan { get => lblClan; set => lblClan = value; }
        public System.Windows.Forms.Label LblSearchText { get => lblSearchText; set => lblSearchText = value; }
        public System.Windows.Forms.Label LblClanText { get => lblClanText; set => lblClanText = value; }
        public System.Windows.Forms.Label LblTextZaduzenja { get => lblTextZaduzenja; set => lblTextZaduzenja = value; }
        public System.Windows.Forms.TextBox TxtSearch { get => txtSearch; set => txtSearch = value; }
        public System.Windows.Forms.Button BtnSearch { get => btnSearch; set => btnSearch = value; }
        public System.Windows.Forms.DataGridView DgvZaduzenja { get => dgvZaduzenja; set => dgvZaduzenja = value; }

    }
}