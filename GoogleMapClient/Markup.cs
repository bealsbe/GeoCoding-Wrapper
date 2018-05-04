using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapClient
{
    class Markup
    {
        public void WriteFile()
        {
            List<string> head = new List<string>();
            head.Add("<!DOCTYPE html>");
            head.Add("<html>");
            head.Add("<head>");
            head.Add("  < meta http - equiv = \"content-type\" content = \"text/html; charset=UTF-8\" /> ");
            head.Add("  <title>Google Maps Multiple Markers</title>");
            head.Add("    <style>");
            head.Add("      html, body, #map {>");
            head.Add("        height: 100%;");
            head.Add("        margin: 0px;");
            head.Add("        padding: 0px");
            head.Add("      }");
            head.Add("    </style>");
            head.Add("  <script src=\"http://maps.google.com/maps/api/js?sensor=false\" ");
            head.Add("          type=\"text / javascript\"></script>");
            head.Add("</head>");
            head.Add("<body>");
            head.Add("  <div id=\"map\"></div>");
            head.Add("");
            head.Add("  <script type=\"text / javascript\">");
            head.Add("    var locations = [");
            //File.WriteAllLines(, head);
        }
    
    }
}
