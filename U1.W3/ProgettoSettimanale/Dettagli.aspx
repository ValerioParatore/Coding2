<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="ProgettoSettimanale.Dettagli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <img runat="server" id="itemImg" />
        </div>
        <div>
            <h1 runat="server" id="itemName"></h1>
            <p runat="server" id="itemDes"></p>
            <span runat="server" id="itemPrezzo"></span>
        </div>
        <asp:Button CssClass="btn btn-success" ID="Button1" runat="server" Text="Aggiungi al carrello" OnClick="Button1_Click"/>
    </div>
</asp:Content>
