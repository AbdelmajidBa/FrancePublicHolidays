using FrancePublicHolidays.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrancePublicHolidays.Service
{
    public  class StaticFileAPI
    {
       

            public StaticFileAPI()
        {
            FrancePublicHolidayAPI service = FrancePublicHolidayAPI.Instance;
            StringBuilder sb = new StringBuilder(); 
            for (int i = 1950; i < 2051; i++)
            {
                var holidays = service.GetPublicHolidaysByYear(i);
                foreach (var h in holidays)
                {
                    sb.Append(h.ToString());
                    sb.Append(",");
                }
                //sb.Append(h.ToString());
                //sb.Append(",");
            }

            var res = sb.ToString();
        }
    }
}
