<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="TPC___Silva___Plaza.Compras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        

  
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
    <form id="Form1" runat="server">
    <asp:ScriptManager ID="ScripManager1" runat="server"></asp:ScriptManager>

    <a>Ingreso de Compras</a>


                <h4><b>Seleccione el Proveedor</b></h4>

                    
                       <asp:UpdatePanel runat="server">
                            <ContentTemplate>
                                
                                <div class="form-group">
                                    <div class="row">
                       
                        <asp:DropDownList runat="server" ID="ListProv" CssClass="mydropdownlist1" AutoPostBack="true"
                            OnSelectedIndexChanged="ListProv_SelectedIndexChanged">
                             <asp:ListItem Value="0">&lt;Seleccione un Proveedor...&gt;</asp:ListItem>
                        </asp:DropDownList>
                        </div>
                     
<%--                         <asp:Button Text="Cargar" ID="btnContinue" autopostback="false" OnClientClick="return validar()" OnClick="btnContinue_Click" CssClass="btn btn-primary" runat="server" />
                         --%>

                         <br />

                    

                         

                         
                                    <asp:GridView ID="DgvProveedor" runat="server"></asp:GridView><br /><br />

                                    <h4><b>Agregue los productos</b></h4>
                                    <label>Buscar por ID: <input type="text" id="txtid" name="nombre" /></label>
                                    <div class="row">
                                        <h4><b>Buscar por filtro</b></h4>
                                        <div class="col">
                                            <asp:Label Text="Categoria" runat="server"></asp:Label>
                                            <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="mydropdownlist1" class="btn btn-outline" AutoPostBack="true"
                                                 OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged"></asp:DropDownList>
                                            
                                            <asp:Label Text="Marca" runat="server"></asp:Label>
                                            <asp:DropDownList runat="server" ID="ddlMarca" CssClass="mydropdownlist1" class="btn btn-outline" AutoPostBack="true"
                                                 OnSelectedIndexChanged="ddlMarca_SelectedIndexChanged"></asp:DropDownList>


                                        </div>
                                        
                                            <div class="col">
                                                <asp:GridView ID="dgvArticulos" runat="server"></asp:GridView><br /><br />

                                        </div>
                                    </div>
                                    
                                    <label>Buscar por ID: <input type="text" id="nombre" name="nombre" /></label>


                                    <table class="table table-striped table-hover">
                                        <thead>
                                            <tr>
                                                <th scope="col">ID</th>
                                                <th scope="col">Vendedor</th>
                                                <th scope="col">Precio</th>
                                                <th scope="col">Fecha</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                          <asp:Repeater runat="server" ID="repetidor">
                                                <ItemTemplate> 
                                                        <tbody>
                                                            <tr>                    
                                                                <%--<td><img src="<%#Eval("ImagenUrl") %>" class="card-img-top"></td>--%>
                                                                <td style="padding-top:4rem;"><%#Eval("IdArticulo") %></td>
                                                                <td style="padding-top:4rem;">$<%#Eval("Precio") %></td>                           
                               
                                                                <%--<td style="padding-top:4rem;"><asp:TextBox TextMode="Number" text='$<%# Session["Cant"].ToString() %>' ID="txtCantidad" min="1" max="20" AutoPostBack="true"  OnTextChanged="txtCantidad_TextChanged" runat="server" />--%>
                                
                                                                <td style="padding-top:4rem;"><'$<%# Session["Cant"].ToString() %>' * <%#Eval("Precio") %>></td>
                            
                           
                               
                                                                <%--<td style="padding-top:4rem;""><asp:Button Style="background-image:url('imagenes/Iconos/delete.png');" class="quitar" ID="Button1" CommandArgument='<%#Eval("Codigo")%>' CommandName="CodArticulo" runat="server" OnClick="EliminarArticuloCarrito" /></td>--%>
                            
                                
                                                            </tr>
                                                        </tbody> 
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </tbody>
                                    </table>
                        
                         

                


                         

                                    </div>
                                
                              </ContentTemplate>
                             </asp:UpdatePanel>
                 </form>            
                        


</asp:Content>
