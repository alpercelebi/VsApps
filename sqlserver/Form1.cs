using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal productOku = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            tablo1.DataSource = productOku.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            productOku.Add(new Product()
            {
                name = textname.Text,
                deger = Convert.ToInt32(textdeger.Text),
                stok = Convert.ToInt32(textstok.Text)
            });
            MessageBox.Show("ürün eklendi");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                id = Convert.ToInt32(textid.Text),
                name=textname.Text,
                deger=Convert.ToInt32(textdeger.Text),
                stok=Convert.ToInt32(textstok.Text)
            };

            productOku.Update(product);
            LoadForm();
            MessageBox.Show("ürün güncellendi");

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                id = Convert.ToInt32(textid.Text)
            };
            productOku.Delete(product);
            LoadForm();
            MessageBox.Show("ürün silindi");
            
        }
    }
}
