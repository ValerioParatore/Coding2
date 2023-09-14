<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="utenteSelezionato.aspx.cs" Inherits="EsercizioRubrica.utenteSelezionato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:TextBox ID="TextNome" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextCognome" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextIndirizzo" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextTelefono" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
        <img runat="server" id="Foto" src="" style="width: 60px"/>

    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click"/>
    </div>
</asp:Content>
