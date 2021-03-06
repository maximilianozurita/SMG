<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <%--checkbox--%>
        <div class="col-2">
            <asp:CheckBoxList ID="CheckBoxList" CssClass="form-check w-100 mt-4" runat="server" AutoPostBack="true">
            </asp:CheckBoxList>

        </div>

        <%--container videojuegos--%>
        <div class="col-8">
            <section id="galeria" class="container">
                <div class="text-start pt-5">
                    <h2>Galeria videojuegos</h2>
                </div>

                <div class="row">

                    <%foreach (var item in ListaVideogames)
                        { %>

                    <div class="col-lg-4">
                        <a href="/ProductDetail.aspx?id=<%=item.ID %>" class="card mx-2 mb-4 text-decoration-none text-reset">
                            <img src="/images/product/<%=item.Imagen.Count>=1? item.Imagen[0].urlImagen:"Default.png"%>" class="card-img-top" alt="..">
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

                    <%} %>
                </div>
            </section>
        </div>
    </div>
</asp:Content>
