using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudForNortwindDatabases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategoris();

           

        }

        private void ListCategoris()
        {
            using(NorthwindContext context=new NorthwindContext())
            {
                comboBox1.DataSource = context.Categories.ToList();
                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "CategoryId";
            }

        }

        private void ListProducts(int id=0)
        {
           
            using (NorthwindContext context = new NorthwindContext())
            {
                if (id == 0)
                {
                    dataGridView1.DataSource = context.Products.ToList();
                }
                else
                {
                    dataGridView1.DataSource = context.Products.Where(p => p.CategoryID == id).ToList();
                }
                //var kategori = context.Categories.Select(p => p.CategoryName).ToArray();
                //comboBox1.Items.AddRange(kategori);
                //foreach (var item in kategori)
                //{
                //    comboBox1.Items.Add(item.CategoryName);
                //}



            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProducts(Convert.ToInt32(comboBox1.SelectedValue));
            }
            catch 
            {

               
            }
        }

        private void ListProductsByText(string name)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                if (name == null || name=="")
                {
                    dataGridView1.DataSource = context.Products.ToList();
                }
                else
                {
                    dataGridView1.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(name.ToLower())).ToList();
                }
              
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByText(textBox1.Text);
            }
            catch 
            {

                
            }
        }
    }
}
