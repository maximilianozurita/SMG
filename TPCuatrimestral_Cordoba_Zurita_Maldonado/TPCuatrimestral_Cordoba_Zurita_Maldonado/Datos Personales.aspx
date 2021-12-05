<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Datos Personales.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Datos_Personales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        function validar()
        {
            var Nombre = document.getElementById("textNombre").value;
            var Apellido = document.getElementById("textApellido").value;
            var Telefono = document.getElementById("textTelefono").value;
            var DNI = document.getElementById("DNI").value;
            if (Nombre === "" || Apellido === "" || Telefono === "" || DNI === "")
            {
                alert("Los datos de la persona que pagara deben estar completos. Gracias!");
                return false;
            }
            return true;
        }
    </script>
    <div class="conteiner p-4 ">
        <h5 class="d-flex justify-content-center"> DATOS DE CONTACTO</h5>
      <div class="input-group mb-3">
  <div class="input-group-prepend">
    <span class="input-group-text" id="basic-addon1">@</span>
  </div>
  <input type="text" class="form-control" placeholder="Email" aria-label="Email" aria-describedby="basic-addon1">
</div>
        </div>

    <div class="conteiner">
        <h5 class="d-flex justify-content-center"> ENTREGA</h5>
        <div class="form-check border border-ligth">
             <div >
                 <h6 class="p-2">Envio a Domicilio</h6>
                 <div class="shadow p-3 mb-5 bg-white rounded">
            <input class="form-check-input" type="radio" name="exampleRadios" id="exampleRadios1" value="option1" checked>
  <label class="form-check-label" for="exampleRadios1">
 A Coordinar
  </label>
                     </div>
            </div>

            <div>
                <h6 class="p-2">Retirar por</h6>
                <div class="shadow p-3 mb-5 bg-white rounded">
                <input class="form-check-input" type="radio" name="exampleRadios" id="exampleRadios2" value="option1" checked>
  <label class="form-check-label" for="exampleRadios1">Gratis</label>
                <p>Retiras por Local Tu mama me mima (CAZON 6897)</p>
                <p class="text-secondary">lunes a viernes de 7am a 8am</p>
                    </div>
            </div>
        </div>
</div>

     <div class="conteiner p-4 ">
        <h5 class="d-flex justify-content-center"> DATOS DE FACTURACION</h5>
  <select class="form-select form-select-lg mb-3" aria-label=".form-select-lg example">
  <option selected>Pais</option>
  <option value="one">Argentina</option>
  <option value="two">Uruguay</option>
  <option value="three">Chile</option>
</select>
     </div>

    <div>
    <h6>Persona que Pagara</h6>
           <div class="p-2">
  <input ID="DNI" type="text" class="form-control p-2 m-3" placeholder="DNI" aria-label="DNI" aria-describedby="basic-addon1">
  <input ID ="textNombre" type="text" class="form-control p-2 m-3" ClientIdMode="static" placeholder="Nombre" aria-label="Nombre">
  <input  ID ="textApellido" type="text" class="form-control p-2 m-3"  placeholder="Apellido" aria-label="Apellido">
  <input  ID="textTelefono" type="text" class="form-control p-2 m-3" placeholder="Telefono" aria-label="Telefono">
    </div>
        
</div>
    
    <asp:Button ID="btnContinuar" OnClientClick="return validar()" Onclick="btnContinuar_Click" class="btn btn-primary" runat="server" Text="Continuar" />

</asp:Content>
