using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sqlserver
{
    public class ProductDal
    {
        SqlConnection con = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETicaret;integrated security=true");

        public List<Product> GetAll()
        {
            ConnectionControl ();
            SqlCommand komut = new SqlCommand("select * from Products", con);
            SqlDataReader oku = komut.ExecuteReader();
            List<Product> products = new List<Product>();
            while (oku.Read())
            {
                Product urun = new Product()
                {
                    id = Convert.ToInt32(oku["id"]),
                    name = oku["name"].ToString(),
                    deger = Convert.ToInt32(oku["UnitPrice"]),
                    stok = Convert.ToInt32(oku["stock"])
                };
                products.Add(urun);

            }
            oku.Close();
            con.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand komut = new SqlCommand("insert into Products values(@name,@unitprice,@stock)",con);
            komut.Parameters.AddWithValue("@name", product.name);
            komut.Parameters.AddWithValue("@unitprice", product.deger);
            komut.Parameters.AddWithValue("@stock", product.stok);
            komut.ExecuteNonQuery();
            con.Close();

        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand komut = new SqlCommand("update Products set name=@name,unitprice=@unitprice,stock=@stock  where id=@id", con);
            komut.Parameters.AddWithValue("@name",product.name);
            komut.Parameters.AddWithValue("@unitprice", product.deger);
            komut.Parameters.AddWithValue("@stock", product.stok);
            komut.Parameters.AddWithValue("@id", product.id);
            komut.ExecuteNonQuery();
            con.Close();


        }
        public void Delete(Product product)
        {
            ConnectionControl();
            SqlCommand komut = new SqlCommand("Delete  from Products where id=@id",con);
            komut.Parameters.AddWithValue("@id", product.id);
            komut.ExecuteNonQuery();
            con.Close();
        }
        
    }
}
