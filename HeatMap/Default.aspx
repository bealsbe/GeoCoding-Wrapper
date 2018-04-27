<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HeatMap.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HeatMap</title>

    <style>
        /* Always set the map height explicitly to define the size of the div
       * element that contains the map. */
        #map {
            height: 100%;
        }
        /* Optional: Makes the sample page fill the window. */
        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
        }

        #floating-panel {
            position: absolute;
            top: 10px;
            left: 25%;
            z-index: 5;
            background-color: #fff;
            padding: 5px;
            border: 1px solid #999;
            text-align: center;
            font-family: 'Roboto','sans-serif';
            line-height: 30px;
            padding-left: 10px;
        }

        #floating-panel {
            background-color: #fff;
            border: 1px solid #999;
            left: 25%;
            padding: 5px;
            position: absolute;
            top: 10px;
            z-index: 5;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Address</h1>
        <div id="AddressBox">
            <br />
            <table>
                <tr>
                    <td>Company Name</td>
                    <td><asp:TextBox ID="CompanyName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address Line 1 </td>
                    <td> <asp:TextBox ID="txt_AddressLine1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address Line 2 </td>
                    <td> <asp:TextBox ID="txt_AddressLine2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City </td>
                    <td><asp:TextBox ID="txt_City" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>State </td>
                    <td> <asp:TextBox ID="txt_State" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Zip </td>
                    <td><asp:TextBox ID="txt_Zip" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <br />

        </div>
        <asp:Button ID="Add" runat="server" Text="Save" OnClick="Save_Click" />

        <asp:Button ID="DisplayButton" runat="server" Text="Load Map" />
        <div id="Listbox">
            <asp:ListBox ID="CompanyListBox" runat="server" Width="572px"></asp:ListBox>
        </div>
    </form>
    <div id="map"></div>

    <script
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyC3hfMFJNWo9f7k0_8rbdV3r-ic4bfLExs&libraries=visualization&callback=initMap"> <%--API from developers.google.com--%>
    </script>

</body>
</html>
