using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja___TalkLink
{
    public class Apiclass
    {
        private static void GetItem(int id)
        {
            var client = new RestClient("https://talklinkapi.azurewebsites.net/api");
            var request = new RestRequest($"/item/{id}", Method.Get);
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        private static void GetItems()
        {
            var client = new RestClient("https://talklinkapi.azurewebsites.net/api");
            var request = new RestRequest("items", Method.Get);
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
        }


        private static void PostItem(string data)
        {
            var client = new RestClient("http://localhost:8080");
            var request = new RestRequest("items", Method.Post);
            request.AddParameter("data", data);
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        private static void PutItem(int id, string data)
        {
            var client = new RestClient("http://localhost:8080");
            var request = new RestRequest("items", Method.Put);
            request.AddParameter("id", id);
            request.AddParameter("data", data);
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        private static void DeleteItem(int id)
        {
            var client = new RestClient("http://localhost:8080");
            var request = new RestRequest($"items/{id}", Method.Delete);
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
