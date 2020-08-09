using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Vtİslemleri;

namespace WebApplication1
{
    public partial class KayitOl : System.Web.UI.Page
    {
        userService userservice = new userService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kayitet_Click(object sender, EventArgs e)
        {
            string ad = kayıtad.Text;
            string soyad = kayıtsoyad.Text;
            string username = kayıtusername.Text;
            string sifre = kayıtsifre.Text;
            if(ad!="" && soyad !="" && username!="" && sifre != "")
            {
                if (username.Length <= 6)
                {
                    Label5.Text = "Kullanıcı adınız en az 6 karakterli olmalı!!";
                }
                else
                {
                    User us = new User
                    {
                        Name = ad,
                        SurName = soyad,
                        Pass = sifre,
                        UserName = username
                    };
                    bool onay = userservice.Add(us);
                    if (onay)
                    {
                        Label5.Text = "Kayıt oldu";
                        kayıtad.Text = "";
                        kayıtusername.Text = "";
                        kayıtsifre.Text = "";
                        kayıtsoyad.Text = "";
                    }
                    else
                    {
                        Label5.Text = "Kayıt Edilemedi!";
                    }
                }
               

            }
            else
            {
                Label5.Text = "Lütfen boş bırakmayınız..";
            }
        }
    }
}