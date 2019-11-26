using FrancePublicHolidays.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrancePublicHolidays.Service
{
    internal class StaticFileAPI : ISericeFrPublicHoliyas
    {
        
        private void InitStaticFileAPI()
        {

            var holidays1950 = new List<Holiday>();
            holidays1950.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1950, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1950, 4, 10)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1950, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1950, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1950, 5, 18)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1950, 5, 29)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1950, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1950, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1950, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1950, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1950, 12, 25)},
            });
            Holidays.Add(1950, holidays1950);
            var holidays1951 = new List<Holiday>();
            holidays1951.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1951, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1951, 3, 26)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1951, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1951, 5, 3)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1951, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1951, 5, 14)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1951, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1951, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1951, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1951, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1951, 12, 25)},
            });
            Holidays.Add(1951, holidays1951);
            var holidays1952 = new List<Holiday>();
            holidays1952.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1952, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1952, 4, 14)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1952, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1952, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1952, 5, 22)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1952, 6, 2)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1952, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1952, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1952, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1952, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1952, 12, 25)},
            });
            Holidays.Add(1952, holidays1952);
            var holidays1953 = new List<Holiday>();
            holidays1953.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1953, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1953, 4, 6)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1953, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1953, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1953, 5, 14)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1953, 5, 25)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1953, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1953, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1953, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1953, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1953, 12, 25)},
            }); 
            Holidays.Add(1953, holidays1953);
            var holidays1954 = new List<Holiday>();
            holidays1954.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1954, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1954, 4, 19)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1954, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1954, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1954, 5, 27)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1954, 6, 7)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1954, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1954, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1954, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1954, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1954, 12, 25)},
            });
            Holidays.Add(1954, holidays1954);
            var holidays1955 = new List<Holiday>();
            holidays1955.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1955, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1955, 4, 11)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1955, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1955, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1955, 5, 19)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1955, 5, 30)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1955, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1955, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1955, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1955, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1955, 12, 25)},
            });
            Holidays.Add(1955, holidays1955);
            var holidays1956 = new List<Holiday>();
            holidays1956.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1956, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1956, 4, 2)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1956, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1956, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1956, 5, 10)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1956, 5, 21)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1956, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1956, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1956, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1956, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1956, 12, 25)},
            });
            Holidays.Add(1956, holidays1956);
            var holidays1957 = new List<Holiday>();
            holidays1957.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1957, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1957, 4, 22)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1957, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1957, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1957, 5, 30)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1957, 6, 10)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1957, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1957, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1957, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1957, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1957, 12, 25)},
            });
            Holidays.Add(1957, holidays1957);
            var holidays1958 = new List<Holiday>();
            holidays1958.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1958, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1958, 4, 7)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1958, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1958, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1958, 5, 15)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1958, 5, 26)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1958, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1958, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1958, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1958, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1958, 12, 25)},
            });
            Holidays.Add(1958, holidays1958);
            var holidays1959 = new List<Holiday>();
            holidays1959.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1959, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1959, 3, 30)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1959, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1959, 5, 7)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1959, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1959, 5, 18)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1959, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1959, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1959, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1959, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1959, 12, 25)},
            });
            Holidays.Add(1959, holidays1959);
            var holidays1960 = new List<Holiday>();
            holidays1960.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1960, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1960, 4, 18)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1960, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1960, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1960, 5, 26)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1960, 6, 6)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1960, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1960, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1960, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1960, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1960, 12, 25)},
            });
            Holidays.Add(1960, holidays1960);
            var holidays1961 = new List<Holiday>();
            holidays1961.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1961, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1961, 4, 3)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1961, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1961, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1961, 5, 11)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1961, 5, 22)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1961, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1961, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1961, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1961, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1961, 12, 25)},
            });
            Holidays.Add(1961, holidays1961);
            var holidays1962 = new List<Holiday>();
            holidays1962.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1962, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1962, 4, 23)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1962, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1962, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1962, 5, 31)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1962, 6, 11)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1962, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1962, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1962, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1962, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1962, 12, 25)},
            });
            Holidays.Add(1962, holidays1962);
            var holidays1963 = new List<Holiday>();
            holidays1963.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1963, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1963, 4, 15)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1963, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1963, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1963, 5, 23)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1963, 6, 3)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1963, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1963, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1963, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1963, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1963, 12, 25)},
            });
            Holidays.Add(1963, holidays1963);
            var holidays1964 = new List<Holiday>();
            holidays1964.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1964, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1964, 3, 30)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1964, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1964, 5, 7)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1964, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1964, 5, 18)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1964, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1964, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1964, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1964, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1964, 12, 25)},
            });
            Holidays.Add(1964, holidays1964);
            var holidays1965 = new List<Holiday>();
            holidays1965.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1965, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1965, 4, 19)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1965, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1965, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1965, 5, 27)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1965, 6, 7)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1965, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1965, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1965, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1965, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1965, 12, 25)},
            });
            Holidays.Add(1965, holidays1965);
            var holidays1966 = new List<Holiday>();
            holidays1966.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1966, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1966, 4, 11)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1966, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1966, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1966, 5, 19)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1966, 5, 30)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1966, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1966, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1966, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1966, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1966, 12, 25)},
            });
            Holidays.Add(1966, holidays1966);
            var holidays1967 = new List<Holiday>();
            holidays1967.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1967, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1967, 3, 27)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1967, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1967, 5, 4)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1967, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1967, 5, 15)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1967, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1967, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1967, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1967, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1967, 12, 25)},
            });
            Holidays.Add(1967, holidays1967);
            var holidays1968 = new List<Holiday>();
            holidays1968.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1968, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1968, 4, 15)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1968, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1968, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1968, 5, 23)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1968, 6, 3)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1968, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1968, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1968, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1968, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1968, 12, 25)},
            });
            Holidays.Add(1968, holidays1968);
            var holidays1969 = new List<Holiday>();
            holidays1969.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1969, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1969, 4, 7)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1969, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1969, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1969, 5, 15)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1969, 5, 26)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1969, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1969, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1969, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1969, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1969, 12, 25)},
            });
            Holidays.Add(1969, holidays1969);
            var holidays1970 = new List<Holiday>();
            holidays1970.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1970, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1970, 3, 30)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1970, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1970, 5, 7)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1970, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1970, 5, 18)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1970, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1970, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1970, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1970, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1970, 12, 25)},
            });
            Holidays.Add(1970, holidays1970);
            var holidays1971 = new List<Holiday>();
            holidays1971.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1971, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1971, 4, 12)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1971, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1971, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1971, 5, 20)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1971, 5, 31)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1971, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1971, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1971, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1971, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1971, 12, 25)},
            });
            Holidays.Add(1971, holidays1971);
            var holidays1972 = new List<Holiday>();
            holidays1972.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1972, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1972, 4, 3)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1972, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1972, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1972, 5, 11)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1972, 5, 22)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1972, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1972, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1972, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1972, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1972, 12, 25)},
            });
            Holidays.Add(1972, holidays1972);
            var holidays1973 = new List<Holiday>();
            holidays1973.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1973, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1973, 4, 23)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1973, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1973, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1973, 5, 31)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1973, 6, 11)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1973, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1973, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1973, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1973, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1973, 12, 25)},
            });
            Holidays.Add(1973, holidays1973);
            var holidays1974 = new List<Holiday>();
            holidays1974.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1974, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1974, 4, 15)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1974, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1974, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1974, 5, 23)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1974, 6, 3)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1974, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1974, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1974, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1974, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1974, 12, 25)},
            });
            Holidays.Add(1974, holidays1974);
            var holidays1975 = new List<Holiday>();
            holidays1975.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1975, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1975, 3, 31)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1975, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1975, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1975, 5, 19)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1975, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1975, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1975, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1975, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1975, 12, 25)},
            });
            Holidays.Add(1975, holidays1975);
            var holidays1976 = new List<Holiday>();
            holidays1976.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1976, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1976, 4, 19)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1976, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1976, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1976, 5, 27)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1976, 6, 7)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1976, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1976, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1976, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1976, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1976, 12, 25)},
            });
            Holidays.Add(1976, holidays1976);
            var holidays1977 = new List<Holiday>();
            holidays1977.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1977, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1977, 4, 11)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1977, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1977, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1977, 5, 19)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1977, 5, 30)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1977, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1977, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1977, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1977, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1977, 12, 25)},
            });
            Holidays.Add(1977, holidays1977);
            var holidays1978 = new List<Holiday>();
            holidays1978.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1978, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1978, 3, 27)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1978, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1978, 5, 4)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1978, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1978, 5, 15)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1978, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1978, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1978, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1978, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1978, 12, 25)},
            });
            Holidays.Add(1978, holidays1978);
            var holidays1979 = new List<Holiday>();
            holidays1979.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1979, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1979, 4, 16)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1979, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1979, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1979, 5, 24)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1979, 6, 4)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1979, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1979, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1979, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1979, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1979, 12, 25)},
            });
            Holidays.Add(1979, holidays1979);
            var holidays1980 = new List<Holiday>();
            holidays1980.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1980, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1980, 4, 7)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1980, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1980, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1980, 5, 15)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1980, 5, 26)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1980, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1980, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1980, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1980, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1980, 12, 25)},
            });
            Holidays.Add(1980, holidays1980);
            var holidays1981 = new List<Holiday>();
            holidays1981.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1981, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1981, 4, 20)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1981, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1981, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1981, 5, 28)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1981, 6, 8)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1981, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1981, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1981, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1981, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1981, 12, 25)},
            });
            Holidays.Add(1981, holidays1981);
            var holidays1982 = new List<Holiday>();
            holidays1982.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1982, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1982, 4, 12)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1982, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1982, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1982, 5, 20)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1982, 5, 31)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1982, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1982, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1982, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1982, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1982, 12, 25)},
            });
            Holidays.Add(1982, holidays1982);
            var holidays1983 = new List<Holiday>();
            holidays1983.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1983, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1983, 4, 4)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1983, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1983, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1983, 5, 12)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1983, 5, 23)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1983, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1983, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1983, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1983, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1983, 12, 25)},
            });
            Holidays.Add(1983, holidays1983);
            var holidays1984 = new List<Holiday>();
            holidays1984.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1984, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1984, 4, 23)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1984, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1984, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1984, 5, 31)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1984, 6, 11)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1984, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1984, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1984, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1984, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1984, 12, 25)},
            });
            Holidays.Add(1984, holidays1984);
            var holidays1985 = new List<Holiday>();
            holidays1985.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1985, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1985, 4, 8)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1985, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1985, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1985, 5, 16)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1985, 5, 27)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1985, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1985, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1985, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1985, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1985, 12, 25)},
            });
            Holidays.Add(1985, holidays1985);
            var holidays1986 = new List<Holiday>();
            holidays1986.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1986, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1986, 3, 31)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1986, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1986, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1986, 5, 19)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1986, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1986, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1986, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1986, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1986, 12, 25)},
            });
            Holidays.Add(1986, holidays1986);
            var holidays1987 = new List<Holiday>();
            holidays1987.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1987, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1987, 4, 20)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1987, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1987, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1987, 5, 28)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1987, 6, 8)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1987, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1987, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1987, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1987, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1987, 12, 25)},
            });
            Holidays.Add(1987, holidays1987);
            var holidays1988 = new List<Holiday>();
            holidays1988.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1988, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1988, 4, 4)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1988, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1988, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1988, 5, 12)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1988, 5, 23)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1988, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1988, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1988, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1988, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1988, 12, 25)},
            });
            Holidays.Add(1988, holidays1988);
            var holidays1989 = new List<Holiday>();
            holidays1989.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1989, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1989, 3, 27)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1989, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1989, 5, 4)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1989, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1989, 5, 15)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1989, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1989, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1989, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1989, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1989, 12, 25)},
            });
            Holidays.Add(1989, holidays1989);
            var holidays1990 = new List<Holiday>();
            holidays1990.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1990, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1990, 4, 16)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1990, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1990, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1990, 5, 24)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1990, 6, 4)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1990, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1990, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1990, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1990, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1990, 12, 25)},
            });
            Holidays.Add(1990, holidays1990);
            var holidays1991 = new List<Holiday>();
            holidays1991.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1991, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1991, 4, 1)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1991, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1991, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1991, 5, 9)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1991, 5, 20)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1991, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1991, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1991, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1991, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1991, 12, 25)},
            });
            Holidays.Add(1991, holidays1991);
            var holidays1992 = new List<Holiday>();
            holidays1992.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1992, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1992, 4, 20)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1992, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1992, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1992, 5, 28)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1992, 6, 8)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1992, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1992, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1992, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1992, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1992, 12, 25)},
            });
            Holidays.Add(1992, holidays1992);
            var holidays1993 = new List<Holiday>();
            holidays1993.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1993, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1993, 4, 12)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1993, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1993, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1993, 5, 20)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1993, 5, 31)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1993, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1993, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1993, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1993, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1993, 12, 25)},
            });
            Holidays.Add(1993, holidays1993);
            var holidays1994 = new List<Holiday>();
            holidays1994.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1994, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1994, 4, 4)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1994, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1994, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1994, 5, 12)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1994, 5, 23)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1994, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1994, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1994, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1994, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1994, 12, 25)},
            });
            Holidays.Add(1994, holidays1994);
            var holidays1995 = new List<Holiday>();
            holidays1995.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1995, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1995, 4, 17)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1995, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1995, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1995, 5, 25)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1995, 6, 5)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1995, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1995, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1995, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1995, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1995, 12, 25)},
            });
            Holidays.Add(1995, holidays1995);
            var holidays1996 = new List<Holiday>();
            holidays1996.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1996, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1996, 4, 8)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1996, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1996, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1996, 5, 16)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1996, 5, 27)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1996, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1996, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1996, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1996, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1996, 12, 25)},
            });
            Holidays.Add(1996, holidays1996);
            var holidays1997 = new List<Holiday>();
            holidays1997.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1997, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1997, 3, 31)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1997, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1997, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1997, 5, 19)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1997, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1997, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1997, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1997, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1997, 12, 25)},
            });
            Holidays.Add(1997, holidays1997);
            var holidays1998 = new List<Holiday>();
            holidays1998.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1998, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1998, 4, 13)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1998, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1998, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1998, 5, 21)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1998, 6, 1)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1998, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1998, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1998, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1998, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1998, 12, 25)},
            });
            Holidays.Add(1998, holidays1998);
            var holidays1999 = new List<Holiday>();
            holidays1999.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(1999, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(1999, 4, 5)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(1999, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(1999, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(1999, 5, 13)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(1999, 5, 24)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(1999, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(1999, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(1999, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(1999, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(1999, 12, 25)},
            });
            Holidays.Add(1999, holidays1999);
            var holidays2000 = new List<Holiday>();
            holidays2000.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2000, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2000, 4, 24)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2000, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2000, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2000, 6, 1)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2000, 6, 12)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2000, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2000, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2000, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2000, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2000, 12, 25)},
            });
            Holidays.Add(2000, holidays2000);
            var holidays2001 = new List<Holiday>();
            holidays2001.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2001, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2001, 4, 16)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2001, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2001, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2001, 5, 24)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2001, 6, 4)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2001, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2001, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2001, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2001, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2001, 12, 25)},
            });
            Holidays.Add(2001, holidays2001);
            var holidays2002 = new List<Holiday>();
            holidays2002.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2002, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2002, 4, 1)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2002, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2002, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2002, 5, 9)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2002, 5, 20)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2002, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2002, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2002, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2002, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2002, 12, 25)},
            });
            Holidays.Add(2002, holidays2002);
            var holidays2003 = new List<Holiday>();
            holidays2003.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2003, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2003, 4, 21)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2003, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2003, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2003, 5, 29)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2003, 6, 9)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2003, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2003, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2003, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2003, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2003, 12, 25)},
            });
            Holidays.Add(2003, holidays2003);
            var holidays2004 = new List<Holiday>();
            holidays2004.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2004, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2004, 4, 12)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2004, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2004, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2004, 5, 20)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2004, 5, 31)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2004, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2004, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2004, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2004, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2004, 12, 25)},
            });
            Holidays.Add(2004, holidays2004);
            var holidays2005 = new List<Holiday>();
            holidays2005.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2005, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2005, 3, 28)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2005, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2005, 5, 5)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2005, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2005, 5, 16)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2005, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2005, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2005, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2005, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2005, 12, 25)},
            });
            Holidays.Add(2005, holidays2005);
            var holidays2006 = new List<Holiday>();
            holidays2006.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2006, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2006, 4, 17)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2006, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2006, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2006, 5, 25)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2006, 6, 5)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2006, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2006, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2006, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2006, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2006, 12, 25)},
            });
            Holidays.Add(2006, holidays2006);
            var holidays2007 = new List<Holiday>();
            holidays2007.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2007, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2007, 4, 9)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2007, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2007, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2007, 5, 17)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2007, 5, 28)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2007, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2007, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2007, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2007, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2007, 12, 25)},
            });
            Holidays.Add(2007, holidays2007);
            var holidays2008 = new List<Holiday>();
            holidays2008.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2008, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2008, 3, 24)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2008, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2008, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2008, 5, 12)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2008, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2008, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2008, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2008, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2008, 12, 25)},
            });
            Holidays.Add(2008, holidays2008);
            var holidays2009 = new List<Holiday>();
            holidays2009.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2009, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2009, 4, 13)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2009, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2009, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2009, 5, 21)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2009, 6, 1)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2009, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2009, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2009, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2009, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2009, 12, 25)},
            });
            Holidays.Add(2009, holidays2009);
            var holidays2010 = new List<Holiday>();
            holidays2010.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2010, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2010, 4, 5)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2010, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2010, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2010, 5, 13)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2010, 5, 24)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2010, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2010, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2010, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2010, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2010, 12, 25)},
            });
            Holidays.Add(2010, holidays2010);
            var holidays2011 = new List<Holiday>();
            holidays2011.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2011, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2011, 4, 25)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2011, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2011, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2011, 6, 2)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2011, 6, 13)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2011, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2011, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2011, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2011, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2011, 12, 25)},
            });
            Holidays.Add(2011, holidays2011);
            var holidays2012 = new List<Holiday>();
            holidays2012.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2012, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2012, 4, 9)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2012, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2012, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2012, 5, 17)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2012, 5, 28)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2012, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2012, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2012, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2012, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2012, 12, 25)},
            });
            Holidays.Add(2012, holidays2012);
            var holidays2013 = new List<Holiday>();
            holidays2013.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2013, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2013, 4, 1)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2013, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2013, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2013, 5, 9)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2013, 5, 20)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2013, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2013, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2013, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2013, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2013, 12, 25)},
            });
            Holidays.Add(2013, holidays2013);
            var holidays2014 = new List<Holiday>();
            holidays2014.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2014, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2014, 4, 21)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2014, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2014, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2014, 5, 29)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2014, 6, 9)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2014, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2014, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2014, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2014, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2014, 12, 25)},
            });
            Holidays.Add(2014, holidays2014);
            var holidays2015 = new List<Holiday>();
            holidays2015.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2015, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2015, 4, 6)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2015, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2015, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2015, 5, 14)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2015, 5, 25)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2015, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2015, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2015, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2015, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2015, 12, 25)},
            });
            Holidays.Add(2015, holidays2015);
            var holidays2016 = new List<Holiday>();
            holidays2016.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2016, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2016, 3, 28)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2016, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2016, 5, 5)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2016, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2016, 5, 16)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2016, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2016, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2016, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2016, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2016, 12, 25)},
            });
            Holidays.Add(2016, holidays2016);
            var holidays2017 = new List<Holiday>();
            holidays2017.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2017, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2017, 4, 17)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2017, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2017, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2017, 5, 25)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2017, 6, 5)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2017, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2017, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2017, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2017, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2017, 12, 25)},
            });
            Holidays.Add(2017, holidays2017);
            var holidays2018 = new List<Holiday>();
            holidays2018.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2018, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2018, 4, 2)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2018, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2018, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2018, 5, 10)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2018, 5, 21)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2018, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2018, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2018, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2018, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2018, 12, 25)},
            });
            Holidays.Add(2018, holidays2018);
            var holidays2019 = new List<Holiday>();
            holidays2019.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2019, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2019, 4, 22)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2019, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2019, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2019, 5, 30)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2019, 6, 10)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2019, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2019, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2019, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2019, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2019, 12, 25)},
            });
            Holidays.Add(2019, holidays2019);
            var holidays2020 = new List<Holiday>();
            holidays2020.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2020, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2020, 4, 13)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2020, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2020, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2020, 5, 21)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2020, 6, 1)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2020, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2020, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2020, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2020, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2020, 12, 25)},
            });
            Holidays.Add(2020, holidays2020);
            var holidays2021 = new List<Holiday>();
            holidays2021.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2021, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2021, 4, 5)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2021, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2021, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2021, 5, 13)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2021, 5, 24)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2021, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2021, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2021, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2021, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2021, 12, 25)},
            });
            Holidays.Add(2021, holidays2021);
            var holidays2022 = new List<Holiday>();
            holidays2022.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2022, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2022, 4, 18)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2022, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2022, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2022, 5, 26)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2022, 6, 6)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2022, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2022, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2022, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2022, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2022, 12, 25)},
            });
            Holidays.Add(2022, holidays2022);
            var holidays2023 = new List<Holiday>();
            holidays2023.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2023, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2023, 4, 10)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2023, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2023, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2023, 5, 18)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2023, 5, 29)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2023, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2023, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2023, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2023, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2023, 12, 25)},
            });
            Holidays.Add(2023, holidays2023);
            var holidays2024 = new List<Holiday>();
            holidays2024.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2024, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2024, 4, 1)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2024, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2024, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2024, 5, 9)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2024, 5, 20)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2024, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2024, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2024, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2024, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2024, 12, 25)},
            });
            Holidays.Add(2024, holidays2024);
            var holidays2025 = new List<Holiday>();
            holidays2025.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2025, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2025, 4, 21)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2025, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2025, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2025, 5, 29)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2025, 6, 9)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2025, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2025, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2025, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2025, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2025, 12, 25)},
            });
            Holidays.Add(2025, holidays2025);
            var holidays2026 = new List<Holiday>();
            holidays2026.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2026, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2026, 4, 6)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2026, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2026, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2026, 5, 14)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2026, 5, 25)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2026, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2026, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2026, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2026, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2026, 12, 25)},
            });
            Holidays.Add(2026, holidays2026);
            var holidays2027 = new List<Holiday>();
            holidays2027.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2027, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2027, 3, 29)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2027, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2027, 5, 6)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2027, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2027, 5, 17)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2027, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2027, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2027, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2027, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2027, 12, 25)},
            });
            Holidays.Add(2027, holidays2027);
            var holidays2028 = new List<Holiday>();
            holidays2028.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2028, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2028, 4, 17)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2028, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2028, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2028, 5, 25)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2028, 6, 5)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2028, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2028, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2028, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2028, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2028, 12, 25)},
            });
            Holidays.Add(2028, holidays2028);
            var holidays2029 = new List<Holiday>();
            holidays2029.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2029, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2029, 4, 2)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2029, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2029, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2029, 5, 10)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2029, 5, 21)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2029, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2029, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2029, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2029, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2029, 12, 25)},
            });
            Holidays.Add(2029, holidays2029);
            var holidays2030 = new List<Holiday>();
            holidays2030.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2030, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2030, 4, 22)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2030, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2030, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2030, 5, 30)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2030, 6, 10)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2030, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2030, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2030, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2030, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2030, 12, 25)},
            });
            Holidays.Add(2030, holidays2030);
            var holidays2031 = new List<Holiday>();
            holidays2031.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2031, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2031, 4, 14)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2031, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2031, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2031, 5, 22)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2031, 6, 2)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2031, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2031, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2031, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2031, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2031, 12, 25)},
            });
            Holidays.Add(2031, holidays2031);
            var holidays2032 = new List<Holiday>();
            holidays2032.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2032, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2032, 3, 29)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2032, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2032, 5, 6)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2032, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2032, 5, 17)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2032, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2032, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2032, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2032, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2032, 12, 25)},
            });
            Holidays.Add(2032, holidays2032);
            var holidays2033 = new List<Holiday>();
            holidays2033.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2033, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2033, 4, 18)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2033, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2033, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2033, 5, 26)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2033, 6, 6)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2033, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2033, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2033, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2033, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2033, 12, 25)},
            });
            Holidays.Add(2033, holidays2033);
            var holidays2034 = new List<Holiday>();
            holidays2034.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2034, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2034, 4, 10)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2034, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2034, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2034, 5, 18)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2034, 5, 29)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2034, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2034, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2034, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2034, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2034, 12, 25)},
            });
            Holidays.Add(2034, holidays2034);
            var holidays2035 = new List<Holiday>();
            holidays2035.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2035, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2035, 3, 26)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2035, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2035, 5, 3)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2035, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2035, 5, 14)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2035, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2035, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2035, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2035, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2035, 12, 25)},
            });
            Holidays.Add(2035, holidays2035);
            var holidays2036 = new List<Holiday>();
            holidays2036.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2036, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2036, 4, 14)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2036, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2036, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2036, 5, 22)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2036, 6, 2)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2036, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2036, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2036, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2036, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2036, 12, 25)},
            });
            Holidays.Add(2036, holidays2036);
            var holidays2037 = new List<Holiday>();
            holidays2037.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2037, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2037, 4, 6)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2037, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2037, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2037, 5, 14)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2037, 5, 25)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2037, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2037, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2037, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2037, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2037, 12, 25)},
            });
            Holidays.Add(2037, holidays2037);
            var holidays2038 = new List<Holiday>();
            holidays2038.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2038, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2038, 4, 26)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2038, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2038, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2038, 6, 3)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2038, 6, 14)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2038, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2038, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2038, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2038, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2038, 12, 25)},
            });
            Holidays.Add(2038, holidays2038);
            var holidays2039 = new List<Holiday>();
            holidays2039.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2039, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2039, 4, 11)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2039, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2039, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2039, 5, 19)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2039, 5, 30)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2039, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2039, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2039, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2039, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2039, 12, 25)},
            });
            Holidays.Add(2039, holidays2039);
            var holidays2040 = new List<Holiday>();
            holidays2040.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2040, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2040, 4, 2)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2040, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2040, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2040, 5, 10)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2040, 5, 21)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2040, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2040, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2040, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2040, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2040, 12, 25)},
            });
            Holidays.Add(2040, holidays2040);
            var holidays2041 = new List<Holiday>();
            holidays2041.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2041, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2041, 4, 22)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2041, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2041, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2041, 5, 30)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2041, 6, 10)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2041, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2041, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2041, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2041, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2041, 12, 25)},
            });
            Holidays.Add(2041, holidays2041);
            var holidays2042 = new List<Holiday>();
            holidays2042.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2042, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2042, 4, 7)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2042, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2042, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2042, 5, 15)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2042, 5, 26)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2042, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2042, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2042, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2042, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2042, 12, 25)},
            });
            Holidays.Add(2042, holidays2042);
            var holidays2043 = new List<Holiday>();
            holidays2043.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2043, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2043, 3, 30)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2043, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2043, 5, 7)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2043, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2043, 5, 18)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2043, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2043, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2043, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2043, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2043, 12, 25)},
            });
            Holidays.Add(2043, holidays2043);
            var holidays2044 = new List<Holiday>();
            holidays2044.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2044, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2044, 4, 18)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2044, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2044, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2044, 5, 26)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2044, 6, 6)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2044, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2044, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2044, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2044, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2044, 12, 25)},
            });
            Holidays.Add(2044, holidays2044);
            var holidays2045 = new List<Holiday>();
            holidays2045.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2045, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2045, 4, 10)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2045, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2045, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2045, 5, 18)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2045, 5, 29)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2045, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2045, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2045, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2045, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2045, 12, 25)},
            });
            Holidays.Add(2045, holidays2045);
            var holidays2046 = new List<Holiday>();
            holidays2046.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2046, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2046, 3, 26)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2046, 5, 1)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2046, 5, 3)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2046, 5, 8)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2046, 5, 14)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2046, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2046, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2046, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2046, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2046, 12, 25)},
            });
            Holidays.Add(2046, holidays2046);
            var holidays2047 = new List<Holiday>();
            holidays2047.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2047, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2047, 4, 15)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2047, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2047, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2047, 5, 23)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2047, 6, 3)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2047, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2047, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2047, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2047, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2047, 12, 25)},
            });
            Holidays.Add(2047, holidays2047);
            var holidays2048 = new List<Holiday>();
            holidays2048.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2048, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2048, 4, 6)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2048, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2048, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2048, 5, 14)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2048, 5, 25)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2048, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2048, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2048, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2048, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2048, 12, 25)},
            });
            Holidays.Add(2048, holidays2048);
            var holidays2049 = new List<Holiday>();
            holidays2049.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2049, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2049, 4, 19)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2049, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2049, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2049, 5, 27)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2049, 6, 7)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2049, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2049, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2049, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2049, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2049, 12, 25)},
            });
            Holidays.Add(2049, holidays2049);
            var holidays2050 = new List<Holiday>();
            holidays2050.AddRange(new[] {
                     new Holiday {Name= "Jour de l'an", Date=new DateTime(2050, 1, 1)},
                     new Holiday {Name= "Lundi de Pâques", Date=new DateTime(2050, 4, 11)},
                     new Holiday {Name= "Fête du travail", Date=new DateTime(2050, 5, 1)},
                     new Holiday {Name= "Victoire des alliés", Date=new DateTime(2050, 5, 8)},
                     new Holiday {Name= "Ascension", Date=new DateTime(2050, 5, 19)},
                     new Holiday {Name= "Lundi de Pentecôte", Date=new DateTime(2050, 5, 30)},
                     new Holiday {Name= "Fête Nationale", Date=new DateTime(2050, 7, 14)},
                     new Holiday {Name= "Assomption", Date=new DateTime(2050, 8, 15)},
                     new Holiday {Name= "Toussaint", Date=new DateTime(2050, 11, 1)},
                     new Holiday {Name= "Armistice", Date=new DateTime(2050, 11, 11)},
                     new Holiday {Name= "Noël", Date=new DateTime(2050, 12, 25)},
            });
            Holidays.Add(2050, holidays2050);


        }
        public StaticFileAPI()
        {
            Holidays = new Dictionary<int, IEnumerable<Holiday>>();
            InitStaticFileAPI();
        }
        private async System.Threading.Tasks.Task<string> GetDataFromApiAsync() 
        {
            FrancePublicHolidayAPI service = FrancePublicHolidayAPI.Instance;
            StringBuilder sb = new StringBuilder();
            for (int i = 1950; i < 2051; i++)
            {
                var holidays = await service.GetDataByYearAsync(i);

                sb.AppendLine($" var holidays{i} = new List<Holiday>();");
                sb.Append($"holidays{i}.AddRange(");
                sb.AppendLine(" new[] {  ");
                foreach (var h in holidays)
                {
                    sb.Append("                     new Holiday ");
                    sb.Append(h.ToString());
                    sb.AppendLine(",");
                }
                sb.AppendLine("            });");
                sb.AppendLine($"Holidays.Add({i}, holidays{i});");
            }

            return sb.ToString();
        }

    }
}
