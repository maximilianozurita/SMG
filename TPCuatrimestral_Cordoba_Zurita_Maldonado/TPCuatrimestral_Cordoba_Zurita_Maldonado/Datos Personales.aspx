<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Datos Personales.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Datos_Personales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row align-items-start">
            <div class="col">
                <h5 class="d-flex justify-content-center">DATOS DE TARJETA</h5>

                <label for="txtNombreApellido" class="form-label">Nombre y Apellido</label>
                <asp:TextBox runat="server" ClientIDMode="Static" ID="txtNombreApellido" CssClass="form-control" />
                <span id="errorNombreApellido" class="alert-danger d-flex align-items-center"></span>

                <label for="txtNumeroTarjeta" class="form-label">Numero de Tarjeta</label>
                <asp:TextBox runat="server" ClientIDMode="Static" ID="txtNumeroTarjeta" CssClass="form-control" />
                <span id="errorNumeroTarjeta" class="alert-danger d-flex align-items-center"></span>

                <label for="txtCodigoSeguridad" class="form-label">Codigo de Seguridad</label>
                <asp:TextBox runat="server" ClientIDMode="Static" ID="txtCodigoSeguridad" CssClass="form-control" />
                <span id="errorCodigoSeguridad" class="alert-danger d-flex align-items-center"></span>

                <label for="txtVencimiento" class="form-label">Fecha de Vencimiento</label>
                <asp:TextBox runat="server" type="date" CssClass="form-control" ClientIDMode="Static" ID="txtVencimiento"></asp:TextBox>
                <span id="errorVencimiento" class="alert-danger d-flex align-items-center"></span>

            </div>
            <div class="col">
                <h5 class="d-flex justify-content-center">TU COMPRA</h5>

                <% float precioTotal = 0;
                    foreach (var item2 in LJuegosAgregados)
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
                                <%precioTotal += item2.Price; %>
                            </div>
                        </div>
                    </div>
                </div>
                <% } %>
                <p class="h2">Total: $<%=precioTotal %></p>
            </div>
        </div>
    </div>
    <br />
    <div class="d-grid gap-2">
        <asp:Button Text="Continuar" CssClass="btn btn-primary" ID="btnContinuar" OnClientClick="return validar()" OnClick="btnContinuar_Click" runat="server" />
    </div>

    <script>
        var txtNombreApellido = document.getElementById("txtNombreApellido");
        var txtNumeroTarjeta = document.getElementById("txtNumeroTarjeta");
        var txtCodigoSeguridad = document.getElementById("txtCodigoSeguridad");
        var txtVencimiento = document.getElementById("txtVencimiento");

        let errorNombreApellido = document.getElementById("errorNombreApellido");
        let errorNumeroTarjeta = document.getElementById("errorNumeroTarjeta");
        let errorCodigoSeguridad = document.getElementById("errorCodigoSeguridad");
        let errorVencimiento = document.getElementById("errorVencimiento");

        let errorArray = [
            errorNombreApellido,
            errorNumeroTarjeta,
            errorCodigoSeguridad,
            errorVencimiento
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
            if (txtNombreApellido.value === "") {
                errorNombreApellido.innerHTML = "Ingrese su nombre y apellido por favor"
                hasError = true;
            }
            if (txtNumeroTarjeta.value === "") {
                errorNumeroTarjeta.innerHTML = "Ingrese el Numero de Tarjeta"
                hasError = true;
            } else if (!isNumeric(txtNumeroTarjeta.value)) {
                errorNumeroTarjeta.innerHTML = "Solo ingrese valores numericos"
                hasError = true;
            }
            if (txtCodigoSeguridad.value === "") {
                errorCodigoSeguridad.innerHTML = "Ingrese el Codigo de Seguridad"
                hasError = true;
            } else if (!isNumeric(txtCodigoSeguridad.value)) {
                errorCodigoSeguridad.innerHTML = "Solo ingrese valores numericos"
                hasError = true;
            }
            if (txtVencimiento.value === "") {
                errorVencimiento.innerHTML = "Ingrese la fecha de vencimiento de la tarjeta"
                hasError = true;
            }
            if (hasError) {
                return false;
            }
        }
    </script>

</asp:Content>
