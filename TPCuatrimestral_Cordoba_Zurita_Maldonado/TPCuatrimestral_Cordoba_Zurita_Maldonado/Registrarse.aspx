<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-md-4">
        <label for="txtNombre" class="form-label">Nombre</label>
        <asp:TextBox runat="server" ClientIDMode="Static" ID="txtNombre" CssClass="form-control" />
        <span id="errorNombre" class="alert-danger d-flex align-items-center"></span>
    </div>


    <div class="col-md-4">
        <label for="txtApellido" class="form-label">Apellido</label>
        <asp:TextBox runat="server" ClientIDMode="Static" ID="txtApellido" CssClass="form-control" />
        <span id="errorApellido" class="alert-danger d-flex align-items-center"></span>
    </div>

    <div class="col-md-4">
        <label for="txtCelular" class="form-label">Celular</label>
        <asp:TextBox runat="server" ClientIDMode="Static" ID="txtCelular" CssClass="form-control" />
        <span id="errorCelular" class="alert-danger d-flex align-items-center"></span>
    </div>

    <div>
        <label for="txtNacimiento" class="form-label">Fecha de nacimiento</label>
        <asp:TextBox runat="server" type="date" CssClass="form-control" ClientIDMode="Static" ID="txtNacimiento"></asp:TextBox>
        <span id="errorNacimiento" class="alert-danger d-flex align-items-center"></span>
    </div>

    <div class="mb-3">
        <label for="txtEmail" class="form-label">Correo Electronico (Nombre de Usuario) </label>
        <asp:TextBox runat="server" ClientIDMode="Static" ID="txtEmail" type="email" CssClass="form-control" placeholder="name@example.com" />
        <span id="errorEmail" class="alert-danger d-flex align-items-center"></span>
    </div>


    <div class="col-md-4">
        <label for="txtContraseña" class="form-label">Contraseña</label>
        <asp:TextBox runat="server" ClientIDMode="Static" ID="txtContraseña" CssClass="form-control" />
        <span id="errorContraseña" class="alert-danger d-flex align-items-center"></span>
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

                    <asp:Button Text="Si!" CssClass="btn btn-primary" ID="btnSI" OnClientClick="return validar()" OnClick="btnCrearCuenta_Click" runat="server" />
                    <br />
                    <asp:Button Text="Volver al Home" CssClass="btn btn-primary" ID="btnNO" OnClick="btnNO_Click" runat="server" />

                </div>
            </div>
        </div>

        <%} %>
        <%else
            { %>

        <asp:Button Text="Crear Cuenta" CssClass="btn btn-primary" ID="btnCrearCuenta" OnClientClick="return validar()" OnClick="btnCrearCuenta_Click" runat="server" />

        <%} %>
    </div>

    <script>
        var txtNombre = document.getElementById("txtNombre");
        var txtApellido = document.getElementById("txtApellido");
        var txtCelular = document.getElementById("txtCelular");
        var txtNacimiento = document.getElementById("txtNacimiento");
        var txtEmail = document.getElementById("txtEmail");
        var txtContraseña = document.getElementById("txtContraseña");

        let errorNombre = document.getElementById("errorNombre");
        let errorApellido = document.getElementById("errorApellido");
        let errorCelular = document.getElementById("errorCelular");
        let errorNacimiento= document.getElementById("errorNacimiento");
        let errorEmail = document.getElementById("errorEmail");
        let errorContraseña = document.getElementById("errorContraseña");

        let errorArray = [
            errorNombre,
            errorApellido,
            errorCelular,
            errorNacimiento,
            errorEmail,
            errorContraseña
        ];

        function resetError() {
            errorArray.forEach(error => {
                error.innerHTML = ""
            });
        }

        function isNumeric(n) {
            return !isNaN(parseFloat(n)) && isFinite(n);
        }

        //function ValidClass(input) {
        //    input.ClassList.Remove("is-invalid");
        //    input.classList.add("is-valid");
        //}

        //function InvalidClass(input) {
        //    input.ClassList.Remove("is-valid");
        //    input.classList.add("is-invalid");
        //}


        function validar() {

            resetError()

            let hasError = false;
            if (txtNombre.value === "") {
                errorNombre.innerHTML = "Ingrese su nombre por favor"
                hasError = true;
            }
            if (txtApellido.value === "") {
                errorApellido.innerHTML = "Ingrese su apellido por favor"
                hasError = true;
            }
            if (txtCelular.value === "") {
                errorCelular.innerHTML = "Ingrese su numero de celular"
                hasError = true;
            } else if (!isNumeric(txtCelular.value)) {
                errorCelular.innerHTML = "Solo ingrese valores numericos"
                hasError = true;
            }
            if (txtNacimiento.value === "") {
                errorNacimiento.innerHTML = "Ingrese su fecha de Nacimiento"
                hasError = true;
            }
            if (txtEmail.value === "") {
                errorEmail.innerHTML = "Debe ingresar un Email"
                hasError = true;
            }
            if (txtContraseña.value === "") {
                errorContraseña.innerHTML = "Debe proporcionar una contraseña"
                hasError = true;
            }


            if (hasError) {
                return false;
            }

        }
    </script>


</asp:Content>
