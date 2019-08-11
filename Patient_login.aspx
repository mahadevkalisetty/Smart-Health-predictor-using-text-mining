<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patient_login.aspx.cs" Inherits="Smart_healthpredictor.Patient_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            height: 665px;
        }
        .auto-style3 {
            width: 473px;
        }
        #form1 {
            height: 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style2" style="background-image: url('Image/wp2386912-stethoscope-wallpapers.jpg');">
            <tr>
                <td class="auto-style3">
                    <asp:Panel ID="Panel1" runat="server" Height="757px" Width="100%">
                        <div class="text-block"><br /><br />
    Email: <asp:TextBox ID="lemail" runat="server" ></asp:TextBox><br/><br />
         password: <asp:TextBox ID="lpassword" runat="server" TextMode="Password" />
         Remember Me? <asp:CheckBox ID="chec" runat="server" /> <br /><br />&nbsp;&nbsp;
          <asp:Button ID="Login" runat="server" Text="Log IN" CssClass="btn" OnClick="Login_Click" ForeColor="Black"/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="Registers" runat="server" Text="Register" CssClass="btn" OnClick="Registers_Click" ForeColor="Black"/>

                        </div>
     
                    </asp:Panel>
                </td>
                <td>
                    <asp:Panel ID="Panel2" runat="server" Height="756px">
                         <div class="Register"><br /><br />
                             <h2 class="h2">New Users Register Here</h2>
          First name:  <asp:TextBox ID="firstname" runat="server" /><br /><br />
          Last name: <asp:TextBox ID="lastname" runat="server" /><br /><br />
          Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="email" runat="server" TextMode="Email" /><br /><br />
          Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="password" runat="server" TextMode="Password" /><br /><br />
          Confirm Password: <asp:TextBox ID="cpassword" runat="server" TextMode="Password" /><br /><br />
          Agree to all Conditions <asp:CheckBox ID="cond" runat="server" />
          <asp:Button ID="Register" runat="server" CssClass="btn" OnClick="Register_Click" text="Register" ForeColor="Black"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartcon %>" SelectCommand="SELECT * FROM [ DocRegister]"></asp:SqlDataSource>
      </div>
                    </asp:Panel>
                </td>
            </tr>
        </table>
&nbsp;<link href="StyleSheet2.css" rel="stylesheet" type="text/css" />
    </form>
</body>
</html>
