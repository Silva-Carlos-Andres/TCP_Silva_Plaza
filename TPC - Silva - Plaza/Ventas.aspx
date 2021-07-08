<%@ Page Title="Ventas" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="TPC___Silva___Plaza.Ventas" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <%--<form action="/" method="post" runat="server">
        <div class="row"> 
            <div class="col">
                <h4>ID</h4>
                <asp:TextBox ID="FiltroId" runat="server" AutoCompleteType="Enabled" TextMode="Search" ViewStateMode="Inherit"></asp:TextBox>
            </div>
            <div class="col">
                <h4>Cliente</h4>
                <asp:TextBox ID="FiltroCliente" runat="server" AutoCompleteType="Enabled" TextMode="Search" ViewStateMode="Inherit"></asp:TextBox>
            </div>
            <div class="col">
                <h4>Vendedor</h4>
                <asp:TextBox ID="FiltroVendedor" runat="server" AutoCompleteType="Enabled" TextMode="Search" ViewStateMode="Inherit"></asp:TextBox>
            </div>
        </div>
    </form>--%>

    <a href="/NuevaVenta"><i class="fi fi-plus"></i>Nueva Venta</a>

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
         <% foreach (Dominio.Venta item in ventas)
            {%>
            <tr>
                <th scope="row"><% = item.Id %></th>
                <td>Falta</td>
                <td><% = item.Monto %></td>
                <td><% = item.Fecha %></td>
            </tr>
        <%} %>
        </tbody>
    </table>

</asp:Content>
