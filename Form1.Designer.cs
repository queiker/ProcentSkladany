
namespace ProcentSkladany
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kapital_poczatkowy = new System.Windows.Forms.TextBox();
            this.txt_liczba_kapitalizacji_w_roku = new System.Windows.Forms.TextBox();
            this.txt_roczne_oprocentowanie_w_procentach = new System.Windows.Forms.TextBox();
            this.txt_liczba_lat_zapadalnosci_depozytu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_wynik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "kapitał początkowy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "liczba kapitalizacji w roku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "roczne oprocentowanie w procentach";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "liczba lat zapadalności depozytu";
            // 
            // txt_kapital_poczatkowy
            // 
            this.txt_kapital_poczatkowy.Location = new System.Drawing.Point(12, 36);
            this.txt_kapital_poczatkowy.Name = "txt_kapital_poczatkowy";
            this.txt_kapital_poczatkowy.Size = new System.Drawing.Size(183, 20);
            this.txt_kapital_poczatkowy.TabIndex = 5;
            // 
            // txt_liczba_kapitalizacji_w_roku
            // 
            this.txt_liczba_kapitalizacji_w_roku.Location = new System.Drawing.Point(12, 75);
            this.txt_liczba_kapitalizacji_w_roku.Name = "txt_liczba_kapitalizacji_w_roku";
            this.txt_liczba_kapitalizacji_w_roku.Size = new System.Drawing.Size(183, 20);
            this.txt_liczba_kapitalizacji_w_roku.TabIndex = 6;
            // 
            // txt_roczne_oprocentowanie_w_procentach
            // 
            this.txt_roczne_oprocentowanie_w_procentach.Location = new System.Drawing.Point(12, 114);
            this.txt_roczne_oprocentowanie_w_procentach.Name = "txt_roczne_oprocentowanie_w_procentach";
            this.txt_roczne_oprocentowanie_w_procentach.Size = new System.Drawing.Size(183, 20);
            this.txt_roczne_oprocentowanie_w_procentach.TabIndex = 7;
            // 
            // txt_liczba_lat_zapadalnosci_depozytu
            // 
            this.txt_liczba_lat_zapadalnosci_depozytu.Location = new System.Drawing.Point(12, 153);
            this.txt_liczba_lat_zapadalnosci_depozytu.Name = "txt_liczba_lat_zapadalnosci_depozytu";
            this.txt_liczba_lat_zapadalnosci_depozytu.Size = new System.Drawing.Size(183, 20);
            this.txt_liczba_lat_zapadalnosci_depozytu.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_wynik
            // 
            this.lbl_wynik.AutoSize = true;
            this.lbl_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_wynik.ForeColor = System.Drawing.Color.Red;
            this.lbl_wynik.Location = new System.Drawing.Point(213, 191);
            this.lbl_wynik.Name = "lbl_wynik";
            this.lbl_wynik.Size = new System.Drawing.Size(311, 37);
            this.lbl_wynik.TabIndex = 11;
            this.lbl_wynik.Text = "XXXXXXXXXXXXXX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_wynik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_liczba_lat_zapadalnosci_depozytu);
            this.Controls.Add(this.txt_roczne_oprocentowanie_w_procentach);
            this.Controls.Add(this.txt_liczba_kapitalizacji_w_roku);
            this.Controls.Add(this.txt_kapital_poczatkowy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Procent składany";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kapital_poczatkowy;
        private System.Windows.Forms.TextBox txt_liczba_kapitalizacji_w_roku;
        private System.Windows.Forms.TextBox txt_roczne_oprocentowanie_w_procentach;
        private System.Windows.Forms.TextBox txt_liczba_lat_zapadalnosci_depozytu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_wynik;
    }
}

