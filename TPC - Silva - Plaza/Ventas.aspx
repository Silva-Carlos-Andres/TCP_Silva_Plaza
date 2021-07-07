<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="TPC___Silva___Plaza.Ventas" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

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
                <td><% = item.Precio %></td>
                <td><% = item.Fecha %></td>
            </tr>
        <%} %>
        </tbody>
    </table>

</asp:Content>
