namespace sqlserver
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablo1 = new System.Windows.Forms.DataGridView();
            this.textname = new System.Windows.Forms.TextBox();
            this.textdeger = new System.Windows.Forms.TextBox();
            this.textstok = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablo1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablo1
            // 
            this.tablo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo1.Location = new System.Drawing.Point(62, 162);
            this.tablo1.Name = "tablo1";
            this.tablo1.Size = new System.Drawing.Size(269, 167);
            this.tablo1.TabIndex = 0;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(167, 25);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 1;
            // 
            // textdeger
            // 
            this.textdeger.Location = new System.Drawing.Point(167, 65);
            this.textdeger.Name = "textdeger";
            this.textdeger.Size = new System.Drawing.Size(100, 20);
            this.textdeger.TabIndex = 2;
            // 
            // textstok
            // 
            this.textstok.Location = new System.Drawing.Point(167, 106);
            this.textstok.Name = "textstok";
            this.textstok.Size = new System.Drawing.Size(100, 20);
            this.textstok.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(47, 136);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textstok);
            this.Controls.Add(this.textdeger);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.tablo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablo1;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textdeger;
        private System.Windows.Forms.TextBox textstok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

