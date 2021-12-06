<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ContraseñaOlvidada.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.ContraseñaOlvidada" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row container">
        <div class="col-3"></div>
        <div class="col">
            <div class="mb-3">
                <h6>Te olvidaste tu contraseña? Escribinos tu email y te mandamos un correo electronico con tu contraseña!</h6>
            </div>
            <div class="mb-3">
                <asp:TextBox runat="server" AutoCompleteType="email" CssClass="form-control" ID="txtEmail" aria-describedby="exampleInputEmail" placeholder="Email@gmail.com" />
            </div>
            <div>
                <asp:Button Text="Enviar Email" CssClass="btn btn-primary" ID="btnEnviarEmail" OnClick="btnEnviarEmail_Click" runat="server" />
            </div>

            <% if (txtEmail.Text != "")
               {
                    Mod_Dominio.Usuario user = new Mod_Dominio.Usuario();
                    Negocio.UsuarioNegocio userNeg = new Negocio.UsuarioNegocio();
                    user = userNeg.Loguear(txtEmail.Text);

                    if (user == null)
                    {%>
                        <br />
                        <div class="alert alert-danger" role="alert">
                        El correo ingresado no existe. Cree una cuenta presionando <a href="Registrarse.aspx" class="alert-link">aqui</a>
                         </div>
                  <%}
                    else
                    {
                         if (user.Email == txtEmail.Text)
                         {%>
                             <br /> 
                             <div class="alert alert-success" role="alert">
                             Enviamos tu contraseña a tu Email! Para volver aingresar, presiona <a href="Login.aspx" class="alert-link">aqui</a>.
                             </div>
                       <%} %>
                  <%} %>
             <%} %>
        </div>
        <div class="col-3"></div>
    </div>

</asp:Content>
