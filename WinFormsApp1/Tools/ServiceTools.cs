using Library.Entities.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace LibraryManagerWinForm.Helpers
{
    public static class ServiceTools
    {

        public static string responseMessage;
       
     
        public static async Task<bool> IsServiceAvailable<T>( string controller,string action,string value) where T:class
        { 
            try {
                    var result = await ServiceGetByName<T>(controller, action, value);
                    bool isAvailable = !result.Any();
                    if (isAvailable == false)
                        return true; 
                    return false;
            } catch
            {
                return false;
            }
        }
        public static async Task<List<T>> ServiceGetByName<T>(string controller,string action, string value)where T:class
        {
           
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => { return true; };
                HttpClient client = new HttpClient(clientHandler);
                client.BaseAddress = new Uri("https://localhost:5001");
                HttpResponseMessage response = await client.GetAsync(string.Format("/api/{0}/{1}?name={2}", controller, action, value));
                string result = await response.Content.ReadAsStringAsync();
            if(response.StatusCode==System.Net.HttpStatusCode.BadRequest || response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            responseMessage = response.StatusCode.ToString()+ "(error while trying to retrieve information from service )";
            return JsonConvert.DeserializeObject<List<T>>(result);
           
        }
        public static async Task<T> ServiceGetById<T>(string controller, string action, int value,string name)where T:class
        {
           
            HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => { return true; };
                HttpClient client = new HttpClient(clientHandler);
                client.BaseAddress = new Uri("https://localhost:5001");
            HttpResponseMessage response;
            if (name==string.Empty)
            {
                 response = await client.GetAsync(string.Format("/api/{0}/{1}/{2}", controller, action, value));
            }
            else { response = await client.GetAsync(string.Format("/api/{0}/{1}?name={2}", controller, action, name)); }

            string result = await response.Content.ReadAsStringAsync();
            responseMessage = response.StatusCode.ToString();
            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest || response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                responseMessage = response.StatusCode.ToString() + "  while trying to retrieve information from service ";
            return JsonConvert.DeserializeObject<T>(result);
            
        }
       
        /* public static async Task<string> ServicePut<T>(string controller,string action,T entity)where T:class
          {

             /* var inputData = new Dictionary<string, string>
              {
                  {"name", name },
                  {"job",job }
              };*/

        /// var input = new FormUrlEncodedContent(inputData);
        /* var datas = JsonConvert.SerializeObject(entity);
         // var input = new FormUrlEncodedContent(datas);
         // var input = new FormUrlEncodedContent(inputData);
         using (HttpClient client=new HttpClient())
         {
             // HttpResponseMessage rm = await client.PostAsync(baseURL + "users", input);
             HttpResponseMessage rm = await client.PutAsync("",datas);
             HttpContent content = rm.Content;
             string data = await content.ReadAsStringAsync();
             if (data != null)
                 return data;

             var param = JsonConvert.SerializeObject(status);
             HttpContent content = new StringContent(param, UnicodeEncoding.UTF8, "application/json");
             var response = client.PutAsync("/api/BookStatus/UpdateStatus", content).Result;
             message = response.StatusCode.ToString();*/
        // }
        //}
    }
}
