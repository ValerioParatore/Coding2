<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Progetto_Edile.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="div-home">
        <h1>Lista dei dipendenti</h1>
        <asp:GridView ID="GridView1" runat="server" ItemType="Progetto_Edile.Dipendente" AutoGenerateColumns="false"
                AlternatingRowStyle-CssClass="righe-alterne" RowStyle-CssClass="righe" HeaderStyle-CssClass="header">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Nome
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%#Item.nome %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Cognome
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%#Item.cognome %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Mansione
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%#Item.mansione %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Indirizzo
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%#Item.indirizzo %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Codice Fiscale
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%#Item.cd %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Sposato
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%#Progetto_Edile.Dipendente.sposato %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Figli a carico
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%#Item.nFigli %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
