<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPC___Silva___Plaza.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Maestro de Articulos</h4>

        <table class="table table-striped table-hover">
        <thead>
            <tr>
                <th scope="col">Codigo</th>
                <th scope="col">Nombre</th>
                <th scope="col">Modelo</th>
                <th scope="col">Descripcion</th>
                <th scope="col">Proveedor</th>
                <th scope="col">Precio</th>
                <th scope="col">Ganancia(%)</th>
                <th scope="col">Marca</th>
                <th scope="col">Tipo</th>
                <th scope="col">Categoria</th>
                <th scope="col">StockActual</th>
                <th scope="col">StockMinimo</th>
                <th scope="col">Estado</th>
            </tr>
        </thead>
        <tbody>
         <% foreach (Dominio.Articulo item in articulos)
            {%>
            <tr onclick="alert('Has pinchado con el ratón');" >
                <th scope="row" ><% = item.Codigo %></th>
                <th scope="row"><% = item.Nombre %></th>
                <th scope="row"><% = item.Modelo %></th>
                <th scope="row"><% = item.Descripcion %></th>
                <th scope="row"><% = item.Proveedor %></th>
                <td scope="row">$<% = item.Precio %></td>
                <th scope="row"><% = item.GananciaPorcentual %></th>
                <th scope="row"><% = item.Marca %></th>
                <th scope="row"><% = item.Tipo %></th>
                <th scope="row"><% = item.Categoria %></th>
                <th scope="row"><% = item.StockActual %></th>
                <th scope="row"><% = item.StockMinimo %></th>
                <th scope="row"><% = item.Estado%></th>
                <%--{ CurrencyFormatted(<% = item.Precio %>)}</td>--%>

            </tr>
        <%} %>
        </tbody>
    </table>
</asp:Content>
