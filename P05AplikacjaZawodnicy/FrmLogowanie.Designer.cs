namespace P05AplikacjaZawodnicy
{
    partial class FrmLogowanie
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
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Location = new System.Drawing.Point(95, 90);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(75, 23);
            this.btnZaloguj.TabIndex = 0;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = true;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(17, 26);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(153, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // txtHaslo
            // 
            this.txtHaslo.Location = new System.Drawing.Point(17, 64);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.PasswordChar = '*';
            this.txtHaslo.Size = new System.Drawing.Size(153, 20);
            this.txtHaslo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło";
            // 
            // FrmLogowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 134);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHaslo);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnZaloguj);
            this.Name = "FrmLogowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}