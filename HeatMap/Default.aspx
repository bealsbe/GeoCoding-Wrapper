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
        <div id="Listbox">
            <asp:ListBox ID="CompanyListBox" runat="server" Width="572px"></asp:ListBox>
        </div>
    </form>
    <div id="map"></div>
    <script>

        // This example requires the Visualization library. Include the libraries=visualization
        // parameter when you first load the API. For example:
        // <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyC05GCbqi1vpEOdptcGBs94meu4-ooZ2hw&libraries=visualization">

        var map, heatmap;

        function initMap() {
            map = new google.maps.Map(document.getElementById('map'), {
                zoom: 7.5,
                center: { lat: 44.942, lng: -122.933 }, //Oregon's coordinates (Willamette Valley)
                mapTypeId: 'roadmap' //map view vs. satellite view
            });

            placeMarker();

            heatmap = new google.maps.visualization.HeatmapLayer({
                data: getPoints(),
                map: map
            });
        }

        function toggleHeatmap() {
            heatmap.setMap(heatmap.getMap() ? null : map);
        }

        function changeGradient() {
            var gradient = [
                'rgba(0, 255, 255, 0)',
                'rgba(0, 255, 255, 1)',
                'rgba(0, 191, 255, 1)',
                'rgba(0, 127, 255, 1)',
                'rgba(0, 63, 255, 1)',
                'rgba(0, 0, 255, 1)',
                'rgba(0, 0, 223, 1)',
                'rgba(0, 0, 191, 1)',
                'rgba(0, 0, 159, 1)',
                'rgba(0, 0, 127, 1)',
                'rgba(63, 0, 91, 1)',
                'rgba(127, 0, 63, 1)',
                'rgba(191, 0, 31, 1)',
                'rgba(255, 0, 0, 1)'
            ]
            heatmap.set('gradient', heatmap.get('gradient') ? null : gradient);
        }

        function changeRadius() {
            heatmap.set('radius', heatmap.get('radius') ? null : 20);
        }

        function changeOpacity() {
            heatmap.set('opacity', heatmap.get('opacity') ? null : 0.2);
        }

        // Heatmap data: 500 Points
        function getPoints() {
            return [
                <% 
                    foreach (Geocode.MapLocation address in addresses)
                    {
                        Response.Write($"placeMarker({address.latitude}, {address.longitude})"); //Reads as a string in C#, outputs into the js file as js code
                    }
                %>
            ];
        }

        //Places a single marker on a map
        function placeMarker(coordlat, coordlong) {
            var marker = new google.maps.Marker({
            position: { lat: coordlat, lng: coordlong }, 
            map: map,
            title: '<% CompanyName.Text.ToString(); %>'
        });
        }

        </script>
    <script
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCk9XYR_DLnFl6kzvnvoFw4lJTQ1Ejbqms&libraries=visualization&callback=initMap"> <%--API from developers.google.com--%>
    </script>

</body>
</html>
