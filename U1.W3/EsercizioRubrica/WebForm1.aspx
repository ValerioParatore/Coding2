<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EsercizioRubrica.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <span>Inserisci Nome</span>
        <asp:TextBox ID="TextNome" runat="server"></asp:TextBox>
        <span>Inserisci Cognome</span>
        <asp:TextBox ID="TextCognome" runat="server"></asp:TextBox>
        <span>Inserisci Indirizzo</span>
        <asp:TextBox ID="TextIndirizzo" runat="server"></asp:TextBox>
        <span>Inserisci Numero di Telefono</span>
        <asp:TextBox ID="TextTelefono" runat="server"></asp:TextBox>
        <span>Inserisci email</span>
        <asp:TextBox ID="Textemail" runat="server"></asp:TextBox>
        <span>Inserisci Immagine</span>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button CssClass="btn btn-success" ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
    </div>
</asp:Content>
