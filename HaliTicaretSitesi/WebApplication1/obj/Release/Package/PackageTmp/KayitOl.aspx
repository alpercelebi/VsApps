<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayitOl.aspx.cs" Inherits="WebApplication1.KayitOl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="kayit.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="kayitmenü">
            <br /><br /><br /><br />
            <asp:Label ID="Label1" runat="server" Text="Ad:"></asp:Label><br /><asp:TextBox CssClass="deneme" ID="kayıtad" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Soyad:"></asp:Label><br /><asp:TextBox CssClass="deneme" ID="kayıtsoyad" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Kullanıcı Adı:"></asp:Label><br /><asp:TextBox CssClass="deneme" ID="kayıtusername" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Şifre:"></asp:Label><br /><asp:TextBox CssClass="deneme" ID="kayıtsifre" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="kayitet" CssClass="btnilet" runat="server" Text="Kayıt Et" OnClick="kayitet_Click" /><br />
            <asp:Label ID="Label5" runat="server"  ></asp:Label><br />
            <a href="/Login.aspx">Giriş Yap</a>
        </div>
    </form>
</body>
</html>
