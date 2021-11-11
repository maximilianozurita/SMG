<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TPCuatrimestral_Cordoba_Zurita_Maldonado.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <%--checkbox--%>
        <div class="col-1">
            <div class="form-check">
              <input class="form-check-input" type="checkbox" value="" id="CheckLanzamientos">
              <label class="form-check-label" for="flexCheckDefault">
                Nuevos Lanzamientos
              </label>
            </div>
            <div class="form-check">
              <input class="form-check-input" type="checkbox" value="" id="CheckOfertas">
              <label class="form-check-label" for="flexCheckDefault">
                Ofertas
              </label>
            </div>
            <div class="form-check">
              <input class="form-check-input" type="checkbox" value="" id="CheckCategoria">
              <label class="form-check-label" for="flexCheckDefault">
                Cateogira1
              </label>
            </div>
            <div class="form-check">
              <input class="form-check-input" type="checkbox" value="" id="flexCheckChecked" checked>
              <label class="form-check-label" for="flexCheckChecked">
                Categoria2
              </label>
            </div>
        </div>
        
        <%--container videojuegos--%>
        <div class="col-9">
            <section id="galeria" class="container">
                <div class="text-start pt-5">
                    <h2>Galeria videojuegos</h2>
                </div>

                <div class="row">

                    <div class="col-lg-4">
                        <div class="card mx-2 mb-4">
                            <img src="/images/EFT.png" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Card title</h5>
                                <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            </div>
                            <div class="card-footer">
                                <small class="text-muted">Last updated 3 mins ago</small>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="card mx-2 mb-4"">
                            <img src="/images/EFT.png" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Card title</h5>
                                <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            </div>
                            <div class="card-footer">
                                <small class="text-muted">Last updated 3 mins ago</small>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="card mx-2 mb-4"">
                            <img src="/images/EFT.png" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Card title</h5>
                                <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            </div>
                            <div class="card-footer">
                                <small class="text-muted">Last updated 3 mins ago</small>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 mb-4"">
                        <div class="card mx-2 mb-4">
                            <img src="/images/EFT.png" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Card title</h5>
                                <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            </div>
                            <div class="card-footer">
                                <small class="text-muted">Last updated 3 mins ago</small>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="card mx-2 mb-4"">
                            <img src="/images/EFT.png" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Card title</h5>
                                <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            </div>
                            <div class="card-footer">
                                <small class="text-muted">Last updated 3 mins ago</small>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="card mx-2 mb-4"">
                            <img src="/images/EFT.png" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Card title</h5>
                                <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            </div>
                            <div class="card-footer">
                                <small class="text-muted">Last updated 3 mins ago</small>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="card mx-2 mb-4"">
                            <img src="/images/EFT.png" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Card title</h5>
                                <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            </div>
                            <div class="card-footer">
                                <small class="text-muted">Last updated 3 mins ago</small>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="card mx-2 mb-4"">
                            <img src="/images/EFT.png" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Card title</h5>
                                <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            </div>
                            <div class="card-footer">
                                <small class="text-muted">Last updated 3 mins ago</small>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
     </div>
</asp:Content>
