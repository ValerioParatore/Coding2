<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EsercizioPizze.pizzeria.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Hai gia' effettuato il login?</h3>
            <a href="pizze.aspx">Clicca qui per ordinare le tue pizze</a>
        </div>
        <div>
            <h3>Effettua il login</h3>
            <span>Inserisci il tuo nome</span>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                    runat="server" ErrorMessage="Campo obbligatorio " ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </div>
            <span>Inserisci la tua password</span>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox2"
                    runat="server" ErrorMessage="Campo obbligatorio"></asp:RequiredFieldValidator>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Accedi" OnClick="Button1_Click"/>
        </div>
        <div id="alert" runat="server">
            <h3>I dati inseriti non sono validi! Riprova</h3>
        </div>
    </form>
</body>
</html>
