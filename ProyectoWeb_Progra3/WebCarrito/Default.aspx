<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebCarrito.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <style> 

        /*Cuerpo*/

        body
        {
          
            font-family:Arial, Helvetica, sans-serif;
        }
        /**/
        /*ID de DIV*/
         #contenedor
         {   
                    width: 70%;
                    width: auto;
                    margin: 0px auto;
                    
                    
         }

         /*para que el footer no se pegue*/
         .clearfix{
             clear:both;

         }

         /*Seccion principal ID de section*/
         #Principal
         {
             float:right;
             width:90%;
             min-height: 800px;
            background: red;
         }

         /*Barra izquierda*/
         aside
         {
             float:left;
             width:10%;
             min-height: 800px;
                
             
         }

         ul li
         {
            /* float:left; 
             margin: 2px;
             list-style: none;*/

         }
         
    </style>

 

    <body>
           
        <div id="contenedor">
            <section id="Principal">
            <h1>Cuerpo</h1>

        </section>

        <aside>
            <div class="container-fluid">
                <div class="row" >
                    <div class="col-sm-3">
                        <p class="fw-bolder h5">Categorias</p>
                        <div class="opacity-50">
                        <ul class="list-unstyled">
                            <li><a class="text-primary text-decoration-none" href="#">Audio</a></li>
                            <li><a class="text-primary text-decoration-none" href="#">Televisores</a></li>
                            <li><a class="text-primary text-decoration-none" href="#">Media</a></li>
                            <li><a class="text-primary text-decoration-none" href="#">Celulares</a></li>
                        </ul>
                        </div>
                    </div>
                </div>
                 <div class="row" >
                    <div class="col-sm-3">
                        <p class="fw-bolder h5">Marcas</p>
                        <div>
                        <div class="opacity-50">
                        <ul class="list-unstyled">
                            <li><a class="text-primary text-decoration-none" href="#">Samsung</a></li>
                            <li><a class="text-primary text-decoration-none" href="#">Apple</a></li>
                            <li><a class="text-primary text-decoration-none" href="#">Sony</a></li>
                            <li><a class="text-primary text-decoration-none" href="#">Huawei</a></li>
                            <li><a class="text-primary text-decoration-none" href="#">Motorola</a></li>
                        </ul>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
            
            
        </aside>



        </div>



    </body>
    
</asp:Content>
