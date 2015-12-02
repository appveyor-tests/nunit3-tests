using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestsX86
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [Category("A")]
        public void TestA()
        {
            // appSettings
            var someValue = "Hello, config!";
            Assert.AreEqual("Hello, config!", someValue);
        }
    }
}
