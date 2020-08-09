<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<%@ Import Namespace="WebApplication1.Vtİslemleri" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Anasayfa</title>
    <link href="AnasayfaCss.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Manrope:wght@500&family=Poppins:wght@300&display=swap" rel="stylesheet">

</head>
<body>
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
                    <li style="float:right;"><a href="Login.aspx">Giriş Yap</a></li> 
                <%}
                %>
      

    </ul>
    </div>
    
    <div class="anasayfamain">


   <br /><br /><br /><br />
        <form id="form1" runat="server">
        <div>
            <%PostService postService = new PostService();
                var liste = postService.GetAll();
                for (int i = 0; i < liste.Count; i++)
                {
                    if (liste[i].Stock > 0)
                    { %>

                    <div class="anasayfaurun">
                        <div class="resim">
                            <img class="urunboyut" src="resimler/<%=liste[i].Image %>" />
                        </div>
                        <div class="info">
                              <p style="font-family:'Manrope', sans-serif;"><b>•<%=liste[i].Name %></b></p>
                              <p>•<%=liste[i].Info %></p>
                              <p style="font-family:'Manrope', sans-serif;">
                                  <a href="UrunDetaylari.aspx?id=<%=liste[i].Id%>">
                                      <b>Ürün Detaylarına Gidiniz..</b>
                                  </a>

                              </p>
                        </div>
                      
                    </div>
   
            
                    
                <%}
    }%>



        </div>
    </form>

         </div>
</body>
</html>
