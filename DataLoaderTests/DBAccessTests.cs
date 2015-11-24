using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataLoader.Tests
{
    [TestClass()]
    public class DBAccessTests
    {
        [TestMethod()]
        public void FetchAllContactsTest()
        {
            DBAccess target = new DBAccess();

            target.FetchAllContacts();

            Assert.Fail();
        }
    }
}