using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GetCompanies
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string key = "90b02bb4-4185-47a7-b5e7-75db65b5ed8e";
            Console.WriteLine("Enter number of company: ");
            string number = Console.ReadLine();
            string url = $"https://api.company-information.service.gov.uk/company/{number}";
            try
            {
                Company company = await GetCompanyByNumber(key, url);
                if (company != null)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"{company}");
                }
                else
                {
                    Console.WriteLine("Not found!");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Object is unknown!");
            }
            Console.Read();
        }

        static async Task<Company> GetCompanyByNumber(string key, string url)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(key));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authInfo);
            HttpResponseMessage response = await client.GetAsync(url);
            HttpContent content = response.Content;
            Console.WriteLine("Response StatusCode: " + (int)response.StatusCode);
            string json = await content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<Company>(json);
            return res;
        }
    }
}
