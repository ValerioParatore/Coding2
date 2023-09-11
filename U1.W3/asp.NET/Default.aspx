<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="asp.NET.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet"/>
</head>
<body class="d-flex justify-content-center">
    <form id="form1" runat="server">
        <div class="m-3 border-1">
            <h3>Scegli un'auto di cui vuoi avere il preventivo.</h3>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem Value="peugeot-308.png" Text="Puegeto 308"></asp:ListItem>
                <asp:ListItem Value="merced-benz-amg-gt.png" Text="Audi A3"></asp:ListItem>
                <asp:ListItem Value="audi'-A3.png" Text="Mercedes benz AMG"></asp:ListItem>
            </asp:DropDownList>
            <div class="d-flex flex-column justify-content-around">
                <asp:Image ID="Image1" runat="server" Width="240px" ImageUrl=""/>
                <asp:Label ID="Label1" runat="server" Text="" CssClass="fw-bolder m-2"></asp:Label>
            </div>
        </div>
        <div class="m-3 border-1">
            <h3>Scegli uno o piu optional per il tuo preventivo.</h3>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Value="330" Text="Vernice metallizzata (costo euro 330,00)"></asp:ListItem>
                <asp:ListItem Value="180" Text="Fari Xeno (costo euro 180,00)"></asp:ListItem>
                <asp:ListItem Value="1800" Text="Sistema navigazione satellitare (costo euro 1.800,00)"></asp:ListItem>
                <asp:ListItem Value="2000" Text="Line Assistant (costo euro 2.000,00)"></asp:ListItem>
                <asp:ListItem Value="155" Text="Ruota di scorta (costo euro 155,00)"></asp:ListItem>
                <asp:ListItem Value="700" Text="Sedili/volante in pelle (costo euro 700,00)"></asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div class="m-3 border-1">
            <h3>Scegli gli anni di garanzia.(120 euro per anno)</h3>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem Value="1" Text="1 anno di garanzia"></asp:ListItem>
                <asp:ListItem Value="2" Text="2 anni di garanzia"></asp:ListItem>
                <asp:ListItem Value="3" Text="3 anni di garanzia"></asp:ListItem>
                <asp:ListItem Value="4" Text="4 anni di garanzia"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="m-3 d-flex justify-content-between">
            <asp:Button ID="Button1" CssClass="btn btn-primary m-3" runat="server" Text="Stampa il preventivo" OnClick="Button1_Click"/>

            <div class="d-flex flex-column bg-info p-3 rounded">
                <asp:Label ID="Label2" runat="server" Text="Costo auto di partenza" CssClass="fw-medium fs-5 text-secondary"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="Costo optional" CssClass="fw-medium fs-5 text-secondary"></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="Costo garanzia" CssClass="fw-medium fs-5 text-secondary"></asp:Label>
                <asp:Label ID="Label5" runat="server" Text="Prezzo totale" CssClass="fw-medium fs-5 text-secondary"></asp:Label>
            </div>

        </div>
    </form>
</body>

</html>
