<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ONEmovie.aspx.cs" Inherits="WebApplication1.ONEmovie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div >
    <div class="row">
        <div class="col-md-4">
    <asp:Image ID="Image1" runat="server" Height="300px" Width="300px"  />
            
        </div>
        <div class="col-md-8 words" style="font-size:25px;">
        <div class="row">    
    <asp:Label ID="plot" runat="server"></asp:Label></div>
            <div class ="row">

                <div class="col-md-4"><asp:Label ID="rate" runat="server"></asp:Label> </div>
           <div class="col-md-4"> <asp:Button ID="urate" runat="server" Text="submit your rate" BackColor="#333333" ForeColor="#FFFFCC" OnClick="urate_Click" /> </div>
           <div class="col-md-4"><h3>Rate</h3> <asp:TextBox ID="userrate" runat="server" BackColor="#333333" ForeColor="#FFFFCC"></asp:TextBox> </div>
            </div>
        </div>
        </div>
    <div class="row words" style="font-size:25px;"">
        <div class="col-md-4"><asp:Label ID="moviename" runat="server"></asp:Label></div>
        <div class="col-md-4"><H3>directed by: </H3><asp:Label ID="dir" runat="server"></asp:Label></div>
        <div class="col-md-4"><H3>writer :</H3><asp:Label ID="auth" runat="server"></asp:Label></div>
        </div>
    <div class="row words" style="font-size:25px; padding-left :15px;"><asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound">
            </asp:GridView></div></div>
</asp:Content>
