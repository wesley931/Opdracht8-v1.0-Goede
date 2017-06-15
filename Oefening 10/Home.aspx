<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Oefening_10.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welkom</h1>
    Welkom bij mijn website over films.<br />
    Op deze site staat informatie over&nbsp;
    <asp:Literal ID="litAantal" runat="server" />
    &nbsp;films.
</asp:Content>
