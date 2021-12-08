<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Datos Personales.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Datos_Personales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="container">
            <div class="row align-items-start">
                <div class="col">
                    <h5 class="d-flex justify-content-center">DATOS DE CONTACTO</h5>
                    <select class="form-select form-select-lg mb-3" aria-label=".form-select-lg example">
                        <option selected>Pais</option>
                        <option value="one">Argentina</option>
                        <option value="two">Uruguay</option>
                        <option value="three">Chile</option>
                    </select>

                    <label for="txtNombre" class="form-label">Nombre</label>
                    <asp:TextBox runat="server" ClientIDMode="Static" ID="txtNombre" CssClass="form-control" />
                    <span id="errorNombre" class="alert-danger d-flex align-items-center"></span>

                    <label for="txtApellido" class="form-label">Apellido</label>
                    <asp:TextBox runat="server" ClientIDMode="Static" ID="txtApellido" CssClass="form-control" />
                    <span id="errorApellido" class="alert-danger d-flex align-items-center" ></span>

                    <label for="txtDni" class="form-label">Dni</label>
                    <asp:TextBox runat="server" ClientIDMode="Static" ID="txtDni" CssClass="form-control" />
                    <span id="errorDni" class="alert-danger d-flex align-items-center"></span>

                    <label for="txtCelular" class="form-label">Celular</label>
                    <asp:TextBox runat="server" ClientIDMode="Static" ID="txtCelular" CssClass="form-control" />
                    <span id="errorCelular" class="alert-danger d-flex align-items-center"></span>

                    <label for="txtEmail" class="form-label">Email</label>
                    <asp:TextBox runat="server" ClientIDMode="Static" ID="txtEmail" CssClass="form-control" />
                    <span id="errorEmail" class="alert-danger d-flex align-items-center"></span>

                </div>
                <div class="col">
                    <h5 class="d-flex justify-content-center">TU COMPRA</h5>
                    <% foreach (var item2 in LJuegosAgregados)
                       {%>
                    <div class="card mb-3 " style="max-width: 800px;">
                        <div class="row no-gutters">
                            <div class="col-md-4">
                                <img src="/images/product/<%=item2.Imagen.Count>=1? item2.Imagen[0].urlImagen:"Default.png"%>" class="card-img-top" alt="..">
                            </div>
                            <div class="col-md-8">

                                <div class="card-body">

                                    <a href="ProductDetail.aspx?id=<%=item2.ID %>" class="text-primary"><%=item2.Name%></a>
                                    <p class="card-text"><%=item2.Description %></p>
                                    <p class="card-text"><%="Precio: $" %><%=item2.Price %></p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <% } %>
                </div>
            </div>
        </div>
    <br />
    <div class="d-grid gap-2">
        <asp:Button Text="Continuar" CssClass="btn btn-primary" ID="btnContinuar" OnClientClick="return validar()" OnClick="btnContinuar_Click" runat="server" />
    </div>

    <script>
        var txtNombre = document.getElementById("txtNombre");
        var txtApellido = document.getElementById("txtApellido");
        var txtDni = document.getElementById("txtDni");
        var txtCelular = document.getElementById("txtCelular");
        var txtEmail = document.getElementById("txtEmail");

        let errorNombre = document.getElementById("errorNombre");
        let errorApellido = document.getElementById("errorApellido");
        let errorDni = document.getElementById("errorDni");
        let errorCelular = document.getElementById("errorCelular");
        let errorEmail = document.getElementById("errorEmail");

        let errorArray = [
            errorNombre,
            errorApellido,
            errorDni,
            errorCelular,
            errorEmail
        ];

        function resetError() {
            errorArray.forEach(error => {
                error.innerHTML = ""
            });
        }

        function isNumeric(n) {
            return !isNaN(parseFloat(n)) && isFinite(n);
        }

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
            if (txtDni.value === "") {
                errorDni.innerHTML = "Ingrese su DNI"
                hasError = true;
            } else if (!isNumeric(txtDni.vlue)) {
                errorDni.innerHTML = "Solo ingrese valores numericos"
                hasError = true;
            }
            if (txtCelular.value === "") {
                errorCelular.innerHTML = "Ingrese su numero de celular"
                hasError = true;
            } else if (!isNumeric(txtCelular.value)) {
                errorCelular.innerHTML = "Solo ingrese valores numericos"
                hasError = true;
            }
            if (txtEmail.value === "") {
                errorEmail.innerHTML = "Debe ingresar un Email"
                hasError = true;
            }
            if (hasError) {
                return false;
            }
        }
    </script>

</asp:Content>
