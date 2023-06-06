<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FinalizarCompra.aspx.cs" Inherits="WebCarrito.FinalizarCompra" %>
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

  }

  img
  {
      max-width: 130px ;
  }

   main
  {
      display: flex;
      gap: 30px;
      margin-bottom: 80px;
  }

   #container {
    display: flex;
    align-items: center;
    gap: 10px;
   }

  li {
    list-style-position: inside;
    
  }


</style>


<body>
 

<hr style="color: white; background-color: white; width:75%;" />

<div id="container">

  <div>
      <img src="https://t2.ea.ltmcdn.com/es/posts/7/4/3/como_ayudar_a_un_gatito_a_defecar_20347_orig.jpg" alt="Imagen" />
  </div>
  <div>
       <center>
      <div>
          <h5>Aca va el nombre</h5>
      </div>
       </center> 
      <div>
          <div>
          <ul>
              <li>descripcion aca</li>
              <li>codigo aca</li>
          </ul>
          </div>
      </div>
      <h6>Precio:</h6>
  </div>
</div>
<hr style="color: white; background-color: white; width:75%;" />
</body>
</asp:Content>
