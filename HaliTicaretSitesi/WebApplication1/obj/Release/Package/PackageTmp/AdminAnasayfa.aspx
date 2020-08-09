<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAnasayfa.aspx.cs" Inherits="WebApplication1.AdminAnasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="AdminPageCss.css" />
</head>
<body>
    <div class="menu">
        <a href="Login.aspx/Cikis" style="float:right;"><b>Çıkış Yap</b> ></a>
           
    </div>
    <form id="form1" runat="server">
        <div class="anadiv">
        <asp:GridView ID="GridView1" runat="server" ></asp:GridView><br />
            <asp:Label ID="Label3" runat="server">SİLME</asp:Label><br/>
        <asp:TextBox ID="textDeleteId" placeholder="Id.." runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Sil" OnClick="Button1_Click" /><br/>
        <asp:Label ID="Label1" runat="server"></asp:Label><br/>
        <asp:Label ID="lb" runat="server">GÜNCELLEME</asp:Label><br/>

        <asp:TextBox ID="textupid"  placeholder="Id.."  runat="server"></asp:TextBox><br/><br />
        <asp:TextBox ID="textupname"  placeholder="Name.."  runat="server"></asp:TextBox><br/><br/>
        <asp:TextBox ID="textupstock"  placeholder="Stok.."  runat="server"></asp:TextBox><br/><br/>
        <asp:TextBox ID="textupinfo"  placeholder="İnfo.."  runat="server"></asp:TextBox><br/><br/>
        <asp:Label ID="Label2" runat="server" ></asp:Label>
        <asp:Button ID="bntup" runat="server" Text="Güncelle" OnClick="bntup_Click" /><br />
            <asp:Label ID="Label4" runat="server">EKLEME</asp:Label><br/>
        <asp:TextBox ID="addname"  placeholder="Name.."  runat="server"></asp:TextBox><br/><br/>
        <asp:TextBox ID="addstock"  placeholder="Stok.."  runat="server"></asp:TextBox><br/><br/>
        <asp:TextBox ID="addcategory"  placeholder="Category.."  runat="server"></asp:TextBox><br/><br/>
        <asp:TextBox ID="addinfo"  placeholder="Info.."  runat="server"></asp:TextBox><br/><br />
        <asp:FileUpload ID="FileUpload1" runat="server" /><br />
        <asp:Button ID="btnadd" runat="server" Text="Ekle" OnClick="btnadd_Click" /><br />
        <asp:Label ID="Label5" runat="server" ></asp:Label>


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
