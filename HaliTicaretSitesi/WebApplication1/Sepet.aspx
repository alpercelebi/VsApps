<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sepet.aspx.cs" Inherits="WebApplication1.Sepet" %>
<%@ Import Namespace="WebApplication1.Vtİslemleri" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="AnasayfaCss.css" rel="stylesheet" />
    <script src="jquery.min.js"></script>
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
                    <li style="float:right;"><a href="#iletisim">Giriş Yap</a></li> 
                <%}
                %>
      

    </ul>
    </div>
    <br /><br /><br /><br />
        <form id="form1" runat="server">


            <%
                OrderPostService data = new OrderPostService();
                PostService item = new PostService();
                int id = Convert.ToInt32(Session["user"]);
                var datasiparisler = data.GetByUser(id);
                for (int i = 0; i < datasiparisler.Count; i++)
                { %>
                  
                        <%if (datasiparisler[i].OnayDurumu == true)
                            {%>
            
                        <div class="sipariset">
                        <div class="siparisresim">
                            <img src="resimler/<%=item.GetById(datasiparisler[i].PostId).Image %>" class="resimsepet" />
                        </div>
                           
                        <div class="siparisbilgi">
                            <br />
                            <label>Ürün adı:</label><label><%=item.GetById(datasiparisler[i].PostId).Name %></label><br />
                            <label>Kategori:</label><label><%=item.GetById(datasiparisler[i].PostId).Category%></label><br />
                            <label>Ürün Sayısı:</label><label><%=datasiparisler[i].Stock %></label><br />
                            <label>Adres:</label><textarea disabled  style="min-height:25px; max-height:50px; resize:vertical;"  ><%=datasiparisler[i].Adress%></textarea><br />
                            <label>Ürün Onaylanmıştır.</label>
                            
                              </div>
                             </div>  
                          <%  }

                            else
                            {%>
                         <div class="sipariset">
                        <div class="siparisresim">
                            <img src="resimler/<%=item.GetById(datasiparisler[i].PostId).Image %>" class="resimsepet" />
                        </div>
                        <div class="siparisbilgi">
                            <br />
                            <input  type="text" id="siparisid" value="<%=datasiparisler[i].Id %>" style="display:none;" runat="server"/>
                            <label>Ürün adı:</label><label> <%=item.GetById(datasiparisler[i].PostId).Name%></label><br />
                            <label>Kategori:</label><label> <%=item.GetById(datasiparisler[i].PostId).Category%></label><br />
                            <label>Ürün Sayısı:</label><label> <%=datasiparisler[i].Stock %></label><br />
                            <label>Adres:</label><textarea id="adress" style="resize:vertical; max-height:50px; min-height:25px;"></textarea><br />
                            <select id="onayla">
                                <option value="hayır">Hayır</option>
                                <option value="evet">Evet</option>
                            </select><br />
                            <button type="button" onclick="sipariskaydet()">Sipariş Et</button>

            
                         </div>
                             </div>  
                           <% }
                          %>



           
              
              <%  }



                %>

        
    </form>
    <script>
        function sipariskaydet() {
            var adres = $("#adress").val();
            var onay = $("#onayla").val();
            var id = $("#siparisid").val();
            if (adres != "" && onay == "evet") {
                var onaylar = confirm("12345678901234567 nolu hesaba havale yaptığınız vakit siparişiniz yollanacaktır.\nOnaylıyor musunuz ? ");
                if (onaylar == true) {
                    alert("Sipariş Alınmıştır..")
                }
                else {
                    alert("Sipariş Alınamamıştır.")
                }
            }
            else {
                alert("lütfen adresi ve onaylamayı tutarlı giriniz.")
            }
        }
    </script>

</body>
</html>
