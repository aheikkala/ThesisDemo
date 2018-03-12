using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ThesisDemo
{
    class WebApi
    {

        //data transfer objects:
        public class GroupData
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public List<UserData> Users { get; set; }
        }

        public class UserData
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public bool Online { get; set; }
            public List<GroupData> Groups { get; set; }
        }

        public class MessageData
        {
            public int UserID { get; set; }
            public int GroupID { get; set; }
            public string Message { get; set; }
        }

        private static HttpClient client;

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

        public UserData[] GetAllUsers()
        {
            var result = client.GetAsync("http://localhost:19216/api/User").Result;

            if (result.IsSuccessStatusCode)
            {
               return result.Content.ReadAsAsync<UserData[]>().Result;
               
            }

            return null;
        }

        public async Task<UserData> GetUser(int userID)
        {
            var result = await client.GetAsync($"http://localhost:19216/api/User/{userID}");

            if (result.IsSuccessStatusCode)
            {
                return result.Content.ReadAsAsync<UserData>().Result;

            }

            return null;
        }

        public async Task<GroupData> GetGroup(int groupID)
        {
            var result = await client.GetAsync($"http://localhost:19216/api/group/{groupID}");

            if (result.IsSuccessStatusCode)
            {
                return result.Content.ReadAsAsync<GroupData>().Result;

            }

            return null;
        }

        public static async Task<HttpStatusCode> AddGroup(int userID, string groupName)
        {

            var group = new GroupData
            {
                Name = groupName
            };

            var result = await client.PostAsJsonAsync($"http://localhost:19216/api/user/{userID}/group", group);
            result.EnsureSuccessStatusCode();

            return result.StatusCode;
        }

        public async Task<HttpStatusCode> AddMessage(int userID, int groupID, string message)
        {

            var msg = new MessageData
            {
                UserID = userID,
                GroupID = groupID,
                Message = message
            };

            var result = await client.PostAsJsonAsync($"http://localhost:19216/api/message", msg);
            result.EnsureSuccessStatusCode();

            return result.StatusCode;
        }
    }
}
