<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="submit.aspx.cs" Inherits="WebApplication1.submit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 100%;
            border-color: #CCCCCC;
            background-color: #333333;
            background-image: url('1.jpg');
        }
        .auto-style4 {
            width: 133px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table class="auto-style3">
                <tr>
                    <td class="auto-style4">User name </td>
                    <td>
                        <asp:TextBox ID="user" runat="server" Height="20px" Width="113px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Password</td>
                    <td>
                        <asp:TextBox ID="pass" runat="server" Height="16px" TextMode="Password" Width="114px"></asp:TextBox>
&nbsp;</td>
                </tr>
            </table>
            
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>
