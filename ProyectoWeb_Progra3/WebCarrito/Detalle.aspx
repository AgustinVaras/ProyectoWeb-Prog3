<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebCarrito.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
       
        *
        {
            padding:0;
            margin:0;
            box-sizing:border-box;

        }

        body
        {
            max-width: auto;
            

        }

        img
        {
            max-width: 100%;

        }

        main
        {
            display: flex;
            gap: 30px;
            margin-bottom: 80px;

        }

        .conteiner-imagen
        {
            
            flex:1;

        }

        .container-info-producto
        {

            flex:1;
            display: flex;
            flex-direction: column;
        }

        .container-precio
        {
            padding-bottom: 20px;
            border-bottom: 1px solid #ffffff;
            display: flex;
            align-items: center;

        }
       
        .container-precio span
        {
            font-size: 24px;
            font-weight: 400;

        }

        .container-add-cart
        {
            display: flex;
            gap: 10px;
            padding-bottom: 10px;
            border-bottom: 1px solid #ffffff;

        }

        .container-cantidad
        {
            position: relative;

        }

        .input-cantidad
        {
            background-color: #0094ff;
            padding: 10px;
            border: none;
            width: 60px;
            height: 100%;
            color: #ffffff;
            font-weight: 500;
        }

        .btn-add-al-carrito
        {
            border:none;
            background-color: #0094ff;
            width: 200px;
            padding: 10px;
            color: #ffffff;
            display: flex;
            align-items: center;
            justify-content: center;
            gap: 5px;
            font-weight: 700;
            cursor: pointer;
            
        }

        .container-descripcion
        {
            display:flex;
            flex-direction: column;
            padding: 10px 0;

        }

        .text-descripcion
        {

            display:flex;
            align-content: center;
            justify-content: space-between;
            cursor: pointer;
        }

        .text-descripcion
        {
            font-size: 13px;
            color: #252525;
            line-height: 22px;
            margin-top: 10px;

        }



    </style>


<body>

    <main>
        <div class="conteiner-imagen">
           
            <%-- Imagen referencia --%>
            <img src="https://d22fxaf9t8d39k.cloudfront.net/e4b14270ade1a3c25db5c1ea9e90b98a866aa0784cd791de5e651b53f50d7c99155135.jpeg" alt="Producto" />
        
        </div>

        <div class="container-info-producto">
            
             <div class="container-descripcion">
                <div class="title-descripcion">
                    <h4>Descripcion</h4>
                </div>
                <div class="text-descripcion">
                    <%-- Detalle referencia --%>
                    <p>CELULAR</p>
                </div>
            </div>

            <div class="container-precio">
               
                <%-- Precio referencia --%>
                <span>$100.000</span>
            </div>

            <div class="container-add-cart">

                <div class="container-cantidad">

                    <input type="number" placeholder="1" value="1" min="1" class="input-cantidad"/>
                    <%--  Contador, minimo valor aceptable 1, arranca con el valor en 1  --%>
                </div>
            <button class="btn-add-al-carrito">
               <i class="bi bi-plus"></i>
                Añadir al carrito
            </button>

            </div>



        </div>

    </main>




</body>





</asp:Content>
