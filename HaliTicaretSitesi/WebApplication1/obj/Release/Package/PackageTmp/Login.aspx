<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="WebApplication1.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="LoginCss.css" />
    <script src="jquery.min.js"></script>
        <link href="https://fonts.googleapis.com/css2?family=Manrope:wght@500&family=Poppins:wght@300&display=swap" rel="stylesheet">

</head>
<body style="background-color:snow;">
     <form id="form1" runat="server">
        <div class="loginanadiv">
            <br /><br /><br />
            <label style="font-family:'Manrope', sans-serif; font-size:25px; display:block; font-weight:600;">GİRİŞ</label><br />
            <asp:TextBox ID="textUserName" placeholder="UserName giriniz.."  runat="server"></asp:TextBox> <br />
            <asp:TextBox ID="textPass" TextMode="Password" placeholder="Password giriniz.." runat="server"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="Giriş Yapınız" OnClick="btnLogin_Click" /><br />
            <asp:Label ID="labeluyari" runat="server"></asp:Label>
            <a href="/KayitOl.aspx">Kayıt Ol</a>
        </div>

    </form>

 <script type="text/javascript">
     history.pushState(null, null, location.href);
     window.onpopstate = function () {
         history.go(1);
     };
    </script>
</body>
</html>
