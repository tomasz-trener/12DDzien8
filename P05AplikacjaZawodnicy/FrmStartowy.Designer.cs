namespace P05AplikacjaZawodnicy
{
    partial class FrmStartowy
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
            this.lvDane = new System.Windows.Forms.ListView();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.btnNowy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKraje = new System.Windows.Forms.ComboBox();
            this.btnRaport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStrona = new System.Windows.Forms.TextBox();
            this.btnLewo = new System.Windows.Forms.Button();
            this.btnPrawo = new System.Windows.Forms.Button();
            this.txtIleWyswietlac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSortowanie = new System.Windows.Forms.ComboBox();
            this.wbRaport = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lvDane
            // 
            this.lvDane.HideSelection = false;
            this.lvDane.Location = new System.Drawing.Point(12, 72);
            this.lvDane.Name = "lvDane";
            this.lvDane.Size = new System.Drawing.Size(347, 288);
            this.lvDane.TabIndex = 0;
            this.lvDane.UseCompatibleStateImageBehavior = false;
            this.lvDane.SelectedIndexChanged += new System.EventHandler(this.lvDane_SelectedIndexChanged);
            this.lvDane.DoubleClick += new System.EventHandler(this.lvDane_DoubleClick);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 43);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Enabled = false;
            this.btnSzczegoly.Location = new System.Drawing.Point(284, 43);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(75, 23);
            this.btnSzczegoly.TabIndex = 2;
            this.btnSzczegoly.Text = "Szczegóły";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // btnNowy
            // 
            this.btnNowy.Enabled = false;
            this.btnNowy.Location = new System.Drawing.Point(203, 43);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(75, 23);
            this.btnNowy.TabIndex = 3;
            this.btnNowy.Text = "Nowy";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kraj";
            // 
            // cbKraje
            // 
            this.cbKraje.FormattingEnabled = true;
            this.cbKraje.Location = new System.Drawing.Point(259, 12);
            this.cbKraje.Name = "cbKraje";
            this.cbKraje.Size = new System.Drawing.Size(100, 21);
            this.cbKraje.TabIndex = 6;
            // 
            // btnRaport
            // 
            this.btnRaport.Location = new System.Drawing.Point(93, 43);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(75, 23);
            this.btnRaport.TabIndex = 7;
            this.btnRaport.Text = "Raport";
            this.btnRaport.UseVisualStyleBackColor = true;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Strona";
            // 
            // txtStrona
            // 
            this.txtStrona.Location = new System.Drawing.Point(284, 366);
            this.txtStrona.Name = "txtStrona";
            this.txtStrona.Size = new System.Drawing.Size(37, 20);
            this.txtStrona.TabIndex = 14;
            this.txtStrona.Text = "1";
            // 
            // btnLewo
            // 
            this.btnLewo.Location = new System.Drawing.Point(246, 364);
            this.btnLewo.Name = "btnLewo";
            this.btnLewo.Size = new System.Drawing.Size(32, 23);
            this.btnLewo.TabIndex = 13;
            this.btnLewo.Text = "<-";
            this.btnLewo.UseVisualStyleBackColor = true;
            this.btnLewo.Click += new System.EventHandler(this.btnLewo_Click);
            // 
            // btnPrawo
            // 
            this.btnPrawo.Location = new System.Drawing.Point(327, 364);
            this.btnPrawo.Name = "btnPrawo";
            this.btnPrawo.Size = new System.Drawing.Size(32, 23);
            this.btnPrawo.TabIndex = 12;
            this.btnPrawo.Text = "->";
            this.btnPrawo.UseVisualStyleBackColor = true;
            this.btnPrawo.Click += new System.EventHandler(this.btnPrawo_Click);
            // 
            // txtIleWyswietlac
            // 
            this.txtIleWyswietlac.Location = new System.Drawing.Point(90, 367);
            this.txtIleWyswietlac.Name = "txtIleWyswietlac";
            this.txtIleWyswietlac.Size = new System.Drawing.Size(37, 20);
            this.txtIleWyswietlac.TabIndex = 16;
            this.txtIleWyswietlac.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ile wyświetlać";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sortowanie";
            // 
            // cbSortowanie
            // 
            this.cbSortowanie.FormattingEnabled = true;
            this.cbSortowanie.Location = new System.Drawing.Point(81, 15);
            this.cbSortowanie.Name = "cbSortowanie";
            this.cbSortowanie.Size = new System.Drawing.Size(87, 21);
            this.cbSortowanie.TabIndex = 19;
            // 
            // wbRaport
            // 
            this.wbRaport.Location = new System.Drawing.Point(365, 72);
            this.wbRaport.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbRaport.Name = "wbRaport";
            this.wbRaport.Size = new System.Drawing.Size(321, 288);
            this.wbRaport.TabIndex = 20;
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 398);
            this.Controls.Add(this.wbRaport);
            this.Controls.Add(this.cbSortowanie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIleWyswietlac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStrona);
            this.Controls.Add(this.btnLewo);
            this.Controls.Add(this.btnPrawo);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.cbKraje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNowy);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lvDane);
            this.Name = "FrmStartowy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnSzczegoly;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKraje;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStrona;
        private System.Windows.Forms.Button btnLewo;
        private System.Windows.Forms.Button btnPrawo;
        private System.Windows.Forms.TextBox txtIleWyswietlac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSortowanie;
        private System.Windows.Forms.WebBrowser wbRaport;
    }
}

