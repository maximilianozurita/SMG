<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Medio de Pago.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Medio_de_Pago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteiner ">
        <h5 class="d-flex justify-content-center">Medios de Pago</h5>
        <div>
        <img class="h-25 w-25" src="https://d1zxmlch3z83cq.cloudfront.net/production/2.1.226/_next/server/static/img/brands/original/mercadopago.svg" alt="[object Object]"/>
  </div>
        </div>

    <asp:Button ID="btnRealizarPedido"  Onclick="btnRealizarPedido_Click"  runat="server" Text="Realizar Pedido" class="d-flex justify-content-end"/>

</asp:Content>
