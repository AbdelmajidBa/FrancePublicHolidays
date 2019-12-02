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
            Holiday result = null;
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
            IEnumerable<Holiday> results = null;
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
            var holiday = service.GetHolidaysByYear(date.Year).Where(h => h.Date == date).FirstOrDefault();
            if (holiday != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Get total business days holidays from given year and month
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>


        public int GetBusinessDays(int year, int month)
        {
            CheckValues(year);
            IEnumerable<Holiday> results = null;
            results = service.GetHolidaysByYear(year).Where(h=>h.Date.Month==month);
            var hDates = results.Select(h=> new { Date = h.Date });
            
            
            var daysInMonth = DateTime.DaysInMonth(year, month);

            var dates = Enumerable.Range(1, daysInMonth)
                                        .Select(n => new DateTime(year, month, n))
                                        .Where(date => IsWorkingDay(date) && !hDates.Contains(new { Date = date.Date }))
                                        .ToArray();

            return dates.Count();
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

        private bool IsWorkingDay(DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday
                && date.DayOfWeek != DayOfWeek.Sunday;
        }

    }
}
