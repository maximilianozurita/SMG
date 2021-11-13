<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductCreate.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.ProductCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="row">
        <div class="col-4">
            <div class="mb-3">
                <label for="formFile" class="form-label">Cargue imagen 1</label>
                <input class="form-control" type="file" id="formFile">
            </div>
            <div class="mb-3">
                <label for="formFileMultiple" class="form-label">Multiple files input example</label>
                <input class="form-control" type="file" id="formFileMultiple" multiple>
            </div>
            <div class="mb-3">
                <label for="formFileDisabled" class="form-label">Disabled file input example</label>
                <input class="form-control" type="file" id="formFileDisabled" disabled>
            </div>
            <div class="mb-3">
                <label for="formFileSm" class="form-label">Small file input example</label>
                <input class="form-control form-control-sm" id="formFileSm" type="file">
            </div>
            <div>
                <label for="formFileLg" class="form-label">Large file input example</label>
                <input class="form-control form-control-lg" id="formFileLg" type="file">
            </div>
        </div>
        <div class="col-6">
            <div class="row g-3">


                <div class="col-12">
                    <label for="input" class="form-label">Nombre</label>
                    <asp:TextBox runat="server" type="text" Cssclass="form-control" id="inputNombre"></asp:TextBox>
                </div>
                <div class="col-12">
                    <label for="input" class="form-label">Descripción</label>
                    <asp:TextBox runat="server"  type="text" Cssclass="form-control" id="inputDescripcion"></asp:TextBox>
                </div>
                <div class="col-12">
                    <label for="input" class="form-label">Requerimientos</label>
                    <asp:TextBox runat="server"  type="text" Cssclass="form-control" id="inputRequerimiento"></asp:TextBox>
                </div>
                <div class="col-12">
                    <label for="input" class="form-label">Clasificación</label>
                    <asp:TextBox runat="server"  type="number" min="0" max="22" Cssclass="form-control" id="inputClasificacion"></asp:TextBox>
                </div>
                <div class="col-md-6">
                    <label for="input" class="form-label">Precio</label>
                    <asp:TextBox runat="server"  type="number" step=".01" min="0" Cssclass="form-control" id="inputPrecio"></asp:TextBox>
                </div>
                <div class="col-md-6">
                    <label for="input" class="form-label">Descuento</label>
                    <asp:TextBox runat="server"  type="number" step=".01" min="0" max="100" Cssclass="form-control" id="inputDescuento"></asp:TextBox>
                </div>

                <div class="col-12">
                    <label for="input" class="form-label">Fecha de lanzamiento</label>
                    <asp:TextBox runat="server"  type="date" Cssclass="form-control" id="inputFechaLanzamiento"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <label for="inputCategory" class="form-label">Categoria</label>
                   <asp:DropDownList Cssclass="form-select" id="DropdCategoria" runat="server"></asp:DropDownList>
                </div>
                <div class="col-md-4">
                    <label for="inputDev" class="form-label">Developer</label>
                   <asp:DropDownList Cssclass="form-select" id="DropdDeveloper" runat="server"></asp:DropDownList>
                </div>

                <div class="col-12">
                    <div class="form-check">
                        <label for="inputDestacado" class="form-label">Destacado</label>
                        <asp:CheckBox runat="server" Cssclass="form-check-label" id="CheckDestacado" for="gridCheck"/>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="col-12">
        <asp:Button Text="Crear" CssClass="btn btn-primary" ID="btnCrearProducto" OnClick="btnCrearProducto_Click" runat="server" />
    </div>






</asp:Content>
