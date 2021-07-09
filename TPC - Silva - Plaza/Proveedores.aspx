<%@ Page Title="Proveedores" ValidateRequest="false" EnableEventValidation="false" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Proveedores.aspx.cs" Inherits="TPC___Silva___Plaza.Proveedores" %>
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
    <h4>AMB Proveedores</h4>


    



    <form id="Form1" runat="server">


        <%--NO BORRAR -SE CONFIRMA LA PREGUNTA AL USUARIO--%>
        <asp:textbox Visible="false" id="txtInput" runat="server" />



    <asp:Label Text="Nombre : " runat="server" />
    <asp:TextBox ID="txtnombre" runat="server" />

         <asp:Label Text="Email : " runat="server" />
        <input id="txtemail" size="30" type="email" name="email" value="" runat="server" />

         <asp:Label Text="Cuit : " runat="server" />
        <input id="txtcuit" type="number" name="numero" value="" runat="server" />

         <asp:Label Text="Dirreccion : " runat="server" />
    <asp:TextBox ID="txtDir" Width="255" runat="server"/>

        <asp:ImageButton ID="btn_agregar" OnClick="btn_agregar_Click" ImageUrl="../Resources/add_person1.png" runat="server" />


        

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
        <%-- <% foreach (Dominio.Proveedor item in Proveedors)
            {%>
            <tr>
                <th scope="row"><% = item.Id %></th>
                <td><% = item.Nombre %></td>
                <td><% = item.Email %></td>
                <td><% = item.CUIT %></td>
                <td><asp:ImageButton ImageUrl="../Resources/edit_person.png" runat="server" /></td>
               <td><asp:ImageButton ImageUrl="../Resources/delete_person.png" CommandArgument="'<% = item.Id %>'" runat="server" /></td>
               <td> <asp:Button Style="background-image:url('../Resources/delete_person.png');" ID="btnBorrar" CommandArgument="<%#Eval("id") %>" CommandName="IDClient" runat="server" OnClick="btnBorrar_Click" /></td>
            </tr>
        <%} %>--%>






            <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate> 
                    <tbody>
                        <tr>
                            <td><%#Eval("id") %></td>
                            <td><%#Eval("Nombre") %></td>
                            <td><%#Eval("Email") %></td>
                            <td><%#Eval("CUIT") %></td>
                            <td><asp:ImageButton ImageUrl="../Resources/edit_person.png" runat="server" /></td>
                            <%--<td><asp:ImageButton ImageUrl="../Resources/delete_person.png" CommandArgument='<%#Eval("id") %>' ID="btnBorrar" CommandName="IDClient" OnClick="btnBorrar_Click" runat="server" /></td>--%>
                            <%-- <td> <asp:Button  Style="background-image:url('Resources/delete_person.png');" ID="btnBorrar" CommandArgument=<%#Eval("id") %> CommandName="IDClient" runat="server" OnClick="btnBorrar_Click" /></td>--%>
                            <td><asp:Button Text="Borrar" CommandArgument='<%#Eval("id") %>' ID="btnBorrar" OnClientClick="return clearOnConfirm();" CommandName="IDClient" OnClick="btnBorrar_Click" runat="server" /> </td>
                            
                                
                        </tr>
                    </tbody> 
            </ItemTemplate>
        </asp:Repeater>
        </tbody>
    </table>
        </form>
</asp:Content>
