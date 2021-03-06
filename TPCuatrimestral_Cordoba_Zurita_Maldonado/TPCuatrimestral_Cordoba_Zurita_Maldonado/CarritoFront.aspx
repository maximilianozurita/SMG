<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CarritoFront.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.CarritoFront" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="conteiner d-flex justify-content-center m-2">
        <h2 class="p-2">Carrito de Compras</h2>
    </div>

    <div class="conteiner d-flex  justify-content-start">
      <div >
        <asp:CheckBoxList ID="CheckBoxList" CssClass="form-check w-100 mt-5" runat="server" >
        </asp:CheckBoxList>
     </div>
        <div>
           <% foreach (var item2 in LJuegosAgregados)
              {%>
                  <div class="card mb-3 " style="max-width: 800px;">
                    
                    <div class="row no-gutters">
                       
                    <div class="col-md-4">
                          
                     <img src="/images/product/<%=item2.Imagen.Count >= 1 ? item2.Imagen[0].urlImagen : "Default.png"%>" class="card-img-top" alt="..">
                    </div>
                    <div class="col-md-8">
                      <div class="card-body">
                       <a href="ProductDetail.aspx?id=<%=item2.ID %>" class="text-primary"><%=item2.Name%></a>
                       <p class="card-text"><%=item2.Description %></p>
                       <p class="card-text"><%="Precio: $" %><%=item2.Price %></p>
                      </div>
                    </div>
                   </div>
                    
                  </div>
    <%} %>
             </div>
    
           
      </div>
    
   
   
    <div class=" h-25 d-flex align-items-end">
        <%if ((Session["nombreUsuario"]) != null)
            { %>
                <div class="d-grid gap-2 d-md-flex justify-content-md-end">

        <a href="/Datos Personales.aspx" type="button" class="btn btn-outline-primary">Iniciar Compra</a>
                    </div>
        <%}
        else
            { %>
        <div class="d-grid gap-2 d-md-flex justify-content-md-end">
            <a href="/Login.aspx" type="button" class="btn btn-outline-primary">Iniciar Compra</a>
        </div>
        <%} %>
        <div>
        <asp:Button Text="ELiminar del carrito" CssClass="btn btn-primary me-md-2" ID="btnEliminar" OnClick="btnEliminar_Click" runat="server" />
    </div>
        </div>


</asp:Content>
