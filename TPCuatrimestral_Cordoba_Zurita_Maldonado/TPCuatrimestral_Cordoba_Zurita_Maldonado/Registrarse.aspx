<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-md-4">
        <label for="txtNombre" class="form-label">Nombre</label>
        <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
    </div>


    <div class="col-md-4">
        <label for="txtApellido" class="form-label">Apellido</label>
        <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
    </div>

    <div class="col-md-4">
        <label for="txtCelular" class="form-label">Celular</label>
        <asp:TextBox runat="server" ID="txtCelular" CssClass="form-control" />
    </div>

    <div>
        <label for="txtNacimiento" class="form-label">Fecha de nacimiento</label>
        <asp:TextBox runat="server" type="date" CssClass="form-control" ID="txtNacimiento"></asp:TextBox>
    </div>

    <div class="mb-3">
        <label for="txtEmail" class="form-label">Correo Electronico (Nombre de Usuario) </label>
        <asp:TextBox runat="server" ID="txtEmail" type="email" CssClass="form-control" placeholder="name@example.com" />
    </div>


    <div class="col-md-4">
        <label for="txtContraseña" class="form-label">Contraseña</label>
        <asp:TextBox runat="server" ID="txtContraseña" CssClass="form-control" />
    </div>


    <div class="mb-3">
        <label for="formFile" class="form-label">Ingrese una foto (opcional)</label>
        <input class="form-control" type="file" id="formFile">
    </div>


    <div class="col-12">

        <%if ((Session["NombreUsuario"]) != null)
            { %>

        <asp:Button Text="Volver" CssClass="btn btn-primary" ID="btnVolver" OnClick="btnVolver_Click" runat="server" />

        <button class="btn btn-primary" type="button" data-bs-toggle="collapse" data-bs-target="#collapseWidthExample" aria-expanded="false" aria-controls="collapseWidthExample">
            Modificar
        </button>

        <div style="min-height: 120px;">
            <div class="collapse collapse-horizontal" id="collapseWidthExample">
                <div class="card card-body" style="width: 300px;">
                    Esta seguro que quiere modificar sus datos? 

                    <asp:Button Text="Si!" CssClass="btn btn-primary" ID="btnSI" OnClick="btnCrearCuenta_Click" runat="server" />
                    <br />
                    <asp:Button Text="Volver al Home" CssClass="btn btn-primary" ID="btnNO" OnClick="btnNO_Click" runat="server" />

                </div>
            </div>
        </div>

        <%} %>
        <%else
            { %>

        <asp:Button Text="Crear Cuenta" CssClass="btn btn-primary" ID="btnCrearCuenta" OnClick="btnCrearCuenta_Click" runat="server" />

        <%} %>
    </div>

</asp:Content>
