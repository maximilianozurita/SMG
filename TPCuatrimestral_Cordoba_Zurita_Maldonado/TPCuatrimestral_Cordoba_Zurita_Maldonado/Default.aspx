<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="row mx-4 mt-3">
        <div id="carouselExampleCaptions" class="carousel slide" data-bs-ride="carousel">
            <div class="carousel-indicators">

                <% int j = 0;
                    foreach (var item in ListaVideogames)
                    {
                        if (item.Destacado == true)
                        {
                %>
                <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="<%=j %>" aria-label="Slide <%=j+1 %>" <%= j==0? "class='active' aria-current='true'":"" %>></button>
                <%j++;
                        }
                    } %>
            </div>
            <div class="carousel-inner">
                <%int i = 0;
                    foreach (var item in ListaVideogames)
                    {
                        if (item.Destacado == true)
                        {
                %>

                <a href="/ProductDetail.aspx?id=<%=item.ID %>" class="carousel-item <%= i==0?"active":"" %>">
                    <img src="/images/product/EFT.PNG" class="d-block w-100" alt="...">
                    <div class="carousel-caption d-none d-md-block">
                        <h5><%=item.Name %></h5>
                        <p><%=item.Description%></p>
                    </div>
                </a>

                <%i++;
                        }

                    }%>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>
    </div>

    <%-- OFERTAS --%>
    <div class="row mx-4 mt-5">
        <h2>Ofertas</h2>
        <div class="card-group">
            <% foreach (var item in VideoGamesOfertas)
                {%>
            <div class="col-lg-4">
                <a href="/ProductDetail.aspx?id=<%=item.ID %>" class="card mx-2 text-decoration-none text-reset">
                    <img src="/images/product/EFT.png" class="card-img-top" alt="..">
                    <div class="card-body">
                        <h5 class="card-title"><%=item.Name %></h5>
                        <p class="card-text"><%=item.Description %></p>
                        <small class="text-muted">fecha de lanzamiento:<%=item.LaunchDate.Day%>/<%=item.LaunchDate.Month%>/<%=item.LaunchDate.Year %></small>
                    </div>
                    <div class="card-footer text-lg-center">
                        <small class="text-muted m-1">$<%=item.Price %></small>
                        <small class="text-muted m-1">Descuento: <%=item.Descuento%>%</small>
                    </div>
                </a>
            </div>

            <%}%>
        </div>
    </div>

    <%-- NUEVOS LANZAMIENTOS --%>
    <div class="row mx-4 mt-5">
        <h2>Nuevos lanzamientos</h2>
        <div class="card-group">

            <% foreach (var item in NewVideoGames)
                {%>
            <div class="col-lg-4">
                <a href="/ProductDetail.aspx?id=<%=item.ID %>" class="card mx-2 text-decoration-none text-reset">
                    <img src="/images/product/EFT.png" class="card-img-top" alt="..">
                    <div class="card-body">
                        <h5 class="card-title"><%=item.Name %></h5>
                        <p class="card-text"><%=item.Description %></p>
                        <small class="text-muted">fecha de lanzamiento:<%=item.LaunchDate.Day%>/<%=item.LaunchDate.Month%>/<%=item.LaunchDate.Year %></small>
                    </div>
                    <div class="card-footer text-lg-center">
                        <small class="text-muted m-1">$<%=item.Price %></small>
                        <small class="text-muted m-1">Descuento: <%=item.Descuento %>%</small>
                    </div>
                </a>
            </div>
            <%}%>
        </div>
    </div>

</asp:Content>
