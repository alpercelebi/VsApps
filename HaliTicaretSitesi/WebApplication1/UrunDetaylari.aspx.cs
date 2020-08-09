using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Vtİslemleri;

namespace WebApplication1
{
    public partial class UrunDetaylari : System.Web.UI.Page
    {
        PostService postService = new PostService();
        OrderPostService orderPost = new OrderPostService();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            var data = postService.GetById(id);
            lbname.Text = data.Name;
            lbinfo.Text = data.Info;
            lbcategory.Text = data.Category;
            sepetid.Text = data.Id.ToString();
            imghali.ImageUrl = "resimler/" + data.Image;



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int stok = Convert.ToInt32(sepetekle.Text);
            if (stok <= 0)
            {
                sepetsonuc.Text = "Lütfen Stok Sayısını Düzgün Giriniz!";

            }
            else
            {
                int postID = Convert.ToInt32(sepetid.Text);
                int siparissayi = Convert.ToInt32(sepetekle.Text);

                var data = postService.GetById(postID);
                int stoksayisi = data.Stock;
                if (stoksayisi < siparissayi)
                {
                    sepetsonuc.Text = "Yeterince Stok Yoktur.Daha Az Sipariş Veriniz!";
                }
                else
                {
                    int oturum = Convert.ToInt32(Session["user"]);
                    if (oturum == 0)
                    {
                        Response.Redirect("/Login.aspx");
                    }
                    else
                    {
                        int userId = oturum;
                        DateTime tarih = DateTime.Now;
                        bool Onay = false;
                        string adres = null;
                        OrderPost item = new OrderPost
                        {
                            PostId = postID,
                            UserId = userId,
                            Date = tarih,
                            OnayDurumu = Onay,
                            Adress = adres,
                            Stock=siparissayi
                            
                        };
                        bool durum =orderPost.Add(item);
                        if (durum)
                        {
                            sepetsonuc.Text = "Siparişiniz Alınmıştır";
                            int denetle = stoksayisi - siparissayi;
                            postService.UpdateStock(postID, denetle);
                        
                        }
                        else
                        {
                            sepetsonuc.Text = "Sipariş Alınamamıştır. Tekrar Deneyiniz";
                        }
                    }
                }
            }
        }
    }
}