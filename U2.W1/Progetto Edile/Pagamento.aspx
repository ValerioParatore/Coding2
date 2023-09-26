<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pagamento.aspx.cs" Inherits="Progetto_Edile.Pagamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="div-pagamento">
        <div>
            <span>Inserisci ID dipendente</span>
            <asp:TextBox ID="TextIDdipendente" runat="server" CssClass="input-group-text"></asp:TextBox>
        </div>
        <div>
            <span>Inserisci l'ammontare del pagamento</span>
            <asp:TextBox ID="TextAmmontare" runat="server" CssClass="input-group-text"></asp:TextBox>
        </div>
        <div>
            <span>Scegli il tipo</span>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem Text="Acconto" Value="Acconto"></asp:ListItem>
                <asp:ListItem Text="Pagamento" Value="Pagamento"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button ID="Button1" CssClass="button" runat="server" Text="EFFETTUA PAGAMENTO" OnClick="Button1_Click" />
    </div>
</asp:Content>
