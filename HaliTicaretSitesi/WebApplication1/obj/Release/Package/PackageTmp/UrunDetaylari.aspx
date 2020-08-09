<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UrunDetaylari.aspx.cs" Inherits="WebApplication1.UrunDetaylari" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="urunprofile.css" rel="stylesheet" />
</head>
<body>
<div class="menu">
        
     <ul>

      <li><a class="aktif" href="Anasayfa.aspx">Ana sayfa</a></li>

  
      <li><a href="#hakkımızda">Hakkımızda</a></li>



      <li><a href="#iletisim">İletişim</a></li>


         <% if (Convert.ToInt32(Session["user"]) != 0)
             {%>
                 <li style="float:right;"><a href="Login.aspx/Cikis">Çıkış Yap</a></li>
                 <li style="float:right;"><a href="Sepet.aspx">Sepetim</a></li>
            <% }
                else
                {%>
                     <li style="float:right;"><a href="Login.aspx">Giriş Yap</a></li> 
                <%}
                %>
      

    </ul>
    </div>
    <br /><br /><br />
    <form id="form1" runat="server">
        <div class="urundetay">
            <div class="urunimage">
                <asp:Image ID="imghali" runat="server" />
            </div>
            <br />
            <br />
            <div class="uruninfo">
                <table>
                    <tr>
                        <td>Name:</td>
                        <td><asp:Label ID="lbname" runat="server" Text="Label"></asp:Label>
                        </td>
           
                    </tr>
                    <tr>
                        <td>Kategori:</td>
                        <td><asp:Label ID="lbcategory" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Açıklama:</td>
                        <td><asp:Label ID="lbinfo" runat="server" Text="Label"></asp:Label></td>
                    </tr>

                </table>
                <br />
                <asp:TextBox ID="sepetekle" runat="server" type="number">0</asp:TextBox>

                <asp:Button ID="Button1" runat="server" Text="Sepete Ekle" OnClick="Button1_Click" /><br />
                <asp:Label ID="sepetsonuc" runat="server"></asp:Label>
                <asp:Label ID="sepetid" runat="server" ></asp:Label>
                
            </div>
        </div>
    </form>
</body>
</html>
