<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProgettoSettimanale.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Repeater ID="Repeater1" runat="server" ItemType="ProgettoSettimanale.Prodotto">
                <itemtemplate>
                    <div class="col-md-4 m-4 bg-transparent border border-3 border-dark d-flex flex-column justify-content-around align-content-center">
                        <div class="m-2">
                            <img src="<%#Item.ImgItem %>" class="imgItem"/>
                        </div>
                        <hr />
                        <div class="m-2">
                            <h1 class="text-light"><%#Item.NameItem %></h1>
                            <span class="text-light bg-warning p-2"><%#Item.PrezzoItem %> Rune</span>
                            <a class="text-decoration-none btn btn-primary" href="Dettagli.aspx?IDitem=<%#Item.IDitem %>">Dettagli Prodotto</a>
                        </div>
                    </div>
                </itemtemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
