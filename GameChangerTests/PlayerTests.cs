using GameChangerAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameChanger.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void BatsTest()
        {
            EBatsHand expected = EBatsHand.Both;

            Player target = new Player();

            target.Bats = expected;
            EBatsHand actual = target.Bats;

            Assert.AreEqual(expected, actual);
        }
    }
}