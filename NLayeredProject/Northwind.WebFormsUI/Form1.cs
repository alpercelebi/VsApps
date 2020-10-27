using Northwind.Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        IProductService productManager = new ProductManager(new EfProductDal());
        ICategoryService categoryService = new CategoryManager(new EfCategoryDal());
        private void Form1_Load(object sender, EventArgs e)
        {

            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            comboBox1.DataSource = categoryService.GetAll();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
            
            KategoriUrunTxt.DataSource = categoryService.GetAll();
            KategoriUrunTxt.DisplayMember = "CategoryName";
            KategoriUrunTxt.ValueMember = "CategoryId";

            GunKategori.DataSource = categoryService.GetAll();
            GunKategori.DisplayMember = "CategoryName";
            GunKategori.ValueMember = "CategoryId";

        }
        private void LoadProducts()
        {
            dataGridView1.DataSource = productManager.GetAll();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = productManager.GetAll().Where(p => p.CategoryID == Convert.ToInt32(comboBox1.SelectedValue)).ToList();
            }
            catch
            {

             
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productManager.GetAll().Where(p => p.ProductName.ToLower().Contains(textBox2.Text.ToLower())).ToList();
        }

        private void UrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                productManager.Add(new Product
                {
                    ProductName = UrunAdiTxt.Text,
                    CategoryID = Convert.ToInt32(KategoriUrunTxt.SelectedValue),
                    QuantityPerUnit = UrunBirimTxt.Text,
                    UnitPrice = Convert.ToInt32(UrunFiyatTxt.Text),
                    UnitsInStock = Convert.ToInt16(UrunStkTxt.Text)
                });
                MessageBox.Show("ÜRÜN KAYDEDİLDİ");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                productManager.Update(new Product
                {
                    ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                    ProductName = GunAd.Text,
                    UnitPrice = Convert.ToDecimal(GunFiyat.Text),
                    CategoryID = Convert.ToInt32(GunKategori.SelectedValue),
                    UnitsInStock = Convert.ToInt16(GunStok.Text),
                    QuantityPerUnit = GunBirimAdet.Text

                });
                MessageBox.Show("Ürün Güncellendi");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GunKategori.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            GunAd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            GunFiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            GunStok.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            GunBirimAdet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    productManager.Delete(new Product
                    {
                        ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi");
                    LoadProducts();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }
    }
}
