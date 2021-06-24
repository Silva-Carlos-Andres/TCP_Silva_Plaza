<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="TPC_Silva_Plaza.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>    Titulo </h1>
 
    <script>
    function validar() {
            // ésta es la forma clásica y full JS de leer un elemento del dom (el dom es la página). Busco el elemento por ID poniendo el ID explícito.
            // Recordemos que como el control es ASP .NET, tuvimos que poner el ClientIDMode="Static" para txtDescripcion, para que no cambie 
        var descripcion = document.getElementById("textnombre").value;
            
            // acá estamos usando JS puro, pero concatenando con una sentencia de C# embebido para obtener el Id del control, al que no le agregamos la propiedad ClientIDMode antes mencionada.
           
            // y acá estamos usando JQuery. No lo vimos mucho, así que no pierdan el sueño con esto. La única diferencia acá es que la sentencia es más corta, pero hacemos lo mismo.
            // bueno, la otra diferencia es que en vez de poner ".value" ponemos ese "is checked", eso va a devolver un verdadero o falso.
           
            // luego evalulamos
            if (descripcion === "" || nombre === "") {
                // en este caso estamos mostrando un alert, es lo menos ideal, pero funciona. 
                // otra opción es mostrar algo en el HTML, desocultar algún control, por ejemplo. En el video les mostraré algo de eso.
                alert("Debes completar los campos");
                // finalmente, si hay una validación RETORNO FALSE.
                return false;
            }
            // acá simplemente mostramos un cartel o no, pero no necesariamente queremos que frene el flujo, sería informativo. 
            // repito: en ESTE caso, es un ejemplo.
            if (evoluciona) {
                alert("El pokemon evoluciona");
            }
           // Finalmente, si pasó todo y estuvo todo OK, RETORNO TRUE.
            return true;
        }
    </script>


    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet">
<div class="container">
  <div class="row">
    <div class="col-sm-4 col-md-3">
      <form>
        <div class="well">
          <div class="row">
            <div class="col-sm-12">
              <div class="input-group">
               <%-- <input id= "textnombre" clientIDMode="Static" type="text" class="form-control" placeholder="Search products...">--%>
                <asp:TextBox Text="Escriba..." ID="textnombre" ClientIDMode="Static" CssClass="form-control" runat="server"></asp:TextBox>
                  <span class="input-group-btn">
                  <%--<button class="btn btn-primary" type="submit">--%>
                      <asp:Button text="Buscar" ID="btnBuscar" autoPostBack="false" OnClientClick="return validar()" OnClick="btnBuscar_Click" CssClass="form-control" runat="server" />
                    <i class="fa fa-search"></i>
                  </button>
                </span>
              </div>
            </div>
          </div>
        </div>
      </form>

      <!-- Filter -->
      <form class="shop__filter">
        <!-- Price -->
        <h3 class="headline">
          <span>Price</span>
        </h3>
        <div class="radio">
          <input type="radio" name="shop-filter__price" id="shop-filter-price_1" value="" checked="">
          <label for="shop-filter-price_1">Under $25</label>
        </div>
        <div class="radio">
          <input type="radio" name="shop-filter__price" id="shop-filter-price_2" value="">
          <label for="shop-filter-price_2">$25 to $50</label>
        </div>
        <div class="radio">
          <input type="radio" name="shop-filter__price" id="shop-filter-price_3" value="">
          <label for="shop-filter-price_3">$50 to $100</label>
        </div>
        <div class="radio">
          <input type="radio" name="shop-filter__price" id="shop-filter-price_4" value="specify">
          <label for="shop-filter-price_4">Other (specify)</label>
        </div>
        <div class="form-group shop-filter__price">
          <div class="row">
            <div class="col-xs-4">
              <label for="shop-filter-price_from" class="sr-only"></label>
              <input id="shop-filter-price_from" type="number" min="0" class="form-control" placeholder="From" disabled="">
            </div>
            <div class="col-xs-4">
              <label for="shop-filter-price_to" class="sr-only"></label>
              <input id="shop-filter-price_to" type="number" min="0" class="form-control" placeholder="To" disabled="">
            </div>
            <div class="col-xs-4">
              <button type="submit" class="btn btn-block btn-default" disabled="">Go</button>
            </div>
          </div>
        </div>

        <!-- Checkboxes -->
        <h3 class="headline">
          <span>Categorias</span>
        </h3>
        <!-- aca pegalo despues -->
        <!-- Radios -->
        <h3 class="headline">
          <span>Material</span>
        </h3>
        <div class="radio">
          <input type="radio" name="shop-filter__radio" id="shop-filter-radio_1" value="" checked="">
          <label for="shop-filter-radio_1">100% Cotton</label>
        </div>
        <div class="radio">
          <input type="radio" name="shop-filter__radio" id="shop-filter-radio_2" value="">
          <label for="shop-filter-radio_2">Bamboo</label>
        </div>
        <div class="radio">
          <input type="radio" name="shop-filter__radio" id="shop-filter-radio_3" value="">
          <label for="shop-filter-radio_3">Leather</label>
        </div>
        <div class="radio">
          <input type="radio" name="shop-filter__radio" id="shop-filter-radio_4" value="">
          <label for="shop-filter-radio_4">Polyester</label>
        </div>
        <div class="radio">
          <input type="radio" name="shop-filter__radio" id="shop-filter-radio_5" value="">
          <label for="shop-filter-radio_5">Not specified</label>
        </div>

        <!-- Colors -->
        <h3 class="headline">
          <span>Colors</span>
        </h3>
        <div class="shop-filter__color">
          <input type="text" id="shop-filter-color_1" value="" data-input-color="black">
          <label for="shop-filter-color_1" style="background-color: black;"></label>
        </div>
        <div class="shop-filter__color">
          <input type="text" id="shop-filter-color_2" value="" data-input-color="gray">
          <label for="shop-filter-color_2" style="background-color: gray;"></label>
        </div>
        <div class="shop-filter__color">
          <input type="text" id="shop-filter-color_3" value="" data-input-color="brown">
          <label for="shop-filter-color_3" style="background-color: brown;"></label>
        </div>
        <div class="shop-filter__color">
          <input type="text" id="shop-filter-color_4" value="" data-input-color="beige">
          <label for="shop-filter-color_4" style="background-color: beige;"></label>
        </div>
        <div class="shop-filter__color">
          <input type="text" id="shop-filter-color_5" value="" data-input-color="white">
          <label for="shop-filter-color_5" style="background-color: white;"></label>
        </div>
      </form>
    </div>
    
    <div class="col-sm-8 col-md-9">
      <!-- Filters -->

  
        <div class="row">
       <% foreach (Dominio.Articulo item in lista)

            {%>
            <div class="col">

                
                   
                   
                <div class="card-A">
                    <div class="card-group">
                        
                        <%--<div class="card-body">--%>
                        <img src="<% = item.ImagenUrl %>" class="card-img-top" alt="...">
                          
                        <h5 class="card-title"><% = item.Nombre %>
                            
                            </h5>
                            </div>
                        <p class="card-text"><% = item.Descripcion %></p>
                            <ul class="list-group list-group-flush">
                             <%--   <li class="list-group-item"><% = item.Marca %></li>
                                <li class="list-group-item"><% = item.Categoria %></li>--%>
                            </ul>
                            
                        <div class="card-footer bg-transparent border-success"><h6><s>$<% = (item.Precio) + 200 %></s> Envio Gratis</h6></div>
                        <div class="text-center">$<% = item.Precio %></div>
                        <a href="Carrito.aspx?codigo=<% = item.Codigo %>" class="stretched-link"></a>
                       </div>
                            
                  <%--  </div>--%>

                    

                


            </div>
            <%} %>
            </div>
<%--    <asp:Repeater ID="ListArticulo" runat="server">
        <ItemTemplate>
            <div class="col">
                <div class="card">
                    <div class="card-group">
                        <div class="card-body">
                           <img src="<%# Eval("ImagenUrl") %>" class="card-img-top" alt="Card image cap">

                            <h5 class="card-title"><%# Eval("Nombre") %>
                           
                        </div>
                    </div>
                </div>
            </div>


        </ItemTemplate>
    </asp:Repeater>--%>






</div> <!-- / .col-sm-8 -->
  </div> <!-- / .row -->
</div>
</asp:Content>
