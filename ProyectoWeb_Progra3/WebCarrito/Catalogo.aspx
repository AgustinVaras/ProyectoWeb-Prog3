<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="WebCarrito.Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Tienda</h1>
    <p>Catálogo de Productos</p>
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% foreach (Clases.Articulo articulo in ListaArticulo)
           {
                foreach (Clases.Imagen imagen in ListaImagen)
                {
                    if (articulo.Id == imagen.IdArticulo)
                    { %>
                        <div class="col">
                            <div class="card h-100">
                                <img src="<%: imagen.ImagenUrl %>" class="card-img-top img-fluid" alt="...">
                                <div class="card-body">
                                    <h5 class="card-title ms-1"><%: articulo.Nombre %></h5>
                                    <p class="card-text mb-1 ms-1">$<%: articulo.Precio %></p>
                                    <div class="btn-toolbar justify-content-between" role="toolbar" aria-label="Toolbar with button groups">
                                        <div class="btn-group me-2" role="group" aria-label="First group">
                                            <a href="Detalle.aspx?id=<%: articulo.Id %>" class="btn btn-light btn-sm mb-3">Ver detalles</a>
                                        </div>
                                        <div class="btn-group" role="group" aria-label="Second group">                                            
                                            <button type="button" class="btn btn-danger btn-sm mb-3">♥</button>
                                        </div>
                                    </div>
                                    <div  class="d-grid gap-2">
                                        <a href="#" class="btn btn-dark">Agregar al carrito</a>
                                    </div>
                                </div>
                                <div class="card-footer">
                                    <small class="text-body-secondary">Código de artículo: <%: articulo.Codigo %></small>
                                </div>
                            </div>
                        </div>
                 <% }
                }
           } %>
    </div>
</asp:Content>
