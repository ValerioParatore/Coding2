<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pizze.aspx.cs" Inherits="EsercizioPizze.pizzeria.pizze" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 runat="server" id="welcome"></h2>
            <div>
                            <h1>Scegli che pizze vuoi ordinare</h1>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem Value="1" Text="Margherita"></asp:ListItem>
                <asp:ListItem Value="2" Text="Capricciosa"></asp:ListItem>
                <asp:ListItem Value="3" Text="4 formaggi"></asp:ListItem>
                <asp:ListItem Value="4" Text="Diavola"></asp:ListItem>
                <asp:ListItem Value="5" Text="Norma"></asp:ListItem>
            </asp:DropDownList>
            </div>
            <div>
                            <h3>Scegli gli ingredienti extra che vuoi aggiungere</h3>
            <asp:CheckBoxList ID="ingredienti" runat="server">
                <asp:ListItem Value="1" Text="Olive(0,50)"></asp:ListItem>
                <asp:ListItem Value="2" Text="Spack(2,50)" ></asp:ListItem>
                <asp:ListItem Value="3" Text="Spinaci(1,00)"></asp:ListItem>
                <asp:ListItem Value="4" Text="Rucola(0,50)"></asp:ListItem>
                <asp:ListItem Value="5" Text="Extra formaggio(1,00)"></asp:ListItem>
                <asp:ListItem Value="6" Text="Patatine(1,50)"></asp:ListItem>
            </asp:CheckBoxList>

            </div>
            <asp:Button ID="Button1" runat="server" Text="Aggiungi pizza all'ordine" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="Completa ordine" OnClick="Button2_Click"/>
            <div runat="server" id="stampa">
            </div>
        </div>
    </form>
</body>
</html>
