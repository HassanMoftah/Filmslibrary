<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Actors.aspx.cs" Inherits="WebApplication1.Actors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="words" style="font-size:35px;">
        <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" Width="812px">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Redirect" Text="GO">
                <ItemStyle ForeColor="#006699" />
                </asp:ButtonField>
            </Columns>
        </asp:GridView>
        </div>
</asp:Content>
