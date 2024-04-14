using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using IPinfo;
using IPinfo.Models;

namespace SoftwareIIb
{
    internal class LocationService
    {
        static private string token = "34f367a4228c19";
        private IPinfoClient client = new IPinfoClient.Builder()
            .AccessToken(token)
            .Build();
        private string ip { get; set; } 
        private string city { get; set; }
        private string region { get; set; }
        private string country { get; set; }

        public async Task<IPResponse> GetUserLocationAsync()
        {
            IPResponse ipResponse = await client.IPApi.GetDetailsAsync();
            city = ipResponse.City;
            region = ipResponse.Region;
            ip = ipResponse.IP;
            country = ipResponse.Country;
            return ipResponse;
            //return $"IP: {ip}, City: {city}, Region: {region}";

            //return "Location information not available";
        }
    }
}
