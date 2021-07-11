<%@ Page Title="Vendedor" ValidateRequest="false" EnableEventValidation="false" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Vendedor.aspx.cs" Inherits="TPC___Silva___Plaza.Vendedor" %>
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
    <h4>AMB Vendedor</h4>
    <form id="Form3" runat="server">

              <%--NO BORRAR -SE CONFIRMA LA PREGUNTA AL USUARIO--%>
        <asp:textbox Visible="false" id="txtInput" runat="server" />



    <asp:Label Text="Nombre : " runat="server" />
    <asp:TextBox ID="txtnombre" runat="server" />

            <asp:Label Text="Apellido : " runat="server" />
    <asp:TextBox ID="txtapellido" runat="server" />

         <asp:Label Text="Email : " runat="server" />
        <input id="txtemail" size="30" type="email" name="email" value="" runat="server" />

         <asp:Label Text="DNI : " runat="server" />
        <input id="txtdni" maxlength="10" type="number" name="numero" value="" runat="server" />
        

         <asp:Label Text="Dirreccion : " runat="server" />
    <asp:TextBox ID="txtDir" Width="255" runat="server"/>

                 <asp:Label Text="Fecha Nacimiento : " runat="server" />
    <asp:TextBox ID="txtFN" Width="80" runat="server"/>

     <asp:Label Text="Sueldo: " runat="server" />
    <asp:TextBox ID="txtsueldo" Width="60" runat="server"/>

<%--        <asp:ImageButton ID="btn_agregar" OnClick="btn_agregar_Click" ImageUrl="../Resources/add_person1.png" runat="server" />--%>
        <asp:Button Text="Agregar" CommandArgument='<%#Eval("id") %>' ID="btnagregar" OnClick="btnagregar_Click" runat="server" />

        <table class="table table-striped table-hover">
        <thead>
            <tr>
                <th scope="col">ID</th>
                <th scope="col">Nombre</th>
                <th scope="col">Apellido</th>
                <th scope="col">Email</th>
                <th scope="col">DNI</th>
                <th scope="col">Fecha Nac</th>
                <th scope="col">Sueldo</th>
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
                            <td><%#Eval("Apellido") %></td>
                            <td><%#Eval("Email") %></td>
                            <td><%#Eval("DNI") %></td>
                            <td><%#Eval("FNacimiento") %></td>
                            <td><%#Eval("Sueldo") %></td>
                            <%--<td><asp:ImageButton ImageUrl="../Resources/edit_person.png" runat="server" /></td>--%>
                            <td><asp:Button Text="Editar" CommandArgument='<%#Eval("id") %>' ID="btneditar" CommandName="IDClient" OnClick="btneditar_Click" runat="server" /> </td>
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
