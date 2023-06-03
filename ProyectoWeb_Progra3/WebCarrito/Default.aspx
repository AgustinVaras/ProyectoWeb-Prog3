<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebCarrito.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        /*Cuerpo*/

        body {
            max-width: auto;
        }
        /**/
        /*ID de DIV*/
        #contenedor {
            width: 20%;
            margin: 0px auto;
        }

        /*para que el footer no se pegue*/
        .clearfix {
            clear: both;
        }

        /*Seccion principal ID de section*/
        #Principal {
            float: right;
            width: 90%;
            min-height: 800px;
        }

        /*Barra izquierda*/
        aside {
            float: left;
            width: 10%;
            min-height: 800px;
        }

        ul li {
            /* float:left; 
             margin: 2px;
             list-style: none;*/
        }
    </style>    
</asp:Content>
