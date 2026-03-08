namespace Client.UserControls
{
    partial class UCPretraziKnjigu
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
            this.lblMsgSearch = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvKnjiga = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchParam = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjiga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsgSearch
            // 
            this.lblMsgSearch.AutoSize = true;
            this.lblMsgSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMsgSearch.Location = new System.Drawing.Point(250, 111);
            this.lblMsgSearch.Name = "lblMsgSearch";
            this.lblMsgSearch.Size = new System.Drawing.Size(149, 13);
            this.lblMsgSearch.TabIndex = 30;
            this.lblMsgSearch.Text = "Pretražite po nazivu ili ISBN-u.";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMessage.Location = new System.Drawing.Point(309, 397);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(134, 13);
            this.lblMessage.TabIndex = 29;
            this.lblMessage.Text = "Pretrazite knjige po nazivu.";
            // 
            // btnLoad
            // 
            this.btnLoad.FlatAppearance.BorderSize = 3;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Location = new System.Drawing.Point(654, 82);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 31);
            this.btnLoad.TabIndex = 28;
            this.btnLoad.Text = "Prikazi knjigu";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(517, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvKnjiga
            // 
            this.dgvKnjiga.AllowUserToAddRows = false;
            this.dgvKnjiga.AllowUserToDeleteRows = false;
            this.dgvKnjiga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjiga.Location = new System.Drawing.Point(67, 134);
            this.dgvKnjiga.MultiSelect = false;
            this.dgvKnjiga.Name = "dgvKnjiga";
            this.dgvKnjiga.ReadOnly = true;
            this.dgvKnjiga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKnjiga.Size = new System.Drawing.Size(677, 244);
            this.dgvKnjiga.TabIndex = 26;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(244, 87);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(261, 20);
            this.txtSearch.TabIndex = 25;
            // 
            // lblSearchParam
            // 
            this.lblSearchParam.AutoSize = true;
            this.lblSearchParam.Location = new System.Drawing.Point(201, 91);
            this.lblSearchParam.Name = "lblSearchParam";
            this.lblSearchParam.Size = new System.Drawing.Size(39, 13);
            this.lblSearchParam.TabIndex = 24;
            this.lblSearchParam.Text = "Knjiga:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(312, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 24);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Pretraga knjiga";
            // 
            // UCPretraziKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMsgSearch);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvKnjiga);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearchParam);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCPretraziKnjigu";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjiga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsgSearch;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvKnjiga;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchParam;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public System.Windows.Forms.Label LblSearchParam { get => lblSearchParam; set => lblSearchParam = value; }
        public System.Windows.Forms.Label LblMessage { get => lblMessage; set => lblMessage = value; }
        public System.Windows.Forms.Label LblMsgSearch { get => lblMsgSearch; set => lblMsgSearch = value; }
        public System.Windows.Forms.TextBox TxtSearch { get => txtSearch; set => txtSearch = value; }
        public System.Windows.Forms.DataGridView DgvKnjiga { get => dgvKnjiga; set => dgvKnjiga = value; }
        public System.Windows.Forms.Button BtnSearch { get => btnSearch; set => btnSearch = value; }
        public System.Windows.Forms.Button BtnLoad { get => btnLoad; set => btnLoad = value; }
    }
}