using System.Reflection.Emit;

namespace Client.UserControls
{
    partial class UCDefaultMain
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserData = new System.Windows.Forms.Label();
            this.btnAddKnjiga = new System.Windows.Forms.Button();
            this.btnAddClana = new System.Windows.Forms.Button();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnZaduzi = new System.Windows.Forms.Button();
            this.btnRazduzi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(328, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 26);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Dobrodošli!";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUser.Location = new System.Drawing.Point(66, 96);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(54, 15);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Korisnik:";
            // 
            // lblUserData
            // 
            this.lblUserData.AutoSize = true;
            this.lblUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserData.Location = new System.Drawing.Point(23, 80);
            this.lblUserData.Name = "lblUserData";
            this.lblUserData.Size = new System.Drawing.Size(0, 15);
            this.lblUserData.TabIndex = 10;
            // 
            // btnAddKnjiga
            // 
            this.btnAddKnjiga.FlatAppearance.BorderSize = 3;
            this.btnAddKnjiga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddKnjiga.Location = new System.Drawing.Point(255, 306);
            this.btnAddKnjiga.Name = "btnAddKnjiga";
            this.btnAddKnjiga.Size = new System.Drawing.Size(107, 42);
            this.btnAddKnjiga.TabIndex = 13;
            this.btnAddKnjiga.Text = "Dodaj knjigu";
            this.btnAddKnjiga.UseVisualStyleBackColor = true;
            // 
            // btnAddClana
            // 
            this.btnAddClana.FlatAppearance.BorderSize = 3;
            this.btnAddClana.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddClana.Location = new System.Drawing.Point(69, 306);
            this.btnAddClana.Name = "btnAddClana";
            this.btnAddClana.Size = new System.Drawing.Size(107, 42);
            this.btnAddClana.TabIndex = 14;
            this.btnAddClana.Text = "Dodaj člana";
            this.btnAddClana.UseVisualStyleBackColor = true;
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSearchText.Location = new System.Drawing.Point(251, 181);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(84, 15);
            this.lblSearchText.TabIndex = 18;
            this.lblSearchText.Text = "Brza pretraga:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(600, 207);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 26);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(243, 207);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(329, 26);
            this.txtSearch.TabIndex = 15;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(131, 207);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(102, 26);
            this.cmbSearch.TabIndex = 19;
            // 
            // btnZaduzi
            // 
            this.btnZaduzi.FlatAppearance.BorderSize = 3;
            this.btnZaduzi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZaduzi.Location = new System.Drawing.Point(443, 306);
            this.btnZaduzi.Name = "btnZaduzi";
            this.btnZaduzi.Size = new System.Drawing.Size(107, 42);
            this.btnZaduzi.TabIndex = 20;
            this.btnZaduzi.Text = "Zaduži knjigu";
            this.btnZaduzi.UseVisualStyleBackColor = true;
            // 
            // btnRazduzi
            // 
            this.btnRazduzi.FlatAppearance.BorderSize = 3;
            this.btnRazduzi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRazduzi.Location = new System.Drawing.Point(617, 306);
            this.btnRazduzi.Name = "btnRazduzi";
            this.btnRazduzi.Size = new System.Drawing.Size(107, 42);
            this.btnRazduzi.TabIndex = 21;
            this.btnRazduzi.Text = "Razduži knjigu";
            this.btnRazduzi.UseVisualStyleBackColor = true;
            // 
            // UCDefaultMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRazduzi);
            this.Controls.Add(this.btnZaduzi);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.lblSearchText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddClana);
            this.Controls.Add(this.btnAddKnjiga);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserData);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCDefaultMain";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserData;
        private System.Windows.Forms.Button btnAddKnjiga;
        private System.Windows.Forms.Button btnAddClana;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnZaduzi;
        private System.Windows.Forms.Button btnRazduzi;

        public System.Windows.Forms.Label LblUser { get => lblUser; set => lblUser = value; }
        public System.Windows.Forms.Label LblUserData { get => lblUserData; set => lblUserData = value; }
        public System.Windows.Forms.Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public System.Windows.Forms.Label LblSearchText { get => lblSearchText; set => lblSearchText = value; }
        public System.Windows.Forms.TextBox TxtSearch { get => txtSearch; set => txtSearch = value; }
        public System.Windows.Forms.ComboBox CmbSearch { get => cmbSearch; set => cmbSearch = value; }
        public System.Windows.Forms.Button BtnSearch { get => btnSearch; set => btnSearch = value; }
        public System.Windows.Forms.Button BtnAddKnjiga { get => btnAddKnjiga; set => btnAddKnjiga = value; }
        public System.Windows.Forms.Button BtnAddClana { get => btnAddClana; set => btnAddClana = value; }
        public System.Windows.Forms.Button BtnZaduzi { get => btnZaduzi; set => btnZaduzi = value; }
        public System.Windows.Forms.Button BtnRazduzi { get => btnRazduzi; set => btnRazduzi = value; }

    }
}
