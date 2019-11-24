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
    internal class FrancePublicHolidayAPI : IDisposable
    {
        private const string URI = "https://jours-feries-france.antoine-augusti.fr/api/";
        private static FrancePublicHolidayAPI instance = null;

        private IDictionary<int, IEnumerable<Holiday>> holidays;

        private FrancePublicHolidayAPI()
        {
             holidays = new Dictionary<int, IEnumerable<Holiday>>();
             var data = GetDataByYearAsync(DateTime.Now.Year);
            if (!data.IsFaulted)
                holidays.Add(DateTime.Now.Year, data.Result);
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


        public IEnumerable<Holiday> GetPublicHolidaysByYear(int year)
        {
            IEnumerable<Holiday> results = null;
            if (holidays.ContainsKey(year))
                results = holidays[year];
            else
            {
                InitHolidaysRepository(year);
                results = holidays[year];
            }
            return results;
        }
        public Holiday GetPublicHolidayByDate(DateTime date)
        {
            Holiday result = null;

            if (isPublicHoliday(date))
            {
                var holiday = holidays[date.Year].Where(h => h.Date == date).FirstOrDefault();
                result = holiday;
            }
            return result;
        }

        public Holiday GetPublicHolidayByNameAndYear(String name, int year)
        {
            Holiday result = null;

            if (!holidays.ContainsKey(year))
                InitHolidaysRepository(year);
            
            result = holidays[year].Where(h => h.Name == name).FirstOrDefault();

            return result;
        }


        public bool isPublicHoliday(DateTime date)
        {
            if (!holidays.ContainsKey(date.Year))
                InitHolidaysRepository(date.Year);
            
            var holiday = holidays[date.Year].Where(h => h.Date == date).FirstOrDefault();
            if (holiday != null)
                return true;
            else
                return false;

        }

        private void InitHolidaysRepository(int year)
        {
            var data = GetDataByYearAsync(year);
            if (data.IsFaulted)
                throw new CallApiException(data.Exception.Message, data.Exception.InnerException);
            else
                holidays.Add(year, data.Result);

        }
        private async void GetDataAsync()
        {
            for (int i = 1950; i < 2051; i++)
            {
                var data = await GetDataByYearAsync(i);
                holidays.Add(i, data);
            }
        }
        
        private async Task<IEnumerable<Holiday>> GetDataByYearAsync(int year)
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
