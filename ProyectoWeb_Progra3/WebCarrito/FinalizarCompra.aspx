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


 <%if (Session["articulosAgregados"] != null)
     { %>
<body>
    <asp:Repeater ID="repArticulos" OnItemDataBound="repImagenes_ItemDataBound" runat="server">
        <ItemTemplate>

                     <hr style="color: white; background-color: white; width: 75%;" />

            <div id="container">

                <asp:Repeater ID="repImagenes" runat="server">
                    <ItemTemplate>
                <div>
                    <img src="<%#Eval("ImagenUrl") %>" alt="Imagen" />
                </div>
                    </ItemTemplate>
                </asp:Repeater>
                <div>
                    <center>
                        <div>
                            <h5><%#Eval("Nombre")%></h5>
                        </div>
                    </center>
                    <div>
                        <div>
                            <ul>
                                <li><%#Eval("Descripcion")%></li>
                                <li><%#Eval("Codigo")%></li>
                            </ul>
                        </div>
                    </div>
                    <h6><%#Eval("Precio")%></h6>
                </div>
            </div>
            <hr style="color: white; background-color: white; width: 75%;" />

        </ItemTemplate>
    </asp:Repeater>
                    

    <div>


        <asp:Label ID="PrecioFinal" runat="server" Text="Precion Final">  </asp:Label>
    </div>
          
               



    </body>

    
    <%}
        else
        { %>

    <h2>No hay productos</h2>

    <%} %>


</asp:Content>
