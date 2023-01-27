<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="MiniProjectjan23.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 425px;
            margin-top: 57px;
        }
        .auto-style3 {
            margin-left: 105px;
        }
        .auto-style4 {
            margin-top: 0px;
        }
        .auto-style5 {
            margin-top: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="font-family: 'Eras Demi ITC'; font-size: large; font-weight: normal; font-style: oblique; text-decoration: blink; color: #0000FF">
        <div>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -------HOME PAGE------------<br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnhome" runat="server" Text="HOME" OnClick="btnhome_Click" BackColor="#FFCC00" CssClass="auto-style3" Font-Bold="True" Font-Size="Large" ForeColor="#FF3399" Height="75px" Width="105px" />
            <asp:Button ID="btnAddStudent" runat="server" Text="ADD STUDENT" OnClick="btnAddStudent_Click" BackColor="#0099FF" CssClass="auto-style5" Font-Bold="True" Font-Italic="False" Font-Size="Small" ForeColor="#FFFFCC" Height="55px" />
            <asp:Button ID="btnDisplay" runat="server" Text="DISPLAY" OnClick="btnDisplay_Click" BackColor="#33CC33" BorderStyle="Inset" CssClass="auto-style4" Font-Bold="True" Font-Size="Medium" ForeColor="#333300" Height="41px"/>            
            
            <asp:Button ID="btnLogout" runat="server" Text-="LOGOUT" OnClick="btnLogout_Click" BackColor="Red" Font-Bold="True" ForeColor="White"/>

        </div>
        <asp:GridView ID="grview" runat="server" CssClass="auto-style2" Width="563px">
            <EmptyDataTemplate>
                &nbsp;&nbsp;
            </EmptyDataTemplate>
        </asp:GridView>
            
    </form>
</body>
</html>
