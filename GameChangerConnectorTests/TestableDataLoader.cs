using GameChangerConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChangerConnectorTests
{
    public class TestableDataLoader : DataLoader
    {
        public TestableDataLoader() : base() { }

        public void loadPlayerAccessor()
        {
            loadPlayer();
        }

        protected override void loadPlayer()
        {
            base.loadPlayer();
        }
    }
}
