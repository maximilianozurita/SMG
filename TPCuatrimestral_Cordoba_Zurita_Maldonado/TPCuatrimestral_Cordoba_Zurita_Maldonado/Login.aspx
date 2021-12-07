<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row container">
        <div class="col-3"></div>
        <div class="col">
            <div class="mb-3">
                <asp:TextBox runat="server" type="email" CssClass="form-control" ID="txtEmail" aria-describedby="exampleInputEmail1" placeholder="Email" />
            </div>
            <div class="mb-3">
                <asp:TextBox runat="server" type="password" CssClass="form-control" ID="txtContraseña" aria-describedby="exampleInputPassword1" placeholder="Password" />
                <asp:Button type="button" CssClass="btn btn-link" Text="¿Olvidaste tu contraseña? Presiona aqui!" ID="linkContraseñaOlvidada" OnClick="linkContraseñaOlvidada_Click" runat="server" />
            </div>
            <div class="container justify-content-center align-content-center">
                <asp:Button Text="Cancelar" CssClass="btn btn-primary" ID="btnCancelar" OnClick="btnCancelar_Click" runat="server" />
                <asp:Button Text="Iniciar sesión" CssClass="btn btn-primary" ID="ButtonAceptar" OnClick="btnAceptarClick" runat="server" />
            </div>
        </div>
        <div class="col-3"></div>

    </div>
</asp:Content>
