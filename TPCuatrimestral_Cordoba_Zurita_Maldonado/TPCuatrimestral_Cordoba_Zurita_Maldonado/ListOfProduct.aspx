<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListOfProduct.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.ListOfProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%if ((Session["email"]) != null && ((Mod_Dominio.LoginUsuario)Session["email"]).TipoUsuario == Mod_Dominio.TipoUsuario.Admin)
        { %>

    <div class="row">
        <%--checkbox--%>
        <div class="col-1">
            <div class="form-check mt-2">
                <input class="form-check-input" type="checkbox" value="NuevosLanzamientos" id="CheckLanzamientos">
                <label class="form-check-label" for="flexCheckDefault">
                    Nuevos
                </label>
            </div>
            <div class="form-check mt-2">
                <input class="form-check-input" type="checkbox" value="Ofertas" id="CheckOfertas">
                <label class="form-check-label" for="flexCheckDefault">
                    Ofertas
                </label>
            </div>

            <%--categorias--%>
            <% foreach (var item in ListaCategorias)
                { %>
            <div class="form-check mt-2">
                <input class="form-check-input" type="checkbox" value="<%=item.Id %>" id="CheckCategoria<%=item.Id %>">
                <label class="form-check-label" for="flexCheckDefault">
                    <%=item.Name %>
                </label>

            </div>
            <%} %>
        </div>

        <%--container videojuegos--%>
        <div class="col-9">
            <section id="galeria" class="container">
                <div class="text-start pt-5">
                    <h2>Galeria videojuegos</h2>
                </div>

                <div class="row">

                    <div class="col-lg-4">
                        <a href="/ProductCreate.aspx" class="card mx-2 mb-4 text-decoration-none text-reset">
                            <img src="/images/upload.jpg" class="card-img-top" alt="..">
                            <div class="card-footer text-lg-center">
                                <small class="text-muted m-1">Subir nuevo videojuego</small>
                            </div>
                        </a>
                    </div>

                    <%foreach (var item in ListaVideogames)
                        { %>

                    <div class="col-lg-4">
                        <a href="/ModProduct.aspx?id=<%=item.ID %>" class="card mx-2 mb-4 text-decoration-none text-reset">
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

                    <%} %>
                </div>
            </section>
        </div>
    </div>
    <%} %>
    <%else
        {%>
    <%if ((Session["email"]) != null && ((Mod_Dominio.LoginUsuario)Session["email"]).TipoUsuario == Mod_Dominio.TipoUsuario.Normal)
        { %>

    <div class="alert alert-success" role="alert">
        <h4 class="alert-heading">Acceso denegado</h4>
        <p>Usted no tiene permisos.</p>
    </div>

    <%} %>
    <%else
        { %>

    <div class="alert alert-success" role="alert">
        <h4 class="alert-heading">Acceso denegado</h4>
        <p>Usted esta intentando ingresar a una dirección no valida.</p>
        <hr>
        <p class="mb-0"> Por favor, ingrese a su cuenta y luego intente de nuevo</p>
    </div>

    <%} %>
    <%} %>


</asp:Content>
