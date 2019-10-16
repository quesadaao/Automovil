<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfIndex.aspx.cs" Inherits="Fidelitas.UI.wfIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td >
                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
            <td >
                <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label2" runat="server" Text="Estilo"></asp:Label></td>
            <td ><asp:DropDownList ID="ddlEstilo" runat="server">
                <asp:ListItem Value="0">Suv</asp:ListItem>
                <asp:ListItem Value="1">Sedan</asp:ListItem>
                <asp:ListItem Value="2">Hatschbacks</asp:ListItem>
                <asp:ListItem Value="3">Minivans</asp:ListItem>
                </asp:DropDownList></td>
            <td >
                <asp:Label ID="Label4" runat="server" Text="Cilindraje"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtCilindraje" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label5" runat="server" Text="Costo"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox></td>
            <td >
                <asp:Label ID="Label6" runat="server" Text="Transmision"></asp:Label></td>
            <td >
                <asp:DropDownList ID="ddlTransmision" runat="server">
                    <asp:ListItem>Automatico</asp:ListItem>
                    <asp:ListItem>CVT</asp:ListItem>
                    <asp:ListItem>Manual</asp:ListItem>
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label7" runat="server" Text="# Puertas"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtPuertas" runat="server"></asp:TextBox></td>
            <td >
                <asp:Label ID="Label8" runat="server" Text="Ano"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtAno" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label9" runat="server" Text="Marca"></asp:Label></td>
            <td >
                <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox></td>
            <td colspan ="2"></td>
        </tr>
        <tr>
            <td style="text-align:right">
                <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" /></td>
            <td style="text-align:right">
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" /></td>
            <td style="text-align:right">
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" /></td>
            <td style="text-align:right">
                <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" /></td>
        </tr>
        <tr>
            <td colspan="5" >
                <asp:GridView ID="gridview" runat="server" Width="100%" Height="100%"></asp:GridView>

            </td>
        </tr>
    </table>
</asp:Content>
