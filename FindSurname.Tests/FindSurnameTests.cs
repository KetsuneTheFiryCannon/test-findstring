using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FindSurname;

namespace FindSurname.Tests
{
    [TestClass]
    public class FindSurnameTests
    {
        [TestMethod]
        public void FindSurname()
        {
            bool exists = FileManager.FindLogFio("Akima Samurai Ooishi");
            Assert.IsTrue(exists);
        }
    }
}
