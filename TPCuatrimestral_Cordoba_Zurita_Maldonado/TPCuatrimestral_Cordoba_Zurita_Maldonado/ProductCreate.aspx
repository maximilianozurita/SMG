<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductCreate.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.ProductCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-4">
            <div class="mb-3">
                <label for="formFile" class="form-label">Cargue imagen 1</label>
                <asp:FileUpload ID="FileUpload1" runat="server" accept=" .jpg .png .jpeg" CssClass="form-control form-control-lg " />
            </div>
            <div class="mb-3">
                <label for="formFileSm" class="form-label">Cargue imagen 2</label>
                <asp:FileUpload ID="FileUpload2" runat="server" accept=" .jpg .png .jpeg" CssClass="form-control form-control-lg" />
            </div>
            <div class="mb-3">
                <label for="formFileSm" class="form-label">Cargue imagen 3</label>
                <asp:FileUpload ID="FileUpload3" runat="server" accept=" .jpg .png .jpeg" CssClass="form-control form-control-lg" />
            </div>
            <div class="mb-3">
                <label for="formFileSm" class="form-label">Cargue imagen 4</label>
                <asp:FileUpload ID="FileUpload4" runat="server" accept=" .jpg .png .jpeg" CssClass="form-control form-control-lg" />
            </div>
            <div>
                <label for="formFileSm" class="form-label">Cargue imagen 5</label>
                <asp:FileUpload ID="FileUpload5" runat="server" accept=" .jpg .png .jpeg" CssClass="form-control form-control-lg" />
            </div>
        </div>
        <div class="col-6">
            <div class="row g-3">
                <div class="col-12">
                    <label for="input" class="form-label">Nombre</label>
                    <asp:TextBox runat="server" type="text" CssClass="form-control" ClientIDMode="Static" ID="inputNombre"></asp:TextBox>
                    <span id="errorName" class="alert-danger d-flex align-items-center"></span>
                </div>
                <div class="col-12">
                    <label for="input" class="form-label">Descripción</label>
                    <asp:TextBox runat="server" type="text" CssClass="form-control" ClientIDMode="Static" ID="inputDescripcion"></asp:TextBox>
                    <span id="errorDescription" class="alert-danger d-flex align-items-center"></span>
                </div>
                <div class="col-12">
                    <label for="input" class="form-label">Requerimientos</label>
                    <asp:TextBox runat="server" type="text" CssClass="form-control" ClientIDMode="Static" ID="inputRequerimiento"></asp:TextBox>
                    <span id="errorRequerimiento" class="alert-danger d-flex align-items-center"></span>
                </div>
                <div class="col-12">
                    <label for="input" class="form-label">Link de video</label>
                    <asp:TextBox runat="server" type="text" CssClass="form-control" ClientIDMode="Static" ID="inputLinkVideo"></asp:TextBox>
                    <span id="errorLinkVideo" class="alert-danger d-flex align-items-center"></span>
                </div>
                <div class="col-12">
                    <label for="input" class="form-label">Clasificación</label>
                    <asp:TextBox runat="server" type="number" min="0" max="18" CssClass="form-control" ClientIDMode="Static" ID="inputClasificacion"></asp:TextBox>
                    <span id="errorClasificacion" class="alert-danger d-flex align-items-center"></span>
                </div>
                <div class="col-md-6">
                    <label for="input" class="form-label">Precio</label>
                    <asp:TextBox runat="server" type="number" step=".01" min="0" CssClass="form-control" ClientIDMode="Static" ID="inputPrecio"></asp:TextBox>
                    <span id="errorPrecio" class="alert-danger d-flex align-items-center"></span>
                </div>
                <div class="col-md-6">
                    <label for="input" class="form-label">%Descuento</label>
                    <asp:TextBox runat="server" type="number" step=".01" min="0" max="100" CssClass="form-control" ClientIDMode="Static" ID="inputDescuento"></asp:TextBox>
                    <span id="errorDescuento" class="alert-danger d-flex align-items-center"></span>
                </div>

                <div class="col-12">
                    <label for="input" class="form-label">Fecha de lanzamiento</label>
                    <asp:TextBox runat="server" type="date" CssClass="form-control" ClientIDMode="Static" ID="inputFechaLanzamiento"></asp:TextBox>
                    <span id="errorFecha" class="alert-danger d-flex align-items-center"></span>
                </div>
                <div class="col-md-4">
                    <label for="inputCategory" class="form-label">Categoria</label>
                    <asp:DropDownList CssClass="form-select" ClientIDMode="Static" ID="DropdCategoria" runat="server"></asp:DropDownList>
                </div>
                <div class="col-md-4">
                    <label for="inputDev" class="form-label">Developer</label>
                    <asp:DropDownList CssClass="form-select" ClientIDMode="Static" ID="DropdDeveloper" runat="server"></asp:DropDownList>
                </div>

                <div class="col-12">
                    <div class="form-check">
                        <label for="inputDestacado" class="form-label">Destacado</label>
                        <asp:CheckBox runat="server" CssClass="form-check-label" ID="CheckDestacado" for="gridCheck" />
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="col-12">
        <asp:Button Text="Crear" CssClass="btn btn-primary" ID="btnCrearProducto" OnClientClick="return validar()" OnClick="btnCrearProducto_Click" runat="server" />
    </div>

    <script>
        var inputNombre = document.getElementById("inputNombre");
        var inputDescripcion = document.getElementById("inputDescripcion");
        var inputRequerimiento = document.getElementById("inputRequerimiento");
        var inputLinkVideo = document.getElementById("inputLinkVideo");
        var inputClasificacion = document.getElementById("inputClasificacion");
        var inputPrecio = document.getElementById("inputPrecio");
        var inputDescuento = document.getElementById("inputDescuento");
        var inputFechaLanzamiento = document.getElementById("inputFechaLanzamiento");

        let errorName = document.getElementById("errorName");
        let errorDescription = document.getElementById("errorDescription");
        let errorRequerimiento = document.getElementById("errorRequerimiento");
        let errorLinkVideo = document.getElementById("errorLinkVideo");
        let errorClasificacion = document.getElementById("errorClasificacion");
        let errorPrecio = document.getElementById("errorPrecio");
        let errorDescuento = document.getElementById("errorDescuento");
        let errorFechaLanzamiento = document.getElementById("errorFecha");

        let errorArray = [
            errorName,
            errorDescription,
            errorRequerimiento,
            errorLinkVideo,
            errorClasificacion,
            errorPrecio,
            errorDescuento,
            errorFechaLanzamiento
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
            if (inputNombre.value === "") {
                errorName.innerHTML = "Ingrese el nombre del videojuego"
                hasError = true;
            }
            if (inputDescripcion.value === "") {
                errorDescription.innerHTML = "Ingrese la descripcion del videojuego"
                hasError = true;
            }
            if (inputRequerimiento.value === "") {
                errorRequerimiento.innerHTML = "Ingrese los requerimientos del videojuego"

                hasError = true;
            }
            if (inputLinkVideo.value === "") {
                errorLinkVideo.innerHTML = "Ingrese los un link de video del videojuego"

                hasError = true;
            }

            if (inputClasificacion.value === "") {
                errorClasificacion.innerHTML = "Ingrese la clasificación"

                hasError = true;
            } else if (inputClasificacion.value > 18) {
                errorClasificacion.innerHTML = "El limite de clasificacion maximo es de 18 años"

                hasError = true;
            } else if (!isNumeric(inputClasificacion.value)) {
                errorClasificacion.innerHTML = "Ingrese valores numericos"

                hasError = true;
            }

            if (inputPrecio.value === "") {
                errorPrecio.innerHTML = "Ingrese el precio"

                hasError = true;
            } else if (!isNumeric(inputPrecio.value)) {
                errorPrecio.innerHTML = "Ingrese valores numericos"

                hasError = true;
            }


            if (inputDescuento.value === "") {
                errorDescuento.innerHTML = "Ingrese el descuento"

                hasError = true;
            } else if (inputDescuento.value > 100) {
                errorDescuento.innerHTML = "El limite de descuento maximo es de 100%"

                hasError = true;
            } else if (!isNumeric(inputDescuento.value)) {
                errorDescuento.innerHTML = "Ingrese valores numericos"

                hasError = true;
            }


            if (inputFechaLanzamiento.value === "") {
                errorFechaLanzamiento.innerHTML = "Ingrese la fecha de lanzamiento"

                hasError = true;
            }

            if (hasError) {
                return false;
            }

        }
    </script>

</asp:Content>

