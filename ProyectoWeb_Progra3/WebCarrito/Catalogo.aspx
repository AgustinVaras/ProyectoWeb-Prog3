<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="WebCarrito.Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Tienda</h1>
    <p>Catálogo de Productos</p>
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% foreach (Clases.Articulo articulo in ListaArticulo)
            { %>
            <div class="col">
                <div class="card h-100">
                    <img src="..." class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%: articulo.Nombre %></h5>
                        <p class="card-text">$<%: articulo.Precio %></p>
                        <a href="#" class="btn btn-primary">Agregar al carrito</a>
                    </div>
                    <div class="card-footer">
                        <small class="text-body-secondary">Código de artículo: <%: articulo.Codigo %></small>
                    </div>
                </div>
            </div>
        <% } %>
    </div>
</asp:Content>
