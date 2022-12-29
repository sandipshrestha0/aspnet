<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="webSandipform.Dashboard" %>

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
<body style="background-color:lightskyblue">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Button ID="btnins" runat="server" Text="Insert" OnClick="btnins_Click" Width="90px" style="background-color: lightgreen;"/>
                </td>
                <td>
                    <asp:Button ID="btnupdate" runat="server" Text="Update" Width="96px" OnClick="btnupdate_Click" style="background-color: lightgreen;"/>
                </td>
                <td>
                    <asp:Button ID="btndel" runat="server" Text="Delete" Width="82px" OnClick="btndel_Click" style="background-color: lightgreen;"/>
                </td>
                <td>
                    <asp:Button ID="btnshow" runat="server" Text="Show all" Width="94px" OnClick="btnshow_Click" style="background-color: lightgreen;" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
