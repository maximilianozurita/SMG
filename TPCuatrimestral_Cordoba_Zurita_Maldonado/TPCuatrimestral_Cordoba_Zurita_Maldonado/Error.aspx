<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Upss! Hubo un problema</h1>
    <asp:Label Text="Para poder ingresar, primero debe registrarse" ID="lblMensaje" runat="server" />

    <div class="col-12">
        <asp:Button Text="Volver" CssClass="btn btn-primary" ID="btnVolver" OnClick="btnVolver_Click" runat="server" />
    </div>

</asp:Content>
