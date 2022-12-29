<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showall.aspx.cs" Inherits="webSandipform.showall" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Show all</h1>

        <asp:GridView ID="gvshow" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EnableModelValidation="True">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                <asp:BoundField DataField="dob" HeaderText="dob" SortExpression="dob" />
                <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sandipFormConnectionString %>" SelectCommand="SELECT [id], [name], [age], [dob], [gender] FROM [tblemp]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
    </form>

    </body>
</html>
