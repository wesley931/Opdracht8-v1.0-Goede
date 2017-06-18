<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="Oefening_10.Gebruikers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Gebruikers</h2>
    <h2>
        <asp:ListBox ID="lbUsers" runat="server" OnSelectedIndexChanged="lbUsers_SelectedIndexChanged" Height="171px" Width="192px" AutoPostBack="True">
            <asp:ListItem Value="Wesley931">testval</asp:ListItem>
        </asp:ListBox>
    </h2>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblVoornaam" runat="server" Text="Voornaam: " Visible="false"></asp:Label>
        <asp:TextBox ID="txbNaam" runat="server" Visible="false"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblTussenvoegsel" runat="server" Text="Tussenvoegsel: " Visible="false"></asp:Label>
        <asp:TextBox ID="txbTussenvoegsel" runat="server" Visible="false"></asp:TextBox >
    </p>
    <p>
        <asp:Label ID="lblAchternaam" runat="server" Text="Achternaam: " Visible="false"></asp:Label>
        <asp:TextBox ID="txbAchternaam" runat="server" Visible="false"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblUsername" runat="server" Text="Username: " Visible="false"></asp:Label>
        <asp:TextBox ID="txbUsername" runat="server" Visible="false"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblPassword" runat="server" Text="Password: " Visible="false"></asp:Label>
        <asp:TextBox ID="txbPassword" runat="server" Visible="false"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAdd" runat="server" Text="Toevoegen" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Aanpassen" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDel" runat="server" Text="Verwijderen" OnClick="btnDel_Click" />
    </p>
</asp:Content>
