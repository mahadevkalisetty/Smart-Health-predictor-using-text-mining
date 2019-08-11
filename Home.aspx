<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Smart_healthpredictor.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 705px;
        }
        .auto-style2 {
            height: 177px;
        }
        .auto-style3 {
            width: 196px;
        }
        .auto-style4 {
            width: 206px;
        }
    </style>
</head>
    <body>
        <form id="form1" runat="server">
        <table class="auto-style1" style="background-image: url('Image/wp2469685-medical-doctor-wallpaper-hd.jpg')">
            <tr>
                <td colspan="3" class="auto-style2"><h1 style="color:gold; padding:30px; text-align:center; font-size:2cm;">The Smart Health Predictor</h1><br />
                    <div class="example1"><h4>The Mini Project Done By K Mahadev Naidu</h4></div>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="button" runat="server" Text="Patient login" ForeColor="Black" CssClass="Btn" OnClick="patientlogin_Click" /></td>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="button1" runat="server" Text="Doctor login" ForeColor="Black" CssClass="Btn" OnClick="doctorlogin_Click" /></td>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="button2" runat="server" Text="Admin login" ForeColor="Black" CssClass="Btn" OnClick="Button1_Click" /></td>
            </tr>
        </table>
        </form>
</body>
</html>
