<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Archiviazione.aspx.cs" Inherits="Progetto_Edile.Archiviazione" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="div-archiviazione">
        <div>
            <span>Inserisci nome dipendente</span>
            <asp:TextBox ID="TextNome" runat="server" CssClass="input-group-text"></asp:TextBox>
        </div>
        <div>
            <span>Inserisci cognome dipendente</span>
            <asp:TextBox ID="TextCognome" runat="server" CssClass="input-group-text"></asp:TextBox>
        </div>

        <div>
            <span>Inserisci indirizzo dipendente</span>
            <asp:TextBox ID="TextIndirizzo" runat="server" CssClass="input-group-text"></asp:TextBox>
        </div>
        <div>
            <span>Inserisci codice fiscale dipendente</span>
            <asp:TextBox ID="TextCD" runat="server" CssClass="input-group-text"></asp:TextBox>
        </div>

        <div>
            <span>Mansione del dipendente</span>
            <asp:DropDownList ID="MansioneList" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem Text="Ingeniere" Value="Ingeniere"></asp:ListItem>
                <asp:ListItem Text="Architetto" Value="Architetto"></asp:ListItem>
                <asp:ListItem Text="Elettricista" Value="Elettricista"></asp:ListItem>
                <asp:ListItem Text="Capo Cantiere" Value="Capo Cantiere"></asp:ListItem>
                <asp:ListItem Text="Manovale" Value="Manovale"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <span>Sposato</span>
            <asp:CheckBox ID="CheckBoxFigli" runat="server" CssClass="input-group-check"/>
            
        </div>
        <div>
            <span>Numero di figli a carico</span>
            <asp:TextBox ID="TextNfigli" runat="server" CssClass="input-group"></asp:TextBox>

        </div>
         <asp:Button ID="Button2" CssClass="button" runat="server" Text="AGGIUNGI DIPENDENTE" OnClick="Button1_Click" />
    </div>
</asp:Content>
