<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Upss! Hubo un problema</h1>
    <asp:Label Text="Para poder ingresar, primero debe registrarse" ID="lblMensaje" runat="server" />

    <%if ((Session["email"]) != null && ((Mod_Dominio.LoginUsuario)Session["email"]).TipoUsuario == Mod_Dominio.TipoUsuario.Admin)
        { %>
    <asp:Label Text="Hubo un problema, el link al que intenta ingresar no funciona" ID="Label1" runat="server" />
    <a href="/Default.aspx" class="btn btn-primary">Volver a home</a>
    <%} %>
    <%else
        {%>
    <%if ((Session["email"]) != null && ((Mod_Dominio.LoginUsuario)Session["email"]).TipoUsuario == Mod_Dominio.TipoUsuario.Normal)
        { %>

    <div class="alert alert-success" role="alert">
        <h4 class="alert-heading">Acceso denegado</h4>
        <p>Usted no tiene permisos.</p>
    </div>
    <a href="/Default.aspx" class="btn btn-primary">Volver a home</a>

    <%} %>
    <%else
        { %>

    <div class="alert alert-success" role="alert">
        <h4 class="alert-heading">Acceso denegado</h4>
        <p>Para poder ingresar, primero debe Logearse.</p>
        <hr>
        <p class="mb-0">Por favor, ingrese a su cuenta y luego intente de nuevo</p>
    </div>
    <a href="/Login.aspx" class="btn btn-primary">Login</a>

    <%} %>
    <%} %>
</asp:Content>
