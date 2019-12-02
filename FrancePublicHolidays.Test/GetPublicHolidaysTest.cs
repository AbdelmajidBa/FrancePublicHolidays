using System;
using System.Collections.Generic;
using System.Linq;
using FrancePublicHolidays.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FrancePublicHolidays.Test
{
   
    [TestClass]
    public class UnitTestRESTapi
    {
        private PublicHoliday publicHoliday;
        
        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                publicHoliday = new PublicHoliday("RESTapi");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
            
        }

        [TestCleanup]
        public void TestCleanup()
        {
            publicHoliday.Dispose();
            publicHoliday = null;
        }

        
        [TestMethod]
        public void IsPublicHoliday_20191225()
        {
            
            var res = publicHoliday.isPublicHoliday(new DateTime(2019,12,25));
            Assert.IsTrue(res);
        }
        
        [TestMethod]
        public void IsPublicHoliday_20171508()
        {
            var res = publicHoliday.isPublicHoliday(new DateTime(2017, 08, 15));
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void IsPublicHoliday_19800509()
        {
            var res = publicHoliday.isPublicHoliday(new DateTime(1980, 05, 09));
            Assert.IsFalse(res);
        }

        [TestMethod]
        /*
            "date": "1995-05-01",
            "nom_jour_ferie": "Fête du travail"
        */
        public void GetPublicHolidayByDate_19950501()
        {
            var res = publicHoliday.GetPublicHolidayByDate(new DateTime(1995, 05, 01));
            Assert.AreEqual(res.Name, "Fête du travail");
        }
        /*
            "date": "2020-04-13",
            "nom_jour_ferie": "Lundi de Pâques"
        */
        [TestMethod]
        public void GetPublicHolidayByDate_20200413()
        {
            var res = publicHoliday.GetPublicHolidayByDate(new DateTime(2020, 04, 13));
            Assert.AreEqual(res.Name, "Lundi de Pâques");
        }

        [TestMethod]
        public void GetPublicHolidayByDate_20140414()
        {
            var res = publicHoliday.GetPublicHolidayByDate(new DateTime(2020, 04, 14));
            Assert.IsNull(res);
        }

        [TestMethod]
        public void GetPublicHolidayByNameAndYear_20150815()
        {
            var res = publicHoliday.GetPublicHolidayByNameAndYear("Assomption", 2015);
            Assert.AreEqual(res.Date, new DateTime(2015, 08, 15));
        }

        [TestMethod]
        public void GetPublicHolidayByNameAndYear_2020()
        {
            var res = publicHoliday.GetPublicHolidayByNameAndYear("Nothing", 2020);
            Assert.IsNull(res);
        }

        [TestMethod]
        public void GetPublicHolidaysByYear_2029()
        {
            var res = publicHoliday.GetPublicHolidaysByYear(2029);
            var expected = new List<Holiday>();
            expected.AddRange(new[] {   new Holiday { Name= "Jour de l'an", Date=new DateTime(2029, 01, 01)},
                                        new Holiday { Name= "Lundi de Pâques", Date=new DateTime(2029, 04, 02)},
                                        new Holiday { Name= "Fête du travail", Date=new DateTime(2029, 05, 01)},
                                        new Holiday { Name= "Victoire des alliés", Date=new DateTime(2029, 05, 08)},
                                        new Holiday { Name= "Ascension", Date=new DateTime(2029, 05, 10)},
                                        new Holiday { Name= "Lundi de Pentecôte", Date=new DateTime(2029, 05, 21)},
                                        new Holiday { Name= "Fête Nationale", Date=new DateTime(2029, 07, 14)},
                                        new Holiday { Name= "Assomption", Date=new DateTime(2029, 08, 15)},
                                        new Holiday { Name= "Toussaint", Date=new DateTime(2029, 11, 01)},
                                        new Holiday { Name= "Armistice", Date=new DateTime(2029, 11, 11)},
                                        new Holiday { Name= "Noël", Date=new DateTime(2029, 12, 25)}
            });
            CollectionAssert.AreEqual(expected, res.ToList());
        }

        
        [TestMethod]
        public void AuthorizedValuesException_1930()
        {
            try
            {
                var res = publicHoliday.GetPublicHolidayByDate(new DateTime(1930, 05, 01));
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "The year must be between 1950 and 2050. Other values are not provided by our API");
            }
        }

        [TestMethod]
        public void GetBusinessDays_2019_From01To12()
        {
            var res = publicHoliday.GetBusinessDays(2019, 12);
            Assert.AreEqual(res, 21);

            res = publicHoliday.GetBusinessDays(2019, 11);
            Assert.AreEqual(res, 19);

            res = publicHoliday.GetBusinessDays(2019, 10);
            Assert.AreEqual(res, 23);

            res = publicHoliday.GetBusinessDays(2019, 9);
            Assert.AreEqual(res, 21);

            res = publicHoliday.GetBusinessDays(2019, 8);
            Assert.AreEqual(res, 21);

            res = publicHoliday.GetBusinessDays(2019, 7);
            Assert.AreEqual(res, 23);

            res = publicHoliday.GetBusinessDays(2019, 6);
            Assert.AreEqual(res, 19);

            res = publicHoliday.GetBusinessDays(2019, 5);
            Assert.AreEqual(res, 20);

            res = publicHoliday.GetBusinessDays(2019, 4);
            Assert.AreEqual(res, 21);

            res = publicHoliday.GetBusinessDays(2019, 3);
            Assert.AreEqual(res, 21);

            res = publicHoliday.GetBusinessDays(2019, 2);
            Assert.AreEqual(res, 20);

            res = publicHoliday.GetBusinessDays(2019, 1);
            Assert.AreEqual(res, 22);
        }
    }
    [TestClass]
    public class UnitTestStaticFileApi
    {
        private PublicHoliday publicHoliday;

        [TestInitialize]
        public void TestInitialize()
        {
            try
            {
                publicHoliday = new PublicHoliday();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

        }

        [TestCleanup]
        public void TestCleanup()
        {
            publicHoliday.Dispose();
            publicHoliday = null;
        }


        [TestMethod]
        public void IsPublicHoliday_20191225()
        {

            var res = publicHoliday.isPublicHoliday(new DateTime(2019, 12, 25));
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IsPublicHoliday_20171508()
        {
            var res = publicHoliday.isPublicHoliday(new DateTime(2017, 08, 15));
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void IsPublicHoliday_19800509()
        {
            var res = publicHoliday.isPublicHoliday(new DateTime(1980, 05, 09));
            Assert.IsFalse(res);
        }

        [TestMethod]
        /*
            "date": "1995-05-01",
            "nom_jour_ferie": "Fête du travail"
        */
        public void GetPublicHolidayByDate_19950501()
        {
            var res = publicHoliday.GetPublicHolidayByDate(new DateTime(1995, 05, 01));
            Assert.AreEqual(res.Name, "Fête du travail");
        }
        /*
            "date": "2020-04-13",
            "nom_jour_ferie": "Lundi de Pâques"
        */
        [TestMethod]
        public void GetPublicHolidayByDate_20200413()
        {
            var res = publicHoliday.GetPublicHolidayByDate(new DateTime(2020, 04, 13));
            Assert.AreEqual(res.Name, "Lundi de Pâques");
        }

        [TestMethod]
        public void GetPublicHolidayByDate_20140414()
        {
            var res = publicHoliday.GetPublicHolidayByDate(new DateTime(2020, 04, 14));
            Assert.IsNull(res);
        }

        [TestMethod]
        public void GetPublicHolidayByNameAndYear_20150815()
        {
            var res = publicHoliday.GetPublicHolidayByNameAndYear("Assomption", 2015);
            Assert.AreEqual(res.Date, new DateTime(2015, 08, 15));
        }

        [TestMethod]
        public void GetPublicHolidayByNameAndYear_2020()
        {
            var res = publicHoliday.GetPublicHolidayByNameAndYear("Nothing", 2020);
            Assert.IsNull(res);
        }

        [TestMethod]
        public void GetPublicHolidaysByYear_2029()
        {
            var res = publicHoliday.GetPublicHolidaysByYear(2029);
            var expected = new List<Holiday>();
            expected.AddRange(new[] {   new Holiday { Name= "Jour de l'an", Date=new DateTime(2029, 01, 01)},
                                        new Holiday { Name= "Lundi de Pâques", Date=new DateTime(2029, 04, 02)},
                                        new Holiday { Name= "Fête du travail", Date=new DateTime(2029, 05, 01)},
                                        new Holiday { Name= "Victoire des alliés", Date=new DateTime(2029, 05, 08)},
                                        new Holiday { Name= "Ascension", Date=new DateTime(2029, 05, 10)},
                                        new Holiday { Name= "Lundi de Pentecôte", Date=new DateTime(2029, 05, 21)},
                                        new Holiday { Name= "Fête Nationale", Date=new DateTime(2029, 07, 14)},
                                        new Holiday { Name= "Assomption", Date=new DateTime(2029, 08, 15)},
                                        new Holiday { Name= "Toussaint", Date=new DateTime(2029, 11, 01)},
                                        new Holiday { Name= "Armistice", Date=new DateTime(2029, 11, 11)},
                                        new Holiday { Name= "Noël", Date=new DateTime(2029, 12, 25)}
            });
            CollectionAssert.AreEqual(expected, res.ToList());
        }


        [TestMethod]
        public void AuthorizedValuesException_1930()
        {
            try
            {
                var res = publicHoliday.GetPublicHolidayByDate(new DateTime(1930, 05, 01));
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "The year must be between 1950 and 2050. Other values are not provided by our API");
            }
        }

        [TestMethod]
        public void GetBusinessDays_2019_From01To12()
        {
            var res = publicHoliday.GetBusinessDays(2019, 12);
            Assert.AreEqual(res, 21);

            res = publicHoliday.GetBusinessDays(2019, 11);
            Assert.AreEqual(res, 19);

            res = publicHoliday.GetBusinessDays(2019, 10);
            Assert.AreEqual(res, 23);

            res = publicHoliday.GetBusinessDays(2019, 9);
            Assert.AreEqual(res, 21);

            res = publicHoliday.GetBusinessDays(2019, 8);
            Assert.AreEqual(res, 21);

            res = publicHoliday.GetBusinessDays(2019, 7);
            Assert.AreEqual(res, 23);

            res = publicHoliday.GetBusinessDays(2019, 6);
            Assert.AreEqual(res, 19);

            res = publicHoliday.GetBusinessDays(2019, 5);
            Assert.AreEqual(res, 20);

            res = publicHoliday.GetBusinessDays(2019, 4);
            Assert.AreEqual(res, 21);

            res = publicHoliday.GetBusinessDays(2019, 3);
            Assert.AreEqual(res, 21);

            res = publicHoliday.GetBusinessDays(2019, 2);
            Assert.AreEqual(res, 20);

            res = publicHoliday.GetBusinessDays(2019, 1);
            Assert.AreEqual(res, 22);
        }

       
    }
}
