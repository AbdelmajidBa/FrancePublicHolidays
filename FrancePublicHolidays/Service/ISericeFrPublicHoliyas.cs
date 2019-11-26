using FrancePublicHolidays.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrancePublicHolidays.Service
{
    internal class ISericeFrPublicHoliyas
    {
        protected IDictionary<int, IEnumerable<Holiday>> Holidays { get; set; }

        public IEnumerable<Holiday> GetHolidaysByYear(int year)
        {
            return Holidays[year];
        }

    }
}
