namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UrunAdiTxt = new System.Windows.Forms.TextBox();
            this.KategoriUrunTxt = new System.Windows.Forms.ComboBox();
            this.UrunFiyatTxt = new System.Windows.Forms.TextBox();
            this.UrunStkTxt = new System.Windows.Forms.TextBox();
            this.UrunBirimTxt = new System.Windows.Forms.TextBox();
            this.UrunEkle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GunBirimAdet = new System.Windows.Forms.TextBox();
            this.GunStok = new System.Windows.Forms.TextBox();
            this.GunFiyat = new System.Windows.Forms.TextBox();
            this.GunKategori = new System.Windows.Forms.ComboBox();
            this.GunAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriye Göre Ara";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(319, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 59);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Adına Göre Ara";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UrunEkle);
            this.groupBox3.Controls.Add(this.UrunBirimTxt);
            this.groupBox3.Controls.Add(this.UrunStkTxt);
            this.groupBox3.Controls.Add(this.UrunFiyatTxt);
            this.groupBox3.Controls.Add(this.KategoriUrunTxt);
            this.groupBox3.Controls.Add(this.UrunAdiTxt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 488);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 224);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Ürün Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stok Adedi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Birim Adedi:";
            // 
            // UrunAdiTxt
            // 
            this.UrunAdiTxt.Location = new System.Drawing.Point(76, 30);
            this.UrunAdiTxt.Name = "UrunAdiTxt";
            this.UrunAdiTxt.Size = new System.Drawing.Size(248, 20);
            this.UrunAdiTxt.TabIndex = 5;
            // 
            // KategoriUrunTxt
            // 
            this.KategoriUrunTxt.FormattingEnabled = true;
            this.KategoriUrunTxt.Location = new System.Drawing.Point(76, 68);
            this.KategoriUrunTxt.Name = "KategoriUrunTxt";
            this.KategoriUrunTxt.Size = new System.Drawing.Size(248, 21);
            this.KategoriUrunTxt.TabIndex = 6;
            // 
            // UrunFiyatTxt
            // 
            this.UrunFiyatTxt.Location = new System.Drawing.Point(76, 103);
            this.UrunFiyatTxt.Name = "UrunFiyatTxt";
            this.UrunFiyatTxt.Size = new System.Drawing.Size(248, 20);
            this.UrunFiyatTxt.TabIndex = 7;
            // 
            // UrunStkTxt
            // 
            this.UrunStkTxt.Location = new System.Drawing.Point(76, 132);
            this.UrunStkTxt.Name = "UrunStkTxt";
            this.UrunStkTxt.Size = new System.Drawing.Size(248, 20);
            this.UrunStkTxt.TabIndex = 8;
            // 
            // UrunBirimTxt
            // 
            this.UrunBirimTxt.Location = new System.Drawing.Point(76, 162);
            this.UrunBirimTxt.Name = "UrunBirimTxt";
            this.UrunBirimTxt.Size = new System.Drawing.Size(248, 20);
            this.UrunBirimTxt.TabIndex = 9;
            // 
            // UrunEkle
            // 
            this.UrunEkle.Location = new System.Drawing.Point(76, 188);
            this.UrunEkle.Name = "UrunEkle";
            this.UrunEkle.Size = new System.Drawing.Size(248, 36);
            this.UrunEkle.TabIndex = 4;
            this.UrunEkle.Text = "Ekle";
            this.UrunEkle.UseVisualStyleBackColor = true;
            this.UrunEkle.Click += new System.EventHandler(this.UrunEkle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.GunBirimAdet);
            this.groupBox4.Controls.Add(this.GunStok);
            this.groupBox4.Controls.Add(this.GunFiyat);
            this.groupBox4.Controls.Add(this.GunKategori);
            this.groupBox4.Controls.Add(this.GunAd);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(458, 488);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 224);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Güncelle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GunBirimAdet
            // 
            this.GunBirimAdet.Location = new System.Drawing.Point(76, 162);
            this.GunBirimAdet.Name = "GunBirimAdet";
            this.GunBirimAdet.Size = new System.Drawing.Size(248, 20);
            this.GunBirimAdet.TabIndex = 9;
            // 
            // GunStok
            // 
            this.GunStok.Location = new System.Drawing.Point(76, 132);
            this.GunStok.Name = "GunStok";
            this.GunStok.Size = new System.Drawing.Size(248, 20);
            this.GunStok.TabIndex = 8;
            // 
            // GunFiyat
            // 
            this.GunFiyat.Location = new System.Drawing.Point(76, 103);
            this.GunFiyat.Name = "GunFiyat";
            this.GunFiyat.Size = new System.Drawing.Size(248, 20);
            this.GunFiyat.TabIndex = 7;
            // 
            // GunKategori
            // 
            this.GunKategori.FormattingEnabled = true;
            this.GunKategori.Location = new System.Drawing.Point(76, 68);
            this.GunKategori.Name = "GunKategori";
            this.GunKategori.Size = new System.Drawing.Size(248, 21);
            this.GunKategori.TabIndex = 6;
            // 
            // GunAd
            // 
            this.GunAd.Location = new System.Drawing.Point(76, 30);
            this.GunAd.Name = "GunAd";
            this.GunAd.Size = new System.Drawing.Size(248, 20);
            this.GunAd.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Birim Adedi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Stok Adedi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fiyat:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Kategori:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ürün Adı:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(518, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 136);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ürün Sil";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 43);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 724);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button UrunEkle;
        private System.Windows.Forms.TextBox UrunBirimTxt;
        private System.Windows.Forms.TextBox UrunStkTxt;
        private System.Windows.Forms.TextBox UrunFiyatTxt;
        private System.Windows.Forms.ComboBox KategoriUrunTxt;
        private System.Windows.Forms.TextBox UrunAdiTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox GunBirimAdet;
        private System.Windows.Forms.TextBox GunStok;
        private System.Windows.Forms.TextBox GunFiyat;
        private System.Windows.Forms.ComboBox GunKategori;
        private System.Windows.Forms.TextBox GunAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
    }
}

