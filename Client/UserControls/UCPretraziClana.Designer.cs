namespace Client.UserControls
{
    partial class UCPretraziClana
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoadClan = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSearchText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(305, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 24);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Pretraga članova";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(209, 86);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(31, 13);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Član:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(249, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(263, 20);
            this.txtSearch.TabIndex = 17;
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.AllowUserToAddRows = false;
            this.dgvClanovi.AllowUserToDeleteRows = false;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(107, 132);
            this.dgvClanovi.MultiSelect = false;
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.ReadOnly = true;
            this.dgvClanovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClanovi.Size = new System.Drawing.Size(559, 244);
            this.dgvClanovi.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(532, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLoadClan
            // 
            this.btnLoadClan.FlatAppearance.BorderSize = 3;
            this.btnLoadClan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadClan.Location = new System.Drawing.Point(688, 132);
            this.btnLoadClan.Name = "btnLoadClan";
            this.btnLoadClan.Size = new System.Drawing.Size(75, 31);
            this.btnLoadClan.TabIndex = 20;
            this.btnLoadClan.Text = "Prikaži člana";
            this.btnLoadClan.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMessage.Location = new System.Drawing.Point(251, 395);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(297, 13);
            this.lblMessage.TabIndex = 21;
            this.lblMessage.Text = "Pretražite članove po broju članske karte, imenu ili prezimenu.";
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSearchText.Location = new System.Drawing.Point(251, 108);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(247, 13);
            this.lblSearchText.TabIndex = 22;
            this.lblSearchText.Text = "Pretraži po broju članske karte, imenu ili prezimenu.";
            // 
            // UCPretraziClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSearchText);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLoadClan);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvClanovi);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCPretraziClana";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoadClan;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSearchText;

        public System.Windows.Forms.Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public System.Windows.Forms.Label LblSearch { get => lblSearch; set => lblSearch = value; }
        public System.Windows.Forms.Label LblMessage { get => lblMessage; set => lblMessage = value; }
        public System.Windows.Forms.Label LblSearchText { get => lblSearchText; set => lblSearchText = value; }
        public System.Windows.Forms.TextBox TxtSearch { get => txtSearch; set => txtSearch = value; }
        public System.Windows.Forms.DataGridView DgvClanovi { get => dgvClanovi; set => dgvClanovi = value; }
        public System.Windows.Forms.Button BtnSearch { get => btnSearch; set => btnSearch = value; }
        public System.Windows.Forms.Button BtnLoadClan { get => btnLoadClan; set => btnLoadClan = value; }

    }
}