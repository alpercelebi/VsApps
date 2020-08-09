using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Vtİslemleri;

namespace WebApplication1
{
    public partial class AdminAnasayfa : System.Web.UI.Page
    {
        PostService postService = new PostService();
        protected void Page_Load(object sender, EventArgs e)
        {
            var data=postService.GetAll();
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool sonuc=postService.Delete(Convert.ToInt32(textDeleteId.Text));
            if (sonuc)
            {
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                Label1.Text = "Yanlış Id Girdiniz..";
            }
        }

        protected void bntup_Click(object sender, EventArgs e)
        {

            string id = textupid.Text;
            string name = textupname.Text;
            string info = textupinfo.Text;
            string stok = textupstock.Text;
            try
            {
                if (id != "" && stok != "" && info != "" && stok != "")
                {
                    PostUpdateDto post = new PostUpdateDto
                    {
                        Id = Convert.ToInt32(id),
                        Name = name,
                        Info = info,
                        Stock = Convert.ToInt32(stok)
                    };
                    if (postService.Updating(post))
                        {
                        Response.Redirect(Request.RawUrl);
                    }
                    else
                    {
                        Label2.Text = ("Güncellenemedi.");
                    }

                }
                else
                {
                    Label2.Text=("lütfen boş bırakmayınız.");
                }
            }
            catch (Exception)
            {

                Label2.Text = ("Güncellenemedi."); 
            }


  


        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
          
            string name = addname.Text;
            string category = addcategory.Text;
            string stock = addstock.Text;
            string info = addinfo.Text;

            if(name !="" && category !="" && stock !="" && info != "")
            {
                if (FileUpload1.HasFile)
                {
                    if (FileUpload1.PostedFile.ContentType == "image/jpeg")
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/resimler/") + FileUpload1.FileName);
                        PostDto postAdd = new PostDto
                        {
                            Category = category,
                            Name = name,
                            Stock = Convert.ToInt32(stock),
                            Info = info,
                            Image = FileUpload1.FileName,
                            Slug=name
                        };
                        bool a=postService.Adding(postAdd);
                        if (a)
                        {
                            
                            Response.Redirect(Request.RawUrl);
                            
                        }
                        else { Label5.Text = "Bilgiler Eklenemedi.Tekrar deneyiniz."; }

                    }
                    else
                    {
                        Label5.Text = "Lütfen jpg uzantılı resim seçiniz.";
                    }

                }
                else
                {
                    Label5.Text = "Lütfen bir dosya seçiniz.";
                }
            }
            else
            {
                Label5.Text="Lütfen boş bırakmayınız.";
            }

           
                
        }
    }
}