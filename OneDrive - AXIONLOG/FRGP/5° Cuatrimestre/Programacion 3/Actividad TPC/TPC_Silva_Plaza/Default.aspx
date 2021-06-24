<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPC_Silva_Plaza._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <figure class="text-center">
            <h1>Lista de Productos</h1>
        </figure>


   <%-- <div class="productos">

        <div class="row">
            <% foreach (Dominio.Articulo item in lista)

                {%>
            <div class="col">

                <div class="card">



                    <div class="card-group">
                        <div class="card-body">
                            <img src="<% = item.ImagenUrl %>" class="card-img-top" alt="Card image cap">

                            <h5 class="card-title"><% = item.Nombre %>
                            
                            </h5>

                            <a href="Carrito.aspx?codigo=<% = item.Codigo %>" class="stretched-link"></a>


                        </div>



                    </div>


                </div>
                <%} %>
            </div>

        </div>
    </div>--%>

       
    
  <div class="container-menu">
        <div class="cont-menu">
            <br />
            <br />
            <br />
            <br />
     <%--         FILTRO DE NOMBRE                                                       --%>
            
            <h4><b>Buscar por Nombre</b></h4>
           
               <div class="input-group">
                <div class="form-outline">
                
                    
<%--                   <div class="form-inline">
                    <div class="d-grid gap-2 col-6">
                    <asp:TextBox ID="textNombre1" runat="server"  OnTextChanged="textNombre1_TextChanged">
                     
                    </asp:TextBox>
                         <% Session["Nombre"] = textNombre1.Text;  %>
                            <a href="ListaProductos.aspx?Nombre= textNombre1.Text"></a>    
                        


                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" text="Buscar" OnClientClick="GetURL():" />

                        <asp:Label Visible="false" Text="text" ID="TEXTPRUEBA" runat="server" />

                        </div>
                </div>--%>
                </div>
          

            </div>
            
     <%--       FILTRO DE CATEGORIA                                                                             --%>
            <h4><b>Filtrar por Categoria</b></h4>
            <div class="btn-group">
<div class="dropdown">
  <a class="btn btn-secondary dropdown-toggle" href="#" role="button" id="dropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
   Seleccionar...
      </a>
                <div class="dropdown-menu" aria-labelledby="dropdownMenuLink">

                    <asp:Repeater ID="ListCategoria" runat="server">
                        <ItemTemplate>
                            <a class="dropdown-item" href="#">1</a>
                           <%-- <a class="dropdown-item" href="#">%# Eval("Categoria")%</a>--%>
                            <%--<li><a href="ListaProductos.aspx?Categoria=<%# Eval("Categoria")%>"><%# Eval("Categoria")%></a></li>--%>
                        </ItemTemplate>
                    </asp:Repeater>
                   <%-- <li><a href="">1</a></li>--%>
                </ul>


            </div>
            <br />
            <br />
           
</div>
      </div>


</asp:Content>
