<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleVenta.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.DetalleVenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="container w-50">
        <h1>Detalle de venta</h1>

        <%foreach (var item in ListaVideogames)
            { %>
        <div class="card mb-3" style="max-width: 540px;">
            <div class="row g-0">
                <div class="col-md-4">
                    <img src="/images/product/<%=item.Imagen.Count>=1? item.Imagen[0].urlImagen:"Default.png"%>" class="img-fluid rounded-start" alt="...">
                </div>
                <div class="col-md-8">
                    <div class="card-body">
                        <h5 class="card-title"><%=item.Name%></h5>
                        <p class="card-text"><%=item.Description %></p>
                        <p class="card-text"><small class="text-muted"><%="Precio: $" %><%=item.Price %></small></p>
                    </div>
                </div>
            </div>
        </div>




        <%} %>
    </div>



</asp:Content>
