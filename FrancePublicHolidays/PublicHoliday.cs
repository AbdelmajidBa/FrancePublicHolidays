using FrancePublicHolidays.Exceptions;
using FrancePublicHolidays.Model;
using FrancePublicHolidays.Service;
using System;
using System.Collections.Generic;

namespace FrancePublicHolidays
{
    public class PublicHoliday : IPublicHoliday, IDisposable
    {

        private FrancePublicHolidayAPI service;

        /// <summary>
        /// Constructor
        /// </summary>
        public PublicHoliday()
        {
            service = FrancePublicHolidayAPI.Instance;
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
            return service.GetPublicHolidayByDate(date);
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
            return service.GetPublicHolidayByNameAndYear(name, year);
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
            return service.GetPublicHolidaysByYear(year);
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
            return service.isPublicHoliday(date);
        }
        /// <summary>
        /// Dipose resources 
        /// </summary>
        public void Dispose()
        {
            service = null;
            if (FrancePublicHolidayAPI.Instance != null)
                FrancePublicHolidayAPI.Instance.Dispose();
            

        }
    }
}
