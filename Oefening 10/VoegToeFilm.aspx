<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VoegToeFilm.aspx.cs" Inherits="Oefening_10.VoegToeFilm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>VoegTieFilm</h1>
    Vul de onderstaande velden in en druk op de knop
    om de film toe te voegen. <br /><br />
    Titel <asp:TextBox ID="txtTitel" runat="server" />
    <br />
    Datum uitgifte <asp:Textbox ID="txtDatum" runat="server" />
    (jjjj-mm-dd)
    <br /><br />
       <asp:Button ID="btnVoegToe" runat="server" Text="Toevoegen" OnClick="btnVoegToe_Click" />
</asp:Content>
