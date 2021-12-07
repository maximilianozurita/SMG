<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListOfProduct.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.ListOfProduct" %>

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
        <div class="col-9">
            <section id="galeria" class="container">
                <div class="text-start pt-5">
                    <h2>Lista de videojuegos (ADMINISTRADOR)</h2>
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
                            <img src="/images/product/<%=item.Imagen[0].urlImagen %>" class="card-img-top" alt="..">
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

</asp:Content>
