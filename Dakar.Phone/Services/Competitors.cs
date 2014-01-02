using Dakar.Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace Dakar.Core.Services
{
    public static class Services
    {
        public static async Task<List<Competitor>> GetBikesList()
        {
            string urlBikes = "http://www.dakar.com/dakar/2014/us/rider/rider-list-bikes.html";
            string urlCars = "http://www.dakar.com/dakar/2014/us/rider/rider-list-cars.html";
            string urlTrucks = "http://www.dakar.com/dakar/2014/us/rider/rider-list-trucks.html";
            string urlQuads = "http://www.dakar.com/dakar/2014/us/rider/rider-list-quads.html";

            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(urlTrucks);
            string[] filters = new string[] {"<table>","</table>"};
            string[] filtersForRows = new string[] { "<tr>", "</tr>" };
            string[] filterOne = new string[] { ".html\" >", "</a>" };
            string[] filterOneOptional = new string[] {"<li>"," ("};
            string[] filterTwo = new string[] { "(",")"};
            string[] filterThree = new string[] { "<p>", "</p>" };
            string[] filterFour = new string[] { "<td>", "</td>" };
            string[] results = result.Split(filters, StringSplitOptions.None);
            string[] rows = results[1].Split(filtersForRows,StringSplitOptions.None);
            List<Competitor> competitors = new List<Competitor>();
            foreach (string item in rows)
            {
                if (item != "" && !item.StartsWith("<th>"))
                {
                    Competitor c = new Competitor();
                    string []number = (item.Split(filterOne, StringSplitOptions.None));
                    try
                    {
                        c.Position = int.Parse(number[1]);
                        c.Name = number[3];
                    }
                    catch (Exception)
                    {
                        c.Position = int.Parse((item.Split(filterFour, StringSplitOptions.None)[1]));
                        c.Name = (item.Split(filterOneOptional, StringSplitOptions.None)[1]);
                    }
                    c.Country = item.Split(filterTwo, StringSplitOptions.None)[1];
                    c.Team = item.Split(filterThree, StringSplitOptions.None)[1];
                    c.Model = item.Split(filterFour, StringSplitOptions.None)[7];
                    competitors.Add(c);
                }
            }
            return competitors;
        }
    }
}
