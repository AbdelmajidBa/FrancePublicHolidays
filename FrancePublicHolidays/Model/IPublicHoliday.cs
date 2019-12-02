using System;
using System.Collections.Generic;

namespace FrancePublicHolidays.Model
{
    interface IPublicHoliday
    {
        IEnumerable<Holiday> GetPublicHolidaysByYear(int year);

        Holiday GetPublicHolidayByDate(DateTime date);

        Holiday GetPublicHolidayByNameAndYear(String name, int year);

        bool isPublicHoliday(DateTime date);
        
        int GetBusinessDays(int year, int month);
    }
}
