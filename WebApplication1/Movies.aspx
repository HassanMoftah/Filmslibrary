<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Movies.aspx.cs" Inherits="WebApplication1.Movies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="words grids" style="font-size:35px; width:100%;">
    <asp:GridView ID="GridView1" runat="server" Height="217px" Width="918px" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:ButtonField ButtonType="Button" Text="GO" CommandName="Redirect" >
            <ItemStyle ForeColor="#333399" />
            </asp:ButtonField>
        </Columns>
    </asp:GridView>
    </div>
        
    </asp:Content>
