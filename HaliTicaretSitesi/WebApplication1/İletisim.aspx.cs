using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class İletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mesajgönder_Click(object sender, EventArgs e)
        {
            string mailadress = TextBox3.Text;
            string name = TextBox1.Text;
            string surname = TextBox2.Text;
            string content = TextBox4.Text;


            try
            {
                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.To.Add("blog.alpercelebioglu@gmail.com");

                mail.From = new MailAddress(mailadress, "Blog Sayfam", System.Text.Encoding.UTF8);

                mail.Body = "<b>" + name.ToUpper() + " " + surname.ToUpper() + "</b>" + " kişisi tarafından;</br>" + "E-mail adresi:" + "<b>" + mailadress + "</b>" + " olan " + "<b>"+ content + "</b>";
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential("blog.alpercelebioglu@gmail.com", "Alper.1997");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Label5.Text = "Mesaj Gönderildi.";

            }
            catch (Exception)
            {
       
                Label5.Text = "Mesaj Gönderilemedi.";

            }
        }
    }
}