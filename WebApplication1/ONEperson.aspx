﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ONEperson.aspx.cs" Inherits="WebApplication1.ONEperson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row words" >
        <div class="col-md-4">
            <asp:ImageMap ID="ImageMap1" runat="server" Height="300px" Width="300px"></asp:ImageMap>
    </div>
        <div class="col-md-8">
            <div class="row">
    <h3>Name: </h3><asp:Label ID="name" runat="server"></asp:Label></div>
            <div class="row">
    <h3>Birth: </h3> <asp:Label ID="birth" runat="server"></asp:Label></div>
            <div class="row">
    <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound">
    </asp:GridView></div>
            </div>
        
            <div class ="row">

            <div class="col-md-4"><asp:Label ID="rate" runat="server"></asp:Label> </div>
           <div class="col-md-4"> <asp:Button ID="urate" runat="server" Text="submit your rate" BackColor="#333333" ForeColor="#FFFFCC" OnClick="urate_Click" Height="40px" Width="168px" /> 
                </div>
           <div class="col-md-4"><h3>Rate</h3> <asp:TextBox ID="userrate" runat="server" BackColor="#333333" ForeColor="#FFFFCC" Height="46px" Width="162px"></asp:TextBox>  
               <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="userrate" ErrorMessage="must be number" Type="Double"></asp:CompareValidator>
                </div>
            
            </div>
        </div>
</asp:Content>
