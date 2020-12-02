using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace SistemaVentas.Models
{
    public class Clima
    {
        public Object getClima()
        {
            string appid = "d239307ceab467e3f5527756c20c0f81";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Asuncion&lang=sp&APPID=" + appid + "&units=metric";
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}