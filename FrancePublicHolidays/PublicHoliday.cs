using FrancePublicHolidays.Exceptions;
using FrancePublicHolidays.Model;
using FrancePublicHolidays.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrancePublicHolidays
{
    /// <summary>
    /// This package gives French Public Holidays between 1950 and 2050.
    /// It uses, a web API described in this French government website : 
    ///     https://www.data.gouv.fr/fr/datasets/jours-feries-en-france/.
    /// </summary>
    public class PublicHoliday : IPublicHoliday, IDisposable
    {

        //private FrancePublicHolidayAPI service;
        //private StaticFileAPI service;

        private ISericeFrPublicHoliyas service;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="_service">by befault satic api will be instanciated or _service="RESTapi" to use "https://jours-feries-france.antoine-augusti.fr/api/" API </param>
        public PublicHoliday(string _service="Default")
        {
            switch (_service)
            {
                case "RESTapi":
                    service = FrancePublicHolidayAPI.Instance;
                    break;
                default:
                    service = new StaticFileAPI();
                    break;
            }
        }

        
        private void CheckValues(int year)
        {
            if (year > 2050 || year < 1950)
            {
                throw new AuthorizedValuesException("The year must be between 1950 and 2050. Other values are not provided by our API");
            }
        }
        /// <summary>
        /// Get public holiday information from given date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>
        ///     Public holiday information of input date
        ///     null if not found
        ///     Thrown CallApiException if an Exception occurred when calling web API.
        /// </returns>
        public Holiday GetPublicHolidayByDate(DateTime date)
        {
            CheckValues(date.Year);
            //return service.GetPublicHolidayByDate(date);
            Holiday result = null;

            if (isPublicHoliday(date))
            {
                var holiday = service.GetHolidaysByYear(date.Year).Where(h => h.Date == date).FirstOrDefault();
                result = holiday;
            }
            return result;
        }
        /// <summary>
        /// Get public holiday information from given holiday name and year
        /// </summary>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <returns>
        ///     Public holiday information of input name and year
        ///     null if not found
        ///     Thrown CallApiException if an Exception occurred when calling web API.
        /// </returns>
        public Holiday GetPublicHolidayByNameAndYear(string name, int year)
        {
            CheckValues(year);
            //return service.GetPublicHolidayByNameAndYear(name, year);
            Holiday result = null;

            //if (service.Holidays.ContainsKey(year))
                result = service.GetHolidaysByYear(year).Where(h => h.Name == name).FirstOrDefault();

            return result;
        }

        /// <summary>
        /// Get all public holidays from given year
        /// </summary>
        /// <param name="year"></param>
        /// <returns>
        ///     List of public holidays of input year
        ///     null if not found 
        ///     Thrown CallApiException if an Exception occurred when calling web API.
        /// </returns>
        public IEnumerable<Holiday> GetPublicHolidaysByYear(int year)
        {
            CheckValues(year);
            //return service.GetPublicHolidaysByYear(year);
            IEnumerable<Holiday> results = null;
            //if (service.Holidays.ContainsKey(year))
                results = service.GetHolidaysByYear(year);

            return results;
        }
        /// <summary>
        /// check if given date is a public holiday 
        /// </summary>
        /// <param name="date"></param>
        /// <returns>
        ///     true if given date is a public holiday
        ///     flase if not
        ///     Thrown CallApiException if an Exception occurred when calling web API.
        /// </returns>
        public bool isPublicHoliday(DateTime date)
        {
            CheckValues(date.Year);
            //return service.isPublicHoliday(date);
            var holiday = service.GetHolidaysByYear(date.Year).Where(h => h.Date == date).FirstOrDefault();
            if (holiday != null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Dipose resources 
        /// </summary>
        public void Dispose()
        {

            if (service is FrancePublicHolidayAPI)
            {
                if (FrancePublicHolidayAPI.Instance != null)
                    FrancePublicHolidayAPI.Instance.Dispose();
            }
            service = null;

        }
    }
}
