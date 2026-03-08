using System.Reflection.Emit;
using System.Windows.Forms;

namespace Client
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblMsgUsername = new System.Windows.Forms.Label();
            this.lblMsgPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnChangeRole = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsgUsername
            // 
            this.lblMsgUsername.AutoSize = true;
            this.lblMsgUsername.Location = new System.Drawing.Point(205, 135);
            this.lblMsgUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsgUsername.Name = "lblMsgUsername";
            this.lblMsgUsername.Size = new System.Drawing.Size(0, 17);
            this.lblMsgUsername.TabIndex = 6;
            // 
            // lblMsgPassword
            // 
            this.lblMsgPassword.AutoSize = true;
            this.lblMsgPassword.Location = new System.Drawing.Point(207, 193);
            this.lblMsgPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsgPassword.Name = "lblMsgPassword";
            this.lblMsgPassword.Size = new System.Drawing.Size(0, 17);
            this.lblMsgPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(118, 127);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Šifra:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Purple;
            this.lblText.Location = new System.Drawing.Point(34, 59);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(231, 17);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "Unesite broj članske karte i lozinku:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Thistle;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(191, 169);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 26);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Prijavite se";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(34, 85);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(125, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Broj članske karte:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(165, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(187, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(165, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // btnChangeRole
            // 
            this.btnChangeRole.BackColor = System.Drawing.Color.Thistle;
            this.btnChangeRole.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChangeRole.FlatAppearance.BorderSize = 3;
            this.btnChangeRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRole.Location = new System.Drawing.Point(354, 217);
            this.btnChangeRole.Name = "btnChangeRole";
            this.btnChangeRole.Size = new System.Drawing.Size(100, 27);
            this.btnChangeRole.TabIndex = 5;
            this.btnChangeRole.Text = "Admin log- in";
            this.btnChangeRole.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(144, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 31);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Prijava za članove";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.lblMsgPassword);
            this.pnlLogin.Controls.Add(this.lblTitle);
            this.pnlLogin.Controls.Add(this.lblMsgUsername);
            this.pnlLogin.Controls.Add(this.btnChangeRole);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblText);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Location = new System.Drawing.Point(69, 50);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(469, 257);
            this.pnlLogin.TabIndex = 8;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.LoginFinalna;
            this.ClientSize = new System.Drawing.Size(606, 368);
            this.Controls.Add(this.pnlLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Prijavite se";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMsgUsername;
        private System.Windows.Forms.Label lblMsgPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblText;
        private Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnChangeRole;
        private System.Windows.Forms.Label lblTitle;
        private Panel pnlLogin;

        public System.Windows.Forms.Label LblUsername { get => lblUsername; set => lblUsername = value; }
        public System.Windows.Forms.Label LblPassword { get => lblPassword; set => lblPassword = value; }
        public System.Windows.Forms.Label LblCurrentRole { get => lblText; set => lblText = value; }
        public System.Windows.Forms.Label LblMsgUsername { get => lblMsgUsername; set => lblMsgUsername = value; }
        public System.Windows.Forms.Label LblMsgPassword { get => lblMsgPassword; set => lblMsgPassword = value; }
        public System.Windows.Forms.Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public System.Windows.Forms.Label LblText { get => lblText; set => lblText = value; }
        public TextBox TxtUsername { get => txtUsername; set => txtUsername = value; }
        public TextBox TxtPassword { get => txtPassword; set => txtPassword = value; }
        public Panel PnlLogin { get => pnlLogin; set => pnlLogin = value; }
        public Button BtnLogin { get => btnLogin; set => btnLogin = value; }
        public Button BtnChangeRole { get => btnChangeRole; set => btnChangeRole = value; }

    }
}
