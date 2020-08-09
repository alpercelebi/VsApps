<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hakkimizda.aspx.cs" Inherits="WebApplication1.Hakkimizda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hakkımızda</title>
        <link href="AnasayfaCss.css" rel="stylesheet" />
        <link href="https://fonts.googleapis.com/css2?family=Manrope:wght@500&family=Poppins:wght@300&display=swap" rel="stylesheet">

</head>
<body >
       <div class="menu">
        
     <ul>

      <li><a class="aktif" href="Anasayfa.aspx">Ana sayfa</a></li>

  
      <li><a href="/Hakkimizda.aspx">Hakkımızda</a></li>



       <li><a href="/İletisim.aspx">İletişim</a></li>


         <% if (Convert.ToInt32(Session["user"]) != 0)
             {%>
                 <li style="float:right;"><a href="Login.aspx/Cikis">Çıkış Yap</a></li>
                 <li style="float:right;"><a href="Sepet.aspx">Sepetim</a></li>
            <% }
                else
                {%>
                    <li style="float:right;"><a href="/Login.aspx">Giriş Yap</a></li> 
                <%}
                %>
      

    </ul>
    </div>
    <br /><br /><br />
    <form id="form1" runat="server">
        <div class="hakkımızdamain">
            <p style="font-family:'Manrope', sans-serif;">XXX A.Ş. olarak 2006 yılından itibaren halı ticareti ile uğraşmaktayız.Yurtdışına ihricat satışlarımızda bulunmaktadır.
                Halı kategorilerimiz yün halı, deri halı, yazlık halı, paspas, dokuma halı ve birçok kategori de halı kategorilerimiz bulunmaktadır.

            </p>
        </div>
    </form>
</body>
</html>
