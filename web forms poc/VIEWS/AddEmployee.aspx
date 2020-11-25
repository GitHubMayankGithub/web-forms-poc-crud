<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="AddEmployee.aspx.cs" Inherits="web_forms_poc.VIEWS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <table class="auto-style1" runat="server">
        <tr>
            <td>
                <asp:Label ID="EmpId" runat="server" Text="EmpId"></asp:Label></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Designation" runat="server" Text="Designation"></asp:Label></td>
            <td>&nbsp;</td>
        </tr>
        <tr runat="server">
            <td runat="server">
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="OnSubmit1" />
            </td>
        </tr>
    </table>
        </div>
    </form>
  
</body>
</html>
