<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="İletisim.aspx.cs" Inherits="WebApplication1.İletisim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>İletişim</title>
    <link href="AnasayfaCss.css" rel="stylesheet" />
</head>
<body style="background-color:snow;">
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
        <div class="iletisim">
        <asp:Label  ID="iletisimad" runat="server" Text="Ad:"></asp:Label><br /><asp:TextBox ID="TextBox1" CssClass="deneme" runat="server"></asp:TextBox><br />
        <asp:Label ID="iletisimsoyad" runat="server" Text="Soyad:"></asp:Label><br /><asp:TextBox CssClass="deneme" ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Label ID="iletisimmail" runat="server" Text="MailAdres:"></asp:Label><br /><asp:TextBox CssClass="deneme" TextMode="Email" ID="TextBox3" runat="server"></asp:TextBox><br />
        <asp:Label ID="iletisimmesaj" runat="server" Text="Mesaj:"></asp:Label><br /><asp:TextBox CssClass="textarea" TextMode="MultiLine" Rows="5" Columns="40" ID="TextBox4" runat="server"></asp:TextBox><br />
        <asp:Button ID="mesajgönder" CssClass="btnilet" runat="server" Text="Mesaj Gönder" OnClick="mesajgönder_Click" /><br />
            <asp:Label ID="Label5" runat="server"></asp:Label>

        
        </div>
    </form>
</body>
</html>
