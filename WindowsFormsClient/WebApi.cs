using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ThesisDemo
{
    class WebApi
    {
        public class Group
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private HttpClient client;

        public WebApi()
        {
            client = new HttpClient();
            ////client.DefaultRequestHeaders.Accept = new System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue>("application/json");
            ////async,await
            //var result = client.GetAsync("http://localhost:19216/api/group").Result;
            //if (result.IsSuccessStatusCode)
            //{
            //    var groups = result.Content.ReadAsAsync<Group[]>().Result;
            //    foreach (var g in groups)
            //    {

            //    }
            //}

            ////client.PutAsync<Group>()
        }

       
    }
}
