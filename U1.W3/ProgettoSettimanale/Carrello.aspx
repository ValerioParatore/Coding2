<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="ProgettoSettimanale.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex flex-column">
        <div>
            <asp:GridView CssClass="table table-bordered"  ID="GridView1" runat="server" ItemType="ProgettoSettimanale.ItemsCarrello">
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate><strong class="text-light">Nome Prodotto</strong></HeaderTemplate>
                        <ItemTemplate>
                            <p class="text-light">
                                <%#Item.NameItem %>
                            </p>

                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <strong class="text-light">Prezzo</strong>
                        </HeaderTemplate>
                        <ItemTemplate>
                           <p class="text-light">
                                <%#Item.PrezzoItem %>
                           </p>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <strong class="text-light">Elimina dal carrello</strong>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Button CssClass="btn btn-danger" ID="Button1" ClientIDMode="AutoID" runat="server" Text="Elimina dal carrello" OnClick="Button1_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
        <div>
            <asp:Button CssClass="btn btn-danger" ID="Button1" runat="server" Text="Elimina tutti i prodotti dal carrello" OnClick="Button1_Click2" />
        </div>
    </div>
</asp:Content>
