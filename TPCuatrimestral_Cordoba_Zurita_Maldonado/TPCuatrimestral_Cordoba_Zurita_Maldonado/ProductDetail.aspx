<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Detalle_de_producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="conteiner-fluid h-100  d-flex align-items-start" style="background-image: url(https://th.bing.com/th/id/OIP.ILR58OvpLKq0_H8f4Lde8wHaF8?pid=ImgDet&rs=1)">
        <div class="container-fluid border border-secondary p-2 ">

            <div id="carouselExampleControls" class="carousel slide h-100" data-bs-ride="carousel">
                <div class="carousel-inner">
                    <%int contvuelta = 0;
                        foreach (var item in ListaImagenes)
                        {   %>
                    <% if (contvuelta == 0)
                        {%>
                    <div class="carousel-item active">
                        <%--                       <%int contvuelta= 0; foreach (var item in ListaImagenes){--%>
                        <div class="col-lg-2">
                            <a href="/ProductDetail.aspx?id=<%=item.idVdeoJuego %>" class="card mx-2 text-decoration-none text-reset">
                                <img src="/images/product/<%=item.urlImagen %>" class="card-img-top " alt="..">
                            </a>
                        </div>
                    </div>
                    <%}
                        if (contvuelta > 0 && contvuelta < 5)
                        {  %>
                    <div class="carousel-item  ">
                        <%--                       <%int contvuelta= 0; foreach (var item in ListaImagenes){--%>
                        <div class="col-lg-4">
                            <a href="/ProductDetail.aspx?id=<%=item.idVdeoJuego %>" class="card mx-2 text-decoration-none text-reset">
                                <img src="/images/product/<%=item.urlImagen %>" class="card-img-top " alt="..">
                            </a>
                        </div>
                    </div>
                    <%} %>
                    <%contvuelta++;
                    }%>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
                </div>
              
           <%-- <%foreach (var item in ListaImagenes)
       { %>
            <div class="col-lg-4">
                <a href="/ProductDetail.aspx?id=<%=item.idVdeoJuego %>" class="card mx-2 text-decoration-none text-reset">
                    <img src="/images/product/<%=item.urlImagen %>" class="card-img-top h-50" alt="..">
                </a>
            </div>
            <%} %>--%>

             
          
        </div>
    <div class=" conteiner border border-secondary text-white bg-dark w-50">
                    <%--                <img src="https://th.bing.com/th/id/R.da80502f891b765a1ea75f3d83400086?rik=26I1RHjMcstfgQ&pid=ImgRaw&r=0" class="  w-75" alt="Alternate Text" />--%>
                    <h3>Descripcion</h3>
                    <p><%=videogame.Description%></p>
                    <h3>Requisitos del Sistema </h3>
                    <p><%=videogame.Requerimentos %></p>
                    <div class="d-grid gap-2">
                        <asp:Button ID="BtnAgregarCarro" OnClick="BtnAgregarCarro_Click" runat="server" CssClass="btn btn-primary" Text="Agregar al carro" />
                    </div>
                </div>
              </div>
</asp:Content>
