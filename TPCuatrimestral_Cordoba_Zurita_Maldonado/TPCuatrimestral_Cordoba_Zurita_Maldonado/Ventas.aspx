<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Historial_de_ventas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container w-50">
        <h1>Lista de ventas</h1>

        <%foreach (var item in ListaVentas)
            { %>
        <div class="list-group list-group-numbered">
            <a href="#" class="text-decoration-none text-reset ">
                <div class="list-group-item list-group-item-action d-flex justify-content-between align-items-start">
                    <div class="ms-2 me-auto">
                        <div class="fw-bold"><%=item.Id_user %></div>
                        Fecha: 
                    </div>
                    <span class="badge bg-primary rounded-pill">Total: <%=item.Suma %>$</span>
                </div>
            </a>
        </div>

        <%} %>


    </div>
</asp:Content>
