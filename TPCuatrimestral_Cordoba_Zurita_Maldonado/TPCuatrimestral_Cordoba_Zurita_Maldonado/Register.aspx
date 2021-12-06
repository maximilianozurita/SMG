<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-md-4">
        <label for="txtNombre" class="form-label">Nombre</label>
        <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"/>  
    </div>


    <div class="col-md-4">
        <label for="txtApellido" class="form-label">Apellido</label>
        <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control"/>  
    </div>


    <div class="col-md-4">
        <label for="txtContraseña" class="form-label">Contraseña</label>
        <asp:TextBox runat="server" ID="txtContraseña" CssClass="form-control"/>  
    </div>


    <div class="mb-3">
        <label for="txtEmail" class="form-label">Correo Electronico (Nombre de Usuario) </label>
        <asp:TextBox runat="server" ID="txtEmail" type="email" CssClass="form-control" placeholder="name@example.com"/>  
    </div>


    <div class="mb-3">
        <label for="formFile" class="form-label">Ingrese una foto (opcional)</label>
        <input class="form-control" type="file" id="formFile">
    </div>


    <div class="col-12">
        <asp:Button Text="Crear Cuenta" CssClass="btn btn-primary" ID="btnCrearCuenta" OnClick="btnCrearCuenta_Click" runat="server" />
    </div>

</asp:Content>
