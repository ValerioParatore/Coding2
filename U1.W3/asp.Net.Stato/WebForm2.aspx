<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="asp.Net.Stato.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
       <h2>Scegli una sala e seleziona se il biglietto e' ridotto.</h2>
       <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
          <asp:ListItem></asp:ListItem>
          <asp:ListItem Value="1" Text="SALA NORD"></asp:ListItem>
          <asp:ListItem Value="2" Text="SALA EST"></asp:ListItem>
          <asp:ListItem Value="3" Text="SALA SUD"></asp:ListItem>
       </asp:DropDownList>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Biglietto ridotto"/>
        <asp:Button ID="Button1" runat="server" Text="Acquista biglietto" OnClick="Button1_Click"/>
    </div>
    <div class="border-2 border-dark bg-opacity-25">
        <span>SALA NORD POSTI DISPONIBILI:</span><span runat="server" id="prn">120</span>
        <span>BIGLIETTI ACQUISTATI :</span> <span runat="server" id="pan">0</span>
        <span>BIGLIETTI RIDOTTI :</span><span runat="server" id="panr">0</span>
    </div>
        <div>
        <span>SALA EST POSTI DISPONIBILI:</span><span runat="server" id="pre">120</span>
        <span>BIGLIETTI ACQUISTATI :</span> <span runat="server" id="pae">0</span>
        <span>BIGLIETTI RIDOTTI :</span><span runat="server" id="paer">0</span>
    </div>
        <div>
        <span>SALA SUD POSTI DISPONIBILI:</span><span runat="server" id="prs">120</span>
        <span>BIGLIETTI ACQUISTATI :</span> <span runat="server" id="pas">0</span>
        <span>BIGLIETTI RIDOTTI :</span><span runat="server" id="pasr">0</span>
    </div>

</asp:Content>
