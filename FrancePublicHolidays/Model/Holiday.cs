using Newtonsoft.Json;
using System;


namespace FrancePublicHolidays.Model
{
     /// <summary>
    ///  Holi
    /// </summary>
    public class Holiday 
    {
        /// <summary>
        /// Public Holiday Nam
        /// </summary>
        [JsonProperty("nom_jour_ferie")]
        public string Name { get; set; }
        /// <summary>
        /// Public Holiday Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Determines whether two Holiday instances are equal.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Holiday other = obj as Holiday;
            if ((Object)other == null) return false;

            return  this.Name == (obj as Holiday).Name &&
                    this.Date.Equals((obj as Holiday).Date);
        }
        /// <summary>
        /// Default hash function
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var holiday = string.Format("Name= \"{0}\", Date=new DateTime({1}, {2}, {3})", Name, Date.Year, Date.Month, Date.Day);

            return "{" + holiday + "}";
        }

    }
}
