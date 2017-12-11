using Athleticum.ServiceAgents.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Athleticum.Classes.ServiceAgents
{
    public class MethodsServiceAgent<T> : IMethodsServiceAgent<T>
    {
        private string _base_url = "";
        private string _controller_name = "";

        public MethodsServiceAgent(string base_url, string controller_name)
        {
            _base_url = base_url;
            _controller_name = controller_name;
        }

        public Task DeleteMethodAsync(string action, int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> PostMethodAsync(string action, object body)
        {
            throw new NotImplementedException();
        }

        public Task<T> PutMethodAsync(string action, object body)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetMethodAsync(string action, Dictionary<string, object> parameters)
        {
            string url = _base_url + _controller_name + action;

            foreach (KeyValuePair<string, object> keyValuePair in parameters)
            {

            }

            using (var client = new HttpClient())
            {
                T objectReturn = default(T);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        objectReturn = JsonConvert.DeserializeObject<T>(jsonResponse);
                    }
                    else
                    {
                        // TODO : Display error message
                    }
                    return objectReturn;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                    return objectReturn;
                }
            }
        }
    }
}
