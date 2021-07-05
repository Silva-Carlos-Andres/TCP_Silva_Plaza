<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="TPC___Silva___Plaza.Compras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <head>

        <title>My Site</title>


  <meta charset="utf-8">
 

  <link rel="stylesheet" href="chosen/chosen.css">

  <meta http-equiv="Content-Security-Policy" content="default-src &apos;self&apos;; script-src &apos;self&apos; https://ajax.googleapis.com; style-src &apos;self&apos;; img-src &apos;self&apos; data:">
            <script src="https://kit.fontawesome.com/86f5330d7d.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js"></script>
    <script src="https://unpkg.com/@popperjs/core@2"></script>
</head>
        <script>
        function validar() {

            var idProv = document.getElementById("selectid").value;

            if (idProv == ""){

                alert("Debes seleccionar un proveedor");

                return false;
            }
            /*var cod = document.getElementById("selectid").value;*/
            alert(idProv);

            var newLabel = document.createElement('label');
            //agrego la clase deseada
            newLabel.className += "col-md-3 control-label";
            newLabel.innerHTML = "Test";
            //agregando el label
            var contenedor = document.getElementById('contenedor');
            contenedor.appendChild(newLabel);   

            /*window.open("Compras.aspx?Id=" + idProv); */

            Session.Add("id", idProv);
            //$('#txtid').val(idProv);
            return true;
        }
        </script>
         <script type="text/javascript">
        function ShowSelected() {
            /* Para obtener el valor */
            var cod = document.getElementById("selectid").value;
            alert(cod);

            /* Para obtener el texto 
            var combo = document.getElementById("selectid");
            var selected = combo.options[combo.selectedIndex].text;
            alert(selected);*/
        }
         </script>



    <a>Ingreso de Compras</a>


<%--           <% foreach (Dominio.Proveedor item in lista)
            {%>
            <div class="col">
                <div class="card">
                    <div class="card-group">
                        <img src="<% = item.ImagenUrl %>" class="card-img-top" alt="Card image cap">
                        <h5 class="card-title"><% = item.Nombre %>
                            </h5>
                            </div>
                        <p class="card-text"><% = item.Descripcion %></p>
                            <ul class="list-group list-group-flush">
                            </ul>
                            
                        <div class="card-footer bg-transparent border-success"><h6><s>$<% = (item.Precio) + 200 %></s> Envio Gratis</h6></div>
                        <div class="text-center">$<% = item.Precio %></div>
                        <a href="Carrito.aspx?codigo=<% = item.Codigo %>" class="stretched-link"></a>

                </div>
            </div>
            <%} %>--%>


                <h4><b>Seleccione el Proveedor</b></h4>
                    
                    <%--<asp:Repeater ID="ListProveedores" runat="server">
                        <ItemTemplate>
                        <select id="selectid" class="form-select" size="5" aria-label="size 5 select example">
                            <option value=<%# Eval("ID")%>><%# Eval("ID")%>-<%# Eval("Nombre")%></option>
                        </select>
                            </ItemTemplate>
                    </asp:Repeater>--%>
                    <form id="Form1" runat="server">
                       <asp:Label Text="Seleccione el Proveedor" runat="server"></asp:Label>
                        <asp:DropDownList runat="server" ID="ListProv" CssClass="btn btn-outline-dark dropdown-toggle" AutoPostBack="true"
                            OnSelectedIndexChanged="ListProv_SelectedIndexChanged"></asp:DropDownList>
                        
                     
<%--                         <asp:Button Text="Cargar" ID="btnContinue" autopostback="false" OnClientClick="return validar()" OnClick="btnContinue_Click" CssClass="btn btn-primary" runat="server" />
                         --%>

                         <br />
                         <br />
                    <h4><b>Proveedor Seleccionado</b></h4>

                         <div id="contenedor"></div>

                         <label id="txtid1" runat="server"></label>
                         <asp:Label ID="txtid" Text="Seleccione una proveedor" EnableViewState="false" runat="server"></asp:Label><br />
                         <asp:Label ID="txtnombre" Visible="false" EnableViewState="false" runat="server"></asp:Label><br />
                         <asp:Label ID="txtemail" Visible="false" EnableViewState="false" runat="server"></asp:Label><br />
                         <asp:Label  ID="txtcuit" Visible="false" EnableViewState="false" runat="server"></asp:Label><br />
                         <label>Nombre: <input type="text" id="nombre" name="nombre" /></label>

                    <asp:Repeater ID="SelectProveedores" runat="server">
                        <ItemTemplate>
                          
                            </ItemTemplate>
                    </asp:Repeater>


                         <asp:Label ID="txtCampo" Visible="false" EnableViewState="false" runat="server"></asp:Label>

                             
                         </form>
                        


</asp:Content>
