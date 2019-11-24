using Newtonsoft.Json;
using System;


namespace FrancePublicHolidays.Model
{
    public class Holiday 
    {

        
        [JsonProperty("nom_jour_ferie")]
        public string Name { get; set; }

        public DateTime Date { get; set; }


        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Holiday other = obj as Holiday;
            if ((Object)other == null) return false;

            return  this.Name == (obj as Holiday).Name &&
                    this.Date.Equals((obj as Holiday).Date);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            var h = string.Format("Name= {0}, Date=new DateTime({1}, {2}, {3})}", Name, Date.Year, Date.Month, Date.Day);

            return "new Holiday {"+ h +"}";
        }

    }
}
