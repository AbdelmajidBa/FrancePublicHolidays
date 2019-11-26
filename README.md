# FrancePublicHolidays 
This package gives French Public Holidays between 1950 and 2050.
It uses, a web API described in this French government website :  https://www.data.gouv.fr/fr/datasets/jours-feries-en-france/.

Nuget: Install-Package FrancePublicHolidays [![Nuget](https://img.shields.io/nuget/v/FrancePublicHolidays.svg) ](https://www.nuget.org/packages/FrancePublicHolidays/)

```C#
//create an instance of FrancePublicHolidays using default constructor (call static api file)
using (var publicHoliday = new PublicHoliday())
{
    //Check if given date is a public holiday 
    bool validPublicHoliday = publicHoliday.isPublicHoliday(new DateTime(2019, 12, 25));

    //Get all public holidays from given year
    IEnumerable<Holiday> holidays = publicHoliday.GetPublicHolidaysByYear(2019);

    //Get public holiday informations from given date
    Holiday holiday = publicHoliday.GetPublicHolidayByDate(new DateTime(1995, 05, 01));

    //Get public holiday informations from given holiday name and year
    holiday = publicHoliday.GetPublicHolidayByNameAndYear("Assomption", 2015);
}
//create an instance of FrancePublicHolidays using Rest api ("https://jours-feries-france.antoine-augusti.fr/api/")
using (var publicHoliday = new PublicHoliday("RESTapi"))
{
    //the same code here 
}

```
