<%@ Page Title="Clientes" ValidateRequest="false" EnableEventValidation="false" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="TPC___Silva___Plaza.Clientes" %>
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
    <h4>AMB Clientes</h4>
    <form id="Clientes" runat="server">


        <%--NO BORRAR -SE CONFIRMA LA PREGUNTA AL USUARIO--%>
        <asp:textbox Visible="false" id="txtInput" runat="server" />
        <asp:ScriptManager ID="ScripManager2" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>

    <asp:Label Text="Nombre : " runat="server" />
    <asp:TextBox ID="txtnombre" runat="server" />

         <asp:Label Text="Email : " runat="server" />
        <input id="txtemail" size="30" type="email" name="email" value="" runat="server" />

         <asp:Label Text="Cuit : " runat="server" />
        <%--<input id="txtcuit" type="number" name="numero" value="" runat="server" />--%>
        <asp:TextBox ID="txtcuit1" runat="server" />

         <asp:Label Text="Dirreccion : " runat="server" />
    <asp:TextBox ID="txtDir" Width="255" runat="server"/>

        <%--<asp:ImageButton ID="btn_agregar" OnClick="btn_agregar_Click" ImageUrl="../Resources/add_person1.png" runat="server" />--%>
        <asp:Button Text="Agregar" CommandArgument='<%#Eval("id") %>' ID="btnagregar" OnClick="btnagregar_Click1" runat="server" />


        

        <table class="table table-striped table-hover">
        <thead>
            <tr>
                <th scope="col">ID</th>
                <th scope="col">Nombre</th>
                <th scope="col">Email</th>
                <th scope="col">Cuit</th>
                <th scope="col"></th>
                <th scope="col"></th>
            </tr>
        </thead>
        <tbody>

            <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate> 
                    <tbody>
                        <tr>
                            <td><%#Eval("id") %></td>
                            <td><%#Eval("Nombre") %></td>
                            <td><%#Eval("Email") %></td>
                            <td><%#Eval("CUIT") %></td>
                            <td>
                                 <asp:Button Text="Editar" CommandArgument='<%#Eval("id") %>' ID="btneditar" CommandName="IDCliente" OnClick="btneditar_Click" AutoPostBack="true" runat="server" />
                            </td>
                            <%--<td><asp:ImageButton ImageUrl="../Resources/delete_person.png" CommandArgument='<%#Eval("id") %>' ID="btnBorrar" CommandName="IDClient" OnClick="btnBorrar_Click" runat="server" /></td>--%>
                            <%-- <td> <asp:Button  Style="background-image:url('Resources/delete_person.png');" ID="btnBorrar" CommandArgument=<%#Eval("id") %> CommandName="IDClient" runat="server" OnClick="btnBorrar_Click" /></td>--%>
                            <td><asp:Button Text="Borrar" CommandArgument='<%#Eval("id") %>' ID="btnBorrar" OnClientClick="return clearOnConfirm();" CommandName="IDClient" OnClick="btnBorrar_Click" runat="server" /> </td>
                            
                                
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
