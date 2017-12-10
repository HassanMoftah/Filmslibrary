<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Directors.aspx.cs" Inherits="WebApplication1.Directors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="words" style="font-size:35px;">
    <asp:GridView ID="GridView1" runat="server" Height="166px" Width="858px" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Redirect" Text="GO">
            <ItemStyle ForeColor="#336699" />
            </asp:ButtonField>
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>
