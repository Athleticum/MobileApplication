using Athleticum.ServiceAgents.Classes;
using Athleticum.ServiceAgents.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Athleticum.Classes.ServiceAgents
{
    public class MethodsServiceAgent<T> : IMethodsServiceAgent<T>, IDisposable
    {
        private string _base_url = string.Empty;
        private string _controller_name = string.Empty;

        public MethodsServiceAgent(string base_url, string controller_name)
        {
            _base_url = base_url;
            _controller_name = controller_name;
        }

        public async Task<T> DeleteMethodAsync(Request request)
        {
            string url = _base_url + "/" + _controller_name + "?" + request;

            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    T objectReturn = JsonConvert.DeserializeObject<T>(jsonResponse);

                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        // TODO : Display Error Message
                    }

                    return objectReturn;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                    throw ex;
                }
            }
        }

        public async Task<T> PostMethodAsync(Request body)
        {
            string url = _base_url + "/" + _controller_name;

            using (var client = new HttpClient())
            {
                try
                {
                    string bodyJSON = JsonConvert.SerializeObject(body);
                    HttpContent httpContent = new StringContent(bodyJSON);

                    HttpResponseMessage response = await client.PostAsync(url, httpContent);

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    T objectReturn = JsonConvert.DeserializeObject<T>(jsonResponse);

                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        // TODO : Display Error Message
                    }

                    return objectReturn;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                    throw ex;
                }
            }
        }

        public async Task<T> PutMethodAsync(Request body)
        {
            string url = _base_url + "/" + _controller_name;

            using (var client = new HttpClient())
            {
                try
                {
                    string bodyJSON = JsonConvert.SerializeObject(body);
                    HttpContent httpContent = new StringContent(bodyJSON);

                    HttpResponseMessage response = await client.PutAsync(url, httpContent);

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    T objectReturn = JsonConvert.DeserializeObject<T>(jsonResponse);

                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        // TODO : Display Error Message
                    }

                    return objectReturn;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                    throw ex;
                }
            }
        }

        public async Task<T> GetMethodAsync(Request request)
        {
            string url = _base_url + _controller_name + "?" + JsonConvert.SerializeObject(request);

            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    T objectReturn = JsonConvert.DeserializeObject<T>(jsonResponse);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        // TODO : Display Error Message
                    }

                    return objectReturn;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                    throw ex;
                }
            }
        }

        public void Dispose()
        {
        }
    }
}
