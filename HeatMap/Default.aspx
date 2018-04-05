<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HeatMap.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Address</h1>
        <div id="AddressBox">
            <br />
            <table>
                <tr>
                    <td>Company Name</td>
                    <td>
                        <asp:TextBox ID="CompanyName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address Line 1 </td>
                    <td>
                        <asp:TextBox ID="txt_AddressLine1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address Line 2 </td>
                    <td>
                        <asp:TextBox ID="txt_AddressLine2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City </td>
                    <td>
                        <asp:TextBox ID="txt_City" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>State </td>
                    <td>
                        <asp:TextBox ID="txt_State" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Zip </td>
                    <td>
                        <asp:TextBox ID="txt_Zip" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <br />

        </div>
        <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />
    </form>
</body>
</html>
