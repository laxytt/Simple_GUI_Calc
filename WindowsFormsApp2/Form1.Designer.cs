namespace WindowsFormsApp2
{
    partial class kalkulator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kalkulator));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.przecinek = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.pomnoz = new System.Windows.Forms.Button();
            this.podziel = new System.Windows.Forms.Button();
            this.procent = new System.Windows.Forms.Button();
            this.pierwiastek = new System.Windows.Forms.Button();
            this.logarytm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(55, 181);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(21, 111);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(28, 27);
            this.n1.TabIndex = 2;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.button1_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.Color.Transparent;
            this.n2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n2.Location = new System.Drawing.Point(55, 111);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(28, 27);
            this.n2.TabIndex = 3;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.Color.Transparent;
            this.n3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n3.Location = new System.Drawing.Point(89, 111);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(28, 27);
            this.n3.TabIndex = 4;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.Color.Transparent;
            this.n6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n6.Location = new System.Drawing.Point(89, 78);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(28, 27);
            this.n6.TabIndex = 7;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.Color.Transparent;
            this.n5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n5.Location = new System.Drawing.Point(55, 78);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(28, 27);
            this.n5.TabIndex = 6;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(21, 78);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(28, 27);
            this.n4.TabIndex = 5;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.Color.Transparent;
            this.n9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n9.Location = new System.Drawing.Point(89, 45);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(28, 27);
            this.n9.TabIndex = 10;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.Color.Transparent;
            this.n8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n8.Location = new System.Drawing.Point(55, 45);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(28, 27);
            this.n8.TabIndex = 9;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(21, 45);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(28, 27);
            this.n7.TabIndex = 8;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(21, 144);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(62, 23);
            this.n0.TabIndex = 11;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // przecinek
            // 
            this.przecinek.BackColor = System.Drawing.Color.Transparent;
            this.przecinek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.przecinek.Location = new System.Drawing.Point(89, 140);
            this.przecinek.Name = "przecinek";
            this.przecinek.Size = new System.Drawing.Size(28, 27);
            this.przecinek.TabIndex = 12;
            this.przecinek.Text = ",";
            this.przecinek.UseVisualStyleBackColor = false;
            this.przecinek.Click += new System.EventHandler(this.przecinek_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Transparent;
            this.del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.del.Location = new System.Drawing.Point(21, 12);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(43, 27);
            this.del.TabIndex = 13;
            this.del.Text = "C";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // wynik
            // 
            this.wynik.BackColor = System.Drawing.Color.Transparent;
            this.wynik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.wynik.Location = new System.Drawing.Point(123, 140);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(28, 27);
            this.wynik.TabIndex = 14;
            this.wynik.Text = "=";
            this.wynik.UseVisualStyleBackColor = false;
            this.wynik.Click += new System.EventHandler(this.wynik_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Transparent;
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plus.Location = new System.Drawing.Point(123, 111);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(28, 27);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Transparent;
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minus.Location = new System.Drawing.Point(123, 78);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(28, 27);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // pomnoz
            // 
            this.pomnoz.BackColor = System.Drawing.Color.Transparent;
            this.pomnoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pomnoz.Location = new System.Drawing.Point(123, 45);
            this.pomnoz.Name = "pomnoz";
            this.pomnoz.Size = new System.Drawing.Size(28, 27);
            this.pomnoz.TabIndex = 17;
            this.pomnoz.Text = "x";
            this.pomnoz.UseVisualStyleBackColor = false;
            this.pomnoz.Click += new System.EventHandler(this.pomnoz_Click);
            // 
            // podziel
            // 
            this.podziel.BackColor = System.Drawing.Color.Transparent;
            this.podziel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.podziel.Location = new System.Drawing.Point(123, 12);
            this.podziel.Name = "podziel";
            this.podziel.Size = new System.Drawing.Size(28, 27);
            this.podziel.TabIndex = 18;
            this.podziel.Text = "/";
            this.podziel.UseVisualStyleBackColor = false;
            this.podziel.Click += new System.EventHandler(this.podziel_Click);
            // 
            // procent
            // 
            this.procent.BackColor = System.Drawing.Color.Transparent;
            this.procent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.procent.Location = new System.Drawing.Point(89, 12);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(28, 27);
            this.procent.TabIndex = 19;
            this.procent.Text = "%";
            this.procent.UseVisualStyleBackColor = false;
            this.procent.Click += new System.EventHandler(this.procent_Click);
            // 
            // pierwiastek
            // 
            this.pierwiastek.BackColor = System.Drawing.Color.Transparent;
            this.pierwiastek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pierwiastek.Location = new System.Drawing.Point(157, 12);
            this.pierwiastek.Name = "pierwiastek";
            this.pierwiastek.Size = new System.Drawing.Size(41, 27);
            this.pierwiastek.TabIndex = 20;
            this.pierwiastek.Text = "V";
            this.pierwiastek.UseVisualStyleBackColor = false;
            this.pierwiastek.Click += new System.EventHandler(this.pierwiastek_Click);
            // 
            // logarytm
            // 
            this.logarytm.BackColor = System.Drawing.Color.Transparent;
            this.logarytm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logarytm.Location = new System.Drawing.Point(157, 45);
            this.logarytm.Name = "logarytm";
            this.logarytm.Size = new System.Drawing.Size(41, 27);
            this.logarytm.TabIndex = 21;
            this.logarytm.Text = "log";
            this.logarytm.UseVisualStyleBackColor = false;
            this.logarytm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(271, 228);
            this.Controls.Add(this.logarytm);
            this.Controls.Add(this.pierwiastek);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.podziel);
            this.Controls.Add(this.pomnoz);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.del);
            this.Controls.Add(this.przecinek);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "kalkulator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.kalkulator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button przecinek;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button wynik;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button pomnoz;
        private System.Windows.Forms.Button podziel;
        private System.Windows.Forms.Button procent;
        private System.Windows.Forms.Button pierwiastek;
        private System.Windows.Forms.Button logarytm;
    }
}

