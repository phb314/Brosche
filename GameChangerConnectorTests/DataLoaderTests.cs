using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameChangerConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameChangerConnectorTests;

namespace GameChangerConnector.Tests
{
    [TestClass()]
    public class DataLoaderTests
    {
        [TestMethod()]
        public void loadPlayerTest()
        {
            TestableDataLoader target = new TestableDataLoader();
            target.loadPlayerAccessor();
        }
    }
}