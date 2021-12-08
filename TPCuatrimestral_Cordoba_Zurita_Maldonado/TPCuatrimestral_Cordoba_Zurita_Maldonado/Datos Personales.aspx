<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Datos Personales.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Datos_Personales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        function validar() {
            var Nombre = document.getElementById("textNombre").value;
            var Apellido = document.getElementById("textApellido").value;
            var Telefono = document.getElementById("textTelefono").value;
            var DNI = document.getElementById("DNI").value;
            if (Nombre === "" || Apellido === "" || Telefono === "" || DNI === "") {
                alert("Los datos de la persona que pagara deben estar completos. Gracias!");
                return false;
            }
            return true;
        }
    </script>
    <div class="conteiner p-4 ">
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
                    <input id="txtNombre" type="text" class="form-control p-2 m-3" placeholder="Nombre" aria-label="Nombre" aria-describedby="basic-addon1">
                    <input id="txtApellido" type="text" class="form-control p-2 m-3" placeholder="Apellido" aria-label="Apellido">
                    <input id="txtDni" type="text" class="form-control p-2 m-3" placeholder="Dni" aria-label="Dni">
                    <input id="txtCelular" type="text" class="form-control p-2 m-3" placeholder="Celular" aria-label="Celular">
                    <input id="txtEmail" type="text" class="form-control p-2 m-3" placeholder="Email" aria-label="Email">
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="basic-addon1">@</span>
                        </div>
                        <input type="text" class="form-control" placeholder="Email" aria-label="Email" aria-describedby="basic-addon1">
                    </div>
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
                    <%
                        } %>
                </div>
            </div>
        </div>

        <%--<div class="conteiner">
        <h5 class="d-flex justify-content-center">ENTREGA</h5>
        <div class="form-check border border-ligth">
            <%--<div>
                <h6 class="p-2">Envio a Domicilio</h6>
                <div class="shadow p-3 mb-5 bg-white rounded">
                    <input class="form-check-input" type="radio" name="exampleRadios" id="exampleRadios1" value="option1" checked>
                    <label class="form-check-label" for="exampleRadios1">
                        A Coordinar
                    </label>
                </div>
            </div>--%>

        <%-- <div>
                <%--<h6 class="p-2">Retirar por</h6>
                <div class="shadow p-3 mb-5 bg-white rounded">
                    <input class="form-check-input" type="radio" name="exampleRadios" id="exampleRadios2" value="option1" checked>
                    <label class="form-check-label" for="exampleRadios1">Gratis</label>
                    <p>Retiras por Local Tu mama me mima (CAZON 6897)</p>
                    <p class="text-secondary">lunes a viernes de 7am a 8am</p>
                </div>--%>
        <%--</div>
        --%>
        <%--<%--  </div>
   <%-- </div>--%>

        <%--    <div class="conteiner p-4 ">
        <h5 class="d-flex justify-content-center">DATOS DE FACTURACION</h5>
        <select class="form-select form-select-lg mb-3" aria-label=".form-select-lg example">
            <option selected>Pais</option>
            <option value="one">Argentina</option>
            <option value="two">Uruguay</option>
            <option value="three">Chile</option>
        </select>
    </div>--%>

        <%-- <div>
        <%--<h6>Persona que Pagara</h6>--%>
        <%--<div class="p-2">
            <input id="DNI" type="text" class="form-control p-2 m-3" placeholder="DNI" aria-label="DNI" aria-describedby="basic-addon1">
            <input id="textNombre" type="text" class="form-control p-2 m-3" clientidmode="static" placeholder="Nombre" aria-label="Nombre">
            <input id="textApellido" type="text" class="form-control p-2 m-3" placeholder="Apellido" aria-label="Apellido">
            <input id="textTelefono" type="text" class="form-control p-2 m-3" placeholder="Telefono" aria-label="Telefono">
        </div>

    </div>--%>

        <div class="d-grid gap-2">
            <asp:Button ID="btnContinuar" OnClientClick="return validar()" OnClick="btnContinuar_Click" class="btn btn-primary" runat="server" Text="Continuar" />
        </div>
</asp:Content>
