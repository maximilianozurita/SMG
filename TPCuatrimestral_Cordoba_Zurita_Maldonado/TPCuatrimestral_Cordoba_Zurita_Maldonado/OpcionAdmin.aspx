<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OpcionAdmin.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.OpcionAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Bienvenido Administrador!</h1>
    <asp:Label Text="Elija la opcion de como quiere entrar a SMG" ID="lblMensaje" runat="server" />

    <div class="d-grid gap-2 col-6 mx-auto">
        <asp:Button Text="Cliente" CssClass="btn btn-primary" ID="btnCliente" OnClick="btnCliente_Click" runat="server" />
        <asp:Button Text="Administrador" CssClass="btn btn-primary" ID="btnAdministrador" OnClick="btnAdministrador_Click" runat="server" />
    </div>

</asp:Content>
