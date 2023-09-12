<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="asp.Net.Stato.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3>Effettua il login per prenotare i posti in sala</h3>
        <span>Inserisci il tuo nome</span>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" Font-Bold="true" ForeColor="Red" 
                runat="server" ErrorMessage="Nome non valido"></asp:RequiredFieldValidator>

        </div>
        <span>Inserisci il tuo cognome</span>
        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
        <div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox2" Font-Bold="true" ForeColor="Red"
                runat="server" ErrorMessage="Cognome non valido"></asp:RequiredFieldValidator>
        </div>
        <span>Inserisci password</span>
        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
        <div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TextBox3" Font-Bold="true" ForeColor="Red"
                runat="server" ErrorMessage="Password non valida"></asp:RequiredFieldValidator>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Login"  OnClick="Button1_Click" CssClass="btn btn-info"/>

    </div>
</asp:Content>
