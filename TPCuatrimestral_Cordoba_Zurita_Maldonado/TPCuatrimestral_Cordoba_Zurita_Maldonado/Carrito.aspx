﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="conteiner d-flex justify-content-center m-2">
    <h2 class="p-2">Carrito de Compras</h2>
    </div>
    <div class="conteiner d-flex justify-content-center">
    <div class="card mb-3 " style="max-width: 800px;">
  <div class="row no-gutters">
    <div class="col-md-4">
      <img src=" /images/product/EFT.png" class="card-img h-100 p-2" alt="...">
    </div>
    <div class="col-md-8">
      <div class="card-body">
          <a href="ProductDetail.aspx?id=<%=videogame.ID %>"class="text-primary"><%=videogame.Name %></a>
          <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
      </div>
    </div>
  </div>
</div>
        <div class=" h-25" >
        <button type="button" class="btn btn-outline-primary  ">Iniciar Compra</button>
            </div>
    </div>
    
</asp:Content>