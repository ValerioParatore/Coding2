<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EsercizioRubrica.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <asp:Repeater ID="Repeater1" runat="server" ItemType="EsercizioRubrica.Utente">
                <ItemTemplate>
                    <div>
                        <div>
                            <img style="width: 60px" src="Content/imgs/<%#Item.foto%>"/>
                        </div>
                        <div>
                            <p><strong><%#Item.nome %></strong> <strong><%#Item.cognome %></strong></p>
                            <p><%#Item.telefono %></p>
                            <a href="utenteSelezionato.aspx?IDutente=<%#Item.IDutente %>">Vedi dettagli utente</a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
