using FrancePublicHolidays.Exceptions;
using FrancePublicHolidays.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FrancePublicHolidays.Service
{
    internal class FrancePublicHolidayAPI : ISericeFrPublicHoliyas, IDisposable
    {
        private const string URI = "https://jours-feries-france.antoine-augusti.fr/api/";
        private static FrancePublicHolidayAPI instance = null;

        private FrancePublicHolidayAPI()
        {
             Holidays = new Dictionary<int, IEnumerable<Holiday>>();
             GetDataAsync();
        }

        public static FrancePublicHolidayAPI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FrancePublicHolidayAPI();
                }
                return instance;
            }
            set { }
        }

        private void GetDataAsync()
        {
            for (int i = 1950; i < 2051; i++)
            {
                var data =  GetDataByYearAsync(i);
                if (data.IsFaulted)
                    throw new CallApiException(data.Exception.Message, data.Exception.InnerException);
                Holidays.Add(i, data.Result);
            }
        }
        
        public async Task<IEnumerable<Holiday>> GetDataByYearAsync(int year)
        {
            try
            {
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                
                using (var httpClient = new HttpClient(clientHandler))
                {
                    httpClient.BaseAddress = new Uri(URI);
                    var acceptType = new MediaTypeWithQualityHeaderValue("application/json");
                    httpClient.DefaultRequestHeaders.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(acceptType);
                   
                    var response = httpClient.GetAsync(year.ToString());
                    response.Wait();
                    
                    var result = response.Result;
                    string jsonString = null;
                    if (result.IsSuccessStatusCode)
                    {
                        jsonString = await result.Content.ReadAsStringAsync();

                    }
                    else
                    {
                        throw new CallApiException($"Error calling API, StatusCode : {result.StatusCode}, Reason :{result.ReasonPhrase}");
                    }
                    
                    return JsonConvert.DeserializeObject<Holiday[]>(jsonString);
                }
            }
            catch (Exception e)
            {
               throw new CallApiException("Error in Web API caused by calling the GetDataByYearAsync method.", e);
            }
           
        }


        public void Dispose()
        {
            if (instance != null)
                instance = null;
        }
    }
}
