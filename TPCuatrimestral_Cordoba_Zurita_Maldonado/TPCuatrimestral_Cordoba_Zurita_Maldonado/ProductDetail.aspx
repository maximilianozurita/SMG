﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Detalle_de_producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="conteiner-fluid h-100" style="background-image: url(https://th.bing.com/th/id/OIP.ILR58OvpLKq0_H8f4Lde8wHaF8?pid=ImgDet&rs=1)">

        <div class="container-fluid border border-secondary  d-flex justify-content-between ">

            <div class="d-flex align-items-start flex-column bd-highlight mb-3 ">
                <%string link = videogame.LinkVideo; %>

                <iframe width="565" height="315" src="<%=videogame.LinkVideo %>"></iframe>

                <div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <% int j = 0;
                                
                                foreach (var item in ListaImagenes)
                                {%>
                            <button type="button" class="d-block w-75" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="<%=j %>" aria-label="Slide <%=j+1 %>" <%= j==0? "class='active' aria-current='true'":"" %>></button>
                            <%j++;

                                } %>
                        </div>
                        <div class="carousel-item">
                            <%int i = 0;
                                foreach (var item in ListaImagenes)
                                {%>

                            

                            <a href="#" class="carousel-item <%= i==0?"active":"" %>">
                                <img src="/images/product/<%=videogame.Imagen.Count>=0? videogame.Imagen[0].urlImagen:"Default.png"%>" class="d-block w-75" alt="...">
                            </a>

                            <%i++;
                                }%>
                        </div>
                    </div>
                </div>

                <%--<div>
                    <img src="<%=videogame.Imagen %>" class="w-25 h-50" alt="Alternate Text" />
                    <img src="https://th.bing.com/th/id/OIP.8eupuFrT4NhRJkv6HXKsfQHaEK?pid=ImgDet&rs=1" class="w-25 h-50" alt="Alternate Text" />
                    <img src="https://www.goclecd.fr/wp-content/uploads/dishonored-800x600-1.jpg" class="w-25 h-50" alt="Alternate Text" />
                    <img src="https://assets.vg247.com/current/2012/08/dishonored-082212-2.jpg" class="w-25 h-50" alt="Alternate Text" />
                </div>--%>
            </div>
            <div class=" border border-secondary text-white bg-dark w-75">
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
    </div>

</asp:Content>
