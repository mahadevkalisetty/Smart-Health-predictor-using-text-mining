<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Doctor_login.aspx.cs" Inherits="Smart_healthpredictor.Doctor_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style8 {
            width: 100%;
        }
        .auto-style9 {
            height: 601px;
            width: 717px;
        }
        .auto-style10 {
            height: 601px;
            width: 349px;
        }
        #form1 {
            height: 800px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        
        
        <table class="auto-style8" style="background-image: url('Image/wp2789219-medical-doctor-wallpaper-hd.jpg'); height: 795px;">
            <tr>
                <td class="auto-style10">
                    <asp:Panel ID="Panel2" runat="server" Height="865px" style="margin-top: -20px">
                        <div class="text-block"><br /><br />
          Email: <asp:TextBox ID="lemail" runat="server" ></asp:TextBox><br/><br />
          Password: <asp:TextBox ID="lpassword" runat="server" TextMode="Password" ></asp:TextBox><br /><br />
           Remember Me?<input type="checkbox" id="checkbox" name="remember me" /><br /><br />&nbsp;&nbsp;
          <asp:Button ID="Login" runat="server" Text="Log IN" CssClass="btn" OnClick="Login_Click1" ForeColor="Black"/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="Registers" runat="server" Text="Register" CssClass="btn" OnClick="Reges_Click" ForeColor="Black"/>
                        </div>

                    </asp:Panel>
                </td>
                <td class="auto-style9">
                    <asp:Panel ID="Panel1" runat="server" Height="858px" style="margin-top: -20px; margin-left: 4px;">
                        <div class="Register"><br />
                             <h2 class="h2">New Users Register Here</h2>
           First name: <asp:TextBox ID="firstname" runat="server" ></asp:TextBox><br /><br />
          Last name name: <asp:TextBox ID="lastname" runat="server" ></asp:TextBox><br /><br />
          Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="email" runat="server" TextMode="Email" /><br /><br />
          Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="password" runat="server" TextMode="Password"/><br /><br />
          Confirm Password: <asp:TextBox ID="confirmpassword" runat="server" TextMode="Password" ></asp:TextBox><br /><br />
          Agree to all Conditions <asp:CheckBox ID="chek" runat="server" />
          <asp:Button ID="Register" runat="server" CssClass="btn" OnClick="Register_Click" text="Register" ForeColor="Black"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:smartcon %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT * FROM [ DocRegister]"></asp:SqlDataSource>
                        </div>
                    </asp:Panel>
                </td>
            </tr>
        </table>
        
        
        
&nbsp;<link href="Doctor_login.css" rel="stylesheet" type="text/css" />
    </form>
</body>
</html>
