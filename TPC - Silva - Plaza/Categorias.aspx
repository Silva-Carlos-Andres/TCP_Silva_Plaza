<%@ Page Title="Categorias"  ValidateRequest="false" EnableEventValidation="false" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="TPC___Silva___Plaza.Categorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <script> 
        function clearOnConfirm() {
            if (confirm("Esta seguro que desea eliminar el registro?")) {
                document.getElementById("<%=txtInput.ClientID %>").value = '';
                return true;
            } else {
                return false;
            }
        }
    </script>
    <h4>AMB Categoria</h4>
    <form id="Categorias" runat="server">
        <asp:ScriptManager ID="ScripManager2" runat="server"></asp:ScriptManager>
        <asp:TextBox Visible="false" ID="txtInput" runat="server" />


        <asp:UpdatePanel runat="server">
            <ContentTemplate>

                <asp:Label Text="Nombre : " runat="server" />
                <asp:TextBox ID="txtnombre" runat="server" />

                <%--<asp:ImageButton ID="btn_agregar" OnClick="btn_agregar_Click" ImageUrl="../Resources/add_person1.png" runat="server" />--%>
                <asp:Button Text="Agregar" CommandArgument='<%#Eval("id") %>' ID="btnagregar" OnClick="btnagregar_Click" runat="server" />
                <table class="table table-striped table-hover">
                    <thead>
                        <tr>
                            <th scope="col">ID</th>
                            <th scope="col">Nombre</th>
                            <th scope="col"></th>
                            <th scope="col"></th>
                        </tr>
                    </thead>
                    <tbody>

                        <asp:Repeater runat="server" ID="ListCategoria">
                            <ItemTemplate>
                                <tbody>
                                    <tr>
                                        <td><%#Eval("id") %></td>
                                        <td><%#Eval("Nombre") %></td>
                                        <%--<td><asp:ImageButton ImageUrl="../Resources/edit_person.png" runat="server" /></td>--%>
                                        <td>
                                            <asp:Button Text="Editar" CommandArgument='<%#Eval("id") %>' ID="btneditar" CommandName="IDCategoria" OnClick="btneditar_Click" AutoPostBack="true" runat="server" />
                                        </td>
                                        <%--<td><asp:ImageButton ImageUrl="../Resources/delete_person.png" CommandArgument='<%#Eval("id") %>' ID="btnBorrar" CommandName="IDClient" OnClick="btnBorrar_Click" runat="server" /></td>--%>
                                        <%-- <td> <asp:Button  Style="background-image:url('Resources/delete_person.png');" ID="btnBorrar" CommandArgument=<%#Eval("id") %> CommandName="IDClient" runat="server" OnClick="btnBorrar_Click" /></td>--%>
                                        <td>
                                            <asp:Button Text="Borrar" CommandArgument='<%#Eval("id") %>' ID="btnBorrar" OnClientClick="return clearOnConfirm();" CommandName="IDCategoria" OnClick="btnBorrar_Click" runat="server" />
                                           
                                        </td>


                                   </tr>
                                </tbody> 
                            </ItemTemplate>
                        </asp:Repeater>
                        </tbody>
                    </table>
                       </ContentTemplate>
                       </asp:UpdatePanel>
        </form>
      
    
        
   
</asp:Content>
