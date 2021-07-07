<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="TPC___Silva___Plaza.Articulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Maestro de Articulos</h4>

        <table class="table table-striped table-hover">
        <thead>
            <tr>
                <th scope="col">Codigo</th>
                <th scope="col">Nombre</th>
                <th scope="col">Marca</th>
                <th scope="col">Categoria</th>
                <th scope="col">Cantidad</th>
                <th scope="col">Precio</th>
            </tr>
        </thead>
        <tbody>
         <% foreach (Dominio.Articulo item in articulos)
            {%>
            <tr>
                <th scope="row"><% = item.Codigo %></th>
                <th scope="row"><% = item.Nombre %></th>
                <th scope="row"><% = item.Marca %></th>
                <th scope="row"><% = item.Categoria %></th>
                <th scope="row"><% = item.Cantidad %></th>
                <td scope="row">$<% = item.Precio %></td>
                   <%-- { CurrencyFormatted(<% = item.Precio %>)}</td>--%>

            </tr>
        <%} %>
        </tbody>
    </table>
</asp:Content>
