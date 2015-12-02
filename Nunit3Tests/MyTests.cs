﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nunit2Tests
{
    [TestFixture]
    public class MyTests
    {
        [Test]
        public void Test_should_access_config()
        {
            // appSettings
            var someValue = ConfigurationManager.AppSettings["SomeValue"];
            Assert.AreEqual("Hello, config!", someValue);

            // connectionStrings
            var connString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Assert.AreEqual("Server=(local);user=John", connString);
        }

        [Test]
        public void Test_NET45()
        {
            // Class "ReflectionContext" exists from .NET 4.5 onwards.
            Assert.IsNotNull(Type.GetType("System.Reflection.ReflectionContext", false), "Class \"ReflectionContext\" exists from .NET 4.5 onwards.");
        }

        [Test]
        public void Test_Uri()
        {
            //Thread.Sleep(60000);
            string expected = "https://data.test.com:81/api/project/?%24skiptoken=1000&%24top=200";
            Uri uri = new Uri("https://data.test.com:81/api/project/?%24skiptoken=1000&%24top=200");
            Assert.AreEqual(uri.ToString(), expected);
        }

        [Test]
        public void PathsWithDotsMustBeParsedWell()
        {
            const string urlWithDots = "http://host.com/path./";
            Assert.AreEqual(urlWithDots, new Uri(urlWithDots).ToString());
        }
    }
}
