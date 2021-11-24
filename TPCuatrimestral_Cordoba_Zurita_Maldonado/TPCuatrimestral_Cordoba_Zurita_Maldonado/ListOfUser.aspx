<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListOfUser.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.ListOfUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="table">
        <thead class="thead-dark">
            <tr>
                <th scope="col">#</th>
                <th scope="col">Nombre</th>
                <th scope="col">Apellido</th>
                <th scope="col">Email</th>
                <th scope="col">Celular</th>
                <th scope="col">Fecha de Nacimiento</th>

            </tr>
        </thead>
        <tbody>
            <% foreach (var item in Listausuarios)
                { %>
            <tr>
                <th scope="row">1</th>
                <td><%=item.Nombre %></td>
                <td><%=item.Apellido %></td>
                <td><%=item.Email %></td>
                <td><%=item.Celular %></td>
                <td><%=item.FechaNacimiento %></td>

            </tr>
            <%} %>
    </table>
</asp:Content>
