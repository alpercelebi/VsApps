using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Vtİslemleri;

namespace WebApplication1
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        AdminService adminService = new AdminService();
        userService userService = new userService();


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = textUserName.Text;
            string userPass = textPass.Text;
            if (userName == "" || userPass == "")
            {
                labeluyari.Text = "Lütfen Boş Bırakmayınız";
            }
            else
            {
                if (userName.Length >= 6)
                {
                    string ad = userName.Substring(0, 5).ToLower();
                    if (ad == "admin")
                    {
                        var data = adminService.LoginAdmin(userName, userPass);
                        if (data != null)
                        {
                            Session["admin"] = data.id;
                            Response.Redirect("/AdminAnasayfa.aspx");
                        }
                        else
                        {
                            labeluyari.Text = "Girilen bilgiler yanlıştır.";
                        }
                    }
                    else
                    {
                        var data = userService.LoginUserControl(userName, userPass);
                        if (data != null)
                        {
                            Session["user"] = data.id;

                            Response.Redirect("/Anasayfa.aspx");
                        }
                        else
                        {
                            labeluyari.Text = "Girilen bilgiler yanlıştır.";
                        }
                    }
                }
                

            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Cikis()
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}