<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebCarrito.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <style> 

        /*Cuerpo*/

        body
        {
            background:#C99B18;
            font-family:Arial, Helvetica, sans-serif;
        }

        /*ID de DIV*/
         #contenedor
         {   
                    width: 70%;
                    width: auto;
                   /* margin: 0px auto; */
                    
                    
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
             min-height: 500px;
             background: black;
         }

         /*Barra izquierda*/
         aside
         {
             float:left;
             width:10%;
             min-height: 500px;
             background:green;
             
         }

         ul li
         {
             float:left; 
             margin: 2px;
             list-style: none;

         }

    </style>
    
 

    <body>
           
        <div id="contenedor">
            <section id="Principal">
            <h1>Cuerpo</h1>

        </section>

        <aside>
            <h3>Barra Lateral</h3>
            
            <ul>
                <li><a href="#">Audio</a></li>
                <li><a href="#">Celulares</a></li>
                <li><a href="#">Televisores</a></li>
                <li><a href="#">Media</a></li>
            </ul>
        </aside>



        </div>



    </body>
    
</asp:Content>
