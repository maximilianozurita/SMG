<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-3"></div>
        <div class="col">
            <div class="mb-3">
                <asp:TextBox runat="server" type="email" CssClass="form-control" ID="ImputEmail" aria-describedby="exampleInputEmail1" placeholder="Email" />
            </div>
            <div class="mb-3">
                <asp:TextBox runat="server" type="password" CssClass="form-control" ID="exampleInputPassword1" aria-describedby="exampleInputPassword1" placeholder="Password" />
            </div>
            <div class="container justify-content-center align-content-center">
                <div class="mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="exampleCheck1">
                    <label class="form-check-label" for="exampleCheck1">Mantener la sesión iniciada</label>
                </div>
                <button type="reset" class="btn btn-primary">Cancelar</button>
                <asp:Button Text="Iniciar sesión" CssClass="btn btn-primary" ID="ButtonAceptar" OnClick="btnAceptarClick" runat="server" />
            </div>

        </div>
        <div class="col-3"></div>

    </div>
</asp:Content>
